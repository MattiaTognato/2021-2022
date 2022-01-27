using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Campo_Minato_2._0
{
    public class Cella
    {
        private PictureBox _pic;
        public int X;
        public int Y;
        public bool visto = false;
        public bool bandierina = false;
        
        public Cella(int x, int y)
        {   
            X = x;
            Y = y;
            _pic = new PictureBox()
            {
                Image = Properties.Resources.minesweeper_00,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(x * 33, y * 33),
                Size = new Size(32, 32),
            };
            
        }
        public PictureBox Pic
        {
            get => _pic;
        }
    }
}

