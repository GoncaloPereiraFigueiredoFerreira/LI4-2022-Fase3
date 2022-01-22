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

        // GET: Monumentos
        public async Task<IActionResult> Index()
        {
            List<Monumentos> mons = await _context.Monumentos.Include("Reviews.User").ToListAsync();
            IEnumerable<MonumentosView> monsViews = getMonumentosViews(mons);
            return View(monsViews);
        }

        public async Task<IActionResult> MonumentsSortedByDistance()
        {
            var amonumentos = _context.Monumentos.Include("Reviews.User").ToListAsync();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            string url = "https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?";
            string position = "origins=" + (await GetLocationAsync()) + "&";
            string destination = "destinations=";
            string final = "&travelMode=driving&key=ApOZlzALIbMO6O6upadu1XeDhNRxOeBLxO84vPgBZs10itB0A3fRKzbq4ppa1qoy";

            var monumentos = await amonumentos;

            foreach (var monumento in monumentos)
                destination = destination + monumento.Latitude + "," + monumento.Longitude + ";";

            Console.WriteLine(url + position + destination.Remove(destination.Length - 1) + final);
            var streamTask = client.GetStreamAsync(url + position + destination.Remove(destination.Length - 1) + final);
            var resorceSet = await JsonSerializer.DeserializeAsync<Result>(await streamTask);


            List<float> distancias = new List<float>();

            foreach (var resorce in resorceSet.resourceSets)
                foreach (var result in resorce.resources)
                    foreach (var dist in result.results)
                        distancias.Add(dist.travelDistance);


            for (int i = distancias.Count-1; i > 0; i--) {
                int index = 0;
                float maxDist = 0;
                for (int j = 0; j <= i; j++) {
                    if (distancias[j] > maxDist) { index = j;maxDist = distancias[j];}
                }
                distancias[index] = distancias[i];
                Monumentos aux = monumentos[index];
                monumentos[index] = monumentos[i];
                monumentos[i] = aux;
            }

            var mons = getMonumentosViews(monumentos);

            return View("Index", mons);
        }

        [HttpGet]
        public IActionResult Filters()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ApplyFilters(string FiltersList)
        {
            string[] arr = FiltersList.Split(",");
            HashSet<Categorias> filtros = new HashSet<Categorias>();

            foreach (string filter in arr)
            {
                filtros.Add((Categorias) Enum.Parse(typeof(Categorias), filter));
            }
 
            List<Monumentos> mons = await _context.Monumentos.Include("Reviews.User").Where(mon => filtros.Contains(mon.Categoria)).ToListAsync();
            IEnumerable<MonumentosView> monsViews = getMonumentosViews(mons);
            return View("Index", monsViews);
        }

        [HttpGet]
        public async Task<IActionResult> SearchMonumentByName(string name)
        {
            IEnumerable<MonumentosView> monsViews = new List<MonumentosView>();
            try
            {
                Monumentos mon = await _context.Monumentos.Include("Reviews.User").FirstAsync(monDB => monDB.Nome.Equals(name));
                ((List<MonumentosView>)monsViews).Add(new MonumentosView(mon, mon.getRating()));
            }
            catch (Exception ex) { }
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

            var monumentos = await _context.Monumentos.Include("Horario").FirstOrDefaultAsync(m => m.Id == id);
            var horario = monumentos.Horario;
            if (horario == null)
            {
                return NotFound();
            }

            return View(horario);
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
                }
                catch (DbUpdateConcurrencyException)
                {
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));

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

        private IEnumerable<MonumentosView> getMonumentosViews(IEnumerable<Monumentos> mons)
        {
            return mons.Select(mon => new MonumentosView(mon, mon.getRating()));
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

            return resorceSet.latitude + "," + resorceSet.longitude;
        }
    }
}
