using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class Acuerdo
    {
        // acuerdoid, nombre, contenido, tipo 
        [Key]
        public int AcuerdoId { get; set; }

        [Required]
        public string Nombre { get; set; } = default!;

        [Required]
        public string Contenido { get; set; } = default!;

        [Required]
        public string Tipo { get; set; } = default!;

        // Relacion Acuerdo - Pais [N - 1]
        public int? PaisId { get; set; }
        public Pais? Pais { get; set; }

        // Relacion Acuerdo - Contrato [N - N]
        public ICollection<AcuerdoContrato>? AcuerdoContratos { get; set; }
    }
}