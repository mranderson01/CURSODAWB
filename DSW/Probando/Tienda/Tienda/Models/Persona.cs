using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Edad")]
        public int age { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

    }
}
