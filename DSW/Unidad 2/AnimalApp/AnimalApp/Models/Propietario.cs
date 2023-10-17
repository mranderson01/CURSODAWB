using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnimalApp.Models
{
    public class Propietario : Persona
    {
        [DisplayName("Apellidos")]
        [Required(ErrorMessage = "Se tiene que insertar los apellidos del propietario.")]
        public string Surname { get; set; }

        [DisplayName("Telefono")]
        [Required(ErrorMessage = "Se tiene que insertar un numero telefonico")]
        public string Number { get; set; }
        [DisplayName("Lista de Animales")]
        public List<Animal>? Animales { get; set; }
    }
}