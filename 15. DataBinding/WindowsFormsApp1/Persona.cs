namespace WindowsFormsApp1
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NomeCompleto { get; set; }

        public Persona(string nome, string cognome, int id)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
        }
    }
}
