using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Campo_Minato_2._0
{
    public partial class finestra : Form
    {
        Panel panello = new Panel() //pannello che conterra la griglia
        {
            Location = new Point(335, 169),
            Size = new Size(749, 555)
        };
        
        public finestra()
        {
            InitializeComponent();
            this.Controls.Add(panello);
            Griglia gr = new Griglia(16, 40, panello, nbombeLbl, lblFinePartita);
            cmbGrandezzaGriglia.SelectedIndex = 2;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            selezionaCreaGriglia(cmbGrandezzaGriglia.SelectedIndex);
        }
        void selezionaCreaGriglia(int caso)     //funzione che crea la griglia a seconda del parametro passato cambia la grandezza e numero di bombe
        {
            int cellePerLato = 0;
            int nBombe = 0;
            switch (caso)
            {
                case 0:
                    cellePerLato = 9;
                    nBombe = 10;
                    break;
                case 1:
                    cellePerLato = 12;
                    nBombe = 25;
                    break;
                case 2:
                    cellePerLato = 16;
                    nBombe = 40;
                    break;
                case 3:
                    cellePerLato = 16;
                    nBombe = 70;
                    break;
            }
            for (int i = panello.Controls.Count - 1; i >= 0; i--)   // cancella Griglia precedente
                panello.Controls.RemoveAt(i); 

            Griglia gr = new Griglia(cellePerLato, nBombe, panello, nbombeLbl, lblFinePartita);
            lblFinePartita.Visible = false;
        }
        void importaGriglia()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)    //viene selezionato un file nel file dialog
            {
                string[] testoFile = File.ReadAllLines(openFileDialog1.FileName);   //salva tutte le righe in celle diverse di un array
                int[,] grigliaCustom = new int[testoFile.Length, testoFile.Length];

                for (int y = 0; y < testoFile.Length; y++)
                    for (int i = 0; i < testoFile[y].Length; i++)
                    {
                        if(!int.TryParse(testoFile[y][i].ToString(), out _) || !(int.Parse(testoFile[y][i].ToString()) == 0 || int.Parse(testoFile[y][i].ToString()) == 1))    //controlla che siano tutti 0 o 1
                        {
                            MessageBox.Show("Caratteri non validi", "Errore");
                            return;
                        }
                        if(testoFile.Length != testoFile[y].Length)
                        {
                            MessageBox.Show("La griglia deve avere lo stesso numero di righe e lo stesso numero di colonne", "Errore");
                            return;
                        }
                        grigliaCustom[i, y] = int.Parse(testoFile[y][i].ToString());
                    }


                int nBombe = 0;
                for (int i = 0; i < testoFile.Length; i++)  //calcola il numero di bombe
                    for (int j = 0; j < testoFile.Length; j++)
                        if (grigliaCustom[i, j] == 1)
                        {
                            nBombe++;
                            grigliaCustom[i, j] = 9;
                        }

                for (int i = panello.Controls.Count - 1; i >= 0; i--)
                    panello.Controls.RemoveAt(i); // cancella Griglia precedente

                Griglia gr = new Griglia(testoFile.Length, nBombe, panello, nbombeLbl, lblFinePartita, grigliaCustom);
                lblFinePartita.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            importaGriglia();
        }

        private void x9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selezionaCreaGriglia(0);
        }

        private void x12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selezionaCreaGriglia(1);
        }

        private void x16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selezionaCreaGriglia(2);
        }

        private void x16HardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selezionaCreaGriglia(3);
        }

        private void importaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importaGriglia();
        }

    }
}
