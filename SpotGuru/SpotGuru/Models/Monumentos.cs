using System.Collections.Generic;

namespace SpotGuru.Models
{
    public class Monumentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Categorias Categoria { get; set; }
        public Horario Horario { get; set; }
        public List<Review> Reviews { get; set; }

        public string pathFoto { get; set; }  
        public Monumentos()
        {
                
        }
        public Monumentos(int id, string nome, string descrição, double latitude, double longitude, Categorias categoria, Horario horario, List<Review> reviews)
        {
            Id = id;
            Nome = nome;
            Descrição = descrição;
            Latitude = latitude;
            Longitude = longitude;
            Categoria = categoria;
            Horario = horario;
            Reviews = reviews;
        }
    }
}
