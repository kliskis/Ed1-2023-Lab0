using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace ED1_Lab0.Controllers
{
    [Route("[controller]")]
    public class PersonasController : Controller
    {
        private List<Persona> _listaDePersonas = new List<Persona>()
                {
                new Persona { Nombre = "Sergio", Edad = 27, Profesion = "Administrador de empresas", DPI = "123456" },
                new Persona { Nombre = "Karla", Edad = 22, Profesion = "Ingeniera en Informatica",DPI = "456789" },
                new Persona { Nombre = "Katy", Edad = 29, Profesion = "Psicologa clinica", DPI = "894563"  }
            };
        public IActionResult Index()
        {
            return View(_listaDePersonas);
        }

        [Route("Remover")]
        public List<Persona> EliminarElemento(string nombre)
        {
            _listaDePersonas.RemoveAll(x=> x.Nombre.Equals(nombre, StringComparison.CurrentCultureIgnoreCase));
            return _listaDePersonas;
        }

        [HttpPost("Insertar")]
        public IActionResult InsertarPersona(string nombre, string edad, string DPI, string profesion)
        {
            _listaDePersonas.Add(new Persona()
            {
                Nombre = nombre,
                Edad = Convert.ToInt32(edad),
                DPI = DPI,
                Profesion = profesion
            });
            return View(_listaDePersonas);
        }

        [Route ("Insertar")]
        public IActionResult InsertarPersona()
        {
            return View(_listaDePersonas);
        }

    }


}
