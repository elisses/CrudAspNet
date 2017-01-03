using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessaoDAL : Conexao
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
    }
}
 //regras de negocios da nossa aplicacao - consultas! - select, update,insert,delete 