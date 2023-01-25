using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Lab0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Persona persona1;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            persona1 = new Persona();
            persona1.Edad = 18;
            persona1.Nombre = "Alland";
            persona1.Profesion = "Ingeniero";

        }

        public Persona Index()
        {
            return persona1;
        }

        public IActionResult Privacy()
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