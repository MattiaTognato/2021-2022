namespace Gestione_appuntamenti_clinica
{
    abstract class Persona
    {
        public string Nome;
        public string Cognome;
        public string Email;
        public int ID;

        protected Persona(string nome, string cognome, string email, int iD)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            ID = iD;
        }
    }
}