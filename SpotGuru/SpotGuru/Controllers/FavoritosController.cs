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
    public class FavoritosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FavoritosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Favoritos
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return View(await _context.Favoritos.Include("Monumentos")
                                      .Where(f => f.Utilizador.Id.Equals(userId))
                                      .ToListAsync());
        }

        // GET: Favoritos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favoritos = await _context.Favoritos.Include("Monumentos").Include("Utilizador")
                                                    .FirstOrDefaultAsync(m => m.Id == id);

            if (favoritos == null)
            {
                return NotFound();
            }

            _context.Historico.Add(new Historico { Monumentos = favoritos.Monumentos, Utilizador = favoritos.Utilizador });
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Monumentos", new {@id=favoritos.Monumentos.Id});
        }


        // GET: Favoritos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favoritos = await _context.Favoritos.Include("Monumentos")
                .FirstOrDefaultAsync(fav => fav.Id == id);

            if (favoritos == null)
            {
                return NotFound();
            }

            return View(favoritos);
        }

        // POST: Favoritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var favoritos = await _context.Favoritos.FindAsync(id);
            _context.Favoritos.Remove(favoritos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //TODO - n tem await
        private bool FavoritosExists(int id)
        {
            return _context.Favoritos.Any(e => e.Id == id);
        }
    }
}
