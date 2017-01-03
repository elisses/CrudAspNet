using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//ADO.NET -> SQL SERVER

namespace DAL.Persistence
{
   public class Conexao
    {
        //Atributos:
        protected SqlConnection Con; // Estabelecer a conexão com sql server
        protected SqlCommand Cmd;// escrever e executar o comando de sql
        protected SqlDataReader Dr; // ler registro obtidos de queres(trabalhando com as consultas)

        //Método - Abrir conexão
        protected void AbrirConexao()
        {
            try
            {
                //buscar a connection string
                Con = new SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elisvieira\Documents\ADD-WS0430.mdf;Integrated Security=True;Connect Timeout=30"); 
                Con.Open();//abrindo a conexao
            }
            catch (Exception EX)
            {

                throw new Exception(EX.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception EX)
            {

                throw new Exception(EX.Message);
            }
        }

    }
}
