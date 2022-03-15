using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binding2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nomeClone.DataBindings.Add("Text", nomeTxt, "Text");

            List<Cantante> listaCantantiTrap = new List<Cantante>();//Cantanti TRAP
            listaCantantiTrap.Add(new Cantante(0, "Tony Effe", "Sosa", "Italiana"));
            listaCantantiTrap.Add(new Cantante(0, "2", "2", "2"));

            List<Cantante> listaCantantiRock = new List<Cantante>();//Cantanti Rock
            listaCantantiRock.Add(new Cantante(0, "Nirvana", "NirvanaArte", "America"));
            listaCantantiRock.Add(new Cantante(0, "2", "2", "2"));

            List<GenereMusica> generiMusicali = new List<GenereMusica>();
            generiMusicali.Add(new GenereMusica("TR", "Trap", listaCantantiTrap));
            generiMusicali.Add(new GenereMusica("RK", "Rock", listaCantantiRock));

            BindingSource bindGeneri = new BindingSource();
            bindGeneri.DataSource = generiMusicali;
            
            ListaGeneri.DataSource = bindGeneri;
            ListaGeneri.DisplayMember = "Sigla";

            NomeGenere.DataBindings.Add("Text", bindGeneri, "NomeGenere");

            Cantanti.DataSource = bindGeneri;
            Cantanti.DisplayMember = "ListaCantanti.NomeCompleto";

            nomeArte.DataBindings.Add("Text", bindGeneri, "ListaCantanti.NomeArte");
            nazionalitaText.DataBindings.Add("Text", bindGeneri, "ListaCantanti.Nazionalità");
            richTextBox1.Text = JsonConvert.SerializeObject(generiMusicali, Formatting.Indented);
        }

    }
}
