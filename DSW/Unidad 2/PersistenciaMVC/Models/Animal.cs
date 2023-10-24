using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersistenciaMVC.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        [ForeignKey("IdMamifero")]
        public int IdMamifero { get; set; }
        public virtual List<Mamifero>? Mamifero { get; set; }

        [ForeignKey("IdReptil")]
        public int IdReptil { get; set; }
        public virtual List<Reptil>? Reptil { get; set; }
    }
}
