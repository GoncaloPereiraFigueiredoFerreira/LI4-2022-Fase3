using System.ComponentModel.DataAnnotations;

namespace SpotGuru.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 5)]
        public short Value { get; set; }

        public Microsoft.AspNetCore.Identity.IdentityUser User { get; set; }

        public Rating()
        {


        }

        public Rating(int Id, short Value, Microsoft.AspNetCore.Identity.IdentityUser User)
        {
            this.Id = Id;
            this.Value = Value;
            this.User = User;
        }
    }
}
