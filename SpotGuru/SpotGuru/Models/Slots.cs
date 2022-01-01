namespace SpotGuru.Models
{
    public class Slots
    {
        public int Id { get; set; }
        public int Hora { get; set; }  
        public int Dia { get; set; }
        public int IdUtilizador { get; set; }

        public Slots(int id, int hora, int dia, int idUtilizador)
        {
            Id = id;
            Hora = hora;
            Dia = dia;
            IdUtilizador = idUtilizador;
        }
    }
}