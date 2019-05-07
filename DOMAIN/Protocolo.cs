using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Protocolo
    {
        public int ProtocoloID { get; set; }
        public string TipoProtocolo { get; set; } // enum Tipo do protocolo
        public string TipoDocumento { get; set; } // enum Tipo do protocolo
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }
        public int ClienteID { get; set; }

    }
}
