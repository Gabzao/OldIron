using DataAccessLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
   public class TagBLL
    {
        TagDAL dal = new TagDAL();
        public void Inserir (CadastroTag tag)
        {
           Validar(tag);
           dal.Inserir(tag);
        }

        public void Editar(CadastroTag t)
        {
            Validar(t);
            dal.Excluir(t);
            dal.Inserir(t);
        }

        public List<string> LerTodasTags (int idPeca)
        {
            List<String> respostaDB = dal.LerTodasTags(idPeca);
            return respostaDB;
        }

        public void Validar(CadastroTag tag)
        {
            StringBuilder erros = new StringBuilder();
            if (tag.ID_Peca == 0)
            {
                erros.AppendLine("O ID da peça deve ser informado. ");
            }

            foreach (string t in tag.Tags)
            {
                if (string.IsNullOrWhiteSpace(t))
                {
                    erros.AppendLine("A tag deve ser informada. ");
                }
                else if (t.Length > 50)
                {
                    erros.AppendLine("Tag não pode conter mais de 50 caracteres.");
                }
                if (!t.Contains("#"))
                {
                    erros.AppendLine("A tag deve conter o caractere #.");
                }
            }
            for (int i = 0; i < tag.Tags.Count; i++)
            {
                tag.Tags[i] = tag.Tags[i].Trim();
            }

            if (erros.Length != 0)
            {
                throw new Exception(erros.ToString());
            }
        }

        public void TirarPreposicao(List<string> tags)
        {
            List<string> palavrasARemover = new List<string>()
            {
                "a", "e", "i", "o", "u","da","de","di","do","du","na",
                "ni","no","nu","ne","as","os","das","dos","des","la","lo"
            };
            
            for (int i = tags.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < palavrasARemover.Count; j++)
                {
                    if (tags[i].ToLower() == palavrasARemover[j].ToLower())
                    {
                        tags.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public List<Peca> LerPecasComATag(string tag)
        {
             List<Peca> respostaDB = dal.LerPecasComATag(tag);
             return respostaDB;
        }

       public List<Peca> LerPecasInterseccaoTags(List<string> tags)
        {
            List<Peca> respostaDB = dal.LerPecasInterseccaoTags(tags);
            return respostaDB;
        }


       
    }
}
