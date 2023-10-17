using Microsoft.AspNetCore.Mvc;
using TheSimpsons.Models;

namespace TheSimpsons.Controllers
{
    public class SimpsonController : Controller
    {
        private static List<PersonajeSimpson> familiaSimpson = new List<PersonajeSimpson>
        {
            new PersonajeSimpson(0, "Homer", 39, "Padre"),
            new PersonajeSimpson(1, "Marge", 36, "Madre"),
            new PersonajeSimpson(2, "Bart", 10, "Hijo Mayor"),
            new PersonajeSimpson(3, "Lisa", 8, "Hija Mayor"),
            new PersonajeSimpson(4, "Maggie", 1, "Bebé")
        };

        [HttpGet]
        public IActionResult Index(string? mensajeError)
        {
            ViewData["Message"] = mensajeError;
            return View(familiaSimpson);
        }         
    }
}
