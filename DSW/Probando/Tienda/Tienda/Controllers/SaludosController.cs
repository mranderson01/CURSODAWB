using Microsoft.AspNetCore.Mvc;

namespace Tienda.Controllers
{
    public class SaludosController : Controller
    {
        public IActionResult Index(string localidad)
        {
            ViewData["localidad"] = localidad;
            return View();
        }

        public IActionResult Despedida(int id,string nombre, string edad) {
            ViewData["id"] = id;
            ViewData["nombre"] = nombre;
            ViewData["edad"] = edad;
            return View();
        }

    }
}
