
namespace binding2
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
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeClone = new System.Windows.Forms.TextBox();
            this.NomeGenere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaGeneri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cantanti = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeArte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nazionalitaText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(95, 339);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(100, 20);
            this.nomeTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nome";
            // 
            // nomeClone
            // 
            this.nomeClone.Location = new System.Drawing.Point(95, 365);
            this.nomeClone.Name = "nomeClone";
            this.nomeClone.Size = new System.Drawing.Size(100, 20);
            this.nomeClone.TabIndex = 0;
            // 
            // NomeGenere
            // 
            this.NomeGenere.Location = new System.Drawing.Point(120, 68);
            this.NomeGenere.Name = "NomeGenere";
            this.NomeGenere.Size = new System.Drawing.Size(100, 20);
            this.NomeGenere.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genere Musicale";
            // 
            // ListaGeneri
            // 
            this.ListaGeneri.FormattingEnabled = true;
            this.ListaGeneri.Location = new System.Drawing.Point(120, 41);
            this.ListaGeneri.Name = "ListaGeneri";
            this.ListaGeneri.Size = new System.Drawing.Size(121, 21);
            this.ListaGeneri.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome genere";
            // 
            // Cantanti
            // 
            this.Cantanti.FormattingEnabled = true;
            this.Cantanti.Location = new System.Drawing.Point(120, 128);
            this.Cantanti.Name = "Cantanti";
            this.Cantanti.Size = new System.Drawing.Size(121, 21);
            this.Cantanti.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantanti";
            // 
            // nomeArte
            // 
            this.nomeArte.Location = new System.Drawing.Point(120, 155);
            this.nomeArte.Name = "nomeArte";
            this.nomeArte.Size = new System.Drawing.Size(100, 20);
            this.nomeArte.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pseudonimo";
            // 
            // nazionalitaText
            // 
            this.nazionalitaText.Location = new System.Drawing.Point(120, 182);
            this.nazionalitaText.Name = "nazionalitaText";
            this.nazionalitaText.Size = new System.Drawing.Size(100, 20);
            this.nazionalitaText.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nazionalità";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(282, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(294, 344);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Cantanti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaGeneri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazionalitaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeArte);
            this.Controls.Add(this.NomeGenere);
            this.Controls.Add(this.nomeClone);
            this.Controls.Add(this.nomeTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeClone;
        private System.Windows.Forms.TextBox NomeGenere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ListaGeneri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cantanti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeArte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nazionalitaText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

