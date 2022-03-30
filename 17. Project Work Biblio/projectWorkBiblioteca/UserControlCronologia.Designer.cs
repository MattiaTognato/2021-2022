namespace projectWorkBiblioteca
{
    partial class UserControlCronologia
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
            this.dataGridViewCronologia = new System.Windows.Forms.DataGridView();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCronologia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCronologia
            // 
            this.dataGridViewCronologia.AllowUserToAddRows = false;
            this.dataGridViewCronologia.AllowUserToDeleteRows = false;
            this.dataGridViewCronologia.AllowUserToResizeRows = false;
            this.dataGridViewCronologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCronologia.Location = new System.Drawing.Point(4, 190);
            this.dataGridViewCronologia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCronologia.MultiSelect = false;
            this.dataGridViewCronologia.Name = "dataGridViewCronologia";
            this.dataGridViewCronologia.ReadOnly = true;
            this.dataGridViewCronologia.RowHeadersVisible = false;
            this.dataGridViewCronologia.RowHeadersWidth = 51;
            this.dataGridViewCronologia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCronologia.Size = new System.Drawing.Size(918, 485);
            this.dataGridViewCronologia.TabIndex = 0;
            this.dataGridViewCronologia.SelectionChanged += new System.EventHandler(this.dataGridViewCronologia_SelectionChanged);
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.Location = new System.Drawing.Point(377, 33);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(163, 149);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBook.TabIndex = 10;
            this.pictureBoxBook.TabStop = false;
            // 
            // UserControlCronologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(178)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.pictureBoxBook);
            this.Controls.Add(this.dataGridViewCronologia);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlCronologia";
            this.Size = new System.Drawing.Size(929, 710);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCronologia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCronologia;
        private System.Windows.Forms.PictureBox pictureBoxBook;
    }
}
