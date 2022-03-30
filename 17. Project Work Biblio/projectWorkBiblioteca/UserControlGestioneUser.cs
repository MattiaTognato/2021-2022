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
    public partial class UserControlGestioneUser : UserControl
    {
        GestioneDati g;
        public UserControlGestioneUser(GestioneDati dati)
        {
            InitializeComponent();
            g = dati;
        }

        private void GestioneLibriAdmin_Load(object sender, EventArgs e)
        {
            BindUsers();
        }
        public void BindUsers()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = g.Users.Values.ToList();
        }
        private void checkBoxAllowEdit_CheckedChanged(object sender, EventArgs e)
        {
            //abilita disabilita modifica datagrid view
            dataGridViewUsers.ReadOnly = !(checkBoxAllowEdit.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inserimento utente e scrittura sul file
            if (checkInputData())
            {
                //controllo che non esista un utente con lo stesso codice
                bool res = g.Users.TryGetValue(textBoxCodice.Text, out User _);
                if(res)
                {
                    MessageBox.Show("Esiste già un utente con questo codice");
                    return;
                }
                g.Users.Add(textBoxCodice.Text, new User()
                {
                    FirstName = textBoxNome.Text,
                    LastName = textBoxCognome.Text,
                    Email = textBoxEmail.Text,
                    Role = radioButtonAdmin.Checked ? "admin" : "user",
                    City = textBoxCitta.Text,
                    Code = textBoxCodice.Text,
                    Password = textBoxPassword.Text,
                    BirthDate = textBoxData.Text
                });
                resetInputs();
                g.WriteUsers();
                BindUsers();
            }
            else
            {
                MessageBox.Show("Inserire correttamente i dati");
            }
        }
        private void resetInputs()
        {
            textBoxNome.Text = String.Empty;
            textBoxCognome.Text = String.Empty;
            textBoxEmail.Text = String.Empty;
            textBoxCitta.Text = String.Empty;
            textBoxCodice.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
            textBoxData.Text = String.Empty;

            radioButtonAdmin.Checked = false;
            radioButtonUser.Checked = false;
        }
        private bool checkInputData()
        {
            //controlla che venga inserito un dato in tutti i campi
            if(textBoxNome.Text.Trim() == String.Empty || textBoxCognome.Text.Trim() == String.Empty ||
                textBoxEmail.Text.Trim() == String.Empty || !(radioButtonAdmin.Checked || radioButtonUser.Checked) ||
                textBoxCitta.Text.Trim() == String.Empty || textBoxCodice.Text.Trim() == String.Empty ||
                textBoxPassword.Text.Trim() == String.Empty || textBoxData.Text.Trim() == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {
            //salva modifiche
            List<User> listaUser = dataGridViewUsers.DataSource as List<User>;
            g.UpdateUsersDictionary(listaUser);
            g.WriteUsers();
            buttonSaveEdit.Enabled = false;
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            //riga selezionata
            var selectedRow = dataGridViewUsers.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Seleziona una riga");
                return;
            }

            //codice presente nella riga selezionata
            string code = selectedRow.Cells[5].Value.ToString().Trim();

            //rimuovo l'utente con quel codice
            g.Users.Remove(code);
            //salvo
            g.WriteUsers();
            
            BindUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            //disabilito il salvataggio se ci sono filtri
            if(text == String.Empty)
            {
                buttonSaveEdit.Enabled = true;
            }
            else
            {
                buttonSaveEdit.Enabled = false;
            }
            var userFiltrati = from user in g.Users.Values
                               where user.FirstName.Contains(text) ||
                               user.LastName.Contains(text) ||
                               user.Code.Contains(text)
                               select user;
            dataGridViewUsers.DataSource = userFiltrati.ToList();
        }
    }
}
