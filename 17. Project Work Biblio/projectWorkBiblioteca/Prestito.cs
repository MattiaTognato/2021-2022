using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWorkBiblioteca
{
    public class Prestito
    {
        public string ISBN { get; set; }
        public string CodiceUtente { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
    }
}
