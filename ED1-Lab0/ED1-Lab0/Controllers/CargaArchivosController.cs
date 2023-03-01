using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Lab0.Controllers
{
    [Route("[controller]")]
    public class CargaArchivosController : Controller
    {
        private List<Persona> _listaDesdeArchivo = new List<Persona>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("subirarchivo")]
        public IActionResult SubirArchivo(IFormFile archivo)
        {
            if(archivo != null)
            {
                try
                {
                    //1. Crear una copia del archivo recibido en el servidor
                    string ruta = Path.Combine(Path.GetTempPath(), archivo.Name); //ruta temporal del archivo
                    using (var stream = new FileStream(ruta, FileMode.Create))
                    {
                        archivo.CopyTo(stream); //Copiar el contenido del archivo
                    }

                    //2. Leer el archivo
                    string informacionArchivo = System.IO.File.ReadAllText(ruta);
                    //3. Obtener lineas del archivo y llenar lista
                    foreach(string linea in informacionArchivo.Split('\n'))
                    {
                        if (!string.IsNullOrEmpty(linea))
                        {
                            //Extraer la informacion de cada persona
                            string[] FilaActual = linea.Split(',');
                            _listaDesdeArchivo.Add(new Persona
                            {
                                Nombre = FilaActual[0],
                                DPI = FilaActual[1],
                                Edad = Convert.ToInt32(FilaActual[2]),
                                Profesion = FilaActual[3]
                            });
                           
                        }
                    }
                }
                catch (Exception e)
                {
                    ViewBag.Errr = "Error al leer el archivo " + e.Message;
                }
            }
            else
            {
                ViewBag.Error = "No se ha ingresado la ruta de archivo";
            }
            return View(_listaDesdeArchivo);
        }

        [Route("subirarchivo")]
        public IActionResult SubirArchivo()
        {
            return View();
        }
    }
}
