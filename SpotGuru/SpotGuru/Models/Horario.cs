using System.Collections.Generic;

namespace SpotGuru.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int HoraAbertura { get; set; }
        public int HoraEncerrament { get; set; }
        public float CustoSlot { get; set; }
        public List<Slots> Slots { get; set; }

        public List<SlotDisponivel> SlotsDisponiveis { get; set; }

        public Horario()
        {

        }
        public Horario(int id, int horaAbertura, int horaEncerrament, float custoSlot, List<Slots> slots, List<SlotDisponivel> slotsDisponiveis)
        {
            Id = id;
            HoraAbertura = horaAbertura;
            HoraEncerrament = horaEncerrament;
            CustoSlot = custoSlot;
            Slots = slots;
            SlotsDisponiveis = slotsDisponiveis;
        }
    }
}
