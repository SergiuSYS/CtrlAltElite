using System.ComponentModel.DataAnnotations;

namespace CtrlAltElite.Data
{
    public class Materie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nume { get; set; }
        public string Descriere { get; set; }
        [Required]
        public string Profesor { get; set; } 
        
    }
}
