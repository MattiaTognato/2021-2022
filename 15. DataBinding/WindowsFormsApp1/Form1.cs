using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Persona> ListaPersone;
        public Form1()
        {
            InitializeComponent();
            ListaPersone = new List<Persona>();
            ListaPersone.Add(new Persona("1", "1", 0));
            ListaPersone.Add(new Persona("2", "2", 1));
            ListaPersone.Add(new Persona("3", "3", 2));
            ListaPersone.Add(new Persona("4", "4", 3));

            BindingSource bind = new BindingSource();//bind combobox ad una lista
            bind.DataSource = ListaPersone;
            cmbLista.DataSource = bind;
            cmbLista.DisplayMember = "Cognome";

            Binding bindTextBox = new Binding("Text", textInput, "Text");// bind text box ad una text box
            textOutput.DataBindings.Add(bindTextBox);

            Binding bindLabel = new Binding("Text", textInput, "Text");// bind label ad una textbox
            labelOutput.DataBindings.Add(bindLabel);
        }

    }
}
