﻿using Microsoft.EntityFrameworkCore;

namespace SpotGuru.Models
{
    public class Localizacao
    {
        public string Id { get; set; }
  
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        
        public Localizacao(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;

        }
    }
}
