using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesETicket.Data;
using MoviesETicket.Models;

namespace MoviesETicket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Movie> movies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
