using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        public void Gravar(Pessoa p)
        {
            try
            {
                //Abrir a conexão
                AbrirConexao();

                Cmd = new SqlCommand("insert into Pessoa (Nome,Endereco,Email) values(@v1,@v2,@v3)", Con );

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);

                Cmd.ExecuteNonQuery();//Executando o código
                
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao gravar o cliente: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("update Pessoa set Nome=@v1, Endereco=@v2, Email=@v3 where Codigo=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception("Erro ao atualizar o cliente: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("delete from Pessoa where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception("Erro ao excluir o cliente: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //metodo pra obter 1 pessoa pelo Codigo(chave primária)
        public Pessoa PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Pessoa where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Pessoa p = null; // criando um espaço de memória. ponteiro

                if (Dr.Read())//Se SqlDataReader Dr for  ler os registros
                {
                    p = new Pessoa(); // inicializar o objeto Pessoa

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }
                return p;
            }
            catch (Exception e )
            {

                throw new Exception("Erro ao pesquisar: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("Select * from Pessoa", Con);

                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>(); // lista vazia

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }
                return lista;

                

            }
            catch (Exception e)
            {

                throw new Exception("Erro ao listar os clientes: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        
    }
}
 //regras de negocios da nossa aplicacao - consultas! - select, update,insert,delete 