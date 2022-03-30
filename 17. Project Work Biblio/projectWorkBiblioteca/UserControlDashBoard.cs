using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWorkBiblioteca
{
    public partial class UserControlDashBoard : UserControl
    {
        GestioneDati g;
        public UserControlDashBoard(GestioneDati g)
        {
            InitializeComponent();

            this.g = g;

            dataGridViewDashboard.AutoGenerateColumns = false;
            ColumnTitolo.DataPropertyName = "Titolo";
            ColumnISBN.DataPropertyName = "ISBN";
            ColumnAutori.DataPropertyName = "Autori";
            ColumnCategorie.DataPropertyName = "Categorie";
            ColumnAnno.DataPropertyName = "Anno";
            ColumnRating.DataPropertyName = "Media";
            ColumnQta.DataPropertyName = "Quantita";
        }
        public void BindDashboard()
        {
            dataGridViewDashboard.DataSource = null;
            dataGridViewDashboard.DataSource = g.Books.Values.ToList();
        }

        private void comboBoxRicerca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = (sender as ComboBox).Text;

            if (text == "Quantità") text = "Quantita";

            var dataOrdered = from book in dataGridViewDashboard.DataSource as List<Libro>
                              orderby (book.GetType().GetProperty(text).GetValue(book, null) as string) ascending
                              select book;

            dataGridViewDashboard.DataSource = null;
            dataGridViewDashboard.DataSource = dataOrdered.ToList();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dataGridViewDashboard.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            //Aggiunta degli headers
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dataGridViewDashboard.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //Aggiunta delle righe contenenti i dati
            foreach (DataGridViewRow row in dataGridViewDashboard.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(pdftable);
                    pdfDocument.Close();
                    stream.Close();
                }
            }
        }
    }
}
