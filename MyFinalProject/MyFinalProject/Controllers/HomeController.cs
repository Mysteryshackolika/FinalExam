using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinalProject.Data;
using MyFinalProject.Models;
//using MyFinalProject.Models;

namespace MyFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task< IActionResult> Index()
        {
            var games=await  _context.Games.ToListAsync();
            return View(games);
        }

     
    }
}
