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
                    Nome = "Bom Jesus do Monte",
                    Descrição = "Monumento em braga",
                    Latitude = 41.554761,
                    Categoria = Categorias.catedral,
                    Longitude = -8.377084,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos sameiro = new Monumentos
                {
                    Nome = "Santuario de Nossa Senhora do Sameiro",
                    Descrição = "Monumento em braga",
                    Latitude = 41.542471,
                    Categoria = Categorias.catedral,
                    Longitude = -8.369686,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos ddiogo= new Monumentos
                {
                    Nome = "Museu de Arqueologia D. Diogo de Sousa",
                    Descrição = "Monumento em braga",
                    Latitude = 41.546083,
                    Categoria = Categorias.museu,
                    Longitude = -8.427188,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos mSe = new Monumentos
                {
                    Nome = "Museu da Sé de Braga",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.museu,
                    Latitude = 41.550393,
                    Longitude = -8.427576,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos montariol = new Monumentos
                {
                    Nome = "Convento Franciscano de Montariol",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.museu,
                    Latitude = 41.569934,
                    Longitude = -8.410950,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos saoVitor = new Monumentos
                {
                    Nome = "Igreja de São Victor",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.igreja,
                    Latitude = 41.553510,
                    Longitude = -8.413584,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos palacioDoRaio = new Monumentos
                {
                    Nome = "Palácio do Raio",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.museu,
                    Latitude = 41.548886,
                    Longitude = -8.422631,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos biscainhos = new Monumentos
                {
                    Nome = "Museu dos Biscainhos",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.museu,
                    Latitude = 41.551474,
                    Longitude = -8.429301,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos tibaes = new Monumentos
                {
                    Nome = "Mosteiro de Tibães",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.atração_turística,
                    Latitude = 41.556407,
                    Longitude = -8.478617,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos barbara = new Monumentos
                {
                    Nome = "Jardim de Santa Bárbara",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.atração_turística,
                    Latitude = 41.551520,
                    Longitude = -8.425855,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos paco = new Monumentos
                {
                    Nome = "Paços do Concelho de Braga",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.ponto_de_referencia_historico,
                    Latitude = 41.551064,
                    Longitude = -8.164455,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos populo = new Monumentos
                {
                    Nome = "Igreja do Pópulo",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.catedral,
                    Latitude = 41.551896,    
                    Longitude = -8.429268,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos palmeira = new Monumentos
                {
                    Nome = "Igreja de Palmeira",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.igreja,
                    Latitude = 41.590084,
                    Longitude = -8.426753,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos se = new Monumentos
                {
                    Nome = "Sé de Braga",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.catedral,
                    Latitude = 41.550234,
                    Longitude = -8.426991,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos sntCruz = new Monumentos
                {
                    Nome = "Igreja de Santa Cruz",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.igreja,
                    Latitude = 41.549541,
                    Longitude = -8.423975,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos chafariz = new Monumentos
                {
                    Nome = "Chafariz da Praça da República",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.atração_turística,
                    Latitude = 41.551440,  
                    Longitude = -8.423092,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                Monumentos arco = new Monumentos
                {
                    Nome = "Arco da Porta Nova",
                    Descrição = "Monumento em braga",
                    Categoria = Categorias.escultura,
                    Latitude  = 41.550441,
                    Longitude = -8.429299,
                    Horario = horario,
                    Reviews = new List<Review>()
                };
                context.Add(horario);
                context.Add(bomJesus);
                context.Add(arco);
                context.Add(chafariz);
                context.Add(sntCruz);
                context.Add(se);
                context.Add(palmeira);
                context.Add(populo);
                context.Add(paco);
                context.Add(barbara);
                context.Add(sameiro);
                context.Add(ddiogo);
                context.Add(mSe);
                context.Add(montariol);
                context.Add(saoVitor);
                context.Add(palacioDoRaio);
                context.Add(biscainhos);
                context.Add(tibaes);


                context.SaveChanges();


            }
            

            
        }
    }
}
