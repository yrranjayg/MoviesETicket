﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesETicket.Data;
using MoviesETicket.Models;

namespace MoviesETicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Producer> producers = await _context.Producers.ToListAsync();
            return View(producers);
        }
    }
}
