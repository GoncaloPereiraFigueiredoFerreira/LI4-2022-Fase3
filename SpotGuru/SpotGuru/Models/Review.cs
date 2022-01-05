﻿namespace SpotGuru.Models
{
    public class Review
    {

        public int Id { get; set; }
        public Monumentos Monumentos{ get; set; }

        public string Comentario { get; set; }

        public int Classificacao { get; set; }  

        public Microsoft.AspNetCore.Identity.IdentityUser User { get; set; }

        public Review()
        {

        }

        public Review(int id, Monumentos monumentos, string comentario, Microsoft.AspNetCore.Identity.IdentityUser user)
        {
            Id = id;
            Monumentos = monumentos;
            Comentario = comentario;
            User = user;
        }
    }
}
