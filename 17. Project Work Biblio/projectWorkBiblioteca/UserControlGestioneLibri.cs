using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWorkBiblioteca
{
    public partial class UserControlGestioneLibri : UserControl
    {
        GestioneDati g;
        public UserControlGestioneLibri(GestioneDati dati)
        {
            InitializeComponent();
            g = dati;
        }
        public void BindBooks()
        {
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = g.Books.Values.ToList();
        }

        private void UserControlGestioneLibri_Load(object sender, EventArgs e)
        {
            BindBooks();
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewBooks.CurrentRow;
            string imgURL = selectedRow.Cells[7].Value.ToString();
            try
            {
                pictureBoxBook.Load(imgURL);
            }
            catch (Exception)
            {
                //immagine non trovata unlucky
            }
        }

        private void checkBoxAllowEdit_CheckedChanged(object sender, EventArgs e)
        {
            //abilita disabilita modifica datagrid view
            dataGridViewBooks.ReadOnly = !(checkBoxAllowEdit.Checked);
        }
        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {
            //salva modifiche
            List<Libro> listaBook = dataGridViewBooks.DataSource as List<Libro>;
            g.UpdateBooksDictionary(listaBook);
            g.WriteBooks();
        }
        private void buttonElimina_Click(object sender, EventArgs e)
        {
            //riga selezionata
            var selectedRow = dataGridViewBooks.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Seleziona una riga");
                return;
            }

            //isbn presente nella riga selezionata
            string code = selectedRow.Cells[0].Value.ToString().Trim();

            //rimuovo il libro con quel codice
            g.Books.Remove(code);
            //salvo
            g.WriteBooks();

            BindBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputData())
            {
                //controllo che non esista un libro con lo stesso codice
                bool res = g.Books.TryGetValue(textBoxISBN.Text, out Libro _);
                if (res)
                {
                    MessageBox.Show("Esiste già un Libro con questo ISBN");
                    return;
                }
                g.Books.Add(textBoxISBN.Text, new Libro()
                {
                    Titolo = textBoxTitolo.Text,
                    Sottotitolo = textBoxSottotitolo.Text,
                    ISBN = textBoxISBN.Text,
                    Descrizione = textBoxDescrizione.Text,
                    Autori = textBoxAutori.Text,
                    Anno = textBoxAnno.Text,
                    Categorie = textBoxCategorie.Text,
                    Immagine = textBoxURL.Text,
                    Quantita = (int)numericUpDownQta.Value,
                    Media = (float)numericUpDownMedia.Value,
                    NVoti = (int)numericUpDownNVoti.Value,
                    NPagine = (int)numericUpDownPagine.Value
                });
                resetInputs();
                g.WriteBooks();
                BindBooks();
            }
            else
            {
                MessageBox.Show("Inserire correttamente i dati");
            }
        }
        private bool checkInputData()
        {
            //controlla che venga inserito un dato in tutti i campi
            if (textBoxTitolo.Text.Trim() == String.Empty || textBoxSottotitolo.Text.Trim() == String.Empty ||
                textBoxISBN.Text.Trim() == String.Empty || textBoxDescrizione.Text.Trim() == String.Empty || 
                textBoxAutori.Text.Trim() == String.Empty || textBoxAnno.Text.Trim() == String.Empty || 
                textBoxCategorie.Text.Trim() == String.Empty || textBoxURL.Text.Trim() == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void resetInputs()
        {
            textBoxTitolo.Text = String.Empty;
            textBoxSottotitolo.Text = String.Empty;
            textBoxISBN.Text = String.Empty;
            textBoxDescrizione.Text = String.Empty;
            textBoxAutori.Text = String.Empty;
            textBoxAnno.Text = String.Empty;
            textBoxCategorie.Text = String.Empty;
            textBoxURL.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            //disabilito il salvataggio se ci sono filtri
            if (t.Text != string.Empty)
            {
                buttonSaveEdit.Enabled = false;
            }
            else
            {
                buttonSaveEdit.Enabled = true;
            }
            var libriFiltrati = from book in g.Books.Values.ToList()
                                where book.ISBN.Contains(t.Text)
                                || book.Titolo.Contains(t.Text)
                                select book;
            dataGridViewBooks.DataSource = libriFiltrati.ToList();
        }
    }
}
