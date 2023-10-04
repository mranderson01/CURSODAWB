using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tienda.Models;

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
        public IActionResult Felicita(int id,string name,int edad)
        {
            ViewData["id"] = id;
            ViewData["name"] = name;
            ViewData["edad"] = edad;
            return View();
        }

        public  IActionResult Perfil() {
            Persona Jesus=new Persona
            {
                Id = 1,
                Name="Jesus",
                age=2023,
                Email="Jesucristo@gmail.com"
            };
            return View(Jesus);
        }
    }
}
