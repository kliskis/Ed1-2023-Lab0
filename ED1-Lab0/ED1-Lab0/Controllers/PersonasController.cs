using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Lab0.Controllers
{
    [Route("[controller]")]
    public class PersonasController : Controller
    {
        [HttpGet]
        [Route("ejemploPersona")]
        public Persona ObtenerPersona()
        {
            Persona ejemplo = new Persona()
            {
                Nombre = "Pedro",
                Profesion = "Medico",
                Edad = 48
            };
            return ejemplo;
        }
    }
}
