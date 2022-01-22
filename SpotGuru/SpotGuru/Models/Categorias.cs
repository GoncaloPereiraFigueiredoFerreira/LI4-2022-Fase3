using System.ComponentModel;

namespace SpotGuru.Models
{
    public enum Categorias
    {
        [Description("Tourist Attraction")] TouristAttraction = 1,
        [Description("Sculpture")] Sculpture = 2,
        [Description("Cathedral")] Cathedral = 3,
        [Description("Church")] Church = 4,
        [Description("Museum")] Museum = 5,
        [Description("Historical Reference Point")] HistoricalReferencePoint = 6,
        [Description("Sanctuary")] Sanctuary = 7,
        [Description("Convent")] Convent = 8,
        [Description("Monastery")] Monastery = 9,
        [Description("Basilica")] Basilica = 10
    }
}
