using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }

        [Required]
        public string Nombre { get; set; } = default!;

        [Required]
        public string Correo { get; set; } = default!;

        [Required]
        public string Cargo { get; set; } = default!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        // Relacion Empleado - Direccion [1 - N]
        public ICollection<Direccion>? Direcciones { get; set; }

        // Relacion Empleado - Telefono [1 - N]
        public ICollection<Telefono>? Telefonos { get; set; }

        // Relacion Empleado - Contrato [1 - 1]
        public int? ContratoId { get; set; }
        public Contrato? Contrato { get; set; }
                
    }
}