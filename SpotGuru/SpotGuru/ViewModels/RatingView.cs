using SpotGuru.Models;

namespace SpotGuru.ViewModels
{
    public class RatingView
    {
        public int Id { get; set; }
        public short Value { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityUser User { get; set; }
        public bool alreadyRated { get; set; }

        public RatingView(Rating rating)
        {
            if (rating == null)
            {
                alreadyRated = false;
            }
            else
            {
                alreadyRated = true;
                this.Id = rating.Id;
                this.Value = rating.Value;
                this.User = rating.User;
            }
        }
    }
}
