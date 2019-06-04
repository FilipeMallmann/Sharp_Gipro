using System;
using System.Collections.Generic;


namespace DOMAIN
{
    public class Cliente
    {
        public int ClienteId { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Watsapp { get; set; }
        public string Email { get; set; }

        public int AutorOuReu { get; set; } // vinculo com a interface autore/reu ou enum

    }
}
