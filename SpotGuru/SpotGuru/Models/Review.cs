using System.ComponentModel.DataAnnotations;

namespace SpotGuru.Models
{
    public class Review
    {

        public int Id { get; set; }

        public Monumentos Monumentos{ get; set; }

        [Required]
        public string Comentario { get; set; }

        [Required]
        [Range(1,5)]
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
