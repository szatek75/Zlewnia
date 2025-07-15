namespace Zlewnia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rozpocznij = new System.Windows.Forms.Button();
            this.btn_zakoncz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_kierowca = new System.Windows.Forms.ComboBox();
            this.comboBox_pojazd = new System.Windows.Forms.ComboBox();
            this.btn_kierowca = new System.Windows.Forms.Button();
            this.btn_klient = new System.Windows.Forms.Button();
            this.btn_wykresy = new System.Windows.Forms.Button();
            this.btn_raport = new System.Windows.Forms.Button();
            this.comboBox_klient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_pojazd = new System.Windows.Forms.Button();
            this.btn_odswiez = new System.Windows.Forms.Button();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(252, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBSŁUGA ZLEWNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(199, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Rozpoczęcia:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_rozpocznij
            // 
            this.btn_rozpocznij.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rozpocznij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_rozpocznij.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rozpocznij.FlatAppearance.BorderSize = 2;
            this.btn_rozpocznij.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_rozpocznij.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_rozpocznij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rozpocznij.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_rozpocznij.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rozpocznij.Location = new System.Drawing.Point(178, 426);
            this.btn_rozpocznij.Name = "btn_rozpocznij";
            this.btn_rozpocznij.Size = new System.Drawing.Size(178, 45);
            this.btn_rozpocznij.TabIndex = 2;
            this.btn_rozpocznij.Text = "ROZPOCZNIJ";
            this.btn_rozpocznij.UseVisualStyleBackColor = false;
            this.btn_rozpocznij.Click += new System.EventHandler(this.btn_rozpocznij_Click);
            // 
            // btn_zakoncz
            // 
            this.btn_zakoncz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_zakoncz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_zakoncz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_zakoncz.FlatAppearance.BorderSize = 2;
            this.btn_zakoncz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_zakoncz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_zakoncz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zakoncz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zakoncz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_zakoncz.Location = new System.Drawing.Point(499, 426);
            this.btn_zakoncz.Name = "btn_zakoncz";
            this.btn_zakoncz.Size = new System.Drawing.Size(178, 45);
            this.btn_zakoncz.TabIndex = 5;
            this.btn_zakoncz.Text = "ZAKOŃCZ";
            this.btn_zakoncz.UseVisualStyleBackColor = false;
            this.btn_zakoncz.Click += new System.EventHandler(this.btn_zakoncz_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(288, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kierowca:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(320, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pojazd:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_kierowca
            // 
            this.comboBox_kierowca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_kierowca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_kierowca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_kierowca.DropDownHeight = 200;
            this.comboBox_kierowca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_kierowca.FormattingEnabled = true;
            this.comboBox_kierowca.IntegralHeight = false;
            this.comboBox_kierowca.Items.AddRange(new object[] {
            "HENIEK",
            "STASIEK",
            "MARCIN",
            "MARIAN",
            "JUREK",
            "ELA"});
            this.comboBox_kierowca.Location = new System.Drawing.Point(431, 218);
            this.comboBox_kierowca.Name = "comboBox_kierowca";
            this.comboBox_kierowca.Size = new System.Drawing.Size(246, 32);
            this.comboBox_kierowca.TabIndex = 11;
            // 
            // comboBox_pojazd
            // 
            this.comboBox_pojazd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_pojazd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_pojazd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_pojazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_pojazd.FormattingEnabled = true;
            this.comboBox_pojazd.Items.AddRange(new object[] {
            "rower",
            "traktor",
            "plecy barbary",
            "taczka",
            "daf"});
            this.comboBox_pojazd.Location = new System.Drawing.Point(431, 265);
            this.comboBox_pojazd.Name = "comboBox_pojazd";
            this.comboBox_pojazd.Size = new System.Drawing.Size(246, 32);
            this.comboBox_pojazd.TabIndex = 12;
            // 
            // btn_kierowca
            // 
            this.btn_kierowca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_kierowca.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_kierowca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kierowca.FlatAppearance.BorderSize = 2;
            this.btn_kierowca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_kierowca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_kierowca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kierowca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kierowca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kierowca.Location = new System.Drawing.Point(12, 12);
            this.btn_kierowca.Name = "btn_kierowca";
            this.btn_kierowca.Size = new System.Drawing.Size(142, 52);
            this.btn_kierowca.TabIndex = 13;
            this.btn_kierowca.Text = "DODAJ KIEROWCĘ";
            this.btn_kierowca.UseVisualStyleBackColor = false;
            this.btn_kierowca.Click += new System.EventHandler(this.btn_kierowca_Click);
            // 
            // btn_klient
            // 
            this.btn_klient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_klient.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_klient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_klient.FlatAppearance.BorderSize = 2;
            this.btn_klient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_klient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_klient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_klient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_klient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_klient.Location = new System.Drawing.Point(160, 12);
            this.btn_klient.Name = "btn_klient";
            this.btn_klient.Size = new System.Drawing.Size(132, 52);
            this.btn_klient.TabIndex = 14;
            this.btn_klient.Text = "DODAJ KLIENTA";
            this.btn_klient.UseVisualStyleBackColor = false;
            this.btn_klient.Click += new System.EventHandler(this.btn_klient_Click);
            // 
            // btn_wykresy
            // 
            this.btn_wykresy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_wykresy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_wykresy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_wykresy.FlatAppearance.BorderSize = 2;
            this.btn_wykresy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_wykresy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_wykresy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_wykresy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wykresy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_wykresy.Location = new System.Drawing.Point(436, 12);
            this.btn_wykresy.Name = "btn_wykresy";
            this.btn_wykresy.Size = new System.Drawing.Size(132, 52);
            this.btn_wykresy.TabIndex = 15;
            this.btn_wykresy.Text = "WYKRESY";
            this.btn_wykresy.UseVisualStyleBackColor = false;
            this.btn_wykresy.Click += new System.EventHandler(this.btn_wykresy_Click);
            // 
            // btn_raport
            // 
            this.btn_raport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_raport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_raport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_raport.FlatAppearance.BorderSize = 2;
            this.btn_raport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_raport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_raport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_raport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_raport.Location = new System.Drawing.Point(574, 12);
            this.btn_raport.Name = "btn_raport";
            this.btn_raport.Size = new System.Drawing.Size(132, 52);
            this.btn_raport.TabIndex = 16;
            this.btn_raport.Text = "RAPORT PDF";
            this.btn_raport.UseVisualStyleBackColor = false;
            this.btn_raport.Click += new System.EventHandler(this.btn_raport_Click);
            // 
            // comboBox_klient
            // 
            this.comboBox_klient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_klient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_klient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_klient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_klient.FormattingEnabled = true;
            this.comboBox_klient.Items.AddRange(new object[] {
            "ELA MARCINIAK",
            "BOGDAN DUT",
            "MICHAL OLSZEWSKI",
            "BEZDOMNI Z OKOLICY",
            "ROBERT POZYCZKA",
            "KRZYZANOWSKI DAREK",
            "SZABOWSKI DAWID"});
            this.comboBox_klient.Location = new System.Drawing.Point(431, 312);
            this.comboBox_klient.Name = "comboBox_klient";
            this.comboBox_klient.Size = new System.Drawing.Size(246, 32);
            this.comboBox_klient.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(327, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Klient:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_pojazd
            // 
            this.btn_pojazd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_pojazd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_pojazd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pojazd.FlatAppearance.BorderSize = 2;
            this.btn_pojazd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_pojazd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_pojazd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pojazd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pojazd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_pojazd.Location = new System.Drawing.Point(298, 12);
            this.btn_pojazd.Name = "btn_pojazd";
            this.btn_pojazd.Size = new System.Drawing.Size(132, 52);
            this.btn_pojazd.TabIndex = 20;
            this.btn_pojazd.Text = "DODAJ POJAZD";
            this.btn_pojazd.UseVisualStyleBackColor = false;
            this.btn_pojazd.Click += new System.EventHandler(this.btn_pojazd_Click);
            // 
            // btn_odswiez
            // 
            this.btn_odswiez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_odswiez.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_odswiez.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_odswiez.FlatAppearance.BorderSize = 2;
            this.btn_odswiez.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_odswiez.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_odswiez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_odswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_odswiez.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_odswiez.Location = new System.Drawing.Point(431, 362);
            this.btn_odswiez.Name = "btn_odswiez";
            this.btn_odswiez.Size = new System.Drawing.Size(107, 33);
            this.btn_odswiez.TabIndex = 21;
            this.btn_odswiez.Text = "ODŚWIEŻ";
            this.btn_odswiez.UseVisualStyleBackColor = false;
            this.btn_odswiez.Click += new System.EventHandler(this.btn_odswiez_Click);
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOd.CustomFormat = "HH:mm dd.MM.yyyy";
            this.dateTimePickerOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOd.Location = new System.Drawing.Point(431, 168);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.Size = new System.Drawing.Size(246, 35);
            this.dateTimePickerOd.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(607, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 447);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btn_odswiez);
            this.Controls.Add(this.btn_pojazd);
            this.Controls.Add(this.comboBox_klient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_raport);
            this.Controls.Add(this.btn_wykresy);
            this.Controls.Add(this.btn_klient);
            this.Controls.Add(this.btn_kierowca);
            this.Controls.Add(this.comboBox_pojazd);
            this.Controls.Add(this.comboBox_kierowca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_zakoncz);
            this.Controls.Add(this.btn_rozpocznij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerOd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marex Zlewnia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rozpocznij;
        private System.Windows.Forms.Button btn_zakoncz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_kierowca;
        private System.Windows.Forms.ComboBox comboBox_pojazd;
        private System.Windows.Forms.Button btn_kierowca;
        private System.Windows.Forms.Button btn_klient;
        private System.Windows.Forms.Button btn_wykresy;
        private System.Windows.Forms.Button btn_raport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_klient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_pojazd;
        private System.Windows.Forms.Button btn_odswiez;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
    }
}

