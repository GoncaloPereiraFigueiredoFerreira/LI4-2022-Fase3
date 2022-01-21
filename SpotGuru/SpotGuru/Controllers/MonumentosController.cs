using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        public MonumentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Monumentos
        public async Task<IActionResult> Index()
        {
            List<Monumentos> mons = await _context.Monumentos.Include("Reviews.User").ToListAsync();
            List<MonumentosView> monsViews = mons.Select(x => new MonumentosView(x, getMonumentRating(x))).ToList();
            return View(monsViews);
        }

        // GET: Monumentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monumentos = await _context.Monumentos.Include("Reviews.User")
                .FirstOrDefaultAsync(m => m.Id == id);

            if (monumentos == null)
            {
                return NotFound();
            }

            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user      = await _context.Users.FindAsync(userId);
            _context.Historico.Add(new Historico { Monumentos = monumentos, Utilizador = user });
            await _context.SaveChangesAsync();

            return View(new MonumentosView(monumentos, getMonumentRating(monumentos), alreadyAddToFavorites(id)));
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

        // GET: Monumentos/Edit/5
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

        // POST: Monumentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        private float getMonumentRating(Monumentos monumentos) {
            int count = monumentos.Reviews.Count;
            if (count == 0) return 0f;
            return (float) monumentos.Reviews.Sum(r => r.Classificacao) / count;
        }
    }
}
