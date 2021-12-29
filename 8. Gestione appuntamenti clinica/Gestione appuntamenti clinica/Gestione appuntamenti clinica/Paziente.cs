namespace Gestione_appuntamenti_clinica
{
    class Paziente : Persona
    {
        public string Indirizzo;
        public string CodiceFiscale;
        public string Patologia;
        public Paziente(string nome, string cognome, string email, int iD, string indirizzo, string codiceFiscale, string patologia) : base(nome, cognome, email, iD)
        {
            Indirizzo = indirizzo;
            CodiceFiscale = codiceFiscale;
            Patologia = patologia;
        }
    }
}