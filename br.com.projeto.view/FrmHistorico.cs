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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            dgvHistorico.DataSource = dao.ListarVendasPorPeriodo(datainicio, datafim);
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            dgvHistorico.AutoGenerateColumns = false;
            dgvHistorico.DataSource = dao.listarVendas();
            dgvHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void dgvHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Abrir outro formulario
            //Passando o id da venda
            int idvenda = int.Parse(dgvHistorico.CurrentRow.Cells[0].Value.ToString());
            FrmDetalhes tela = new FrmDetalhes(idvenda);
            //Formatando a data

            DateTime datavenda = Convert.ToDateTime(tela.txtData.Text = dgvHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtData.Text = datavenda.ToString("dd/MM/yyyy");
            tela.txtCliente.Text = dgvHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = dgvHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = dgvHistorico.CurrentRow.Cells[4].Value.ToString();

            tela.ShowDialog();
        }
    }
}
