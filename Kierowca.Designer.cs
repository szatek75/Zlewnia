namespace Zlewnia
{
    partial class Kierowca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kierowca));
            this.btn_zapisz_kierowce = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kierowca = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zapisz_kierowce
            // 
            this.btn_zapisz_kierowce.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_zapisz_kierowce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_zapisz_kierowce.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_zapisz_kierowce.FlatAppearance.BorderSize = 2;
            this.btn_zapisz_kierowce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_zapisz_kierowce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_zapisz_kierowce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zapisz_kierowce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zapisz_kierowce.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_zapisz_kierowce.Location = new System.Drawing.Point(0, 398);
            this.btn_zapisz_kierowce.Name = "btn_zapisz_kierowce";
            this.btn_zapisz_kierowce.Size = new System.Drawing.Size(800, 52);
            this.btn_zapisz_kierowce.TabIndex = 15;
            this.btn_zapisz_kierowce.Text = "ZAPISZ";
            this.btn_zapisz_kierowce.UseVisualStyleBackColor = false;
            this.btn_zapisz_kierowce.Click += new System.EventHandler(this.btn_zapisz_kierowce_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(326, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Podaj dane kierowcy:\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_kierowca
            // 
            this.textBox_kierowca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_kierowca.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kierowca.Location = new System.Drawing.Point(333, 222);
            this.textBox_kierowca.Name = "textBox_kierowca";
            this.textBox_kierowca.Size = new System.Drawing.Size(325, 40);
            this.textBox_kierowca.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 447);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Kierowca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_kierowca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_zapisz_kierowce);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kierowca";
            this.Text = "Dodawanie Kierowcy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zapisz_kierowce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kierowca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}