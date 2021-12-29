namespace Gestione_appuntamenti_clinica
{
    class Medico : Persona
    {
        public string Specializzazione;
        public Medico(string nome, string cognome, string email, int iD, string specializzazione) : base(nome, cognome, email, iD)
        {
            Specializzazione = specializzazione;
        }
    }
}