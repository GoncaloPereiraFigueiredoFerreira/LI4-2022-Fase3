using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SpotGuru.Models;

namespace SpotGuru.ViewModels
{

    public class MonumentosView
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
        public float Rating { get; set; }
        public bool isFavorite { get; set; } //Represent if the monument was added to the user's list of favorites
        public float distanceToUser { get; set; }
        public MonumentosView() { }

        public MonumentosView(Monumentos monumentos, float rating)
        {
            Id = monumentos.Id;
            Nome = monumentos.Nome;
            Descrição = monumentos.Descrição;
            Latitude = monumentos.Latitude;
            Longitude = monumentos.Longitude;
            Categoria = monumentos.Categoria;
            Horario = monumentos.Horario;
            Reviews = monumentos.Reviews;
            pathFoto = monumentos.pathFoto;
            Rating = rating;
            isFavorite = false;
        }

        public MonumentosView(Monumentos monumentos, float rating, bool isFavorite) : this(monumentos, rating)
        {
            this.isFavorite = isFavorite;
        }

        public MonumentosView(int id, string nome, string descrição, double latitude, double longitude, Categorias categoria, Horario horario, List<Review> reviews, string pathFoto, float rating)
        {
            Id = id;
            Nome = nome;
            Descrição = descrição;
            Latitude = latitude;
            Longitude = longitude;
            Categoria = categoria;
            Horario = horario;
            Reviews = reviews;
            this.pathFoto = pathFoto;
            Rating = rating;
        }
    }
}
