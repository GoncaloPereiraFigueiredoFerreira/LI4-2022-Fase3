using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpotGuru.Data;
using SpotGuru.Models;

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
            return View(await _context.Monumentos.ToListAsync());
        }

        // GET: Monumentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monumentos = await _context.Monumentos.Include("Reviews")
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monumentos == null)
            {
                return NotFound();
            }

            return View(monumentos);
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
            if(_context.Favoritos.Any(e => e.Monumentos.Id == id && e.Utilizador.Id == userId))
                return View("Index", await _context.Monumentos.ToListAsync());

            Favoritos favoritos;
            Monumentos monumentos = _context.Monumentos.Find(id);
            Microsoft.AspNetCore.Identity.IdentityUser user = _context.Users.Find(userId);

            if (monumentos != null && user != null) 
            {
                favoritos = new Favoritos { Utilizador = user, Monumentos = monumentos };

                _context.Favoritos.Add(favoritos); //TODO - Verificar se já foi adicionado anteriormente

                await _context.SaveChangesAsync();
            }

            return View("Index", await _context.Monumentos.ToListAsync());
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
            if (ModelState.IsValid)
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
    }
}
