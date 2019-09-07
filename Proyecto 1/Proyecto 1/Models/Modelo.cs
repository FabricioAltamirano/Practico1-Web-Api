using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_1.Models
{
    public class Modelo
    {
        [Required]
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
