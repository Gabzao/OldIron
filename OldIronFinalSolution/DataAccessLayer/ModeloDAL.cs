using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ModeloDAL
    {
        public void Inserir(Modelo modelo)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO MODELO (NOME, MARCAID) VALUES (@NOME, @MARCAID)";
            command.Parameters.AddWithValue("@NOME", modelo.Nome);
            command.Parameters.AddWithValue("@MARCAID", modelo.IDMarca);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("Modelo já cadastrado.");
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

        public List<Modelo> LerTodos()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM MODELO";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Modelo> modelo = new List<Modelo>();
                while (reader.Read())
                {
                    Modelo m = new Modelo();
                    m.ID = Convert.ToInt32(reader["ID"]);
                    m.Nome = Convert.ToString(reader["NOME"]);
                    m.IDMarca = Convert.ToInt32(reader["MARCAID"]);
                    modelo.Add(m);
                }
                return modelo;
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

        public void Atualizar(Modelo modelo)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE MODELO SET NOME = @NOME, MARCAID = @MARCAID WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", modelo.Nome);
            command.Parameters.AddWithValue("@MARCAID", modelo.IDMarca);
            command.Parameters.AddWithValue("@ID", modelo.ID);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("Modelo já cadastrado");
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

        public string Deletar(Modelo modelo)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM MODELO WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", modelo.ID);
            command.Parameters.AddWithValue("@MARCAID", modelo.IDMarca);

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

        public List<Modelo> LerTodosModelosDaMarca(int id)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM MODELO WHERE MARCAID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Modelo> modelo = new List<Modelo>();
                while (reader.Read())
                {
                    Modelo m = new Modelo();
                    m.ID = Convert.ToInt32(reader["ID"]);
                    m.Nome = Convert.ToString(reader["NOME"]);
                    m.IDMarca = Convert.ToInt32(reader["MARCAID"]);
                    modelo.Add(m);
                }
                return modelo;
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
    }
}
