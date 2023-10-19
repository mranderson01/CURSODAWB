using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBFirst.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [DisplayName("Descripcion")]
        public string? Description { get; set; } 

        public int? ShipperID { get; set; }

        public Shipper? Shipper { get; set; }
    }
}
