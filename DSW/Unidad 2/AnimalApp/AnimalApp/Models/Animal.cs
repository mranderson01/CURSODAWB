using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalApp.Models
{
    public  class Animal
    {
        [Key]
        [DisplayName("Identificacion")]
        public int Id { get; set; }


        [DisplayName("Nombre")]
        [Required(ErrorMessage ="Se tiene que insertar el nombre del animal.")]        
        public string Name { get; set; }

        [DisplayName("Descripcion")]
        public string? Description { get; set; }


        [ForeignKey("idPropietario")]
        [DisplayName("Nombre propietario")]
        [Required(ErrorMessage = "Se tiene que seleccionar el nombre del propietario")]        
        public int idPropietario { get; set; }

        
        [DisplayName("Propietario")]
        public Propietario propietario { get; set; }
    }
}
