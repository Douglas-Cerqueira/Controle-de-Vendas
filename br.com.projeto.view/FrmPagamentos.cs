using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmPagamentos : Form
        
    {
        Cliente cliente = new Cliente();
        DataTable carrino = new DataTable();
        DateTime dataAtual;
        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrino = carrinho;
            this.dataAtual = dataAtual;
            InitializeComponent();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarVenda_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, totalpago, total;
                ProdutoDAO dao_produto = new ProdutoDAO();
                int qtd_estoque, qtd_comprada, estoque_atualizada;

                v_dinheiro = decimal.Parse(txtDinheiro.Text);
                v_cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);
                //Calcula o total pago
                totalpago = v_dinheiro + v_cartao;

                if(totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda!");
                }
                else
                {

                    //Calcula o troco
                    troco = totalpago - total;

                    Venda vendas = new Venda();
                    //Pegando o id do cliente
                    vendas.cliente_id = cliente.codigo;
                    vendas.data_venda = dataAtual;
                    vendas.total_venda = total;
                    vendas.obs = txtobs.Text;

                    VendaDAO vdao = new VendaDAO();
                    txtTroco.Text = troco.ToString();
                    vdao.cadastrarVenda(vendas);
                    

                    //Cadastro de itens da venda
                    //Percorre os itens do carrinho
                    foreach(DataRow linha in carrino.Rows)
                    {
                        ItemVenda item = new ItemVenda();

                        item.venda_id = vdao.retornaIdUltimaVenda();
                        item.produto_id = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Qtd"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        //Baixa no estoque
                        qtd_estoque = dao_produto.retornaEstoqueAtual(item.produto_id);
                        qtd_comprada = item.qtd;
                        estoque_atualizada = qtd_estoque - qtd_comprada;

                        dao_produto.baixaEstoque(item.produto_id, estoque_atualizada);

                        ItemVendaDAO itemdao = new ItemVendaDAO();
                        itemdao.cadastrarItem(item);
                    }
                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Dispose();
                    

                }

               
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }
    }
}
