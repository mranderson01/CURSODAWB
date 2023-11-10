﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ejercicio2.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre")]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Se requiere una descripción")]
        [DisplayName("Descriptión")]
        public string Description { get; set; }

        //GENERO DEL JUEGO
        public int idGenre { get; set; }
        public Genre genre { get; set; }
    }
}
