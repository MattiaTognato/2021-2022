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
    public partial class UserControlCronologia : UserControl
    {
        User UserLogged;
        public UserControlCronologia(User userLogged)
        {
            InitializeComponent();

            this.UserLogged = userLogged;
            
            BindUserHistory();
        }
        public void BindUserHistory()
        {
            dataGridViewCronologia.DataSource = null;
            dataGridViewCronologia.DataSource = UserLogged.HistoryLibri;
        }
        private void dataGridViewCronologia_SelectionChanged(object sender, EventArgs e)
        {
            //prendo il libro corrispondente alla selezione
            var selectedRow = dataGridViewCronologia.CurrentRow;

            if (selectedRow == null) return;

            string img = selectedRow.Cells["Immagine"].Value.ToString();

            //provo a visualizzare l'immagine
            try
            {
                pictureBoxBook.Load(img);
            }
            catch (Exception)
            {
                //immagine non trovata unlucky
            }
        }
    }
}
