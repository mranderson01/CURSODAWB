using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheSimpsons.Models
{
    public class PersonajeSimpson
    {

        [DisplayName("Identificacion")]        
        public int Id { get; set; }
        [DisplayName("Nombre")] 
        [Required(ErrorMessage = "Se tiene que insertar el nombre")]
        public string name { get; set; }

        [DisplayName("Edad")]
        [Required(ErrorMessage = "Se tiene que insertar el nombre")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor a 0")]
        public int age { get; set; }
        [DisplayName("Relación Familiar")]        
        [Required(ErrorMessage = "Se tiene que seleccionar una relacion.")]
        public string relationship { get; set; }

        public PersonajeSimpson() { }

        public PersonajeSimpson(int id,string nombre, int edad, string relacion)
        {
            Id = id;
            name = nombre;
            age = edad;
            relationship = relacion;
        }


    }
}
