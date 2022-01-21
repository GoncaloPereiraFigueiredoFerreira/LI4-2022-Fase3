using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpotGuru.Data;
using SpotGuru.Models;
using SpotGuru.ViewModels;

namespace SpotGuru.Controllers
{
    public class RatingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RatingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ratings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ratings.ToListAsync());
        }

        // GET: Ratings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Ratings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // GET: Ratings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ratings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Value")] Rating rating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rating);
        }

        // GET: Ratings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }
            return View(rating);
        }

        // POST: Ratings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Value")] Rating rating)
        {
            if (id != rating.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RatingExists(rating.Id))
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
            return View(rating);
        }

        // GET: Ratings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Ratings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // POST: Ratings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ShowRate()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Rating rating;
            int ratingSum = await _context.Ratings.SumAsync(r => r.Value);
            int numberRatings = await _context.Ratings.CountAsync();
            float RatingApp = (float) ratingSum/numberRatings;
            Console.WriteLine("*************************************** SUM: " + ratingSum + " *****************************************");
            Console.WriteLine("*************************************** Number: " + numberRatings + " *****************************************");
            Console.WriteLine("*************************************** Rating: " + RatingApp + " *****************************************");
            try
            {
                rating = await _context.Ratings.FirstAsync(r => r.User.Id == userId);
                return View(new RatingUserPlusGlobalView { RatingUser = rating.Value, RatingGlobal = RatingApp }); ;
            }
            catch (Exception ex)
            {
                rating = null;
                return RedirectToAction("Rate");
            }
        }

        // GET: Ratings/Rate
        public IActionResult Rate()
        {
            return View();
        }

        public async Task<IActionResult> ChangeRate(int value)
        {
            if (ModelState.IsValid)
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                try
                {
                    Rating ratingInDB = await _context.Ratings.FirstAsync(r => r.User.Id == userId);
                    ratingInDB.Value = (short) value;
                    _context.Ratings.Update(ratingInDB);
                }
                catch (Exception ex)
                {
                    _context.Add(new Rating {User = _context.Users.Find(userId), Value = (short) value });
                }

                await _context.SaveChangesAsync();
            }
            return RedirectToAction("ShowRate");
        }
        private bool RatingExists(int id)
        {
            return _context.Ratings.Any(e => e.Id == id);
        }
    }
}
