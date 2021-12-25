namespace Riproduttore_musicale_queue
{
    public class Song 
    {
        public string Titolo { get; }
        public int Durata { get; }

        public Song(string titolo, int durata)
        {
            Titolo = titolo;
            Durata = durata;
        }
    }
}
