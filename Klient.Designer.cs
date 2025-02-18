namespace Zlewnia
{
    partial class Klient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klient));
            this.btn_zapisz_klienta = new System.Windows.Forms.Button();
            this.textBox_klient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zapisz_klienta
            // 
            this.btn_zapisz_klienta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_zapisz_klienta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_zapisz_klienta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_zapisz_klienta.FlatAppearance.BorderSize = 2;
            this.btn_zapisz_klienta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_zapisz_klienta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_zapisz_klienta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zapisz_klienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zapisz_klienta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_zapisz_klienta.Location = new System.Drawing.Point(0, 398);
            this.btn_zapisz_klienta.Name = "btn_zapisz_klienta";
            this.btn_zapisz_klienta.Size = new System.Drawing.Size(800, 52);
            this.btn_zapisz_klienta.TabIndex = 14;
            this.btn_zapisz_klienta.Text = "ZAPISZ";
            this.btn_zapisz_klienta.UseVisualStyleBackColor = false;
            this.btn_zapisz_klienta.Click += new System.EventHandler(this.btn_zapisz_klienta_Click_1);
            // 
            // textBox_klient
            // 
            this.textBox_klient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_klient.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_klient.Location = new System.Drawing.Point(64, 222);
            this.textBox_klient.Name = "textBox_klient";
            this.textBox_klient.Size = new System.Drawing.Size(419, 40);
            this.textBox_klient.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 84);
            this.label2.TabIndex = 19;
            this.label2.Text = "Podaj dane Klienta:\r\n(W formacie Nazwisko Imię)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 447);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_klient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_zapisz_klienta);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Klient";
            this.Text = "Dodawanie Klienta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zapisz_klienta;
        private System.Windows.Forms.TextBox textBox_klient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}