using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesETicket.Data;
using MoviesETicket.Models;

namespace MoviesETicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Cinema> cinemas = await _context.Cinemas.ToListAsync();

            return View(cinemas);
        }
    }
}
