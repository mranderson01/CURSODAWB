using System.ComponentModel.DataAnnotations;

namespace apiprueba.Model
{
    public class Juego
    {
        public int id { get; set; }
        [MinLength(5)]
        [MaxLength(15)]
        public string Titulo { get; set; }
        [MinLength(2)]
        [MaxLength(12)]
        public string Genero { get; set; }

    }
}
