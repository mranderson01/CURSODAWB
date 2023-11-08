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
        public IEnumerable<string> Get()
        {
            var juegos=listaJuegos.ToList();
            return (IEnumerable<string>)juegos;
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
            listaJuegos.Add(juego); 
            return Ok();
        }

        // PUT api/<JuegoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<JuegoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
