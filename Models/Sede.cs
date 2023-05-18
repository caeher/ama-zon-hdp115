using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class Sede
    {
        [Key]
        public int SedeId { get; set; }

        [Required]
        public string Nombre { get; set; } = default!;

        [Required]
        public string CodigoSede { get; set; } = default!;

        // Relacion Pais - Sede [1 - N]
        public int? PaisId { get; set; }
        public Pais? Pais { get; set; }

        // Relacion Sede - Direccion [1 - N]
        public ICollection<Direccion>? Direcciones { get; set; }

        // Relacion Sede - Telefono [1 - N]
        public ICollection<Telefono>? Telefonos { get; set; }
    }
}