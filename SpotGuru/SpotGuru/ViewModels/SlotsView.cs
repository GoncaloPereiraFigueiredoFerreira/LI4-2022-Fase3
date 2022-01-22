using System;

namespace SpotGuru.Models
{
    public class SlotsView
    {
        public int Id { get; set; }
        public DateTime HoraInicial { get; set; }  
        public DateTime HoraFinal { get; set; }
        public int IdUtilizador { get; set; }

        public SlotsView(int id, DateTime horaI, DateTime horaF, int idUtilizador)
        {
            Id = id;
            HoraInicial = horaI;
            HoraFinal = horaF;
            IdUtilizador = idUtilizador;
        }
    }
}