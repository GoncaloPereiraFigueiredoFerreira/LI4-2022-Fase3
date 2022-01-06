using SpotGuru.Models;

namespace SpotGuru.ViewModels
{
    public class FavoritosView
    {
        public FavoritosView()
        { 

        }

        public int Id { get; set; }

        public Microsoft.AspNetCore.Identity.IdentityUser Utilizador { get; set; }

        public Monumentos Monumentos { get; set; }

    }
}
