using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TTPay.Models;
using TTPay.Models.Data;

namespace TTPay.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;

        public HomeController(DataContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                return View(await SviSusreti());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(Enumerable.Empty<Susret>());
            }
        }

        private async Task<IEnumerable<Susret>> SviSusreti()
        {
            return await db.Susreti.OrderByDescending(it => it.Datum).ToListAsync();
        }

        public IActionResult NewEntry()
        {
            return View();
        }

        public async Task<IActionResult> ObrisiSusret(int id)
        {
            var s = await db.Susreti.FindAsync(id);
            if (s != null)
            {
                db.Susreti.Remove(s);
                await db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> NoviSusret(DateTime datum,
            int numBTrosak, int numBPlaceno, int numZTrosak, int numZPlaceno, int numMTrosak, int numMPlaceno)
        {
            try
            {
                var s = new Susret
                {
                    Datum = datum,
                    BojanPotrosio = numBTrosak,
                    BojanPlatio = numBPlaceno,
                    ZecPotrosio = numZTrosak,
                    ZecPlatio = numZPlaceno,
                    ManicPotrosio = numMTrosak,
                    ManicPlatio = numMPlaceno,
                };
                await db.Susreti.AddAsync(s);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData.Add("Error", ex.Message);
                return RedirectToAction(nameof(NewEntry));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}