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
            comboBox2.DataSource = bind;
            comboBox2.DisplayMember = "NomeCompleto";

            textboxId.DataBindings.Add("Text", bind, "Id");
            textOutput.DataBindings.Add("Text", textInput, "Text");
            labelOutput.DataBindings.Add("Text", textInput, "Text");
            textBoxFormSize.DataBindings.Add("Text", this, "Size");
        }

    }
}
