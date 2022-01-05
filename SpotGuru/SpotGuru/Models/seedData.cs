using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpotGuru.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpotGuru.Models
{

    public class seedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Monumentos.Any())
                {
                    return;   // DB has been seeded
                }
                Horario horario = new Horario {

                    HoraAbertura = 8,
                    HoraEncerrament = 22,
                    CustoSlot = 0,
                    Slots = new List<Slots>()
                };

                Monumentos bomJesus = new Monumentos
                {
                    Nome = "Bom Jesus",
                    Descrição = "Monumento em braga",
                    Latitude = 41.55476137144669,
                    Longitude = -8.377084395187476,
                    Horario = horario,
                    Reviews = new List<Review>()
                };

                Monumentos arco = new Monumentos
                {
                    Nome = "Arco da Porta Nova",
                    Descrição = "Monumento em braga",
                    Latitude = 41.550441021041735,
                    Longitude = -8.429299286606621,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                context.Add(horario);
                context.Add(bomJesus);
                context.Add(arco);
                context.SaveChanges();


            }
            

            
        }
    }
}
