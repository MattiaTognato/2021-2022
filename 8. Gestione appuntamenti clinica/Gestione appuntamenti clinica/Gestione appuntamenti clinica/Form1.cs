using System.Data;

namespace Gestione_appuntamenti_clinica
{
    public partial class Form1 : Form
    {
        GestioneDati g;
        DataTable tablePazienti;
        DataTable tableMedici;
        DataTable tablePatologie;
        DataTable tableSpecializzazioni;
        DataTable tableAppuntamenti;
        public Form1()
        {
            InitializeComponent();
            g = new GestioneDati();

            tablePazienti = new DataTable();
            tablePazienti.Columns.Add("Id", typeof(int));
            tablePazienti.Columns.Add("Nome", typeof(string));
            tablePazienti.Columns.Add("Cognome", typeof(string));
            tablePazienti.Columns.Add("Patologia", typeof(string));

            tableMedici = new DataTable();
            tableMedici.Columns.Add("Id", typeof(int));
            tableMedici.Columns.Add("Nome", typeof(string));
            tableMedici.Columns.Add("Cognome", typeof(string));
            tableMedici.Columns.Add("Specializzazione", typeof(string));

            tablePatologie = new DataTable();
            tablePatologie.Columns.Add("Nome", typeof(string));
            tablePatologie.Columns.Add("Id", typeof(int));

            tableSpecializzazioni = new DataTable();
            tableSpecializzazioni.Columns.Add("Nome", typeof(string));
            tableSpecializzazioni.Columns.Add("Id", typeof(int));

            tableAppuntamenti = new DataTable();
            tableAppuntamenti.Columns.Add("Data", typeof(DateTime));
            tableAppuntamenti.Columns.Add("Paziente", typeof(string));
            tableAppuntamenti.Columns.Add("Medico", typeof(string));

            BindPazientiDgv();
            BindMediciDgv();
            BindPatologieDvg();
            BindSpecializzazioniDvg();
            BindAppuntamentiDgv();
            BindAppuntamentiCmb();
        }
        void BindAppuntamentiCmb()
        {
            foreach (Paziente p in g.Pazienti)
            {
                PazientePicker.Items.Add(p.Cognome + " " + p.Nome);
            }
            foreach (Medico m in g.Medici)
            {
                MedicoPicker.Items.Add(m.Cognome + " " + m.Nome);
            }
            PazientePicker.SelectedIndex = 0;
            MedicoPicker.SelectedIndex = 0;
        }
        void BindAppuntamentiDgv()
        {
            tableAppuntamenti.Rows.Clear();
            foreach (Appuntamento a in g.Appuntamenti)
            {
                tableAppuntamenti.Rows.Add(a.Data, a.Paziente.Cognome + " " + a.Paziente.Nome, a.Medico.Cognome + " " + a.Medico.Nome);
            }
            AppuntamentiDgv.DataSource = tableAppuntamenti;
            AppuntamentiDgv.Columns[1].Width = 150;
            AppuntamentiDgv.Columns[2].Width = 150;
        }
        void BindPazientiDgv()
        {
            tablePazienti.Rows.Clear();
            foreach (Paziente p in g.Pazienti)
            {
                tablePazienti.Rows.Add(p.ID, p.Nome, p.Cognome, p.Patologia);
            }
            pazientiDgv.DataSource = tablePazienti;
            pazientiDgv.Columns[0].Width = 40;
            pazientiDgv.Columns[3].Width = 250;

        }
        void BindMediciDgv()
        {
            tableMedici.Rows.Clear();
            foreach (Medico m in g.Medici)
            {
                tableMedici.Rows.Add(m.ID, m.Nome, m.Cognome, m.Specializzazione);
            }
            MediciDgv.DataSource = tableMedici;
            MediciDgv.Columns[0].Width = 40;
            MediciDgv.Columns[3].Width = 250;
        }
        void BindPatologieDvg()
        {
            tablePatologie.Rows.Clear();
            int i = 1;
            foreach (var p in g.Patologie)
            {
                if (p == null)
                    continue;
                tablePatologie.Rows.Add(p, i);
                i++;
            }
            PatologieDgv.DataSource = tablePatologie;
            PatologieDgv.Columns[1].Width = 40;
        }
        void BindSpecializzazioniDvg()
        {
            tableSpecializzazioni.Rows.Clear();
            int i = 1;
            foreach (var s in g.Specializzazioni)
            {
                if(s == null)
                    continue ;
                tableSpecializzazioni.Rows.Add(s, i);
                i++;
            }
            SpecializzazioniDgv.DataSource = tableSpecializzazioni;
            SpecializzazioniDgv.Columns[1].Width = 40;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                dateTimePicker.Enabled = true;
            else
                dateTimePicker.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                PazientePicker.Enabled = true;
            else
                PazientePicker.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                MedicoPicker.Enabled = true;
            else
                MedicoPicker.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindAppuntamentiDgv();
            if (dateTimePicker.Enabled)
            {
                for (int i = AppuntamentiDgv.Rows.Count - 1; i >= 0; i--)
                {
                    var row = AppuntamentiDgv.Rows[i];
                    if (row.Cells[0].Value != null && ((DateTime)row.Cells[0].Value).Date != dateTimePicker.Value.Date)
                    {
                        AppuntamentiDgv.Rows.RemoveAt(row.Index);
                    }
                }
            }
            if (PazientePicker.Enabled)
            {
                for (int i = AppuntamentiDgv.Rows.Count - 1; i >= 0; i--)
                {
                    var row = AppuntamentiDgv.Rows[i];
                    if (row.Cells[1].Value != null && (string)row.Cells[1].Value != (string)PazientePicker.SelectedItem)
                    {
                        AppuntamentiDgv.Rows.RemoveAt(row.Index);
                    }
                }
            }
            if (MedicoPicker.Enabled)
            {
                for (int i = AppuntamentiDgv.Rows.Count - 1; i >= 0; i--)
                {
                    var row = AppuntamentiDgv.Rows[i];
                    if (row.Cells[2].Value != null && (string)row.Cells[2].Value != (string)MedicoPicker.SelectedItem)
                    {
                        AppuntamentiDgv.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindAppuntamentiDgv();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            dateTimePicker.Enabled = false;
            MedicoPicker.Enabled = false;
            PazientePicker.Enabled = false;

        }
    }
}