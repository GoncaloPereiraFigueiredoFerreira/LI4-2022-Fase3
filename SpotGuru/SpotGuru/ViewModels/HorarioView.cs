using System.Collections.Generic;

namespace SpotGuru.Models
{
    public class HorarioView
    {
        public int Id { get; set; }
        public int HoraAbertura { get; set; }
        public int HoraEncerrament { get; set; }
        public float CustoSlot { get; set; }

        public List<SlotsView> Slots { get; set; }

        public HorarioView(int id, int horaAbertura, int horaEncerrament, float custoSlot, List<SlotsView> slots)
        {
            Id = id;
            HoraAbertura = horaAbertura;
            HoraEncerrament = horaEncerrament;
            CustoSlot = custoSlot;
            Slots = slots;
        }
    }
}
