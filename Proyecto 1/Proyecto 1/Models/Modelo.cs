using System.ComponentModel.DataAnnotations;

namespace Proyecto_1.Models
{
    public class Modelo
    {
        [Key]
        public int ModeloID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Birthday { get; set; }
        public string Recomendation { get; set; }

    }
 }
