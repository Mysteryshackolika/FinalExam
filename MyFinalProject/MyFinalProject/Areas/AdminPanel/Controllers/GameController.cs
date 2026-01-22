using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinalProject.Data;
using MyFinalProject.Models;

namespace MyFinalProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class GameController : Controller
    {
        private readonly AppDbContext _context;

        public GameController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var games = await _context.Games.ToListAsync();
            return View(games);
        }
        [HttpPost]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
                

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        
    }
}
