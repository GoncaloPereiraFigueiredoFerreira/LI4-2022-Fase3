namespace SpotGuru.Models
{
    public class SlotsView
    {
        public int Id { get; set; }
        public int Hora { get; set; }  
        public int Dia { get; set; }
        public int IdUtilizador { get; set; }

        public SlotsView(int id, int hora, int dia, int idUtilizador)
        {
            Id = id;
            Hora = hora;
            Dia = dia;
            IdUtilizador = idUtilizador;
        }
    }
}