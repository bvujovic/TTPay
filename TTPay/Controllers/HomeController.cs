using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TTPay.Models;
using TTPay.Models.Data;

namespace TTPay.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly DataContext db;

        public HomeController(DataContext db /*ILogger<HomeController> logger*/)
        {
            //_logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewEntry()
        {
            return View();
        }

        public async Task<IActionResult> NewEntryData(DateTime datum,
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
                return RedirectToAction("Index");
            }
            catch (Exception ex) { return RedirectToAction("NewEntry", ex.Message); }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}