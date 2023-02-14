using Microsoft.AspNetCore.Mvc;

namespace ED1_Lab0.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
