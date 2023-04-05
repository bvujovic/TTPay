using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using TTPay.Models;
using TTPay.Models.Data;

namespace TTPay.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext db;

        public AdminController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetSviSusreti()
        {
            try
            {
                return Ok(await db.Susreti.ToListAsync());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return BadRequest();
            }
        }

        public async Task<IActionResult> SetSviSusreti(string json)
        {
            try
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var susreti = JsonSerializer.Deserialize<IEnumerable<Susret>>(json, options);
                if (susreti == null)
                    throw new Exception("Deserijalizacija JSON podataka nije uspela: json -> null.");
                db.Susreti.RemoveRange(db.Susreti);
                await db.Susreti.AddRangeAsync(susreti);
                await db.SaveChangesAsync();
                TempData.Add("Info", "Uspeh!");
            }
            catch (Exception ex)
            {
                TempData.Add("Error", ex.Message);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
