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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabelaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbxFornecedor.DataSource = f_dao.listarFornecedores();
            cbxFornecedor.DisplayMember = "nome";
            cbxFornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProduto.DataSource = dao.listarProdutos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtDescricao.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtEstoque.Text);
            obj.for_id = int.Parse(cbxFornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastraProduto(obj);
            new Helpers().LimparTela(this);
            tabelaProduto.DataSource = dao.listarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = tabelaProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProduto.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();
            cbxFornecedor.Text = tabelaProduto.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabPage1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtDescricao.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtEstoque.Text);
            obj.for_id = int.Parse(cbxFornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtCodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.alterarProduto(obj);
            new Helpers().LimparTela(this);
            tabelaProduto.DataSource = dao.listarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            
            obj.id = int.Parse(txtCodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirProduto(obj);
            new Helpers().LimparTela(this);
            tabelaProduto.DataSource = dao.listarProdutos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();

            tabelaProduto.DataSource = dao.listarProdutosPorNome(nome);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            ProdutoDAO dao = new ProdutoDAO();
            tabelaProduto.DataSource = dao.listarProdutosPorNome(nome);
            if(tabelaProduto.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado com esse Nome");
                tabelaProduto.DataSource = dao.buscarProdutosPorNome(nome);
            }
        }
    }
}
