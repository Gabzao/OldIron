using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FuncionarioDAL
    {
        public string Inserir(Funcionario funcionario)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO CADASTRO_FUNCIONARIO (NOME,USUARIO,SENHA) VALUES (@NOME,@USUARIO,@SENHA)";
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@USUARIO", funcionario.Usuario);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return "Cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    return "Este funcionario já foi cadastrado";
                }
                else
                {
                    return "Erro no DB, contate o administrador.";
                }
            }
            finally
            {
                conn.Dispose();
            }
        }


        public List<Funcionario> LerTodos()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM CADASTRO_FUNCIONARIO";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionario = new List<Funcionario>();
                while (reader.Read())
                {
                    Funcionario f = new Funcionario();
                    f.ID = Convert.ToInt32(reader["ID"]);
                    f.Nome = Convert.ToString(reader["NOME"]);
                    f.Usuario = Convert.ToString(reader["USUARIO"]);
                    f.Senha = Convert.ToString(reader["SENHA"]);

                    funcionario.Add(f);
                }
                return funcionario;
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


        public string Deletar(Funcionario funcionario)
        {

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM CADASTRO_FUNCIONARIO WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", funcionario.ID);

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

        public Funcionario Autenticar(string user, string senha)
        {

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM CADASTRO_FUNCIONARIO WHERE USUARIO = @USUARIO AND SENHA = @SENHA";
            command.Parameters.AddWithValue("@USUARIO", user);
            command.Parameters.AddWithValue("@SENHA", senha);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Funcionario f = new Funcionario();
                    f.ID = Convert.ToInt32(reader["ID"]);
                    f.Nome = Convert.ToString(reader["NOME"]);
                    f.Usuario = Convert.ToString(reader["USUARIO"]);
                    f.Senha = Convert.ToString(reader["SENHA"]);
                    return f;
                }
                return null;
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

        public string Atualizar(Funcionario funcionario)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE CADASTRO_FUNCIONARIO SET USUARIO = @USUARIO, SENHA = @SENHA WHERE ID = @ID";
            command.Parameters.AddWithValue("@USUARIO", funcionario.Usuario);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);
            command.Parameters.AddWithValue("@ID", funcionario.ID);

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
