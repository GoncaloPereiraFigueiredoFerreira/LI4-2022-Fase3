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

            var monumentos = await _context.Monumentos
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

        // GET: Monumentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monumentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descrição,Latitude,Longitude,Categoria")] Monumentos monumentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monumentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monumentos);
        }

        // GET: Monumentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            return View(monumentos);
        }

        // POST: Monumentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descrição,Latitude,Longitude,Categoria")] Monumentos monumentos)
        {
            if (id != monumentos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monumentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonumentosExists(monumentos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(monumentos);
        }

        // GET: Monumentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monumentos = await _context.Monumentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monumentos == null)
            {
                return NotFound();
            }

            return View(monumentos);
        }

        // POST: Monumentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monumentos = await _context.Monumentos.FindAsync(id);
            _context.Monumentos.Remove(monumentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonumentosExists(int id)
        {
            return _context.Monumentos.Any(e => e.Id == id);
        }
    }
}
