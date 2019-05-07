using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Reu //Vinculo da interface para campos -  autor e reu são bem parecidos
    {
        public int ReuId { get; set; }
        public int TipoPessoa { get; set; } // enum fisica ou juridica

        public string NumeroDocumento { get; set; }
        public string Nome { get; set; }
        public DateTime DataCitacao { get; set; }


    }
}
