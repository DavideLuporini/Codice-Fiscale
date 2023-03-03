using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codice_Fiscale
{
    internal class Comune
    {
        public string Nome { get; set; }
        public string Codice { get; set;}

        public Comune(string nome, string codice)
        {
            Nome = nome;
            Codice = codice;
        }
    }
}
