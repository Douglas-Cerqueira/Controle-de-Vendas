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
    public partial class FrmVendas : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal subtotal, total;

        DataTable carrinho = new DataTable();



        public FrmVendas()
        {
            InitializeComponent();
            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LimparTelaVenda()
        {
            
            tabelaProdutos.DataSource = null; // Limpa o DataGridView
            txtData.Clear();
            mtbCPF.Clear();
            txtNome.Clear();
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            txtTotal.Clear();
        }
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.retornaClientePorCpf(mtbCPF.Text);

                if(cliente != null)
        {
                    txtNome.Text = cliente.nome;
                }
                else
                {

                    MessageBox.Show("Cliente não encontrado. Verifique o CPF digitado.");
                    txtNome.Clear();
                    mtbCPF.Focus();
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.retornaProdutoPorCodigo(int.Parse(txtCodigo.Text));

                if(p != null)
                {
                    txtDescricao.Text = p.descricao;
                    txtPreco.Text = p.preco.ToString();
                }
                else
                {
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
                
            }
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtEstoque.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                //Adiciona o produto no carrinho

                carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDescricao.Text, qtd, preco, subtotal);

                txtTotal.Text = total.ToString();
                //Limpar os campos

                txtCodigo.Clear();
                txtDescricao.Clear();
                txtEstoque.Clear();
                txtPreco.Clear();
                txtCodigo.Clear();

                txtCodigo.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite o código do produto!");
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            //Botão remover item 

            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaProdutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();
            total -= subproduto;
            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            if (cliente.codigo == 0)
            {
                MessageBox.Show("Selecione um cliente válido antes de finalizar a venda.");
                return;
            }
            DateTime dataAtual = DateTime.Parse(txtData.Text);
            FrmPagamentos tela = new FrmPagamentos(cliente, carrinho, dataAtual);
            //Passando o total para a tela de pagamentos
            tela.txtTotal.Text = total.ToString();
            LimparTelaVenda();
            tela.ShowDialog();

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //Pegando a data atual

            txtData.Text = DateTime.Now.ToShortDateString();
        }
    }
}
