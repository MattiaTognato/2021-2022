namespace projectWorkBiblioteca
{
    partial class UserControlStore
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
            this.ColumnTitolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxRicerca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitolo,
            this.ColumnISBN,
            this.ColumnAutori,
            this.ColumnCategorie,
            this.ColumnAnno,
            this.ColumnRating,
            this.ColumnQta});
            this.dataGridViewBooks.Location = new System.Drawing.Point(7, 43);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(660, 524);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // ColumnTitolo
            // 
            this.ColumnTitolo.HeaderText = "Titolo";
            this.ColumnTitolo.MinimumWidth = 6;
            this.ColumnTitolo.Name = "ColumnTitolo";
            this.ColumnTitolo.ReadOnly = true;
            this.ColumnTitolo.Width = 125;
            // 
            // ColumnISBN
            // 
            this.ColumnISBN.HeaderText = "ISBN";
            this.ColumnISBN.MinimumWidth = 6;
            this.ColumnISBN.Name = "ColumnISBN";
            this.ColumnISBN.ReadOnly = true;
            this.ColumnISBN.Width = 125;
            // 
            // ColumnAutori
            // 
            this.ColumnAutori.HeaderText = "Autori";
            this.ColumnAutori.MinimumWidth = 6;
            this.ColumnAutori.Name = "ColumnAutori";
            this.ColumnAutori.ReadOnly = true;
            this.ColumnAutori.Width = 125;
            // 
            // ColumnCategorie
            // 
            this.ColumnCategorie.HeaderText = "Categorie";
            this.ColumnCategorie.MinimumWidth = 6;
            this.ColumnCategorie.Name = "ColumnCategorie";
            this.ColumnCategorie.ReadOnly = true;
            this.ColumnCategorie.Width = 125;
            // 
            // ColumnAnno
            // 
            this.ColumnAnno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnAnno.HeaderText = "Anno";
            this.ColumnAnno.MinimumWidth = 6;
            this.ColumnAnno.Name = "ColumnAnno";
            this.ColumnAnno.ReadOnly = true;
            this.ColumnAnno.Width = 90;
            // 
            // ColumnRating
            // 
            this.ColumnRating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnRating.HeaderText = "Rating";
            this.ColumnRating.MinimumWidth = 6;
            this.ColumnRating.Name = "ColumnRating";
            this.ColumnRating.ReadOnly = true;
            this.ColumnRating.Width = 99;
            // 
            // ColumnQta
            // 
            this.ColumnQta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnQta.HeaderText = "Qta";
            this.ColumnQta.MinimumWidth = 6;
            this.ColumnQta.Name = "ColumnQta";
            this.ColumnQta.ReadOnly = true;
            this.ColumnQta.Width = 76;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.Location = new System.Drawing.Point(17, 25);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(195, 176);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBook.TabIndex = 9;
            this.pictureBoxBook.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ricerca per";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 30);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxRicerca
            // 
            this.comboBoxRicerca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRicerca.FormattingEnabled = true;
            this.comboBoxRicerca.Items.AddRange(new object[] {
            "Titolo",
            "ISBN",
            "Autori",
            "Categorie",
            "Anno",
            "Rating",
            "Quantità"});
            this.comboBoxRicerca.Location = new System.Drawing.Point(104, 7);
            this.comboBoxRicerca.Name = "comboBoxRicerca";
            this.comboBoxRicerca.Size = new System.Drawing.Size(121, 30);
            this.comboBoxRicerca.TabIndex = 12;
            this.comboBoxRicerca.SelectedIndexChanged += new System.EventHandler(this.comboBoxRicerca_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBoxBook);
            this.groupBox1.Location = new System.Drawing.Point(674, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 271);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestito";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Richiedi in Prestito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(178)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxRicerca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewBooks);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlStore";
            this.Size = new System.Drawing.Size(929, 710);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxRicerca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutori;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQta;
    }
}
