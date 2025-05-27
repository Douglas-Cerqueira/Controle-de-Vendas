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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Recebe os dados dentro do objeto modelo cliente
            Cliente obj = new Cliente();

            obj.nome = txtNome.Text;
            obj.rg = mtbRG.Text;
            obj.cpf = mtbCPF.Text;
            obj.email = txtEmail.Text;
            obj.telefone = mtbTelefone.Text;
            obj.celular = mtbCelular.Text;
            obj.cep = mtbCEP.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbxUF.Text;

            //Criar um objeto da classe ClienteDAO e chamar o metodo cadastraCliente

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //Atualiza o gridview
            dgvCliente.DataSource = dao.listarClientes();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Criação de uma instância da classe ClienteDAO, que contém métodos para acessar o banco de dados
            ClienteDAO dao = new ClienteDAO();
            // Preenche o DataGridView (dgvCliente) com os dados dos clientes retornados pelo método listarClientes()
            dgvCliente.DataSource = dao.listarClientes();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pega os dados da linha selecionada
            txtCodigo.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            mtbRG.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            mtbCPF.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            mtbTelefone.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            mtbCelular.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            mtbCEP.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgvCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgvCliente.CurrentRow.Cells[12].Value.ToString();
            cbxUF.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();

            //Alterar para a guia Dados Pessoais
            tabClientes.SelectedTab = tabPage1;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            //Pega o codigo
            obj.codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);
            //Recarregar o dataGridView
            dgvCliente.DataSource = dao.listarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Recebe os dados dentro do objeto modelo cliente
            Cliente obj = new Cliente();

            obj.nome = txtNome.Text;
            obj.rg = mtbRG.Text;
            obj.cpf = mtbCPF.Text;
            obj.email = txtEmail.Text;
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

            //Criar um objeto da classe ClienteDAO e chamar o metodo Alterar

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            //Recarregar datagridview
            dgvCliente.DataSource = dao.listarClientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            dgvCliente.DataSource = dao.BuscarClientePorNome(nome);

            if(dgvCliente.Rows.Count == 0 )
            {
                //Recarrega o DataGridView
                dgvCliente.DataSource = dao.listarClientes();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ClienteDAO dao = new ClienteDAO();
            dgvCliente.DataSource = dao.BuscarClientePorNome(nome);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Botão consultar CEP
            try
            {
                string cep = mtbCEP.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
