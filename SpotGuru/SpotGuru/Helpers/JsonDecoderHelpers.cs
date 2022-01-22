using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpotGuru.Controllers
{
    public class Localizacao
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }
    public class Result
    {
        public List<Resources> resourceSets { get; set; }
    }

    public class Resources
    {
        public List<Total> resources { get; set; }
    }

    public class Total
    {
        public List<TravelDistence> results { get; set; }
    }

    public class TravelDistence
    {
        public float travelDistance { get; set; }
    }
}
