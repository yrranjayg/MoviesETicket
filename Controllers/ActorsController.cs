using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesETicket.Data;
using MoviesETicket.Models;

namespace MoviesETicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Actor> actors = await _context.Actors.ToListAsync();

            return View(actors);
        }
    }
}
