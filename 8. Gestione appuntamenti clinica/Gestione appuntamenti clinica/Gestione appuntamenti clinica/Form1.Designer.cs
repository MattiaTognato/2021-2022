namespace Gestione_appuntamenti_clinica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MedicoPicker = new System.Windows.Forms.ComboBox();
            this.PazientePicker = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AppuntamentiDgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pazientiDgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MediciDgv = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PatologieDgv = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SpecializzazioniDgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppuntamentiDgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pazientiDgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediciDgv)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatologieDgv)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecializzazioniDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.AppuntamentiDgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appuntamenti";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.MedicoPicker);
            this.groupBox1.Controls.Add(this.PazientePicker);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtra Griglia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 72);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(269, 91);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(269, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(269, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MedicoPicker
            // 
            this.MedicoPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedicoPicker.Enabled = false;
            this.MedicoPicker.FormattingEnabled = true;
            this.MedicoPicker.Location = new System.Drawing.Point(63, 87);
            this.MedicoPicker.Name = "MedicoPicker";
            this.MedicoPicker.Size = new System.Drawing.Size(200, 23);
            this.MedicoPicker.Sorted = true;
            this.MedicoPicker.TabIndex = 2;
            // 
            // PazientePicker
            // 
            this.PazientePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PazientePicker.Enabled = false;
            this.PazientePicker.FormattingEnabled = true;
            this.PazientePicker.Location = new System.Drawing.Point(63, 59);
            this.PazientePicker.Name = "PazientePicker";
            this.PazientePicker.Size = new System.Drawing.Size(200, 23);
            this.PazientePicker.Sorted = true;
            this.PazientePicker.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(63, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Paziente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // AppuntamentiDgv
            // 
            this.AppuntamentiDgv.AllowUserToAddRows = false;
            this.AppuntamentiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppuntamentiDgv.Location = new System.Drawing.Point(6, 133);
            this.AppuntamentiDgv.Name = "AppuntamentiDgv";
            this.AppuntamentiDgv.ReadOnly = true;
            this.AppuntamentiDgv.RowTemplate.Height = 25;
            this.AppuntamentiDgv.Size = new System.Drawing.Size(784, 391);
            this.AppuntamentiDgv.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pazientiDgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(796, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pazienti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pazientiDgv
            // 
            this.pazientiDgv.AllowUserToAddRows = false;
            this.pazientiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pazientiDgv.Location = new System.Drawing.Point(4, 3);
            this.pazientiDgv.Name = "pazientiDgv";
            this.pazientiDgv.ReadOnly = true;
            this.pazientiDgv.RowTemplate.Height = 25;
            this.pazientiDgv.Size = new System.Drawing.Size(789, 535);
            this.pazientiDgv.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MediciDgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(796, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Medici";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MediciDgv
            // 
            this.MediciDgv.AllowUserToAddRows = false;
            this.MediciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MediciDgv.Location = new System.Drawing.Point(4, 3);
            this.MediciDgv.Name = "MediciDgv";
            this.MediciDgv.ReadOnly = true;
            this.MediciDgv.RowTemplate.Height = 25;
            this.MediciDgv.Size = new System.Drawing.Size(789, 535);
            this.MediciDgv.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.PatologieDgv);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(796, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patologie";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PatologieDgv
            // 
            this.PatologieDgv.AllowUserToAddRows = false;
            this.PatologieDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatologieDgv.Location = new System.Drawing.Point(6, 6);
            this.PatologieDgv.Name = "PatologieDgv";
            this.PatologieDgv.ReadOnly = true;
            this.PatologieDgv.RowTemplate.Height = 25;
            this.PatologieDgv.Size = new System.Drawing.Size(784, 535);
            this.PatologieDgv.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.SpecializzazioniDgv);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(796, 530);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Specializzazioni";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // SpecializzazioniDgv
            // 
            this.SpecializzazioniDgv.AllowUserToAddRows = false;
            this.SpecializzazioniDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecializzazioniDgv.Location = new System.Drawing.Point(3, 3);
            this.SpecializzazioniDgv.Name = "SpecializzazioniDgv";
            this.SpecializzazioniDgv.ReadOnly = true;
            this.SpecializzazioniDgv.RowTemplate.Height = 25;
            this.SpecializzazioniDgv.Size = new System.Drawing.Size(790, 524);
            this.SpecializzazioniDgv.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 574);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestione appuntamenti clinica";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppuntamentiDgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pazientiDgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediciDgv)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatologieDgv)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpecializzazioniDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView pazientiDgv;
        private DataGridView MediciDgv;
        private DataGridView PatologieDgv;
        private DataGridView SpecializzazioniDgv;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox MedicoPicker;
        private ComboBox PazientePicker;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView AppuntamentiDgv;
    }
}