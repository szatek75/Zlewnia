namespace Zlewnia
{
    partial class Wykresy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wykresy));
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOd_wykres = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_klient_wykres = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_pojazd_wykres = new System.Windows.Forms.ComboBox();
            this.comboBox_kierowca_wykres = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDo_wykres = new System.Windows.Forms.DateTimePicker();
            this.btn_generuj_wykres = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(92, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Od:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerOd_wykres
            // 
            this.dateTimePickerOd_wykres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOd_wykres.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOd_wykres.CustomFormat = "HH:mm dd.MM.yyyy";
            this.dateTimePickerOd_wykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOd_wykres.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOd_wykres.Location = new System.Drawing.Point(220, 122);
            this.dateTimePickerOd_wykres.Name = "dateTimePickerOd_wykres";
            this.dateTimePickerOd_wykres.Size = new System.Drawing.Size(246, 35);
            this.dateTimePickerOd_wykres.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "WYGENERUJ WYKRES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_klient_wykres
            // 
            this.comboBox_klient_wykres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_klient_wykres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_klient_wykres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_klient_wykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_klient_wykres.FormattingEnabled = true;
            this.comboBox_klient_wykres.Location = new System.Drawing.Point(220, 295);
            this.comboBox_klient_wykres.Name = "comboBox_klient_wykres";
            this.comboBox_klient_wykres.Size = new System.Drawing.Size(246, 32);
            this.comboBox_klient_wykres.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(116, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 24;
            this.label6.Text = "Klient:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_pojazd_wykres
            // 
            this.comboBox_pojazd_wykres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_pojazd_wykres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_pojazd_wykres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_pojazd_wykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_pojazd_wykres.FormattingEnabled = true;
            this.comboBox_pojazd_wykres.Location = new System.Drawing.Point(220, 253);
            this.comboBox_pojazd_wykres.Name = "comboBox_pojazd_wykres";
            this.comboBox_pojazd_wykres.Size = new System.Drawing.Size(246, 32);
            this.comboBox_pojazd_wykres.TabIndex = 23;
            // 
            // comboBox_kierowca_wykres
            // 
            this.comboBox_kierowca_wykres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_kierowca_wykres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_kierowca_wykres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_kierowca_wykres.DropDownHeight = 200;
            this.comboBox_kierowca_wykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_kierowca_wykres.FormattingEnabled = true;
            this.comboBox_kierowca_wykres.IntegralHeight = false;
            this.comboBox_kierowca_wykres.Location = new System.Drawing.Point(220, 210);
            this.comboBox_kierowca_wykres.Name = "comboBox_kierowca_wykres";
            this.comboBox_kierowca_wykres.Size = new System.Drawing.Size(246, 32);
            this.comboBox_kierowca_wykres.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(109, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pojazd:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(77, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kierowca:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(92, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data Do:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerDo_wykres
            // 
            this.dateTimePickerDo_wykres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDo_wykres.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDo_wykres.CustomFormat = "HH:mm dd.MM.yyyy";
            this.dateTimePickerDo_wykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDo_wykres.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDo_wykres.Location = new System.Drawing.Point(220, 166);
            this.dateTimePickerDo_wykres.Name = "dateTimePickerDo_wykres";
            this.dateTimePickerDo_wykres.Size = new System.Drawing.Size(246, 35);
            this.dateTimePickerDo_wykres.TabIndex = 26;
            // 
            // btn_generuj_wykres
            // 
            this.btn_generuj_wykres.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_generuj_wykres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_generuj_wykres.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_generuj_wykres.FlatAppearance.BorderSize = 2;
            this.btn_generuj_wykres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_generuj_wykres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_generuj_wykres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generuj_wykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_generuj_wykres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_generuj_wykres.Location = new System.Drawing.Point(0, 404);
            this.btn_generuj_wykres.Name = "btn_generuj_wykres";
            this.btn_generuj_wykres.Size = new System.Drawing.Size(800, 46);
            this.btn_generuj_wykres.TabIndex = 28;
            this.btn_generuj_wykres.Text = "GENERUJ";
            this.btn_generuj_wykres.UseVisualStyleBackColor = false;
            this.btn_generuj_wykres.Click += new System.EventHandler(this.btn_generuj_wykres_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 272);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Wykresy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_generuj_wykres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDo_wykres);
            this.Controls.Add(this.comboBox_klient_wykres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_pojazd_wykres);
            this.Controls.Add(this.comboBox_kierowca_wykres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerOd_wykres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wykresy";
            this.Text = "Wykresy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd_wykres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_klient_wykres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_pojazd_wykres;
        private System.Windows.Forms.ComboBox comboBox_kierowca_wykres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo_wykres;
        private System.Windows.Forms.Button btn_generuj_wykres;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}