using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class Telefono
    {
        [Key]
        public int TelefonoId { get; set; }

        [Required]
        public string Numero { get; set; } = default!;

        // Relacion Sede - Telefono [1 - N]
        public int? SedeId { get; set; }
        public Sede? Sede { get; set; }

        // Relacion Empleado - Telefono [1 - N]
        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }

    }
}