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
    public partial class FrmDetalhes : Form
    {
        int venda_id;
        public FrmDetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            // Carrega tela de detalhes
            ItemVendaDAO dao = new ItemVendaDAO();
            tabelaDetalhes.DataSource = dao.ListarItensPorVenda(venda_id);
        }
    }
}
