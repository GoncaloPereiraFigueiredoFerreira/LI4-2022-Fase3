namespace SpotGuru.Models
{
    public class Slots
    {
        public int Id { get; set; }
        public int Hora { get; set; }
        public int Dia { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityUser Utilizador { get; set; }


        public Slots()
        {
                
        }

        public Slots(int id, int hora, int dia, Microsoft.AspNetCore.Identity.IdentityUser Utilizador)
        {
            Id = id;
            Hora = hora;
            Dia = dia;
            this.Utilizador = Utilizador;
        }
    }
}
