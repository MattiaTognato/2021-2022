namespace binding2
{
    public class Canzone
    {
        public int Id { get; set; }
        public string NomeCanzone { get; set; }
        public int AnnoProduzione { get; set; }
        public Canzone(int id, string nomeCanzone, int annoProduzione)
        {
            Id = id;
            NomeCanzone = nomeCanzone;
            AnnoProduzione = annoProduzione;
        }
    }
}
