using System.ComponentModel;

namespace SpotGuru.Models
{
    public enum Categorias
    {
        [Description("Tourist Attraction")] Tourist_Attraction = 1,
        [Description("Sculpture")] Sculpture = 2,
        [Description("Cathedral")] Cathedral = 3,
        [Description("Church")] Church = 4,
        [Description("Museum")] Museum = 5,
        [Description("Historical Reference Point")] Historical_Reference_Point = 6
    }
}
