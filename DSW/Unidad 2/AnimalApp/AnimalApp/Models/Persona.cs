using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnimalApp.Models
{
    public class Persona
    {
        [Key]
        [DisplayName("identificacion")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }          
    }
}
