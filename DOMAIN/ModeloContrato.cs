using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class ModeloContrato
    {
        public int ModeloContratoId { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; } // vinculo com Doc ?

    }
}
