
using System.Diagnostics;
using EliteTech_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EliteTech_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Works()
        {
            return View();
        }

        public IActionResult NovaMed()
        {
            return View();
        }
        public IActionResult FadaeiTradeC2()
        {
            return View();
        }
        public IActionResult MtaGlobalC3()
        {
            return View();
        }
        public IActionResult DWiseC4()
        {
            return View();
        }
        public IActionResult OpenFreightC5()
        {
            return View();
        }
        public IActionResult EuropeGulfC6()
        {
            return View();
        }
        public IActionResult FreshFlowerC7()
        {
            return View();
        }
        public IActionResult RoyalNordicC8()
        {
            return View();
        }
        public IActionResult VintageCarC9()
        {
            return View();
        }
        public IActionResult DehvariC10()
        {
            return View();
        }
        public IActionResult SarawanC11()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
