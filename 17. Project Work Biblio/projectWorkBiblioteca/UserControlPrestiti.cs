using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace projectWorkBiblioteca
{
    public partial class UserControlPrestiti : UserControl
    {
        User UserLogged;
        GestioneDati g;
        public UserControlPrestiti(GestioneDati g, User userLogged)
        {
            InitializeComponent();

            this.g = g;
            UserLogged = userLogged;
            if(UserLogged.Role == "admin") 
                buttonReclamo.Visible = true;

            BindPrestiti();
        }
       
        public void BindPrestiti()
        {
            dataGridViewPrestiti.DataSource = null;
            
            //se si ha fatto l'accesso come admin allora mostra tutti i prestiti
            //altrimenti mostra solo quelli dello user loggato
            List<Prestito> prestiti = new List<Prestito>();

            if(UserLogged.Role == "admin")
                prestiti = g.Prestiti;
            else
            {
                var prestitiUtente = from prestito in g.Prestiti
                                     where prestito.CodiceUtente == UserLogged.Code
                                     select prestito;
                prestiti = prestitiUtente.ToList();
            }
            var prestitiOrdinati = from prestito in prestiti
                                   orderby prestito.DataFine ascending
                                   select prestito;
            dataGridViewPrestiti.DataSource = prestitiOrdinati.ToList();

            //faccio in modo che le colonne occupino tutta la griglia
            foreach (DataGridViewColumn col in dataGridViewPrestiti.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewPrestiti.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Seleziona una riga");
                return;
            }

            //controllo che l'utente abbia meno di 3 prestiti
            UserLogged.NPrestiti--;
            g.WriteUsers();
            string code = selectedRow.Cells["ISBN"].Value.ToString();
            Libro book = g.Books[code];

            //do un voto al libro
            int voto = stelleLibro.Value;
            book.NVoti++;
            book.Media = book.Media + (((voto * 100) - book.Media) / book.NVoti);
            stelleLibro.coloraStelle(-1);

            //aumento la quantità di libri dato che è stato restituito e salvo
            book.Quantita++;
            g.WriteBooks();

            //cerco il prestito e lo rimuovo
            var prestitoList = from p in g.Prestiti
                           where p.ISBN == code &&
                           p.CodiceUtente == selectedRow.Cells["CodiceUtente"].Value.ToString() && 
                           p.DataInizio.Equals((DateTime)selectedRow.Cells["DataInizio"].Value)
                           select p;

            var prestito = prestitoList.First();
            
            g.Prestiti.Remove(prestito);
            BindPrestiti();
            g.WritePrestiti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewPrestiti.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Seleziona una riga");
                return;
            }

            string code = selectedRow.Cells["ISBN"].Value.ToString();

            //cerco il prestito
            var prestitoList = from p in g.Prestiti
                               where p.ISBN == code &&
                               p.CodiceUtente == selectedRow.Cells["CodiceUtente"].Value.ToString() &&
                               p.DataInizio.Equals((DateTime)selectedRow.Cells["DataInizio"].Value)
                               select p;

            var prestito = prestitoList.First();

            if(prestito.DataFine < DateTime.Now)
            {
                //Il prestito selezionato è in ritardo
                //MailAddress to = new MailAddress(UserLogged.Email);
                MailAddress to = new MailAddress("6190097@itisrossi.vi.it");
                MailAddress from = new MailAddress("projectworklibrary@gmail.com");

                MailMessage message = new MailMessage(from, to);
                message.Subject = "Restituzione libro";
                message.Body = $"Buongiorno Signor {UserLogged.LastName}, deve riconsegnare il libro \"{g.Books[code].Titolo}\".";

                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Credentials = new NetworkCredential("projectworklibrary@gmail.com", "ProjectWorkLibrary2022!"),
                    EnableSsl = true
                };

                try
                {
                    client.Send(message);
                }
                catch
                {
                    MessageBox.Show("L'email non è stata inviata, provare a controllare l'indirizzo email");
                }
            }
            else
            {
                MessageBox.Show("Il prestito è stato fatto meno di 30 giorni fa");
            }
        }
    }
}
