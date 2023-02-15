using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Lab0.Controllers
{
    public class PersonasController : Controller
    {
        private List<Persona> _listaDePersonas =new List<Persona>()
                {
                new Persona { Nombre = "Sergio", Edad = 27, Profesion = "Administrador de empresas", DPI = "123456" },
                new Persona { Nombre = "Karla", Edad = 22, Profesion = "Ingeniera en Informatica",DPI = "456789" },
                new Persona { Nombre = "Katy", Edad = 29, Profesion = "Psicologa clinica", DPI = "894563"  }
            };
public IActionResult Index()
        {
            return View(_listaDePersonas);
        }

        public IActionResult CargarArchivo()
        {
            return View();
        }

    }


}
