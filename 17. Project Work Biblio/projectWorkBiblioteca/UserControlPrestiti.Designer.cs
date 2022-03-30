namespace projectWorkBiblioteca
{
    partial class UserControlPrestiti
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
            this.dataGridViewPrestiti = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stelleLibro = new projectWorkBiblioteca.UserControlStelle();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReclamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestiti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrestiti
            // 
            this.dataGridViewPrestiti.AllowUserToAddRows = false;
            this.dataGridViewPrestiti.AllowUserToDeleteRows = false;
            this.dataGridViewPrestiti.AllowUserToResizeRows = false;
            this.dataGridViewPrestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestiti.Location = new System.Drawing.Point(7, 5);
            this.dataGridViewPrestiti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPrestiti.MultiSelect = false;
            this.dataGridViewPrestiti.Name = "dataGridViewPrestiti";
            this.dataGridViewPrestiti.ReadOnly = true;
            this.dataGridViewPrestiti.RowHeadersVisible = false;
            this.dataGridViewPrestiti.RowHeadersWidth = 51;
            this.dataGridViewPrestiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrestiti.Size = new System.Drawing.Size(619, 562);
            this.dataGridViewPrestiti.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stelleLibro);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(633, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 196);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestito";
            // 
            // stelleLibro
            // 
            this.stelleLibro.Location = new System.Drawing.Point(7, 72);
            this.stelleLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stelleLibro.Name = "stelleLibro";
            this.stelleLibro.Size = new System.Drawing.Size(285, 54);
            this.stelleLibro.TabIndex = 11;
            this.stelleLibro.Value = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Restituisci libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReclamo
            // 
            this.buttonReclamo.Location = new System.Drawing.Point(633, 217);
            this.buttonReclamo.Name = "buttonReclamo";
            this.buttonReclamo.Size = new System.Drawing.Size(292, 46);
            this.buttonReclamo.TabIndex = 14;
            this.buttonReclamo.Text = "Manda email di reclamo";
            this.buttonReclamo.UseVisualStyleBackColor = true;
            this.buttonReclamo.Visible = false;
            this.buttonReclamo.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControlPrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(178)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.buttonReclamo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewPrestiti);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlPrestiti";
            this.Size = new System.Drawing.Size(929, 710);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestiti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPrestiti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private UserControlStelle stelleLibro;
        private System.Windows.Forms.Button buttonReclamo;
    }
}
