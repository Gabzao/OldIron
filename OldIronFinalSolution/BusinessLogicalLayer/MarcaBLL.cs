using DataAccessLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class MarcaBLL
    {
        private MarcaDAL dal = new MarcaDAL();

        public void Inserir(Marca marca)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(marca.Nome))
            {
                erros.AppendLine("O nome da marca deve ser informada. ");
            }

            if (marca.Nome.Length > 50)
            {
                erros.AppendLine("O nome da marca não pode conter mais que 50 caracteres.");
            }
            
            if (erros.Length != 0)
            {
                throw new Exception(erros.ToString());
            }

            dal.Inserir(marca);

        }

        public List<Marca> LerTodos()
        {
            return dal.LerTodos();
        }

        public void Deletar(Marca marca)
        {
            dal.Deletar(marca);
        }

        public void Editar(Marca marca)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(marca.Nome))
            {
                erros.AppendLine("O nome da marca deve ser informada. ");
            }

            if (marca.Nome.Length > 50)
            {
                erros.AppendLine("O nome da marca não pode conter mais que 50 caracteres.");
            }

            if (erros.Length != 0)
            {
                throw new Exception(erros.ToString());
            }
            dal.Atualizar(marca);
        }

    }
}
