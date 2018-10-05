 using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PecaDAL
    {
        public int Inserir(Peca peca)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO CADASTRO_PECA (DESCRICAO,MODELO,ANO,MARCA,PRECO,ESTOQUE) VALUES (@DESCRICAO,@MODELO,@ANO,@MARCA,@PRECO,@ESTOQUE); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@DESCRICAO", peca.Descricao);
            command.Parameters.AddWithValue("@MODELO", peca.Modelo.ID);
            command.Parameters.AddWithValue("@ANO", peca.Ano);
            command.Parameters.AddWithValue("@MARCA", peca.Marca.ID);
            command.Parameters.AddWithValue("@PRECO", peca.Preco);
            command.Parameters.AddWithValue("@ESTOQUE", peca.Estoque);

            try
            {
                conn.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("Peça já cadastrada");
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

        public List<Peca> LerTodos()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT CP.ID, CP.DESCRICAO, MA.NOME 'MARCA' , CP.ANO, CP.PRECO, CP.ESTOQUE, M.NOME 'MODELO' FROM CADASTRO_PECA CP INNER JOIN MARCA MA ON CP.MARCA = MA.ID INNER JOIN MODELO M ON M.ID = CP.MODELO";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Peca> peca = new List<Peca>();
                while (reader.Read())
                {
                    Peca p = new Peca();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    p.Modelo.Nome = Convert.ToString(reader["MODELO"]);
                    p.Ano = Convert.ToInt32(reader["ANO"]);
                    p.Marca.Nome = Convert.ToString(reader["MARCA"]);
                    p.Preco = Convert.ToDouble(reader["PRECO"]);
                    p.Estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    peca.Add(p);
                }
                return peca;
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

        public string Atualizar(Peca peca)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE CADASTRO_PECA SET DESCRICAO = @DESCRICAO, MODELO = @MODELO, ANO = @ANO, MARCA = @MARCA, PRECO = @PRECO, ESTOQUE = @ESTOQUE  WHERE ID = @ID";
            command.Parameters.AddWithValue("@DESCRICAO", peca.Descricao);
            command.Parameters.AddWithValue("@MODELO", peca.Modelo.ID);
            command.Parameters.AddWithValue("@ANO", peca.Ano);
            command.Parameters.AddWithValue("@MARCA", peca.Marca.ID);
            command.Parameters.AddWithValue("@PRECO", peca.Preco);
            command.Parameters.AddWithValue("@ESTOQUE", peca.Estoque);
            command.Parameters.AddWithValue("@ID", peca.ID);
            

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


        public string Deletar(Peca peca)
        {

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM CADASTRO_TAG WHERE ID_PECA = @ID; DELETE FROM IMAGEM_PECA WHERE IDPECA = @ID; DELETE FROM CADASTRO_PECA WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", peca.ID);

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


        public void InserirImagems(Peca peca)
        {
            for (int i = 0; i < peca.Imagens.Count; i++)
            {
                SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "INSERT INTO IMAGEM_PECA (IDPECA,IMAGEM) VALUES (@IDPECA,@IMAGEM)";
                command.Parameters.AddWithValue("@IDPECA", peca.ID);
                command.Parameters.AddWithValue("@IMAGEM", peca.Imagens[i].Imagem);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UNIQUE"))
                    {
                        throw new Exception("Peça já cadastrada");
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
        }

        public byte[] GetImagemPrincipalPeca(int id)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT IMAGEM FROM IMAGEM_PECA WHERE IDPECA = @ID";
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return (byte[])reader["IMAGEM"];
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }

        }

        public List<Peca> LerTodosPecasDoModelo(int id)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT CP.ID, CP.DESCRICAO, MA.NOME 'MARCA' , CP.ANO, CP.PRECO, CP.ESTOQUE, M.NOME 'MODELO' FROM CADASTRO_PECA CP INNER JOIN MARCA MA ON CP.MARCA = MA.ID INNER JOIN MODELO M ON M.ID = CP.MODELO WHERE CP.MODELO = @ID";
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Peca> peca = new List<Peca>();
                while (reader.Read())
                {
                    Peca p = new Peca();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    p.Modelo.Nome = Convert.ToString(reader["MODELO"]);
                    p.Ano = Convert.ToInt32(reader["ANO"]);
                    p.Marca.Nome = Convert.ToString(reader["MARCA"]);
                    p.Preco = Convert.ToDouble(reader["PRECO"]);
                    p.Estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    peca.Add(p);
                }
                return peca;
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

        public List<Peca> LerTodosAoContrario()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT CP.ID, CP.DESCRICAO, MA.NOME 'MARCA' , CP.ANO, CP.PRECO, CP.ESTOQUE, M.NOME 'MODELO' FROM CADASTRO_PECA CP INNER JOIN MARCA MA ON CP.MARCA = MA.ID INNER JOIN MODELO M ON M.ID = CP.MODELO ORDER BY ID DESC";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Peca> peca = new List<Peca>();
                while (reader.Read())
                {
                    Peca p = new Peca();
                    p.ID = Convert.ToInt32(reader["ID"]);
                    p.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    p.Modelo.Nome = Convert.ToString(reader["MODELO"]);
                    p.Ano = Convert.ToInt32(reader["ANO"]);
                    p.Marca.Nome = Convert.ToString(reader["MARCA"]);
                    p.Preco = Convert.ToDouble(reader["PRECO"]);
                    p.Estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    peca.Add(p);
                }
                return peca;
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
