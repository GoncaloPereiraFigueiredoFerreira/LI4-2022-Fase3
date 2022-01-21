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
    public class HistoricoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoricoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Historico
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            List<Historico> historico = await _context.Historico.Include("Monumentos")
                                                      .Where(h => h.Utilizador.Id.Equals(userId))
                                                      .ToListAsync();

            historico.Sort((Historico h1, Historico h2) => { return h2.Id - h1.Id; });

            return View(historico);
        }

        // GET: Eliminar histórico inteiro
        public async Task<IActionResult> DeleteEntradasHistorico()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            bool hasEntries = true;
            while (hasEntries)
            {
                Historico historico = await _context.Historico.FirstOrDefaultAsync(h => h.Utilizador.Id.Equals(userId));

                if (historico != null)
                {
                    _context.Historico.Remove(historico);
                    await _context.SaveChangesAsync();
                }
                else hasEntries = false;
            }      

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entradaHistorico = await _context.Historico.Include("Monumentos").Include("Utilizador")
                .FirstOrDefaultAsync(h => h.Id == id);

            if (entradaHistorico == null)
            {
                return NotFound();
            }

            _context.Historico.Add(new Historico { Monumentos = entradaHistorico.Monumentos, Utilizador = entradaHistorico.Utilizador });
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Monumentos", new { @id=entradaHistorico.Monumentos.Id});
        } 

        // GET: Historico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historico = await _context.Historico.Include("Monumentos")
                .FirstOrDefaultAsync(h => h.Id == id);

            if (historico == null)
            {
                return NotFound();
            }

            return View(historico);
        }

        // POST: Historico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historico = await _context.Historico.FindAsync(id);
            _context.Historico.Remove(historico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoExists(int id)
        {
            return _context.Historico.Any(e => e.Id == id);
        }
    }
}
