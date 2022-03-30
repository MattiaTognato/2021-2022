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
    public partial class UserControlStelle : UserControl
    {
        PictureBox[] pictureBoxes;
        public int Value { get; set; }

        public UserControlStelle()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[5];
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;

            Value = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            coloraStelle(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            coloraStelle(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            coloraStelle(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            coloraStelle(3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            coloraStelle(4);
        }
        public void coloraStelle(int n)
        {
            Value = n+1;
            for(int i = 0; i <= n; i++)
                pictureBoxes[i].Image = Properties.Resources.star;
            for(int i = n+1; i < 5; i++)
                pictureBoxes[i].Image = Properties.Resources.empty_star;
        }
    }
}
