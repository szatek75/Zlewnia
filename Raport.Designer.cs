namespace Zlewnia
{
    partial class Raport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raport));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDo_raport = new System.Windows.Forms.DateTimePicker();
            this.comboBox_klient_raport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_pojazd_raport = new System.Windows.Forms.ComboBox();
            this.comboBox_kierowca_raport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOd_raport = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_generuj_raport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(362, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 33);
            this.label3.TabIndex = 40;
            this.label3.Text = "Data Do:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerDo_raport
            // 
            this.dateTimePickerDo_raport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDo_raport.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDo_raport.CustomFormat = "HH:mm dd.MM.yyyy";
            this.dateTimePickerDo_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDo_raport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDo_raport.Location = new System.Drawing.Point(490, 188);
            this.dateTimePickerDo_raport.Name = "dateTimePickerDo_raport";
            this.dateTimePickerDo_raport.Size = new System.Drawing.Size(246, 35);
            this.dateTimePickerDo_raport.TabIndex = 39;
            // 
            // comboBox_klient_raport
            // 
            this.comboBox_klient_raport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_klient_raport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_klient_raport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_klient_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_klient_raport.FormattingEnabled = true;
            this.comboBox_klient_raport.Location = new System.Drawing.Point(490, 317);
            this.comboBox_klient_raport.Name = "comboBox_klient_raport";
            this.comboBox_klient_raport.Size = new System.Drawing.Size(246, 32);
            this.comboBox_klient_raport.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(386, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 37;
            this.label6.Text = "Klient:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_pojazd_raport
            // 
            this.comboBox_pojazd_raport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_pojazd_raport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_pojazd_raport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_pojazd_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_pojazd_raport.FormattingEnabled = true;
            this.comboBox_pojazd_raport.Location = new System.Drawing.Point(490, 275);
            this.comboBox_pojazd_raport.Name = "comboBox_pojazd_raport";
            this.comboBox_pojazd_raport.Size = new System.Drawing.Size(246, 32);
            this.comboBox_pojazd_raport.TabIndex = 36;
            // 
            // comboBox_kierowca_raport
            // 
            this.comboBox_kierowca_raport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_kierowca_raport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_kierowca_raport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_kierowca_raport.DropDownHeight = 200;
            this.comboBox_kierowca_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_kierowca_raport.FormattingEnabled = true;
            this.comboBox_kierowca_raport.IntegralHeight = false;
            this.comboBox_kierowca_raport.Location = new System.Drawing.Point(490, 232);
            this.comboBox_kierowca_raport.Name = "comboBox_kierowca_raport";
            this.comboBox_kierowca_raport.Size = new System.Drawing.Size(246, 32);
            this.comboBox_kierowca_raport.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(379, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "Pojazd:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(347, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 33);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kierowca:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(362, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Data Od:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerOd_raport
            // 
            this.dateTimePickerOd_raport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOd_raport.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOd_raport.CustomFormat = "HH:mm dd.MM.yyyy";
            this.dateTimePickerOd_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOd_raport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOd_raport.Location = new System.Drawing.Point(490, 144);
            this.dateTimePickerOd_raport.Name = "dateTimePickerOd_raport";
            this.dateTimePickerOd_raport.Size = new System.Drawing.Size(246, 35);
            this.dateTimePickerOd_raport.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(330, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "WYGENERUJ RAPORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 272);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btn_generuj_raport
            // 
            this.btn_generuj_raport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_generuj_raport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_generuj_raport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_generuj_raport.FlatAppearance.BorderSize = 2;
            this.btn_generuj_raport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_generuj_raport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_generuj_raport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generuj_raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_generuj_raport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_generuj_raport.Location = new System.Drawing.Point(0, 404);
            this.btn_generuj_raport.Name = "btn_generuj_raport";
            this.btn_generuj_raport.Size = new System.Drawing.Size(800, 46);
            this.btn_generuj_raport.TabIndex = 42;
            this.btn_generuj_raport.Text = "GENERUJ";
            this.btn_generuj_raport.UseVisualStyleBackColor = false;
            this.btn_generuj_raport.Click += new System.EventHandler(this.btn_generuj_raport_Click_1);
            // 
            // Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_generuj_raport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDo_raport);
            this.Controls.Add(this.comboBox_klient_raport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_pojazd_raport);
            this.Controls.Add(this.comboBox_kierowca_raport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerOd_raport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raport";
            this.Text = "Raport";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo_raport;
        private System.Windows.Forms.ComboBox comboBox_klient_raport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_pojazd_raport;
        private System.Windows.Forms.ComboBox comboBox_kierowca_raport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd_raport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_generuj_raport;
    }
}