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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            //Recebe os dados dos campos
            obj.nome = txtNome.Text;
            obj.rg = mtbRG.Text;
            obj.cpf = mtbCPF.Text;
            obj.email = txtEmail.Text;
            obj.senha = mtbSenha.Text;
            obj.nivel_acesso = cbxNivelAcesso.SelectedItem.ToString();
            obj.cargo = cbxCargo.SelectedItem.ToString();
            obj.telefone = mtbTelefone.Text;
            obj.celular = mtbCelular.Text;
            obj.cep = mtbCEP.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbxUF.Text;
            //Criar o objeto funcionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.ListarFuncionarios();
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            mtbRG.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            mtbCPF.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            mtbSenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbxCargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbxNivelAcesso.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            mtbTelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            mtbCelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            mtbCEP.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbxUF.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();
            tabFuncionario.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtCodigo.Text);
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.deletarFuncionario(obj);
            
            tabelaFuncionario.DataSource = dao.ListarFuncionarios();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            //Recebe os dados dos campos
            obj.nome = txtNome.Text;
            obj.rg = mtbRG.Text;
            obj.cpf = mtbCPF.Text;
            obj.email = txtEmail.Text;
            obj.senha = mtbSenha.Text;
            obj.nivel_acesso = cbxNivelAcesso.SelectedItem.ToString();
            obj.cargo = cbxCargo.SelectedItem.ToString();
            obj.telefone = mtbTelefone.Text;
            obj.celular = mtbCelular.Text;
            obj.cep = mtbCEP.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbxUF.Text;
            obj.codigo = int.Parse(txtCodigo.Text);

            //Criar o objeto funcionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = btnPesquisar.Text;
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.BuscaFuncionariosPorNome(nome);

            if(tabelaFuncionario.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado!");
                tabelaFuncionario.DataSource = dao.ListarFuncionarios();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.ListarFuncionariosPorNome(nome);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Botão consultar CEP
            try
            {
                string cep = mtbCEP.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbxUF.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");
            }
        }
    }
}
