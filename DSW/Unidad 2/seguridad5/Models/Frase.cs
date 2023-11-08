using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace seguridad5.Models
{
    [Table("Frase")]
    public class Frase
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Frase Inglés")]
        public string PhraseEng { get; set; }
        [DisplayName("Frase Español")]
        public string PhraseIng { get; set; }
        [DisplayName("Id Usuario")]
        public string idUsuario { get; set; }
        [DisplayName("Id Termino")]
        public int  idEspeng { get; set; }
    }
}
