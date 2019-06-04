using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIPRO.Domain
{
    public class Processo
    {
        public int ProcessoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataCitacao { get; set; }
        public ICollection<Autor> Autores { get; set; } = new List<Autor>();
        public ICollection<Reu> Reus { get; set; } = new List<Reu>();
        public string Numero { get; set; }
        public ICollection<AndamentoProcessual> Andamentos { get; set; } = new List<AndamentoProcessual>();
        public ICollection<Advogado> AdvogadosResponsaveis { get; set; } = new List<Advogado>();
        public bool IsFinalizado { get; set; }
        public DateTime DataFinalizacao { get; set; }



    }
}
