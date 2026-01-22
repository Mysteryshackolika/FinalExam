using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinalProject.Data;

namespace MyFinalProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController:Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var games = await _context.Games.ToListAsync();
            return View(games);
        }
    }
}
