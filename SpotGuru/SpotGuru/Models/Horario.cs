using System;
using System.Collections.Generic;

namespace SpotGuru.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int HoraAbertura { get; set; }
        public int HoraEncerramento { get; set; }
        public int DuracaoSlot { get; set; } //Duracao em minutos
        public float CustoSlot { get; set; }
        public List<Slots> Slots { get; set; }

        public Horario()
        {
            Slots=new List<Slots>();
        }
        public Horario(int id, int horaAbertura, int horaEncerramento, int duracaoSlot, float custoSlot, List<Slots> slots)
        {
            Id = id;
            HoraAbertura = horaAbertura;
            HoraEncerramento = horaEncerramento;
            DuracaoSlot = duracaoSlot;
            CustoSlot = custoSlot;
            Slots = slots;
        }
    }
}
