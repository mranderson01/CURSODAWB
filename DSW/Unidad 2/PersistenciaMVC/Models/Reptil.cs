using System.ComponentModel.DataAnnotations;

namespace PersistenciaMVC.Models
{
    public class Reptil : Animal
    {
        [Key]
        public int IdReptil { get; set; }
    }
}