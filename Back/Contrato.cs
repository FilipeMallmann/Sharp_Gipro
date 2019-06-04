using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        public int ClienteId { get; set; }
        public decimal ValorCerto { get; set; }
        public string ValorPercentual { get; set; }
        public int TipoContrato { get; set; } // enum
        public DateTime DataAssinatura { get; set; }
        public decimal ValorEntrada { get; set; }
        public int ModeloContratoId { get; set; }
        public bool IsFinalizado { get; set; }

    }
}
