using Microsoft.EntityFrameworkCore;

namespace SpotGuru.Models
{
    public class LocalizacaoView
    {
        public string Id { get; set; }
  
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        
        public LocalizacaoView(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;

        }
    }
}
