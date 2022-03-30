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
    public partial class Form1 : Form
    {
        GestioneDati g;

        UserControlGestioneLibri pannelloGestioneLibri;
        UserControlDashBoard pannelloDashboard;
        UserControlGestioneUser pannelloGestioneUtenti;

        UserControlStore pannelloStore;
        UserControlPrestiti pannelloPrestiti;
        UserControlCronologia pannelloCronologia;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Classe per gestire la scrittura lettura dei file
            g = new GestioneDati();
            //creo il componente login
            Login login = new Login(g);

            panel3.Controls.Add(login);
            login.Dock = DockStyle.Fill;

            //mi iscrivo all'evento del login
            login.Logged += Login_Logged;
            
            
        }

        private void Login_Logged(object sender, User userLogged)
        {
            Login l = (Login)sender;

            //chiudo la schermata di login
            l.Dispose();

            //creo i vari pannelli

            //pannello dello store
            pannelloStore = new UserControlStore(g, userLogged);
            pannelloStore.Location = new Point(252, 106);
            pannelloStore.Size = new Size(921, 702);
            this.Controls.Add(pannelloStore);

            //pannello dei Prestiti
            pannelloPrestiti = new UserControlPrestiti(g, userLogged);
            pannelloPrestiti.Location = new Point(252, 106);
            pannelloPrestiti.Size = new Size(921, 702);
            this.Controls.Add(pannelloPrestiti);

            //Pannello Cronologia
            pannelloCronologia = new UserControlCronologia(userLogged);
            pannelloCronologia.Location = new Point(252, 106);
            pannelloCronologia.Size = new Size(921, 702);
            this.Controls.Add(pannelloCronologia);

            buttonStore.Visible = true;
            buttonPrestiti.Visible = true;
            buttonCronologia.Visible = true;
            panelActiveButton.Visible = true;
            buttonLogout.Visible = true;

            panelActiveButton.Height = buttonStore.Height;
            panelActiveButton.Top = buttonStore.Top;
            pannelloStore.BringToFront();
            pannelloStore.BindBooks();

            //controllo se è uno user o admin
            if (userLogged.Role == "admin")
            {
                //Gestione User
                pannelloGestioneUtenti = new UserControlGestioneUser(g);
                pannelloGestioneUtenti.Location = new Point(252, 106);
                pannelloGestioneUtenti.Size = new Size(921, 702);
                this.Controls.Add(pannelloGestioneUtenti);
                
                //Gestione Books
                pannelloGestioneLibri = new UserControlGestioneLibri(g);
                pannelloGestioneLibri.Location = new Point(252, 106);
                pannelloGestioneLibri.Size = new Size(921, 702);
                this.Controls.Add(pannelloGestioneLibri);

                //pannello DashBoard

                pannelloDashboard = new UserControlDashBoard(g);
                pannelloDashboard.Location = new Point(252, 106);
                pannelloDashboard.Size = new Size(921, 702);
                this.Controls.Add(pannelloDashboard);

                //Rendi visibili i bottoni per l'admin
                buttonGestioneUtenti.Visible = true;
                buttonGestioneLibri.Visible = true;
                buttonDashboard.Visible = true;
            }
        }

        private void buttonGestioneUtenti_Click(object sender, EventArgs e)
        {
            panelActiveButton.Height = buttonGestioneUtenti.Height;
            panelActiveButton.Top = buttonGestioneUtenti.Top;
            pannelloGestioneUtenti.BringToFront();
            pannelloGestioneUtenti.BindUsers();
        }

        private void buttonGestioneLibri_Click(object sender, EventArgs e)
        {
            panelActiveButton.Height = buttonGestioneLibri.Height;
            panelActiveButton.Top = buttonGestioneLibri.Top;
            pannelloGestioneLibri.BringToFront();
            pannelloGestioneLibri.BindBooks();
        }

        private void iconButtonStore_Click(object sender, EventArgs e)
        {
            panelActiveButton.Height = buttonStore.Height;
            panelActiveButton.Top = buttonStore.Top;
            pannelloStore.BringToFront();
            pannelloStore.BindBooks();
        }

        private void buttonPrestiti_Click(object sender, EventArgs e)
        {
            panelActiveButton.Height = buttonPrestiti.Height;
            panelActiveButton.Top = buttonPrestiti.Top;
            pannelloPrestiti.BindPrestiti();
            pannelloPrestiti.BringToFront();
        }

        private void buttonCronologia_Click(object sender, EventArgs e)
        {
            panelActiveButton.Height = buttonCronologia.Height;
            panelActiveButton.Top = buttonCronologia.Top;
            pannelloCronologia.BindUserHistory();
            pannelloCronologia.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panelActiveButton.Height = buttonDashboard.Height;
            panelActiveButton.Top = buttonDashboard.Top;
            pannelloDashboard.BindDashboard();
            pannelloDashboard.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //tolgo tutto
            //bottoni
            buttonStore.Visible = false;
            buttonPrestiti.Visible = false;
            buttonCronologia.Visible = false;
            buttonGestioneUtenti.Visible = false;
            buttonGestioneLibri.Visible = false;
            buttonDashboard.Visible = false;
            buttonLogout.Visible = false;
            //pannelli
            pannelloGestioneLibri?.Dispose();
            pannelloDashboard?.Dispose();
            pannelloGestioneUtenti?.Dispose();
            pannelloStore?.Dispose();
            pannelloPrestiti?.Dispose();
            pannelloCronologia?.Dispose();

            panelActiveButton.Visible = false;

            //creo il componente login
            Login login = new Login(g);

            panel3.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            panel3.BringToFront();
            //mi iscrivo all'evento del login
            login.Logged += Login_Logged;
        }
    }
}
