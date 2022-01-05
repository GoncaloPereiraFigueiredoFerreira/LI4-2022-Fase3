using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpotGuru.Models
{
    public class Favoritos
    {
        public int Id { get; set; } 

        public Microsoft.AspNetCore.Identity.IdentityUser Utilizador { get; set; }

        public Monumentos Monumentos{ get; set; }
        public Favoritos()
        {

        }
    }
}
