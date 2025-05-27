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

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text;
            string senha = txtLoginSenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if(dao.EfetuarLogin(email, senha))
            {
                
                this.Hide();
            }
        }
    }
}
