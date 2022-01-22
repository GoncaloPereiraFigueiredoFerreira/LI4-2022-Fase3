using System.datetime;

namespace SpotGuru.Models
{
    public class SlotDisponivel
    {
        public int Id { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }


        public Slots()
        {

        }

        public Slots(int id, DateTime horaI, DateTime horaF)
        {
            Id = id;
            HoraInicial = horaI;
            HoraFinal = horaF;
        }
    }
}
}
