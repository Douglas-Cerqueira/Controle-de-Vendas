using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using Projeto_Controle_Vendas.br.com.projeto.view;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar Funcionario

        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                //Criar o comando sql
                string sql = "insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)" +
                    " values(@nome,@rg,@cpf,@email,@senha,@cargo,@nivel,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                //Organizar e execurtar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                //Abrir conexão e executar comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso!");
                //Fecha conexão
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        #endregion


        #region Método Alterar Funcionário
        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "uptade tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha," +
                    "cargo=@cargo,nivel_acesso=@nivel,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco," +
                    "numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id = @codigo";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);
                //Abrir conexão e executar comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com sucesso!");
                //Fecha conexão
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

            }
        }


        #endregion


        #region Método Excluir Funcionário
        public void deletarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where id = @codigo";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);
                //Abrir conexão e executar comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com sucesso!");
                //Fecha conexão
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);

            }
        }
        #endregion

        #region Método Listar Funcionários

        public DataTable ListarFuncionarios()
        {
            try
            {
                //Cria o DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";
                //Organiza o comando sql e execute
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                //Cria o MySQLDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);
                //Fecha a conexão 
                conexao.Close();
                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region Método ListarFuncionarios Por Nome
        public DataTable BuscaFuncionariosPorNome(string nome)
        {
            try
            {
                //Cria o DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";
                //Organiza o comando sql e execute
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                //Cria o MySQLDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);
                //Fecha a conexão 
                conexao.Close();
                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que lista funcionários por nome

        public DataTable ListarFuncionariosPorNome(string nome)
        {
            try
            {
                //Cria o DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";
                //Organiza o comando sql e execute
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                //Cria o MySQLDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);
                //Fecha a conexão 
                conexao.Close();
                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que Efetua Login

        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios 
                                where email = @email and senha = @senha";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                
                MySqlDataReader reader = executacmd.ExecuteReader();
                if (reader.Read())
                {
                    //Login realizado com sucesso


                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");
                    MessageBox.Show("Seja bem vindo ao sistema, " + nome);
                    FrmMenu telaMenu = new FrmMenu();

                    telaMenu.txtUsuario.Text = nome;

                    //se o nivel for administrador
                    if (nivel.Equals("Administrador"))
                    {
                        //Abrir a tela menu principal
                        
                        telaMenu.Show();
                    }
                    else if (nivel.Equals("Vendedor"))
                    {
                        //Personalizar o que o vendedor tem acesso
                        telaMenu.menuFuncionario.Enabled = false;
                        telaMenu.menuCadastroDeCliente.Enabled = false;
                        telaMenu.menuCadastroDeFuncionario.Enabled = false;
                        telaMenu.menuCadastroDeFornecedores.Enabled = false;
                        telaMenu.menuCadastroDeProdutos.Enabled = false;
                        telaMenu.Show();
                    }
                    

                    return true;
                }
                else
                {
                    //A senha ou email foi digitado incorreto
                    MessageBox.Show("Email ou senha incorreto!");  
                    return false;
                }

                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return false;
            }
        }
        #endregion
    }
}
