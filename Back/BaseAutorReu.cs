using DOMAIN.Emuns;
using System;
using System.Collections.Generic;

namespace DOMAIN
{
    public class BaseAutorReu
    {
        public TipoPessoa TipoPessoa { get; set; } 
        public string NumeroDocumento { get; set; }
        public string Nome { get; set; }
        public DateTime DataCitacao { get; set; }
        public ICollection<Advogado> Advogados { get; set; } = new List<Advogado>();
    }
}