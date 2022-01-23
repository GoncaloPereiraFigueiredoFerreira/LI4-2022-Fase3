using Microsoft.AspNetCore.Identity;
using SpotGuru.Models;
using System;
using System.Collections.Generic;
using SpotGuru.Helpers;

namespace SpotGuru.ViewModels
{
    public class HorarioView
    {
        public int Id { get; set; }
        public int HoraAbertura { get; set; }
        public int HoraEncerramento { get; set; }
        public int DuracaoSlot { get; set; }
        public float CustoSlot { get; set; }
        public DateTime DiaAtual { get; set; }
        public Dictionary<int, Slots> SlotsOcupados { get; set; }
        public IdentityUser Utilizador { get; set; }

        public HorarioView(Horario horario, IdentityUser user)
        {
            DiaAtual = DateTime.Today;
            Id = horario.Id;
            HoraAbertura = horario.HoraAbertura;
            HoraEncerramento = horario.HoraEncerramento;
            CustoSlot = horario.CustoSlot;
            DuracaoSlot = horario.DuracaoSlot;
            SlotsOcupados = new Dictionary<int, Slots>();
            Utilizador = user;

            horario.Slots.ForEach(s => {
                int id = HorarioHelper.calculaId(DiaAtual, s.HoraInicial, HoraAbertura, HoraEncerramento, DuracaoSlot);  SlotsOcupados.TryAdd(id, s);
                Console.WriteLine("Id: " + id + " | DiaAtual: " + DiaAtual + " | horaInicial: " + s.HoraInicial + " | horaAbertura: " + HoraAbertura + " | horaEnc: " + HoraEncerramento + " | Duracao: " + DuracaoSlot); 
            });
        }

        //Return Values:
        //  -> 0 - Indisponivel
        //  -> 1 - Disponivel
        //  -> 2 - Ocupado pelo próprio utilizador
        //  -> 3 - Ocupado por outros utilizadores
        public int slotDisponibilidade(int idSlot)
        {
            Slots slot = null;

            if (!SlotsOcupados.TryGetValue(idSlot, out slot))
            {
                if (DateTime.Now.CompareTo(HorarioHelper.calculaDiaEHora(idSlot, HoraAbertura, HoraEncerramento, DuracaoSlot, DateTime.Today)) < 0)
                    return 1;
                return 0;
            }
            else
            {
                if (slot.Utilizador.Id == Utilizador.Id) return 2;
                else return 3;
            }
        }
    }
}
