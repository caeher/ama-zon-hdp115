using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }

        public string? Calle { get; set; } = default!;

        [Required]
        public string address { get; set; } = default!;

        public string? zip { get; set; } = default!;

        // Relacion Sede - Direccion [1 - 1]
        public int? SedeId { get; set; }
        public Sede? Sede { get; set; } 

        // Relacion Empleado - Direccion [1 - N]
        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }
    }
}