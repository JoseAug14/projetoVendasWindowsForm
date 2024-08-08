using MySql.Data.MySqlClient;
using projeto_vendas.conexao;
using projeto_vendas.Model;
using projeto_vendas.views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_vendas.dao
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        //Criar Conexão
        //Construtor
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade, estado)
                                values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco,@numero, @complemento, @bairro, @cidade, @estado) ";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);

                executacmd.Parameters.AddWithValue("@cep", obj.Cep);

                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);


                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                //Fechar a conexao
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }
        #endregion

        #region Método Alterar Cliente 
        public void alterarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  update
                string sql = @"update tb_clientes set 

                                nome = @nome,
                                rg = @rg,
                                cpf = @cpf,
                                email = @email,
                                telefone = @telefone,
                                celular = @celular,
                                cep = @cep,
                                endereco = @endereco,
                                numero = @numero,
                                complemento = @complemento,
                                bairro = @bairro,
                                cidade = @cidade,
                                estado = @estado

                                where id = @id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);

                executacmd.Parameters.AddWithValue("@cep", obj.Cep);

                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);

                //Adicionar o parametro do ID
                executacmd.Parameters.AddWithValue("@id", obj.Id);


                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente atualizado com sucesso!");
                //Fechar a conexao
                conexao.Close();


            }

            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }
        #endregion


        #region Método Excluir Cilente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  delete
                string sql = @"delete from tb_clientes where id = @id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //Adicionar o parametro do ID
                executacmd.Parameters.AddWithValue("@id", obj.Id);


                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso!");
                //Fechar a conexao
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }

        #endregion

        #region Método Listar Todos Os Clientes 
        public DataTable listarClientes() {

            try
            {

                //1 passo - criar o DataTable
                DataTable tabelaCliente = new DataTable();

                //2 passo - Comando SQL - SELECT
                string sql = @"select * from tb_clientes";

                //3 passo - Abrir a conexão e executar comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //4 passo - Pegar os dados do executacmd e preencher o DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;
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
