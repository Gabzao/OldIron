using DataAccessLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{

    public class ModeloBLL
    {
        ModeloDAL dal = new ModeloDAL();
        public void Inserir(Modelo modelo)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(modelo.Nome))
            {
                erros.AppendLine("O nome do modelo deve ser informado. ");
            }

            if (modelo.Nome.Length > 50)
            {
                erros.AppendLine(" O modelo não pode conter mais que 50 caracteres. ");
            }

            if (string.IsNullOrWhiteSpace(modelo.IDMarca.ToString()))
            {
                erros.AppendLine("O ID da marca deve ser informada.");
            }

            if (erros.Length != 0)
            {
                throw new Exception(erros.ToString());
            }
              dal.Inserir(modelo);

        }

        public List<Modelo> LerTodos()
        {
            return dal.LerTodos();
        }

        public void Atualizar(Modelo modelo)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(modelo.Nome))
            {
                erros.AppendLine("O nome do modelo deve ser informado. ");
            }

            if (modelo.Nome.Length > 50)
            {
                erros.AppendLine(" O modelo não pode conter mais que 50 caracteres. ");
            }

            if (string.IsNullOrWhiteSpace(modelo.IDMarca.ToString()))
            {
                erros.AppendLine("O ID da marca deve ser informada.");
            }

            if (erros.Length != 0)
            {
                throw new Exception(erros.ToString());
            }
            dal.Atualizar(modelo);

        }

        public List<Modelo> LerTodosModelosDaMarca(int id)
        {
            return dal.LerTodosModelosDaMarca(id);
        }


        public void Deletar(Modelo modelo)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(modelo.ID.ToString()))
            {
                erros.AppendLine("O ID do modelo deve ser informado.");
            }

            if (erros.Length != 0)
            {
                throw new Exception(erros.ToString());
            }
            dal.Deletar(modelo);

        }

    }
}
