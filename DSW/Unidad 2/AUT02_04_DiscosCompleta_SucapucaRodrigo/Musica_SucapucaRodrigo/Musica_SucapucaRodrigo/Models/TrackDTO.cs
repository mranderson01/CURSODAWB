using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Musica_SucapucaRodrigo.Models
{
    public class TrackDTO
    {
        [Key]
        [DisplayName()]
        public int TrackId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "numeric(10, 2)")]
        [DisplayName("Precio Unidad")]
        public decimal UnitPrice { get; set; }
    }

}
