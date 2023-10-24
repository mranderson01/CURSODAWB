using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PersistenciaMVC.Models
{
    public class Mamifero :Animal
    {
        [Key]
        public int IdMamifero { get; set; } 
    }
}
