namespace projectWorkBiblioteca
{
    partial class UserControlGestioneLibri
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPagine = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNVoti = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMedia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQta = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTitolo = new System.Windows.Forms.TextBox();
            this.textBoxAutori = new System.Windows.Forms.TextBox();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAnno = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxCategorie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxSottotitolo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAllowEdit = new System.Windows.Forms.CheckBox();
            this.buttonSaveEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNVoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(5, 149);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(595, 524);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPagine);
            this.groupBox1.Controls.Add(this.numericUpDownNVoti);
            this.groupBox1.Controls.Add(this.numericUpDownMedia);
            this.groupBox1.Controls.Add(this.numericUpDownQta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxTitolo);
            this.groupBox1.Controls.Add(this.textBoxAutori);
            this.groupBox1.Controls.Add(this.textBoxDescrizione);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBoxAnno);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxURL);
            this.groupBox1.Controls.Add(this.textBoxCategorie);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxSottotitolo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(607, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 658);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci Libro";
            // 
            // numericUpDownPagine
            // 
            this.numericUpDownPagine.Location = new System.Drawing.Point(153, 575);
            this.numericUpDownPagine.Name = "numericUpDownPagine";
            this.numericUpDownPagine.Size = new System.Drawing.Size(53, 26);
            this.numericUpDownPagine.TabIndex = 7;
            // 
            // numericUpDownNVoti
            // 
            this.numericUpDownNVoti.Location = new System.Drawing.Point(198, 526);
            this.numericUpDownNVoti.Name = "numericUpDownNVoti";
            this.numericUpDownNVoti.Size = new System.Drawing.Size(53, 26);
            this.numericUpDownNVoti.TabIndex = 7;
            // 
            // numericUpDownMedia
            // 
            this.numericUpDownMedia.Location = new System.Drawing.Point(115, 526);
            this.numericUpDownMedia.Name = "numericUpDownMedia";
            this.numericUpDownMedia.Size = new System.Drawing.Size(53, 26);
            this.numericUpDownMedia.TabIndex = 7;
            // 
            // numericUpDownQta
            // 
            this.numericUpDownQta.Location = new System.Drawing.Point(45, 526);
            this.numericUpDownQta.Name = "numericUpDownQta";
            this.numericUpDownQta.Size = new System.Drawing.Size(30, 26);
            this.numericUpDownQta.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Inserisci Libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTitolo
            // 
            this.textBoxTitolo.Location = new System.Drawing.Point(23, 52);
            this.textBoxTitolo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitolo.Name = "textBoxTitolo";
            this.textBoxTitolo.Size = new System.Drawing.Size(263, 26);
            this.textBoxTitolo.TabIndex = 1;
            // 
            // textBoxAutori
            // 
            this.textBoxAutori.Location = new System.Drawing.Point(23, 296);
            this.textBoxAutori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAutori.Name = "textBoxAutori";
            this.textBoxAutori.Size = new System.Drawing.Size(258, 26);
            this.textBoxAutori.TabIndex = 1;
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(24, 236);
            this.textBoxDescrizione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(258, 26);
            this.textBoxDescrizione.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 83);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Sottotitolo";
            // 
            // textBoxAnno
            // 
            this.textBoxAnno.Location = new System.Drawing.Point(23, 357);
            this.textBoxAnno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAnno.Name = "textBoxAnno";
            this.textBoxAnno.Size = new System.Drawing.Size(258, 26);
            this.textBoxAnno.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Titolo";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(24, 477);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(259, 26);
            this.textBoxURL.TabIndex = 1;
            // 
            // textBoxCategorie
            // 
            this.textBoxCategorie.Location = new System.Drawing.Point(24, 417);
            this.textBoxCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCategorie.Name = "textBoxCategorie";
            this.textBoxCategorie.Size = new System.Drawing.Size(259, 26);
            this.textBoxCategorie.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 147);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "ISBN";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(23, 176);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(263, 26);
            this.textBoxISBN.TabIndex = 1;
            // 
            // textBoxSottotitolo
            // 
            this.textBoxSottotitolo.Location = new System.Drawing.Point(23, 111);
            this.textBoxSottotitolo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSottotitolo.Name = "textBoxSottotitolo";
            this.textBoxSottotitolo.Size = new System.Drawing.Size(263, 26);
            this.textBoxSottotitolo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 207);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Descrizione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 577);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero Pagine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 503);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Voti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Autori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 503);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Media";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 503);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantità";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "URL Immagine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 388);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Categorie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Anno";
            // 
            // checkBoxAllowEdit
            // 
            this.checkBoxAllowEdit.AutoSize = true;
            this.checkBoxAllowEdit.Location = new System.Drawing.Point(23, 46);
            this.checkBoxAllowEdit.Name = "checkBoxAllowEdit";
            this.checkBoxAllowEdit.Size = new System.Drawing.Size(143, 24);
            this.checkBoxAllowEdit.TabIndex = 6;
            this.checkBoxAllowEdit.Text = "Abilita Modifica";
            this.checkBoxAllowEdit.UseVisualStyleBackColor = true;
            this.checkBoxAllowEdit.CheckedChanged += new System.EventHandler(this.checkBoxAllowEdit_CheckedChanged);
            // 
            // buttonSaveEdit
            // 
            this.buttonSaveEdit.Location = new System.Drawing.Point(172, 33);
            this.buttonSaveEdit.Name = "buttonSaveEdit";
            this.buttonSaveEdit.Size = new System.Drawing.Size(138, 41);
            this.buttonSaveEdit.TabIndex = 7;
            this.buttonSaveEdit.Text = "salva";
            this.buttonSaveEdit.UseVisualStyleBackColor = true;
            this.buttonSaveEdit.Click += new System.EventHandler(this.buttonSaveEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonElimina);
            this.groupBox2.Controls.Add(this.checkBoxAllowEdit);
            this.groupBox2.Controls.Add(this.buttonSaveEdit);
            this.groupBox2.Location = new System.Drawing.Point(4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifica/Rimouvi Libri";
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(316, 33);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(118, 41);
            this.buttonElimina.TabIndex = 8;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.Location = new System.Drawing.Point(483, 15);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(117, 90);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBook.TabIndex = 9;
            this.pictureBoxBook.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ricerca per ISBN o Titolo: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserControlGestioneLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(178)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBoxBook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlGestioneLibri";
            this.Size = new System.Drawing.Size(929, 710);
            this.Load += new System.EventHandler(this.UserControlGestioneLibri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNVoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTitolo;
        private System.Windows.Forms.TextBox textBoxAutori;
        private System.Windows.Forms.TextBox textBoxDescrizione;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAnno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxCategorie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxSottotitolo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAllowEdit;
        private System.Windows.Forms.Button buttonSaveEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.NumericUpDown numericUpDownPagine;
        private System.Windows.Forms.NumericUpDown numericUpDownNVoti;
        private System.Windows.Forms.NumericUpDown numericUpDownMedia;
        private System.Windows.Forms.NumericUpDown numericUpDownQta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}
