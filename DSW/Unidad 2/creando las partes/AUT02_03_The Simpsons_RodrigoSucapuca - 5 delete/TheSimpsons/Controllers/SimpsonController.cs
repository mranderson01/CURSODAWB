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

        [HttpGet]
        public IActionResult Create() { 
            return View(new PersonajeSimpson());
        }

        [HttpPost] 
        public IActionResult Create(PersonajeSimpson personajeCrear) {
            if (ModelState.IsValid)
            {
                int ultimoNumPersonaje=familiaSimpson.Count();
                int idUltimoPersonaje=familiaSimpson[ultimoNumPersonaje-1].Id;
                personajeCrear.Id=idUltimoPersonaje+1;
                familiaSimpson.Add(personajeCrear);
                return RedirectToAction("index");
            }
            return View(personajeCrear);            
        }

        [HttpGet]
        public IActionResult Details(int itemid)
        {
            if (ModelState.IsValid)
            {
                PersonajeSimpson? personajeEncontrado = familiaSimpson.Find((personaje) => personaje.Id == itemid);

                if (personajeEncontrado == null)
                {
                    var mensajeError = "No se encontro el personaje";
                    return RedirectToAction("Index", "Simpson", mensajeError);
                }


                return View(personajeEncontrado);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int itemid) {
           
            if (ModelState.IsValid) {
                PersonajeSimpson? personajeEncontrado = familiaSimpson.Find((personaje) => personaje.Id == itemid);

                if (personajeEncontrado == null)
                {
                    var mensajeError = "No se encontro el personaje";
                    return RedirectToAction("Index", "Simpson", mensajeError);
                }

                return View(personajeEncontrado);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(PersonajeSimpson personajeActualizar)
        {
            if (ModelState.IsValid) {
                PersonajeSimpson? personajeEncontrado = familiaSimpson.Find((personaje) => personaje.Id == personajeActualizar.Id);

                if (personajeEncontrado == null)
                {
                    var mensajeError = "No se encontro el personaje";
                    return RedirectToAction("Update", "Simpson", personajeActualizar.Id);
                }
              
                personajeEncontrado.Id= personajeActualizar.Id;
                personajeEncontrado.name = personajeActualizar.name;
                personajeEncontrado.age = personajeActualizar.age;
                personajeEncontrado.relationship = personajeActualizar.relationship;               
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? itemid)
        {
            PersonajeSimpson? personajeEncontrado = familiaSimpson.Find((personaje) => personaje.Id == itemid);
            if (personajeEncontrado == null)
            {
                var mensajeError = "No se encontro el personaje";
                return RedirectToAction("Update", "Simpson", itemid);
            }
            return View(personajeEncontrado);
        }

        [HttpGet] 
        public IActionResult DeleteConfirmed(int itemid)
        {
            PersonajeSimpson? personajeEncontrado = familiaSimpson.Find((personaje) => personaje.Id == itemid);
            if (personajeEncontrado == null)
            {
                var mensajeError = "No se encontro el personaje";
                return RedirectToAction("Update", "Simpson", itemid);
            }
            familiaSimpson.Remove(personajeEncontrado);
            return RedirectToAction("Index");
        }

    }
}
