using System;

namespace SpotGuru.Models
{

    public class Slots
    {
        public int Id { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityUser Utilizador { get; set; }


        public Slots()
        {
                
        }

        public Slots(int id, DateTime horaI, DateTime horaF, Microsoft.AspNetCore.Identity.IdentityUser Utilizador)
        {
            Id = id;
            HoraInicial = horaI;
            HoraFinal = horaF;
            this.Utilizador = Utilizador;
        }
    }
}
