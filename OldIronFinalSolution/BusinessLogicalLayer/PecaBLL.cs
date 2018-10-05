using DataAccessLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class PecaBLL
    {

        PecaDAL dal = new PecaDAL();
        public void Inserir(Peca peca)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(peca.Descricao))
            {
                erros.AppendLine("A descrição deve ser informada. ");
            }
            if (peca.Descricao.Length > 100)
            {
                erros.AppendLine(" A descrição não pode conter mais que 100 caracteres. ");
            }

            if (string.IsNullOrWhiteSpace(peca.Ano.ToString()))
            {
                erros.AppendLine("O ano deve ser informado. ");
            }

            if (string.IsNullOrWhiteSpace(peca.Preco.ToString()))
            {
                erros.AppendLine("O preço deve ser informado. ");
            }

            if (string.IsNullOrWhiteSpace(peca.Estoque.ToString()))
            {
                erros.AppendLine("O estoque deve ser informado. ");
            }

            if (erros.Length != 0)
            {
                throw new Exception(erros.ToString());
            }
            int idGerado = dal.Inserir(peca);
            peca.ID = idGerado;
            dal.InserirImagems(peca);

        }

        public List<Peca> LerTodos()
        {
            return dal.LerTodos();
        }

        public List<Peca> LerTodosAoContrario()
        {
            return dal.LerTodosAoContrario();
        }

        public List<Peca> LerTodosPecasDoModelo(int id)
        {
            return dal.LerTodosPecasDoModelo(id);
        }

         public byte[] GetImagemPrincipalPeca(int id)
        {
            return dal.GetImagemPrincipalPeca(id);
        }

        public string Atualizar(Peca peca)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(peca.Descricao))
            {
                erros.AppendLine("A descrição deve ser informada. ");
            }
            if (peca.Descricao.Length > 100)
            {
                erros.AppendLine(" A descrição não pode conter mais que 100 caracteres. ");
            }

            if (string.IsNullOrWhiteSpace(peca.Ano.ToString()))
            {
                erros.AppendLine("O ano deve ser informado. ");
            }

            if (string.IsNullOrWhiteSpace(peca.Preco.ToString()))
            {
                erros.AppendLine("O preço deve ser informado. ");
            }

            if (string.IsNullOrWhiteSpace(peca.Estoque.ToString()))
            {
                erros.AppendLine("O estoque deve ser informado. ");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }
            string respostaDB = dal.Atualizar(peca);
            return respostaDB;
        }

        public string Deletar(Peca peca)
        {
            string respostaDB = dal.Deletar(peca);
            return respostaDB;
        }
    }
}
