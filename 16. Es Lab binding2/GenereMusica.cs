using System.Collections.Generic;

namespace binding2
{
    public class GenereMusica {
        public string Sigla{ get; set; }
        public string NomeGenere { get; set; }
        public List<Cantante> ListaCantanti { get; set; }

        public GenereMusica(string sigla, string nomeGenere, List<Cantante> list)
        {
            Sigla = sigla;
            NomeGenere = nomeGenere;
            ListaCantanti = list;
        }
    }
}
