using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Lab0.Controllers
{
    [Route("[controller]")]
    public class PersonaController : Controller
    {
        private Persona _persona1 = new Persona()
        {
            Nombre = "Juan Ortega",
            Profesion = "Scrum Master",
            Edad = 25
        };
        public string Index()
        {
            return "/Profesion para profesion, /Nombre para obtener el nombre /edad para obtener la edad y / info para obtener la informacion completa de la persona";
        }

        [HttpGet]
        [Route("Nombre")]
        public string ObtenerNombre()
        {
            return _persona1.Nombre;
        }

        [HttpGet]
        [Route("Profesion")]
        public string ObtenerProfesion()
        {
            return _persona1.Profesion;
        }

        [HttpGet]
        [Route("Edad")]
        public int obtenerEdad()
        {
            return _persona1.Edad;
        }

        [HttpGet]
        [Route ("Info")]
        public Persona ObtenerObjetoPersona()
        {
            return _persona1;
        }
    }
}
