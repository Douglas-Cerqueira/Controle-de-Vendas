using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Pegando a data atual

            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Programação dentro do timer
            //Pegando a hora
            txtHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void menuCadastroDeCliente_Click(object sender, EventArgs e)
        {
            //Abrir a tela de clientes

            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();

        }

        private void menuConsultaDeClientes_Click(object sender, EventArgs e)
        {
            //Abir a tela de clientes com a aba de consulta aberto
            FrmClientes tela = new FrmClientes();
            tela.tabClientes.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroDeFuncionario_Click(object sender, EventArgs e)
        {
            //Abre a tela de funcionarios
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.ShowDialog();
        }

        private void menuConsultaDeFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.tabFuncionario.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroDeFornecedores_Click(object sender, EventArgs e)
        {
            FrmFornecedores tela = new FrmFornecedores();
            tela.ShowDialog();
        }

        private void menuConsultaDeFornecedores_Click(object sender, EventArgs e)
        {
            FrmFornecedores tela = new FrmFornecedores();
            tela.tabFornecedores.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroDeProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
        }

        private void MenuConsultaDeProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.tabProdutos.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroDeVendas_Click(object sender, EventArgs e)
        {
            FrmVendas tela = new FrmVendas();
            tela.ShowDialog();
        }

        private void menuConsultaDeVendas_Click(object sender, EventArgs e)
        {
            FrmHistorico tela = new FrmHistorico(); 
            tela.ShowDialog();
        }

        private void menuTrocaDeUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja trocar de usuário?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
                FrmLogin tela = new FrmLogin();
                this.Hide();
                tela.ShowDialog();
                
            }


        }

        private void menuSairDoSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja Sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
