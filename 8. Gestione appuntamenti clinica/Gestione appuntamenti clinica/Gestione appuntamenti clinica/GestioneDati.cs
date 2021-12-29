using System.IO;
using System.Reflection;

namespace Gestione_appuntamenti_clinica
{
    class GestioneDati 
    {
        public List<Medico> Medici;
        public List<Paziente> Pazienti;
        public List<Appuntamento> Appuntamenti;
        public string[] Patologie;
        public string[] Specializzazioni;

        public GestioneDati()
        {
            
            BindPatologie();
            BindSpecializzazioni();
            Medici = new List<Medico>();
            BindMedici();
            Pazienti = new List<Paziente>();
            BindPazienti();
            Appuntamenti = new List<Appuntamento>();
            BindAppuntamenti();
        }
        public void BindPatologie()
        {
            string[] allLines = File.ReadAllLines("@../../../../../Risorse/patologie.csv");
            Patologie = new string[allLines.Length];
            foreach (var line in allLines)
            {
                string[] tmp = line.Split(';');
                if (!int.TryParse(tmp[0], out int indice))
                {
                    continue;
                }
                Patologie[indice] = tmp[1];
            }
        }
        public void BindSpecializzazioni()
        {
            string[] allLines = File.ReadAllLines("@../../../../../Risorse/specializzazioni.csv");
            Specializzazioni = new string[allLines.Length];
            foreach (var line in allLines)
            {
                string[] tmp = line.Split(';');
                if (!int.TryParse(tmp[0], out int indice))
                {
                    continue;
                }
                Specializzazioni[indice] = tmp[1];
            }
        }
        public void BindMedici()
        {
            string[] allLines = File.ReadAllLines("@../../../../../Risorse/medici.csv");
            foreach(var line in allLines)
            {
                string[] tmp = line.Split(';');
                if (!int.TryParse(tmp[3], out int id) || !int.TryParse(tmp[4], out int indice))
                {
                    continue;
                }
                Medici.Add(new Medico(tmp[0], tmp[1], tmp[2], id, Specializzazioni[indice]));
            }
        }
        public void BindPazienti()
        {
            string[] allLines = File.ReadAllLines("@../../../../../Risorse/pazienti.csv");
            foreach (var line in allLines)
            {
                string[] tmp = line.Split(';');
                if (!int.TryParse(tmp[6], out int id) || !int.TryParse(tmp[5], out int indice))
                {
                    continue;
                }
                Pazienti.Add(new Paziente(tmp[0], tmp[1], tmp[2], id, tmp[3],tmp[4],Patologie[indice]));
            }
        }
        public void BindAppuntamenti()
        {
            string[] allLines = File.ReadAllLines("@../../../../../Risorse/appuntamenti.csv");
            foreach (var line in allLines)
            {
                string[] tmp = line.Split(';');
                if (!int.TryParse(tmp[1], out int idPaziente) || !int.TryParse(tmp[2], out int idMedico))
                {
                    continue;
                }
                DateTime.TryParse(tmp[0], out DateTime data);
                Appuntamenti.Add(new Appuntamento(data, Pazienti.Find(i => i.ID == idPaziente), Medici.Find(j => j.ID == idMedico)));
            }
        }
    }
}