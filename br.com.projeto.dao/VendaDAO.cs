using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public  class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método Cadastrar Venda

        public void cadastrarVenda(Venda obj)
        {
            try
            {   
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                                values(@cliente_id, @data_venda, @total_venda, @obs)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda Cadastrada com sucesso!");
                //Fecha conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion

        #region Método que retorna o Id da ultima venda 

        public int retornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;
                //Essa função retorna o maior valor de uma coluna que especificar 
                string sql = @"select max(id) id from tb_vendas";
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataReader rs = executacmdsql.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                   
                }
                conexao.Close();
                return idvenda;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return 0;
            }
        }

        #endregion

        #region Método que exibi histórico de venda

        public DataTable ListarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT v.id as 'Código',
                                      v.data_venda as 'Data da venda',
                                      c.nome as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Obs'
                                FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)

                                WHERE v.data_venda between @datainicio and @datafim";

                MySqlCommand executacmdsql = new MySqlCommand (@sql, conexao);
                executacmdsql.Parameters.AddWithValue("@datainicio", datainicio);
                executacmdsql.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open ();
                executacmdsql.ExecuteNonQuery ();

                //Criar o sqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill (tabelaHistorico);
                return tabelaHistorico;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Listar todas as vendas
        public DataTable listarVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT v.id as 'Código',
                                      v.data_venda as 'Data da venda',
                                      c.nome as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Obs'
                                FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)";

                               

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                conexao.Open();
                da.Fill (tabelaHistorico);

                conexao.Close ();

                return tabelaHistorico;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

    }
}
