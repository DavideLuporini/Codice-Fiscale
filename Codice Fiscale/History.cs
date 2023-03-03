using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnosoftware.CodiceFiscale;

namespace Codice_Fiscale
{
    public class History
    {


        public List<CodiceFiscale> calcoliEffettuati { get; set; }


        public History()
        {
            calcoliEffettuati = new List<CodiceFiscale>();
        }

        public void AggiungiCalcolo(CodiceFiscale codiceFiscale)
        {
            calcoliEffettuati.Add(codiceFiscale);
        }
    }
}
