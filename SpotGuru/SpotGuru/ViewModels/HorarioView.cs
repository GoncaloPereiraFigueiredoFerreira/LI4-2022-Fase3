using Microsoft.AspNetCore.Identity;
using SpotGuru.Models;
using System;
using System.Collections.Generic;

namespace SpotGuru.ViewModels
{
    public class HorarioView
    {
        public int Id { get; set; }
        public int HoraAbertura { get; set; }
        public int HoraEncerrament { get; set; }
        public float CustoSlot { get; set; }

        public DateTime DiaAtual { get; set; }
        public Dictionary<DateTime, Slots> SlotsDisponiveis { get; set; }

        public Dictionary<DateTime, Slots> SlotsOcupadosPeloUser { get; set; }

        public Dictionary<DateTime, Slots> SlotsOcupadosPorOutros { get; set; }

        public HorarioView(int id, int horaAbertura, int horaEncerrament, float custoSlot, List<Slots> slots, IdentityUser user)
        {
            DiaAtual = DateTime.Now.Date;
            Id = id;
            HoraAbertura = horaAbertura;
            HoraEncerrament = horaEncerrament;
            CustoSlot = custoSlot;

            SlotsDisponiveis = new Dictionary<DateTime, Slots>();
            SlotsOcupadosPeloUser = new Dictionary<DateTime, Slots>();
            SlotsOcupadosPorOutros = new Dictionary<DateTime, Slots>();

            foreach (Slots s in slots)
            {
                IdentityUser utilizador = s.Utilizador;
                if (utilizador == null)
                {
                    SlotsDisponiveis.Add(s.HoraInicial, s);
                }
                else if (utilizador.Equals(user))
                {
                    SlotsOcupadosPeloUser.Add(s.HoraInicial, s);
                }
                else
                {
                    SlotsOcupadosPorOutros.Add(s.HoraInicial, s);
                }
            }
        }

        public IdPlusEstadoView slotDisponibilidade(int diaSemana, int HoraInicial)
        {
            int diferencaDias = (int)DiaAtual.DayOfWeek - diaSemana;
            if (diferencaDias < 0)
            {
                diferencaDias = Math.Abs(diferencaDias) + (int)DiaAtual.DayOfWeek;
            }
            DateTime dia = DiaAtual;
            dia = dia.AddDays(diferencaDias);
            dia = dia.AddHours(HoraInicial);

            Console.WriteLine(diferencaDias);
            Console.WriteLine(HoraInicial);
            Console.WriteLine(dia);

            Slots s=null;
            if (SlotsDisponiveis.TryGetValue(dia,out s))
            {
                return new IdPlusEstadoView
                {
                    Id= s.Id,
                    Estado=1
                };
            }
            if (SlotsOcupadosPeloUser.TryGetValue(dia, out s))
            {
                return new IdPlusEstadoView
                {
                    Id = s.Id,
                    Estado = 2
                };
            }

            if (SlotsOcupadosPorOutros.TryGetValue(dia, out s))
            {
                return new IdPlusEstadoView
                {
                    Id = s.Id,
                    Estado = 3
                };
            }
            return new IdPlusEstadoView
            {
                Id = -1,
                Estado = 0
            };
        }
    }
}
