using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotGuru.Data;
using SpotGuru.Models;
using SpotGuru.ViewModels;

namespace SpotGuru.Controllers
{
    [Authorize]
    public class MonumentosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static readonly HttpClient client = new HttpClient();

        public MonumentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string latitude, string longitude)
        {
            List<Monumentos> mons = await _context.Monumentos.Include("Reviews.User").ToListAsync();
            IEnumerable<MonumentosView> monsViews = await loadMonumentosViewsDistances(mons, latitude, longitude);
            return View(monsViews);
        }

        public async Task<IActionResult> MonumentsSortedByDistance(string latitude, string longitude)
        {
            var monumentos = await _context.Monumentos.Include("Reviews.User").ToListAsync();

            IEnumerable<MonumentosView> monsViews = await loadMonumentosViewsDistances(monumentos, latitude, longitude);

            monsViews = monsViews.OrderBy(monView => monView.distanceToUser);
            
            return View(monsViews);
        }

        [HttpGet]
        public IActionResult Filters(bool sortByDistance)
        {
            return View(sortByDistance);
        }

        [HttpGet]
        public async Task<IActionResult> ApplyFilters(string FiltersList, bool sortByDistance, string latitude, string longitude)
        {
            string[] arr = FiltersList.Split(",");
            HashSet<Categorias> filtros = new HashSet<Categorias>();

            foreach (string filter in arr)
            {
                filtros.Add((Categorias) Enum.Parse(typeof(Categorias), filter));
            }
 
            List<Monumentos> mons = await _context.Monumentos.Include("Reviews.User").Where(mon => filtros.Contains(mon.Categoria)).ToListAsync();
            IEnumerable<MonumentosView> monsViews = await loadMonumentosViewsDistances(mons, latitude, longitude);

            if (sortByDistance) monsViews = monsViews.OrderBy(monv => monv.distanceToUser);

            return View("Index", monsViews);
        }

        [HttpGet]
        public async Task<IActionResult> SearchMonumentByName(string name, string latitude, string longitude)
        {
            IEnumerable<MonumentosView> monsViews;
            try
            {
                Monumentos mon = await _context.Monumentos.Include("Reviews.User").FirstAsync(monDB => monDB.Nome.Equals(name));
                List<Monumentos> mons = new List<Monumentos>();
                mons.Add(mon);
                monsViews = await loadMonumentosViewsDistances(mons, latitude, longitude);
            }
            catch (Exception ex) { monsViews = new List<MonumentosView>();  }
            return View("Index", monsViews);
        }

        // GET: Monumentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mon = await _context.Monumentos.Include("Reviews.User")
                .FirstOrDefaultAsync(m => m.Id == id);

            if (mon == null)
            {
                return NotFound();
            }

            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user      = await _context.Users.FindAsync(userId);
            _context.Historico.Add(new Historico { Monumentos = mon, Utilizador = user });
            await _context.SaveChangesAsync();

            return View(new MonumentosView(mon, mon.getRating(), alreadyAddToFavorites(id)));
        }

        // GET: Monumentos/Horaio/5
        public async Task<IActionResult> Horario(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int idFixo = id.GetValueOrDefault();

            var monumentos = await _context.Monumentos.Include("Horario.Slots").FirstOrDefaultAsync(m => m.Id == id);
            var horario = monumentos.Horario;
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var horarioView = new HorarioView(idFixo,horario.HoraAbertura,horario.HoraEncerrament,horario.CustoSlot, horario.Slots, await _context.Users.FindAsync(userId));
            if (horarioView == null)
            {
                return NotFound();
            }
            return View(horarioView);
        }


        [HttpGet]
        public async Task<IActionResult> FazReserva(int id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Microsoft.AspNetCore.Identity.IdentityUser user = _context.Users.Find(userId);

            var Slots = await _context.Slots.FirstOrDefaultAsync(slot => slot.Id == id);
            Slots.Utilizador = user;
            _context.Slots.Update(Slots);
            await _context.SaveChangesAsync();

            return View("Index","Home");
        }

        // Add Monumento
        public async Task<IActionResult> AddFavorito(int? id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (id == null)
            {
                return NotFound();
            }

            //Se já existir o monumento não o adiciona, e volta a listar os monumentos
            if (!_context.Favoritos.Any(e => e.Utilizador.Id == userId && e.Monumentos.Id == id))
            {
                Favoritos favoritos;
                Monumentos monumentos = _context.Monumentos.Find(id);
                Microsoft.AspNetCore.Identity.IdentityUser user = _context.Users.Find(userId);

                if (monumentos != null && user != null)
                {
                    favoritos = new Favoritos { Utilizador = user, Monumentos = monumentos };

                    _context.Favoritos.Add(favoritos); //TODO - Verificar se já foi adicionado anteriormente

                    await _context.SaveChangesAsync();
                }
            }

            return RedirectToAction("Details", "Monumentos", new { @id = id });
        }


        // Remove Monument Favorite
        public async Task<IActionResult> DeleteFavorito(int? id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (id == null)
            {
                return NotFound();
            }

            try
            {
                Favoritos favoritos = _context.Favoritos.First(f => f.Utilizador.Id == userId && f.Monumentos.Id == id);

                if (favoritos != null)
                {
                    _context.Favoritos.Remove(favoritos);
                    await _context.SaveChangesAsync();
                }
            }
            catch(Exception ignored) { }


            return RedirectToAction("Details", "Monumentos", new { @id = id });
        }

        public async Task<IActionResult> AddReview(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monumentos = await _context.Monumentos.FindAsync(id);
            if (monumentos == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReview(int id, Review review)
        {
            if (ModelState.IsValid && review.Classificacao >= 1 && review.Classificacao <= 5)
            {
                try
                {
                    Review ret = new()
                    {
                        User = _context.Users.Find(User.FindFirst(ClaimTypes.NameIdentifier).Value),
                        Monumentos = _context.Monumentos.Find(id),
                        Comentario = review.Comentario,
                        Classificacao = review.Classificacao
                    };
                    _context.Reviews.Add(ret);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", "Monumentos", new { @id = id });
                }
                catch (DbUpdateConcurrencyException)
                {
                    {
                        throw;
                    }
                }
            }
            return View();
        }

        private bool MonumentosExists(int id)
        {
            return _context.Monumentos.Any(e => e.Id == id);
        }

        private bool alreadyAddToFavorites(int? id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (id == null) return false;

            return _context.Favoritos.Any(e => e.Utilizador.Id == userId && e.Monumentos.Id == id);
        }

        private List<MonumentosView> getMonumentosViews(IEnumerable<Monumentos> mons)
        {
            return mons.Select(mon => new MonumentosView(mon, mon.getRating())).ToList();
        }

        //A partir de uma lista de monumentos, cria as views destes e carrega as respetivas distâncias ao utilizador
        private async Task<List<MonumentosView>> loadMonumentosViewsDistances(IEnumerable<Monumentos> monumentos, string latitude, string longitude)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            string url = "https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?";
            string position = "origins=" + latitude.ToString().Replace(",", ".") + "," + longitude.ToString().Replace(",", ".") + "&";
            string destination = "destinations=";
            string final = "&travelMode=driving&key=ApOZlzALIbMO6O6upadu1XeDhNRxOeBLxO84vPgBZs10itB0A3fRKzbq4ppa1qoy";

            foreach (var monumento in monumentos)
                destination = destination + monumento.Latitude.ToString().Replace(",", ".") + "," + monumento.Longitude.ToString().Replace(",", ".") + ";";

            List<MonumentosView> monsViews = getMonumentosViews(monumentos);

            try {
                Console.WriteLine(url + position + destination.Remove(destination.Length - 1) + final);
                var streamTask = client.GetStreamAsync(url + position + destination.Remove(destination.Length - 1) + final);
                var resorceSet = await JsonSerializer.DeserializeAsync<Result>(await streamTask);
                int monIndex = 0;
                foreach (var resorce in resorceSet.resourceSets)
                    foreach (var result in resorce.resources)
                        foreach (var dist in result.results)
                        {
                            monsViews[monIndex].distanceToUser = dist.travelDistance;
                            monIndex++;
                        }
            }
            catch(HttpRequestException hre) { }

            return monsViews;
        }

        private async Task<string> GetIpAsync()
        {
            var ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            if (ip == "::1") {
                client.DefaultRequestHeaders.Accept.Clear();

                var streamTask = client.GetStreamAsync("https://api.ipify.org/?format=json");
                var resorceSet = await JsonSerializer.DeserializeAsync<IP>(await streamTask);
                ip = resorceSet.ip;
            }
            return ip;
        }

        public async Task<string> GetLocationAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();

            var streamTask = client.GetStreamAsync("https://ipapi.co/" + await GetIpAsync() + "/json/");
            var resorceSet = await JsonSerializer.DeserializeAsync<Localizacao>(await streamTask);

            return resorceSet.latitude.ToString().Replace(",",".") + "," + resorceSet.longitude.ToString().Replace(",", ".");
        }
    }
}
