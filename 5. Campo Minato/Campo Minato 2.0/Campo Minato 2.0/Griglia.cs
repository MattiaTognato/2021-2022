using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Campo_Minato_2._0
{
    public class Griglia
    {
        public Panel panello;
        public Label bombeUpDown;
        public Label lblFinePartita;
        public int[,] matriceValori;
        public Cella[,] matriceCelle;
        public int cellePerLato;
        public int nBombe;
        public bool custom = false;
        public bool gameOver = false;
        public Griglia(int cellePerLato, int nBombe, Panel p, Label c, Label l)
        {
            panello = p;
            bombeUpDown = c;
            lblFinePartita = l;
            bombeUpDown.Text = nBombe.ToString();
            matriceCelle = new Cella[cellePerLato, cellePerLato];
            this.cellePerLato = cellePerLato;
            this.nBombe = nBombe;
            for (int i = 0; i < cellePerLato; i++)//crea le celle e dice cosa fare al click delle celle
            {
                for (int j = 0; j < cellePerLato; j++)
                {
                    matriceCelle[i, j] = new Cella(i, j);
                    int a = i, b = j;
                    matriceCelle[i, j].Pic.Click += delegate (object sender, EventArgs e) { gestioneClick(sender, e, a, b); };
                }
            }
            foreach (var item in matriceCelle)  //aggiunge le picture box alle celle
            {
                panello.Controls.Add(item.Pic);
            }

        }
        public Griglia(int cellePerLato, int nBombe, Panel p, Label c, Label l, int[,] grigliaCustom)
        {
            custom = true;
            matriceValori = grigliaCustom;
            panello = p;
            bombeUpDown = c;
            lblFinePartita = l;
            bombeUpDown.Text = nBombe.ToString();
            matriceCelle = new Cella[cellePerLato, cellePerLato];
            this.cellePerLato = cellePerLato;
            this.nBombe = nBombe;
            for (int i = 0; i < cellePerLato; i++)//crea le celle e dice cosa fare al click delle celle
            {
                for (int j = 0; j < cellePerLato; j++)
                {
                    matriceCelle[i, j] = new Cella(i, j);
                    int a = i, b = j;
                    matriceCelle[i, j].Pic.Click += delegate (object sender, EventArgs e) { gestioneClick(sender, e, a, b); };
                }
            }
            foreach (var item in matriceCelle)  // aggiunge le picture box alle celle
            {
                panello.Controls.Add(item.Pic);
            }
            for (int i = 0; i < cellePerLato; i++)
                for (int j = 0; j < cellePerLato; j++)
                    if (matriceValori[i, j] != 9)
                        matriceValori[i, j] = contaBombe(ref i, ref j); //mette i numeri

        }

        void gestioneClick(object sender, EventArgs e, int y, int x)
        {
            if (gameOver)   //se il gioco è finito non fare niente
                return;

            PictureBox item = (PictureBox)sender;

            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Right && !matriceCelle[y, x].visto)   //al click del tasto destro toglie e mette la bandierina
            {
                if(matriceCelle[y, x].bandierina)
                {
                    matriceCelle[y, x].bandierina = false;
                    item.Image = Properties.Resources.minesweeper_00;
                    bombeUpDown.Text = (Convert.ToInt32(bombeUpDown.Text) + 1).ToString();
                }
                else
                {
                    matriceCelle[y, x].bandierina = true;
                    item.Image = Properties.Resources.minesweeper_02;
                    bombeUpDown.Text = (Convert.ToInt32(bombeUpDown.Text) - 1).ToString();
                }
                
            }
            else if (me.Button == MouseButtons.Left)//al click del tasto sinistro
            {
                if (matriceValori == null) //se l'array non è ancora stato creato
                {
                    Random rnd = new Random();
                    do
                    {
                        matriceValori = new int[cellePerLato, cellePerLato];

                        for (int i = 0; i < nBombe; i++)//generazione bombe
                        {
                            int tmpY = rnd.Next(0, cellePerLato);
                            int tmpX = rnd.Next(0, cellePerLato);
                            if (matriceValori[tmpY, tmpX] != 9)
                                matriceValori[tmpY, tmpX] = 9;
                            else
                                i--;
                        }

                        for (int i = 0; i < cellePerLato; i++)
                            for (int j = 0; j < cellePerLato; j++)
                                if (matriceValori[i, j] != 9)
                                    matriceValori[i, j] = contaBombe(ref i, ref j); //mette i numeri

                    } while (matriceValori[y, x] != 0);
                }

                if (matriceCelle[y, x].bandierina)//togli bandierina se c'è una bandierina
                {
                    matriceCelle[y, x].bandierina = false;
                    item.Image = Properties.Resources.minesweeper_00;
                    bombeUpDown.Text = (Convert.ToInt32(bombeUpDown.Text) + 1).ToString();
                }
                else if (matriceValori[y, x] == 9)//game over
                {
                    matriceCelle[y, x].visto = true;
                    item.Image = Properties.Resources.minesweeper_06;
                    gameOver = true;
                    lblFinePartita.Text = "GAME OVER";
                    lblFinePartita.Visible = true;
                    for (int i = 0; i < cellePerLato; i++)
                        for (int j = 0; j < cellePerLato; j++)
                            if (matriceValori[j, i] == 9 && !matriceCelle[j, i].bandierina && !matriceCelle[j, i].visto)
                                matriceCelle[j, i].Pic.Image = Properties.Resources.minesweeper_05;
                }
                else
                {
                    scopri(x, y);   //funzione ricorsiva che scopre tutte le celle vuote adiacenti
                }
            }
            if (isWin())
            {
                gameOver = true;
                lblFinePartita.Text = "YOU WIN";
                lblFinePartita.Visible = true;
            }
        }
        int contaBombe(ref int y, ref int x)// calcola il numero di bombe adiacenti nelle 8 direzioni
        {
            int counterBombe = 0;

            if(x > 0 && y > 0 && matriceValori[y - 1, x - 1] == 9)  //up sx
                counterBombe++;
            if (x > 0 && matriceValori[y, x - 1] == 9)  //up
                counterBombe++;
            if (x > 0 && y < cellePerLato - 1 && matriceValori[y + 1, x - 1] == 9)  //up dx
                counterBombe++;
            if (y < cellePerLato - 1 && matriceValori[y + 1, x] == 9) //dx
                counterBombe++;
            if (x < cellePerLato - 1 && y < cellePerLato - 1 && matriceValori[y + 1, x + 1] == 9)//dw dx
                counterBombe++;
            if (x < cellePerLato - 1 && matriceValori[y, x + 1] == 9)//dw
                counterBombe++;
            if (x < cellePerLato - 1 && y > 0 && matriceValori[y - 1, x + 1] == 9)//dw sx
                counterBombe++;
            if (y > 0 && matriceValori[y - 1, x] == 9)// sx
                counterBombe++;

            return counterBombe;
        }
        void cambiaImg(int x, int y)
        {
            int valoreCella = matriceValori[y, x];
            switch (valoreCella)
            {
                case 0:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_01;
                    matriceCelle[y, x].visto = true;
                    break;
                case 1:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_08;
                    matriceCelle[y, x].visto = true;
                    break;
                case 2:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_09;
                    matriceCelle[y, x].visto = true;
                    break;
                case 3:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_10;
                    matriceCelle[y, x].visto = true;
                    break;
                case 4:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_11;
                    matriceCelle[y, x].visto = true;
                    break;
                case 5:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_12;
                    matriceCelle[y, x].visto = true;
                    break;
                case 6:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_13;
                    matriceCelle[y, x].visto = true;
                    break;
                case 7:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_14;
                    matriceCelle[y, x].visto = true;
                    break;
                case 8:
                    matriceCelle[y, x].Pic.Image = Properties.Resources.minesweeper_15;
                    matriceCelle[y, x].visto = true;
                    break;
            }
        }
        void scopri(int x, int y)
        {
            cambiaImg(x, y);
            if (matriceValori[y, x] != 0)
                return;

            if (x > 0 && !matriceCelle[y, x - 1].visto && matriceValori[y, x - 1] != 9 && !matriceCelle[y, x - 1].bandierina)  //sopra
                controlloNumeroPerScoprire(x - 1, y);
            
            if (x < cellePerLato - 1 && !matriceCelle[y, x + 1].visto && matriceValori[y, x + 1] != 9 && !matriceCelle[y, x + 1].bandierina) //sotto
                controlloNumeroPerScoprire(x + 1, y);
            
            if (y < cellePerLato - 1 && !matriceCelle[y + 1, x].visto && matriceValori[y + 1, x] != 9 && !matriceCelle[y + 1, x].bandierina)  //destra
                controlloNumeroPerScoprire(x, y + 1);
            
            if (y > 0 && !matriceCelle[y - 1, x].visto && matriceValori[y - 1, x] != 9 && !matriceCelle[y - 1, x].bandierina) // sinistra
                controlloNumeroPerScoprire(x, y - 1);
            
            if (x > 0 && y > 0 && !matriceCelle[y - 1, x - 1].visto && matriceValori[y - 1, x - 1] != 9 && !matriceCelle[y - 1, x - 1].bandierina)  //up sx
                controlloNumeroPerScoprire(x - 1, y - 1);
            
            if (x > 0 && y < cellePerLato - 1 && !matriceCelle[y + 1, x - 1].visto && matriceValori[y + 1, x - 1] != 9 && !matriceCelle[y + 1, x - 1].bandierina)  //up dx
                controlloNumeroPerScoprire(x - 1, y + 1);

            if (x < cellePerLato - 1 && y < cellePerLato - 1 && !matriceCelle[y + 1, x + 1].visto && matriceValori[y + 1, x + 1] != 9 && !matriceCelle[y + 1, x + 1].bandierina)//dw dx
                controlloNumeroPerScoprire(x + 1, y + 1);

            if (x < cellePerLato - 1 && y > 0 && !matriceCelle[y - 1, x + 1].visto && matriceValori[y - 1, x + 1] != 9 && !matriceCelle[y - 1, x + 1].bandierina)//dw sx
                controlloNumeroPerScoprire(x + 1, y - 1);

        }
        void controlloNumeroPerScoprire(int x, int y)
        {
            matriceCelle[y, x].visto = true;

            if (matriceValori[y, x] == 0)
            {
                scopri(x, y);
            }
            else
            {
                cambiaImg(x, y);
            }
        }

        bool isWin()
        {
            if (Convert.ToInt32(bombeUpDown.Text) != 0)
                return false;
            for (int y = 0; y < cellePerLato; y++)
                for (int x = 0; x < cellePerLato; x++)// se tutte le bombe sono contrassegnate dalla bandierina la partità è vinta
                {
                    if(matriceValori[y, x] != 9 && !matriceCelle[y, x].visto)
                        return false;
                    if (matriceValori[y, x] == 9 && !matriceCelle[y, x].bandierina)
                        return false;
                }
                    
            return true;
        }
    }
}
