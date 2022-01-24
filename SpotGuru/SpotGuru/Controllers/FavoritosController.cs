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

        //TODO - n tem await
        private bool FavoritosExists(int id)
        {
            return _context.Favoritos.Any(e => e.Id == id);
        }
    }
}
