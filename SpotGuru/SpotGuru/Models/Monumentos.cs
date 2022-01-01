using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpotGuru.Models
{

    public class Monumentos
    {


        public Monumentos()
        {

        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descrição { get; set; }
        public string PathFoto { get; set; }

        public Localizacao Localizacao { get; set; }

        public List<Review> Reviews { get; set; }

        public string Categoria {get;set;}

        public int IDHorario { get; set; }

        public Monumentos(int id, string nome, string descrição, double latitude, double longitude, List<Review> reviews, string categoria, int IDhorario)
        {
            Id = id;
            Nome = nome;
            Descrição = descrição;
            Localizacao = new Localizacao(latitude, longitude);
            Reviews = reviews;
            Categoria = categoria;
            IDHorario = IDhorario;
        }
    }
}
