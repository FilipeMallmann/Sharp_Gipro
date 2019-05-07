using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Processo
    {
        public int ProcessoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataCitacao { get; set; }
        public List<int> AutoresId { get; set; }
        public List<int> ReusId { get; set; }
        public string Numero { get; set; }
        public int AdvogadoResponsavelId { get; set; }


    }
}
