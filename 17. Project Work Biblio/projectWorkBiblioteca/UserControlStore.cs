using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWorkBiblioteca
{
    public partial class UserControlStore : UserControl
    {
        GestioneDati g;
        User UserLogged;
        public UserControlStore(GestioneDati dati, User userLogged)
        {
            InitializeComponent();
            
            g = dati;
            UserLogged = userLogged;
            
            //inizializzo datagridview
            dataGridViewBooks.AutoGenerateColumns = false;
            ColumnTitolo.DataPropertyName = "Titolo";
            ColumnISBN.DataPropertyName = "ISBN";
            ColumnAutori.DataPropertyName = "Autori";
            ColumnCategorie.DataPropertyName = "Categorie";
            ColumnAnno.DataPropertyName = "Anno";
            ColumnRating.DataPropertyName = "Media";
            ColumnQta.DataPropertyName = "Quantita";

            BindBooks();

            //inizializzo combobox
            comboBoxRicerca.SelectedIndex = 0;
        }
        public void BindBooks()
        {
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = g.Books.Values.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string property = comboBoxRicerca.Text;
            string text = (sender as TextBox).Text;

            Ricerca(property, text);
        }

        private void comboBoxRicerca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string property = (sender as ComboBox).Text;
            string text = textBox1.Text;
            Ricerca(property, text);
        }

        private void Ricerca(string textComboBox, string textTextBox)
        {
            //faccio una ricerca in base alla property selezionatta e al testo
            var listaFiltrata = from book in g.Books.Values
                                where (book.GetType().GetProperty(textComboBox).GetValue(book, null) as string).Contains(textTextBox)
                                select book;

            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = listaFiltrata.ToList();
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            //prendo il libro corrispondente alla selezione
            var selectedRow = dataGridViewBooks.CurrentRow;
            
            if (selectedRow == null) return;

            string code = selectedRow.Cells[1].Value.ToString();
            Libro book = g.Books[code];

            //provo a visualizzare l'immagine
            try
            {
                pictureBoxBook.Load(book.Immagine);
            }
            catch (Exception)
            {
                //immagine non trovata unlucky
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prendo il libro corrispondente alla selezione
            var selectedRow = dataGridViewBooks.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Seleziona una riga");
                return;
            }

            //controllo che l'utente abbia meno di 3 prestiti
            if (UserLogged.NPrestiti > 2)
            {
                MessageBox.Show("Hai esaurito i 3 prestiti disponibili");
                return;
            }
            UserLogged.NPrestiti++;

            string code = selectedRow.Cells[1].Value.ToString();
            Libro book = g.Books[code];

            if(book.Quantita < 1)
            {
                MessageBox.Show("Il libro selezionato è esaurito");
                return;
            }

            //Il libro è disponibile quindi ora è sicuro che l'utente lo può prendere

            //diminuisco la quantità di quel libro
            book.Quantita--;

            //creo il prestito
            Prestito p = new Prestito()
            {
                CodiceUtente = UserLogged.Code,
                ISBN = book.ISBN,
                DataInizio = DateTime.Now,
                DataFine = DateTime.Now.AddDays(30)
            };

            MessageBox.Show($"Hai chiesto in prestito \"{book.Titolo}\" dovrai restituirlo in data {p.DataFine.ToShortDateString()}");


            //aggiungo il libro alla cronologia di libri dell'utente
            UserLogged.HistoryLibri.Add(book);
            
            //Ogni 10 libri l'utente ha diritto ad un premio
            if(UserLogged.HistoryLibri.Count %10 == 0)
                MessageBox.Show("Complimenti hai vinto un premio");

            //aggiungo il prestito
            g.Prestiti.Add(p);
            
            //salvo tutto
            g.WritePrestiti();
            g.WriteBooks();
            g.WriteUsers();
            
            BindBooks();

        }
    }
}
