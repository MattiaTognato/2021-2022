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
    public partial class Login : UserControl
    {
        GestioneDati g;
        public event EventHandler<User> Logged;
        public Login(GestioneDati dati)
        {
            InitializeComponent();
            g = dati;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string username = codeTextbox.Text.Trim();
            string password = PasswordTextbox.Text;

            bool res = g.Users.TryGetValue(username, out User user);
            if (res == true && password == user.Password)
            {
                Logged?.Invoke(this, user);
            }
            else
            {
                MessageBox.Show("Usarname e password non corrispondono");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //codeTextbox.Text = "TYJIKR47F60M553C";
            //PasswordTextbox.Text = "dIIosgaCb4w";
        }
    }
}
