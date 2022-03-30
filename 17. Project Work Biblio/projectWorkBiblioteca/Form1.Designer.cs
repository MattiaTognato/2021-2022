namespace projectWorkBiblioteca
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCronologia = new FontAwesome.Sharp.IconButton();
            this.buttonPrestiti = new FontAwesome.Sharp.IconButton();
            this.buttonStore = new FontAwesome.Sharp.IconButton();
            this.buttonDashboard = new FontAwesome.Sharp.IconButton();
            this.buttonGestioneLibri = new FontAwesome.Sharp.IconButton();
            this.panelActiveButton = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.buttonGestioneUtenti = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogout = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(137)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.buttonCronologia);
            this.panel1.Controls.Add(this.buttonPrestiti);
            this.panel1.Controls.Add(this.buttonStore);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.buttonGestioneLibri);
            this.panel1.Controls.Add(this.panelActiveButton);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.buttonGestioneUtenti);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 808);
            this.panel1.TabIndex = 0;
            // 
            // buttonCronologia
            // 
            this.buttonCronologia.FlatAppearance.BorderSize = 0;
            this.buttonCronologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCronologia.IconChar = FontAwesome.Sharp.IconChar.History;
            this.buttonCronologia.IconColor = System.Drawing.Color.Black;
            this.buttonCronologia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCronologia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCronologia.Location = new System.Drawing.Point(47, 330);
            this.buttonCronologia.Name = "buttonCronologia";
            this.buttonCronologia.Size = new System.Drawing.Size(199, 54);
            this.buttonCronologia.TabIndex = 3;
            this.buttonCronologia.Text = "Cronologia Prestiti";
            this.buttonCronologia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCronologia.UseVisualStyleBackColor = true;
            this.buttonCronologia.Visible = false;
            this.buttonCronologia.Click += new System.EventHandler(this.buttonCronologia_Click);
            // 
            // buttonPrestiti
            // 
            this.buttonPrestiti.FlatAppearance.BorderSize = 0;
            this.buttonPrestiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrestiti.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.buttonPrestiti.IconColor = System.Drawing.Color.Black;
            this.buttonPrestiti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonPrestiti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrestiti.Location = new System.Drawing.Point(47, 270);
            this.buttonPrestiti.Name = "buttonPrestiti";
            this.buttonPrestiti.Size = new System.Drawing.Size(176, 54);
            this.buttonPrestiti.TabIndex = 3;
            this.buttonPrestiti.Text = "Prestiti";
            this.buttonPrestiti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrestiti.UseVisualStyleBackColor = true;
            this.buttonPrestiti.Visible = false;
            this.buttonPrestiti.Click += new System.EventHandler(this.buttonPrestiti_Click);
            // 
            // buttonStore
            // 
            this.buttonStore.FlatAppearance.BorderSize = 0;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.buttonStore.IconColor = System.Drawing.Color.Black;
            this.buttonStore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStore.Location = new System.Drawing.Point(47, 210);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(176, 54);
            this.buttonStore.TabIndex = 3;
            this.buttonStore.Text = "Store";
            this.buttonStore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Visible = false;
            this.buttonStore.Click += new System.EventHandler(this.iconButtonStore_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.buttonDashboard.IconColor = System.Drawing.Color.Black;
            this.buttonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(47, 516);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(176, 54);
            this.buttonDashboard.TabIndex = 3;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Visible = false;
            this.buttonDashboard.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // buttonGestioneLibri
            // 
            this.buttonGestioneLibri.FlatAppearance.BorderSize = 0;
            this.buttonGestioneLibri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestioneLibri.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.buttonGestioneLibri.IconColor = System.Drawing.Color.Black;
            this.buttonGestioneLibri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGestioneLibri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestioneLibri.Location = new System.Drawing.Point(47, 456);
            this.buttonGestioneLibri.Name = "buttonGestioneLibri";
            this.buttonGestioneLibri.Size = new System.Drawing.Size(176, 54);
            this.buttonGestioneLibri.TabIndex = 3;
            this.buttonGestioneLibri.Text = "Gestione Libri";
            this.buttonGestioneLibri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGestioneLibri.UseVisualStyleBackColor = true;
            this.buttonGestioneLibri.Visible = false;
            this.buttonGestioneLibri.Click += new System.EventHandler(this.buttonGestioneLibri_Click);
            // 
            // panelActiveButton
            // 
            this.panelActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(177)))));
            this.panelActiveButton.Location = new System.Drawing.Point(31, 222);
            this.panelActiveButton.Name = "panelActiveButton";
            this.panelActiveButton.Size = new System.Drawing.Size(10, 42);
            this.panelActiveButton.TabIndex = 2;
            this.panelActiveButton.Visible = false;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(47, 396);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(176, 54);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Gestione Utenti";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Visible = false;
            this.iconButton2.Click += new System.EventHandler(this.buttonGestioneUtenti_Click);
            // 
            // buttonGestioneUtenti
            // 
            this.buttonGestioneUtenti.FlatAppearance.BorderSize = 0;
            this.buttonGestioneUtenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestioneUtenti.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.buttonGestioneUtenti.IconColor = System.Drawing.Color.Black;
            this.buttonGestioneUtenti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGestioneUtenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestioneUtenti.Location = new System.Drawing.Point(47, 396);
            this.buttonGestioneUtenti.Name = "buttonGestioneUtenti";
            this.buttonGestioneUtenti.Size = new System.Drawing.Size(176, 54);
            this.buttonGestioneUtenti.TabIndex = 1;
            this.buttonGestioneUtenti.Text = "Gestione Utenti";
            this.buttonGestioneUtenti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGestioneUtenti.UseVisualStyleBackColor = true;
            this.buttonGestioneUtenti.Visible = false;
            this.buttonGestioneUtenti.Click += new System.EventHandler(this.buttonGestioneUtenti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(104)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 106);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(252, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 702);
            this.panel3.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.buttonLogout.IconColor = System.Drawing.Color.Black;
            this.buttonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(720, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(176, 54);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 808);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1189, 847);
            this.MinimumSize = new System.Drawing.Size(1189, 847);
            this.Name = "Form1";
            this.Text = "Project Work Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton buttonGestioneUtenti;
        private System.Windows.Forms.Panel panelActiveButton;
        private FontAwesome.Sharp.IconButton buttonGestioneLibri;
        private FontAwesome.Sharp.IconButton buttonStore;
        private FontAwesome.Sharp.IconButton buttonPrestiti;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton buttonCronologia;
        private FontAwesome.Sharp.IconButton buttonDashboard;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton buttonLogout;
    }
}

