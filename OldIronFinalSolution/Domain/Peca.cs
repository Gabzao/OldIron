using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Peca
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public Modelo Modelo { get; set; }
        public int Ano { get; set; }
        public Marca Marca { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public List<ImagemPeca> Imagens { get; set; }
        public Peca()
        {
            this.Imagens = new List<ImagemPeca>();
            this.Marca = new Marca();
            this.Modelo = new Modelo();
        }
        public void AddImagem(ImagemPeca imagem)
        {
            this.Imagens.Add(imagem);
        }
    }
    public class ImagemPeca
    {
        public byte[] Imagem { get; set; }
    }
}
