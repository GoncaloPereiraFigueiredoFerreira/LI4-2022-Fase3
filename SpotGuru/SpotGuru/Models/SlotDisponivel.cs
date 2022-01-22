using System;

namespace SpotGuru.Models
{
    public class SlotDisponivel
    {
        public int Id { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }


        public SlotDisponivel()
        {

        }

        public SlotDisponivel(int id, DateTime horaI, DateTime horaF)
        {
            Id = id;
            HoraInicial = horaI;
            HoraFinal = horaF;
        }
    }
}

