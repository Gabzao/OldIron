using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MarcaDAL
    {

        public void Inserir(Marca marca)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO MARCA (NOME) VALUES (@NOME)";
            command.Parameters.AddWithValue("@NOME", marca.Nome);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("Marca já cadastrada.");
                }
                else
                {
                    throw new Exception("Erro no banco de dados. Contate o administrador.");
                }
            }
            finally
            {
                conn.Dispose();
            }
        }

        public List<Marca> LerTodos()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM MARCA";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Marca> marca = new List<Marca>();
                while (reader.Read())
                {
                    Marca m = new Marca();
                    m.ID = Convert.ToInt32(reader["ID"]);
                    m.Nome = Convert.ToString(reader["NOME"]);

                    marca.Add(m);
                }
                return marca;
            }
            catch (Exception)
            {
                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }
        }

        public string Deletar(Marca marca)
        {

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM MARCA WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", marca.ID);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return "Deletado com sucesso!";
            }
            catch (Exception)
            {
                return "Erro no DB, contate o administrador.";
            }
            finally
            {
                conn.Dispose();
            }
        }

        public string Atualizar(Marca marca)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE MARCA SET NOME = @NOME WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", marca.Nome);
            command.Parameters.AddWithValue("@ID", marca.ID);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return "Atualizado com sucesso!";
            }
            catch (Exception)
            {
                return "Erro no DB, contate o administrador.";
            }
            finally
            {
                conn.Dispose();
            }
        }



    }
}
