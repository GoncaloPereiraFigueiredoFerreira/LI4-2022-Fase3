using System;

namespace SpotGuru.Models
{

    public class Slots
    {
        public int Id { get; set; }
        public DateTime HoraInicial { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityUser Utilizador { get; set; }
        public Horario Horario { get; set; }

        public Slots()
        {
                
        }

        public Slots(int id, DateTime horaI, Microsoft.AspNetCore.Identity.IdentityUser Utilizador)
        {
            Id = id;
            HoraInicial = horaI;
            this.Utilizador = Utilizador;
        }
    }
}
