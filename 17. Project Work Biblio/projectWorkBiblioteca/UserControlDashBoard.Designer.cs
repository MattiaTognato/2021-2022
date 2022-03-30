namespace projectWorkBiblioteca
{
    partial class UserControlDashBoard
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
            this.dataGridViewDashboard = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOrdina = new System.Windows.Forms.ComboBox();
            this.ColumnTitolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDashboard = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDashboard
            // 
            this.dataGridViewDashboard.AllowUserToAddRows = false;
            this.dataGridViewDashboard.AllowUserToDeleteRows = false;
            this.dataGridViewDashboard.AllowUserToResizeRows = false;
            this.dataGridViewDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitolo,
            this.ColumnISBN,
            this.ColumnAutori,
            this.ColumnCategorie,
            this.ColumnAnno,
            this.ColumnRating,
            this.ColumnQta});
            this.dataGridViewDashboard.Location = new System.Drawing.Point(7, 78);
            this.dataGridViewDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDashboard.MultiSelect = false;
            this.dataGridViewDashboard.Name = "dataGridViewDashboard";
            this.dataGridViewDashboard.ReadOnly = true;
            this.dataGridViewDashboard.RowHeadersVisible = false;
            this.dataGridViewDashboard.RowHeadersWidth = 51;
            this.dataGridViewDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDashboard.Size = new System.Drawing.Size(918, 524);
            this.dataGridViewDashboard.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ordina per";
            // 
            // comboBoxOrdina
            // 
            this.comboBoxOrdina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdina.FormattingEnabled = true;
            this.comboBoxOrdina.Items.AddRange(new object[] {
            "Titolo",
            "ISBN",
            "Autori",
            "Categorie",
            "Anno"});
            this.comboBoxOrdina.Location = new System.Drawing.Point(149, 31);
            this.comboBoxOrdina.Name = "comboBoxOrdina";
            this.comboBoxOrdina.Size = new System.Drawing.Size(229, 28);
            this.comboBoxOrdina.TabIndex = 12;
            this.comboBoxOrdina.SelectedIndexChanged += new System.EventHandler(this.comboBoxRicerca_SelectedIndexChanged);
            // 
            // ColumnTitolo
            // 
            this.ColumnTitolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTitolo.HeaderText = "Titolo";
            this.ColumnTitolo.MinimumWidth = 6;
            this.ColumnTitolo.Name = "ColumnTitolo";
            this.ColumnTitolo.ReadOnly = true;
            // 
            // ColumnISBN
            // 
            this.ColumnISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnISBN.HeaderText = "ISBN";
            this.ColumnISBN.MinimumWidth = 6;
            this.ColumnISBN.Name = "ColumnISBN";
            this.ColumnISBN.ReadOnly = true;
            // 
            // ColumnAutori
            // 
            this.ColumnAutori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAutori.HeaderText = "Autori";
            this.ColumnAutori.MinimumWidth = 6;
            this.ColumnAutori.Name = "ColumnAutori";
            this.ColumnAutori.ReadOnly = true;
            // 
            // ColumnCategorie
            // 
            this.ColumnCategorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCategorie.HeaderText = "Categorie";
            this.ColumnCategorie.MinimumWidth = 6;
            this.ColumnCategorie.Name = "ColumnCategorie";
            this.ColumnCategorie.ReadOnly = true;
            // 
            // ColumnAnno
            // 
            this.ColumnAnno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAnno.HeaderText = "Anno";
            this.ColumnAnno.MinimumWidth = 6;
            this.ColumnAnno.Name = "ColumnAnno";
            this.ColumnAnno.ReadOnly = true;
            // 
            // ColumnRating
            // 
            this.ColumnRating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRating.HeaderText = "Rating";
            this.ColumnRating.MinimumWidth = 6;
            this.ColumnRating.Name = "ColumnRating";
            this.ColumnRating.ReadOnly = true;
            // 
            // ColumnQta
            // 
            this.ColumnQta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnQta.HeaderText = "Qta";
            this.ColumnQta.MinimumWidth = 6;
            this.ColumnQta.Name = "ColumnQta";
            this.ColumnQta.ReadOnly = true;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.IconChar = FontAwesome.Sharp.IconChar.File;
            this.buttonDashboard.IconColor = System.Drawing.Color.Black;
            this.buttonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(724, 16);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(176, 54);
            this.buttonDashboard.TabIndex = 13;
            this.buttonDashboard.Text = "Export pdf";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // UserControlDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(178)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.comboBoxOrdina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewDashboard);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlDashBoard";
            this.Size = new System.Drawing.Size(929, 710);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDashboard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOrdina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutori;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQta;
        private FontAwesome.Sharp.IconButton buttonDashboard;
    }
}
