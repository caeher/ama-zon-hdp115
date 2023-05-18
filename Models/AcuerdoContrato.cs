using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmaZon.Models
{
    public class AcuerdoContrato
    {
        [Key]
        public int AcuerdoContratoId { get; set; }

        // Relacion Acuerdo - Contrato [N - N]
        public int? AcuerdoId { get; set; }
        public Acuerdo? Acuerdo { get; set; }

        public int? ContratoId { get; set; }
        public Contrato? Contrato { get; set; }
    }
}