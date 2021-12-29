namespace Gestione_appuntamenti_clinica
{
    class Appuntamento
    {
        public DateTime Data;
        public Medico Medico;
        public Paziente Paziente;
        public Appuntamento(DateTime data, Paziente paziente, Medico medico)
        {
            Data = data;
            Medico = medico;
            Paziente = paziente;
        }
    }
}