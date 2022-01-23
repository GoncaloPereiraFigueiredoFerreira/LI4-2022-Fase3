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

                List<Slots> slots = new List<Slots>();
                for(int i = 10; i < 20; i++)
                {
                    Slots s = new Slots
                    {
                        HoraInicial = new DateTime(2022, 1, 25, i, 0, 0),
                        Utilizador = null
                    };
                    slots.Add(s);
                    context.Add(s);
                }

                Horario horario = new Horario {

                    HoraAbertura = 8,
                    HoraEncerramento = 22,
                    CustoSlot = 0,
                    DuracaoSlot = 60,
                    Slots = slots
                };

                Monumentos bomJesus = new Monumentos
                {
                    Nome = "Bom Jesus do Monte",
                    Descrição = "Located on the slopes of Mount Espinho, which dominates the city of Braga, in northern Portugal, this cultural landscape evokes Christian Jerusalem and reproduces a sacred mountain crowned with a church. Built over a period of more than 600 years, mainly in a Baroque style, the sanctuary illustrates the European tradition of the  Sacri Monti  (sacred mountains), promoted by the Catholic Church at the Council of Trent in the 16th century  , in reaction to the Protestant Reformation. The Bom Jesus ensemble is centered on a  Via Crucis  that runs along the western flank of Mt. It has a series of chapels that house sculptures evoking the Passion of Christ, fountains, allegorical sculptures and classical gardens. The  Via Crucisleads to the church, built between 1784 and 1811. The granite buildings have plastered, whitewashed facades framed by exposed stone masonry. The famous Staircase of the Five Senses, which features walls, steps, fountains, statues and other ornamental elements, is the most emblematic Baroque work within the property. They are framed by lush woods and surrounded by a picturesque park which, masterfully situated on the steep hill, strongly contributes to the landscape value of the whole. (source: UNESCO)",
                    Latitude = 41.554761,
                    Categoria = Categorias.Sanctuary,
                    Longitude = -8.377084,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "bomjesus.jpg"
                };
                Monumentos sameiro = new Monumentos
                {
                    Nome = "Santuario de Nossa Senhora do Sameiro",
                    Descrição = "The Sanctuary of Our Lady of Sameiro (or Sanctuary of Sameiro) is a sanctuary and Marian shrine located in Braga, in the surroundings of the city of Braga, Portugal. The Shrine of Our Lady of Sameiro is one of the places most visited Marian cult in Portugal, attracting many devotees every year during pilgrimages from 1st Sunday of June and the last Sunday of August. Its construction was initiated in s. XIX, by Father Martinho da Silva, in neoclassical style. Artistically not have much interest except the silver tabernacle that we can see on the main altar and the image of the patron saint, held in Rome by the sculptor Eugénio Maccagnani and brought to the sanctuary in 1880. But his visit is justified by the fact that we have here one of the most spacious panoramic Region, as the Shrine of Our Lady of Sameiro is 566 meters. Construction was begun on 14 July 1863 on the domed church of Nossa Senhora do Sameiro (Our Lady of Sameiro). The founder of the shrine was the Vicar of Braga, Padre Antonio Martinho Pereira da Silva. The sanctuary is the largest Marian devotional shrine in Portugal, second only to the Sanctuary of Fátima. Pope John Paul II visited this Marian shrine on May 15, 1982. (source: Itinari)",
                    Latitude = 41.542471,
                    Categoria = Categorias.Sanctuary,
                    Longitude = -8.369686,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "santuariosameiro.jpg"
                };
                Monumentos ddiogo= new Monumentos
                {
                    Nome = "Museu de Arqueologia D. Diogo de Sousa",
                    Descrição = "The D. Diogo de Sousa Museum is located in Braga, Portugal.The Museum was founded in 1918 and moved to the new house in 2007 June 29. The Museum is housed in a specially designed building in the center of what was the Roman City of Bracara Augusta. Its collection mostly comprises items from excavations that took place in Braga with a vast chronological and cultural period, from the Palaeolithic to the Middle Ages.(source:Wikipedia)",
                    Latitude = 41.546083,
                    Categoria = Categorias.Museum,
                    Longitude = -8.427188,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "museudiogo.png"
                };
                Monumentos mSe = new Monumentos
                {
                    Nome = "Museu da Sé de Braga",
                    Descrição = "The museum is located in the treasury of the Braga cathedral. His collections document over 1500 years of Christian history in the city and its surroundings. The museum's collection includes religious sculptures and paintings, mainly from diocese churches, books and liturgical vessels, as well as church vestments, documents and iconographic collections showing the church's life in different ages. (source: Tropter)",
                    Categoria = Categorias.Museum,
                    Latitude = 41.550393,
                    Longitude = -8.427576,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "museusebraga.jpg"
                };
                Monumentos montariol = new Monumentos
                {
                    Nome = "Convento Franciscano de Montariol",
                    Descrição = "No available description for this monument.",
                    Categoria = Categorias.Convent,
                    Latitude = 41.569934,
                    Longitude = -8.410950,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "conventofran.jpg"
                };
                Monumentos saoVitor = new Monumentos
                {
                    Nome = "Igreja de São Victor",
                    Descrição = "Baroque church dedicated to Saint Vincent of Zaragoza. It was built in the second half of the 16th century and is an example of the Baroque variety typical of Portugal. Its facade is decorated with stonework painting and is crowned with a stepped tympanum. Inside you can see carved altars and walls lined with azulejos.(source: Tropter)",
                    Categoria = Categorias.Church,
                    Latitude = 41.553510,
                    Longitude = -8.413584,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "igrejasaovictor.jpg"
                };
                Monumentos palacioDoRaio = new Monumentos
                {
                    Nome = "Palácio do Raio",
                    Descrição = "The Palace of Raio (Portuguese: Palácio do Raio) is a Baroque era residence in the urbanized area of the municipality of Braga, in the civil parish of São José de São Lázaro. It is an example of the late Baroque, early Rococo style of decoration by Portuguese architect André Soares, notable for his influence in the northern Baroque movement.(source: Wikipedia)",
                    Categoria = Categorias.Museum,
                    Latitude = 41.548886,
                    Longitude = -8.422631,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "palaciodoraio.jpg"
                };
                Monumentos biscainhos = new Monumentos
                {
                    Nome = "Museu dos Biscainhos",
                    Descrição = "The Biscainhos Museum was opened in the second half. Of the twentieth century, and its purpose is to show the everyday life of the eighteenth century nobility and other residents of the property. The phenomenal interiors of the residence present a superbly preserved period decor. Wonderful ceramics, unique family souvenirs and a beautiful collection of clocks will delight not only enthusiasts of art history. The beautiful baroque garden is the perfect place to catch a little breath.The museum is based in a 16th-century palace that has been home to generations of Portuguese aristocrats for centuries. The first owners of the residence was the Bertiandos family. Both the name of the entire property and the museum institution come from their names.The palace's green area is considered one of the most important historical gardens in Portugal. On its territory there is a natural monument - almost 300 years old American tulip tree. Tulipeira from Virginia is the largest and oldest plant of this species in the country.(source: tropter)",
                    Categoria = Categorias.Museum,
                    Latitude = 41.551474,
                    Longitude = -8.429301,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "museubiscainhos.jpg"
                };
                Monumentos tibaes = new Monumentos
                {
                    Nome = "Mosteiro de Tibães",
                    Descrição = "Monastery of saint Martin's church is located on the banks of the Cávado River, about 5 kilometers from the city center of Braga. The monastery known for its rich Rococo style decorations was erected in the 11th century during the fights of Christians with the Moors. Currently, there is a small historical museum inside the church.Immediately after its construction, the Monastery of St. Marcin's became one of the richest religious buildings in this part of the country. In 1567, the temple was chosen the seat of the Order of Saint Benedict. In the first half of the 17th century, the monks began a radical reconstruction, thanks to which the church gained its present shape.In 1757-1760, the main altar, side altars and pulpit were built in the church, which became characteristic elements of Portuguese Rococo art. The author of the works was André Soares, a leading Portuguese sculptor of the 17th century. In the monastery you can also admire the gilded woodwork by José de Santo António Vilaça and the statues of the famous sculptor named Cipriano da Cruz.(source: tropter)",
                    Categoria = Categorias.Monastery,
                    Latitude = 41.556407,
                    Longitude = -8.478617,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "mosteriodetibaes.jpg"
                };
                Monumentos barbara = new Monumentos
                {
                    Nome = "Jardim de Santa Bárbara",
                    Descrição = "The colorful garden is directly adjacent to the medieval Archbishop's Palace. Discounts, boxwoods and avenues are arranged in geometric patterns. Stone arcades form one of the garden walls.(source: tropter)",
                    Categoria = Categorias.TouristAttraction,
                    Latitude = 41.551520,
                    Longitude = -8.425855,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "jardimsantabarbara.jpg"
                };
                Monumentos paco = new Monumentos
                {
                    Nome = "Paços do Concelho de Braga",
                    Descrição = "No available description.",
                    Categoria = Categorias.HistoricalReferencePoint,
                    Latitude = 41.551011,
                    Longitude = -8.428384,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "pacosdoconselho.jpg"
                };
                Monumentos populo = new Monumentos
                {
                    Nome = "Igreja do Pópulo",
                    Descrição = "The church was built in the 16th century as the tomb of Bishop Agostinho de Jesus. Initially, it had the features of Mannerist style, but in the 18th century it was rebuilt in the spirit of neoclassicism. Behind the façade decorated with columns and tymapnon is the interior lined with azulejos.(source: tropter)",
                    Categoria = Categorias.Church,
                    Latitude = 41.551896,    
                    Longitude = -8.429268,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "igrejapopulo.jpg"
                };
                Monumentos palmeira = new Monumentos
                {
                    Nome = "Igreja de Palmeira",
                    Descrição = "Its a church. Very pretty tho. =)",
                    Categoria = Categorias.Church,
                    Latitude = 41.590084,
                    Longitude = -8.426753,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "igrejapalmeira.jpg"
                };
                Monumentos se = new Monumentos
                {
                    Nome = "Sé de Braga",
                    Descrição = "Braga Cathedral (Sé de Braga), in the historic center of Braga is the seat of the Archdiocese of Braga. The archbishop of Braga is the primate of all Portugal, somewhat equivalent to the archbishop of Canterbury in England. Braga Cathedral is the oldest cathedral in Portugal and one of the oldest cathedrals on the Iberian Peninsula.The twin-towered building originally dates from the 11th century and is a mix of different architectural styles as renovation and rebuilding took place over the succeeding centuries. (source: Wikipedia)",
                    Categoria = Categorias.Cathedral,
                    Latitude = 41.550234,
                    Longitude = -8.426991,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "sebraga.jpg"
                };
                Monumentos sntCruz = new Monumentos
                {
                    Nome = "Igreja de Santa Cruz",
                    Descrição = "The Holy Cross Church in Portuguese, Igreja de Santa Cruz is a Portuguese 17th century church in Braga, Portugal, dedicated to the Holy Cross.The Church of the Five Wounds in San Jose, California was modeled after the Holy Cross Church in Braga.(wikipedia)",
                    Categoria = Categorias.Church,
                    Latitude = 41.549541,
                    Longitude = -8.423975,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "igrejaSantaCruz.jpg"
                };
                Monumentos chafariz = new Monumentos
                {
                    Nome = "Chafariz da Praça da República",
                    Descrição = "No available description.",
                    Categoria = Categorias.TouristAttraction,
                    Latitude = 41.551440,  
                    Longitude = -8.423092,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "chafarizPracaRepublica.jpg"
                };
                Monumentos congregados = new Monumentos
                {
                    Nome = "Basílica dos Congregados",
                    Descrição = "The baroque basilica, whose construction began at the beginning of the 18th century, lasted until the mid-20th century, when neo-rococo and neoclassical frescoes were made in the church. It is a three-nave building with an extensive, two-tower facade with numerous pilasters, cornices and other decorative elements. The interior is decorated with stone sculptures of saints, and the presbytery has a baroque high altar with the gilded Throne of the Blessed Sacrament.(tropter)",
                    Categoria = Categorias.Basilica,
                    Latitude = 41.551123,
                    Longitude = -8.421345,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "basilicaCongregados.jpg"
                };
                Monumentos arco = new Monumentos
                {
                    Nome = "Arco da Porta Nova",
                    Descrição = "The Arch of the New Gate (Portuguese: Arco da Porta Nova), is a Baroque and Neoclassical arch, designed by André Soares in the late 18th century, in the civil parish of Sé, municipality of Braga, in northern Portugal. The triumphal arch which decorates the western entrance to the medieval wall of the city, was opened in 1512 and traditionally used to present the city's keys to dignitaries and celebrities.(source: Wikipedia)",
                    Categoria = Categorias.Sculpture,
                    Latitude  = 41.550441,
                    Longitude = -8.429299,
                    Horario = horario,
                    Reviews = new List<Review>(),
                    pathFoto = "arcoPortaNova.jpg"
                };
                context.Add(horario);
                context.Add(bomJesus);
                context.Add(arco);
                context.Add(congregados);
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
