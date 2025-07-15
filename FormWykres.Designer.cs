namespace Zlewnia
{
    partial class FormWykres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWykres));
            this.chartWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Koniec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Klient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pojazd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kierowca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.chartWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWykres
            // 
            this.chartWykres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartWykres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chartWykres.BackImageTransparentColor = System.Drawing.Color.Gainsboro;
            this.chartWykres.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chartWykres.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            legend1.Name = "Legend1";
            this.chartWykres.Legends.Add(legend1);
            this.chartWykres.Location = new System.Drawing.Point(-7, -1);
            this.chartWykres.Name = "chartWykres";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWykres.Series.Add(series1);
            this.chartWykres.Size = new System.Drawing.Size(1918, 822);
            this.chartWykres.TabIndex = 0;
            this.chartWykres.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Start,
            this.Koniec,
            this.Klient,
            this.Pojazd,
            this.Kierowca,
            this.Ilosc,
            this.PH});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-7, 799);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1920, 254);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Start
            // 
            this.Start.Text = "Start";
            this.Start.Width = 300;
            // 
            // Koniec
            // 
            this.Koniec.Text = "Koniec";
            this.Koniec.Width = 300;
            // 
            // Klient
            // 
            this.Klient.Text = "Klient";
            this.Klient.Width = 300;
            // 
            // Pojazd
            // 
            this.Pojazd.Text = "Pojazd";
            this.Pojazd.Width = 300;
            // 
            // Kierowca
            // 
            this.Kierowca.Text = "Kierowca";
            this.Kierowca.Width = 300;
            // 
            // Ilosc
            // 
            this.Ilosc.Text = "Ilość";
            this.Ilosc.Width = 210;
            // 
            // PH
            // 
            this.PH.Text = "PH";
            this.PH.Width = 210;
            // 
            // FormWykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chartWykres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWykres";
            this.Text = "Wykres";
            ((System.ComponentModel.ISupportInitialize)(this.chartWykres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartWykres;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Start;
        private System.Windows.Forms.ColumnHeader Koniec;
        private System.Windows.Forms.ColumnHeader Klient;
        private System.Windows.Forms.ColumnHeader Pojazd;
        private System.Windows.Forms.ColumnHeader Kierowca;
        private System.Windows.Forms.ColumnHeader Ilosc;
        private System.Windows.Forms.ColumnHeader PH;
    }
}