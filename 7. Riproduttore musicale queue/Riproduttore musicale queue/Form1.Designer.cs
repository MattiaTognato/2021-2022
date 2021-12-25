
namespace Riproduttore_musicale_queue
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
            this.PlaylistDataGridView = new System.Windows.Forms.DataGridView();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.AddToQueueBtn = new System.Windows.Forms.Button();
            this.PlayCodaBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaylistDataGridView
            // 
            this.PlaylistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaylistDataGridView.Location = new System.Drawing.Point(14, 14);
            this.PlaylistDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.PlaylistDataGridView.Name = "PlaylistDataGridView";
            this.PlaylistDataGridView.Size = new System.Drawing.Size(248, 259);
            this.PlaylistDataGridView.TabIndex = 0;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(272, 181);
            this.PlayerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(178, 21);
            this.PlayerLabel.TabIndex = 1;
            this.PlayerLabel.Text = "Niente in riproduzione";
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Location = new System.Drawing.Point(460, 14);
            this.PlayerDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.Size = new System.Drawing.Size(252, 259);
            this.PlayerDataGridView.TabIndex = 0;
            // 
            // AddToQueueBtn
            // 
            this.AddToQueueBtn.Location = new System.Drawing.Point(307, 12);
            this.AddToQueueBtn.Name = "AddToQueueBtn";
            this.AddToQueueBtn.Size = new System.Drawing.Size(100, 92);
            this.AddToQueueBtn.TabIndex = 2;
            this.AddToQueueBtn.Text = "Aggiungi alla coda";
            this.AddToQueueBtn.UseVisualStyleBackColor = true;
            this.AddToQueueBtn.Click += new System.EventHandler(this.AddToQueueBtn_Click);
            // 
            // PlayCodaBtn
            // 
            this.PlayCodaBtn.Location = new System.Drawing.Point(307, 110);
            this.PlayCodaBtn.Name = "PlayCodaBtn";
            this.PlayCodaBtn.Size = new System.Drawing.Size(99, 68);
            this.PlayCodaBtn.TabIndex = 3;
            this.PlayCodaBtn.Text = "Play Coda";
            this.PlayCodaBtn.UseVisualStyleBackColor = true;
            this.PlayCodaBtn.Click += new System.EventHandler(this.PlayCodaBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(307, 205);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(99, 35);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(307, 246);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(99, 27);
            this.Skip.TabIndex = 5;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 283);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PlayCodaBtn);
            this.Controls.Add(this.AddToQueueBtn);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.PlayerDataGridView);
            this.Controls.Add(this.PlaylistDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlaylistDataGridView;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private System.Windows.Forms.Button AddToQueueBtn;
        private System.Windows.Forms.Button PlayCodaBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button Skip;
    }
}

