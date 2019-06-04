using DOMAIN.Emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Advogado
    {
        public int AdvogadoId { get; set; }
        public string Nome { get; set; }
        public TipoAdvogado TipoAdvogado { get; set; } 
        public string OAB { get; set; }
        public string CertificadoDigital { get; set; }
        public string SenhaCertificado { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string WatsApp { get; set; }
        public string Email { get; set; }
        public bool IsRecebeIntimacao { get; set; }


    }
}
