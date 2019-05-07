using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class AndamentoProcessual
    {
        public int AndamentoProcessualId { get; set; }
        public int ProcessoId { get; set; }
        public string Movimento { get; set; }
        public DateTime DataAndamento { get; set; }
        public string TipoAndamento { get; set; }// enum

        public int UsuarioId { get; set; }


    }
}
