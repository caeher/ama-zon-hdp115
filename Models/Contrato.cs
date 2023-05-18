using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class Contrato
    {
        [Key]
        public int ContratoId { get; set; }

        [Required]
        public string Tipo { get; set; } = default!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        // Relacion Contrato - Empleado [1 - 1]
        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }  

        // Relacion Contrato - Acuerdo [N - N]
        public ICollection<AcuerdoContrato>? AcuerdoContratos { get; set; } 
    }
}