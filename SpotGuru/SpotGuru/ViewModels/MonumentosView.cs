using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpotGuru.Models
{

    public class MonumentosView
    {


        public MonumentosView()
        {

        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descrição { get; set; }
        public string PathFoto { get; set; }

        public LocalizacaoView Localizacao { get; set; }

        public List<ReviewView> Reviews { get; set; }

        public string Categoria {get;set;}

        public int IDHorario { get; set; }

        public MonumentosView(int id, string nome, string descrição, double latitude, double longitude, List<ReviewView> reviews, string categoria, int IDhorario)
        {
            Id = id;
            Nome = nome;
            Descrição = descrição;
            Localizacao = new LocalizacaoView(latitude, longitude);
            Reviews = reviews;
            Categoria = categoria;
            IDHorario = IDhorario;
        }
    }
}
