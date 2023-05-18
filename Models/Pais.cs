using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string IsoAlfa2 { get; set; }

        [Required]
        public string Idioma { get; set; }


        // Relacion Pais - Sede [1 - N]
        public ICollection<Sede>? Sedes { get; set; }

        // Relacion Pais - Acuerdos [1 - N]
        public ICollection<Acuerdo>? Acuerdos { get; set; }
    }
}