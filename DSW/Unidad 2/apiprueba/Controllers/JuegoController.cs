using apiprueba.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiprueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuegoController : ControllerBase
    {
        public static List<Juego> listaJuegos = new List<Juego>
             {
                new Juego
                {
                    id = 1,
                    Titulo = "The Legend of Zelda",
                    Genero = "Aventura"
                },
                new Juego
                {
                    id = 2,
                    Titulo = "Super Mario",
                    Genero = "Plataformas"
                },
                new Juego
                {
                    id = 3,
                    Titulo = "Call of Duty",
                    Genero = "Disparos"
                }
             };
        // GET: api/<JuegoController>
        [HttpGet]
        public IActionResult Get()
        {
            var juegos=listaJuegos.ToList();
            if (juegos==null)
            {
                return NotFound();
            }
            return Ok(juegos);
        }

        // GET api/<JuegoController>/5
        [HttpGet("{id}")] 
        public ActionResult<Juego> Get(int id)
        {
            var juegos = listaJuegos.ToList();
            var juego = juegos.FirstOrDefault(j => j.id == id);

            if (juego != null)
            {
                return Ok(juego); // Devolver el juego encontrado
            }

            return NotFound(); // El juego no se encontró, devuelve un error 404
        }

        // POST api/<JuegoController>
        [HttpPost]
        public IActionResult Post([FromBody] Juego juego)
        {
            if (ModelState.IsValid)
            {
                listaJuegos.Add(juego);
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<JuegoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Juego juego)
        {
            if (ModelState.IsValid)
            {
                var juegoBuscado=listaJuegos.FirstOrDefault(juego=>juego.id==id);

                 
                if (juegoBuscado == null)
                {
                    return BadRequest();
                }
                var CopiaJuego = juegoBuscado;
                listaJuegos.Remove(juegoBuscado);

                CopiaJuego.id = juego.id;
                CopiaJuego.Titulo = juego.Titulo;
                CopiaJuego.Genero = juego.Genero;
                CopiaJuego.id = juego.id;

                listaJuegos.Add(CopiaJuego);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<JuegoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var juegoEncontrado=listaJuegos.FirstOrDefault(juego=>juego.id==id);
            if (juegoEncontrado==null)
            {
                return BadRequest();
            }

            listaJuegos.Remove(juegoEncontrado);
            return Ok();
        }
    }
}
