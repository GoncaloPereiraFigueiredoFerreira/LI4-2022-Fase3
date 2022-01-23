using System;

namespace SpotGuru.ViewModels
{
    public class SlotsView
    {
        public int Id { get; set; }
        public DateTime HoraInicial { get; set; }  
        public DateTime HoraFinal { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityUser Utilizador { get; set; }

        public SlotsView(int id, DateTime horaI, DateTime horaF, Microsoft.AspNetCore.Identity.IdentityUser utilizador)
        {
            Id = id;
            HoraInicial = horaI;
            HoraFinal = horaF;
            Utilizador = utilizador;
        }
    }
}