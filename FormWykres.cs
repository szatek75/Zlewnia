using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Zlewnia
{
    public partial class FormWykres : Form
    {
        // Konstruktor formularza wykresu
        public FormWykres(List<Tuple<DateTime, double, double, DateTime, string, string, string>> chartData)
        {
            InitializeComponent();

            // Usuwamy stare serie wykresu
            chartWykres.Series.Clear();

            if (chartData.Count == 0)
            {
                MessageBox.Show("Brak danych do wykresu.");
                return;  // Jeśli brak danych, kończymy konstruktor
            }

            // Tworzymy serię dla 'Ilość'
            Series seriesIlosc = new Series
            {
                Name = "Ilość",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Column, // Typ wykresu: pionowy słupkowy
                BorderWidth = 3 // Grubość krawędzi słupków
            };

            // Tworzymy serię dla 'pH'
            Series seriesPh = new Series
            {
                Name = "pH",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Column, // Typ wykresu: pionowy słupkowy
                BorderWidth = 3 // Grubość krawędzi słupków
            };

            // Dodajemy punkty do obu serii oraz do ListView1
            foreach (var data in chartData)
            {
                // Teraz data.Item1 (data) będzie na osi X, a Item2 (ilość) oraz Item3 (pH) na osi Y
                seriesIlosc.Points.AddXY(data.Item1, Math.Round(data.Item2, 2)); // Zaokrąglona Ilość
                seriesPh.Points.AddXY(data.Item1, Math.Round(data.Item3, 2)); // Zaokrąglone pH

                // Dodajemy dane do ListView1
                ListViewItem item = new ListViewItem(data.Item1.ToString("dd/MM/yyyy HH:mm")); // Start - Data rozpoczęcia
                item.SubItems.Add(data.Item4.ToString("dd/MM/yyyy HH:mm")); // Koniec - Data zakończenia
                item.SubItems.Add(data.Item5); // Klient
                item.SubItems.Add(data.Item6); // Pojazd
                item.SubItems.Add(data.Item7); // Kierowca
                item.SubItems.Add(Math.Round(data.Item2, 2).ToString()); // Ilość
                item.SubItems.Add(Math.Round(data.Item3, 2).ToString()); // pH

                listView1.Items.Add(item);

            }

            // Dodanie serii do wykresu
            chartWykres.Series.Add(seriesIlosc);
            chartWykres.Series.Add(seriesPh);

            chartWykres.ChartAreas[0].AxisY.LabelStyle.Format = "0.0";

            // Dynamiczne dopasowanie zakresu osi Y
            double minY = chartData.Min(x => Math.Min(x.Item2, x.Item3)) > 0 ? chartData.Min(x => Math.Min(x.Item2, x.Item3)) - 1 : 0;
            double maxY = chartData.Max(x => Math.Max(x.Item2, x.Item3)) + 1;

            // Zaokrąglamy minY i maxY do najbliższej liczby 0.5
            minY = Math.Floor(minY * 2) / 2;
            maxY = Math.Ceiling(maxY * 2) / 2;

            // Ustawienie zakresu osi Y
            chartWykres.ChartAreas[0].AxisY.Minimum = minY;
            chartWykres.ChartAreas[0].AxisY.Maximum = maxY;

            // Ustawienie tytułów osi
            chartWykres.ChartAreas[0].AxisX.Title = "Czas";
            chartWykres.ChartAreas[0].AxisY.Title = "Wartość";

            // Zwiększanie czcionki dla tytułów osi
            chartWykres.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            chartWykres.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);

            // Formatowanie osi X (daty)
            chartWykres.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy HH:mm";
        }

    }
}
