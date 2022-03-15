using System.Collections.Generic;

namespace binding2
{
    public class Cantante
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeArte { get; set; }
        public string Nazionalità { get; set; }
        public List<Canzone> ListaCanzoni { get; set; }

        public Cantante(int id, string nomeCompleto, string nomeArte, string nazionalità)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            NomeArte = nomeArte;
            Nazionalità = nazionalità;
            ListaCanzoni = new List<Canzone>();
        }
    }
}
