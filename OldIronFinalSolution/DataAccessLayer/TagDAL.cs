using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TagDAL
    {
        public void Inserir(CadastroTag cadastroTag)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            conn.Open();

            for (int i = 0; i < cadastroTag.Tags.Count; i++)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "INSERT INTO CADASTRO_TAG (ID_PECA,TAG) VALUES (@ID_PECA,@TAG)";
                command.Parameters.AddWithValue("@ID_PECA", cadastroTag.ID_Peca);
                command.Parameters.AddWithValue("@TAG", cadastroTag.Tags[i]);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception )
                {
                    throw new Exception("Erro no banco de dados.");
               }
            }
            conn.Close();
        }

        public List<string> LerTodasTags(int idpeca)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM CADASTRO_TAG WHERE ID_PECA = @ID_PECA";
            command.Parameters.AddWithValue("@id_peca", idpeca);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<string> tags = new List<string>();
                while (reader.Read())
                {
                    tags.Add((string)reader["TAG"]);
                }
                return tags;
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

        public List<Peca> LerPecasInterseccaoTags(List<string> tags)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            for (int i = 0; i < tags.Count; i++)
            {
                command.CommandText += @"

                    SELECT 
                             CP.ID,
                             CP.DESCRICAO,
	                         CP.ANO,
	                         MM.NOME 'MODELO',
	                         M.NOME 'MARCA',
	                         CP.PRECO,
	                         CP.ESTOQUE
                             FROM CADASTRO_PECA CP 
	                         INNER JOIN CADASTRO_TAG CT ON
				             CP.ID = CT.ID_PECA
                             INNER JOIN MARCA M ON M.ID = CP.MARCA
                             INNER JOIN MODELO MM ON MM.ID = CP.MODELO
							 WHERE
							     (
								  CT.TAG LIKE @TAG" + i + ")";
                command.Parameters.AddWithValue("@TAG" + i, "%" + tags[i] + "%");

                if(i != tags.Count - 1)
                {
                    command.CommandText += " INTERSECT ";
                }
            }

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Peca> pecas = new List<Peca>();
                while (reader.Read())
                {
                    Peca p = new Peca();
                    p.ID = (int)reader["ID"];
                    p.Descricao = (string)reader["DESCRICAO"];
                    p.Ano = (int)reader["ANO"];
                    p.Modelo.Nome = (string)reader["MODELO"];
                    p.Marca.Nome = (string)reader["MARCA"];
                    p.Preco = (double)reader["PRECO"];
                    p.Estoque = (int)reader["ESTOQUE"];
                    pecas.Add(p);
                }
                return pecas;
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

        public List<Peca> LerPecasComATag(string tag)
           {
               SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
               SqlCommand command = new SqlCommand();
               command.Connection = conn;
               command.CommandText =
                   @"
             SELECT 
                   CP.ID,
                   CP.DESCRICAO,
	               CP.ANO,
	               MM.NOME 'MODELO',
	               M.NOME 'MARCA',
	               CP.PRECO,
	               CP.ESTOQUE
                             FROM CADASTRO_PECA CP 
	                         INNER JOIN CADASTRO_TAG CT ON
                             CP.ID = CT.ID_PECA
				             INNER JOIN MARCA M ON M.ID = CP.MARCA
                             INNER JOIN MODELO MM ON MM.ID = CP.MODELO
				             WHERE CT.TAG LIKE @TAG";
                   
               command.Parameters.AddWithValue("@TAG","%" +tag +"%" );

              
               try
               {
                   conn.Open();
                   SqlDataReader reader = command.ExecuteReader();
                   List<Peca> pecas = new List<Peca>();
                   while (reader.Read())
                   {
                       Peca p = new Peca();
                       p.ID = (int)reader["ID"];
                       p.Descricao = (string)reader["DESCRICAO"];
                       p.Ano = (int)reader["ANO"];
                       p.Modelo.Nome = (string)reader["MODELO"];
                       p.Marca.Nome = (string)reader["MARCA"];
                       p.Preco = (double)reader["PRECO"];
                       p.Estoque = (int)reader["ESTOQUE"];
                       pecas.Add(p);
                   }
                   return pecas;
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

        public void Excluir(CadastroTag tag)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM CADASTRO_TAG WHERE ID_PECA = @ID_PECA";
            command.Parameters.AddWithValue("@ID_PECA", tag.ID_Peca);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch
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
          