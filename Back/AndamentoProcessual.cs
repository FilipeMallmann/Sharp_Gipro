using DOMAIN.Emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class AndamentoProcessual
    {
        public int AndamentoProcessualId { get; set; }
        public string Movimento { get; set; }
        public DateTime DataAndamento { get; set; }
        public TipoAndamento TipoAndamento { get; set; }
        public Usuario Usuario { get; set; }



    }
}
