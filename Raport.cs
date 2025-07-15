using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Zlewnia
{
    public partial class Raport : Form
    {
        public Raport(object[] kierowcaItems, object[] pojazdItems, object[] klientItems)
        {
            InitializeComponent();

            comboBox_kierowca_raport.Items.AddRange(kierowcaItems);
            comboBox_pojazd_raport.Items.AddRange(pojazdItems);
            comboBox_klient_raport.Items.AddRange(klientItems);

            UstawDomyslneGodziny();
        }

        private void btn_generuj_raport_Click_1(object sender, EventArgs e)
        {
            string selectedKierowca = comboBox_kierowca_raport.SelectedItem?.ToString();
            string selectedPojazd = comboBox_pojazd_raport.SelectedItem?.ToString();
            string selectedKlient = comboBox_klient_raport.SelectedItem?.ToString();

            DateTime startDate = dateTimePickerOd_raport.Value;
            DateTime endDate = dateTimePickerDo_raport.Value;

            string query = @"SELECT Datastartu, datakonca, klient, kierowca, pojazd, ilosc, ph
                             FROM zlewnia
                             WHERE Datastartu >= @startDate
                             AND datakonca <= @endDate";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrEmpty(selectedKlient))
            {
                query += " AND klient = @klient";
                parameters.Add(new SQLiteParameter("@klient", selectedKlient));
            }
            if (!string.IsNullOrEmpty(selectedKierowca))
            {
                query += " AND kierowca = @kierowca";
                parameters.Add(new SQLiteParameter("@kierowca", selectedKierowca));
            }
            if (!string.IsNullOrEmpty(selectedPojazd))
            {
                query += " AND pojazd = @pojazd";
                parameters.Add(new SQLiteParameter("@pojazd", selectedPojazd));
            }

            string dbPath = @"C:\ZlewniaMarex\Zlewnia.db";
            List<Tuple<DateTime, double, double, DateTime, string, string, string>> reportData = new List<Tuple<DateTime, double, double, DateTime, string, string, string>>();

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DateTime datastartu = Convert.ToDateTime(reader["Datastartu"]);
                                double ilosc = Convert.ToDouble(reader["ilosc"]);
                                double ph = Convert.ToDouble(reader["ph"]);
                                DateTime dataKonca = Convert.ToDateTime(reader["DataKonca"]);
                                string klient = reader["Klient"].ToString();
                                string pojazd = reader["Pojazd"].ToString();
                                string kierowca = reader["Kierowca"].ToString();

                                reportData.Add(new Tuple<DateTime, double, double, DateTime, string, string, string>(
                                    datastartu, ilosc, ph, dataKonca, klient, pojazd, kierowca));
                            }

                            // Tworzymy raport PDF
                            GenerujRaportPDF(reportData);
                        }
                        else
                        {
                            MessageBox.Show("Brak wyników dla podanych kryteriów.", "Brak danych");
                        }
                    }
                }
            }
        }

        private void GenerujRaportPDF(List<Tuple<DateTime, double, double, DateTime, string, string, string>> dane)
        {
            try
            {
                // Ścieżka folderu, w którym zapisujemy raport
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string raportyFolderPath = Path.Combine(desktopPath, "Zlewnia");

                if (!Directory.Exists(raportyFolderPath))
                {
                    Directory.CreateDirectory(raportyFolderPath);
                }

                // Pobieramy listę istniejących raportów z tego samego dnia
                string datePart = DateTime.Now.ToString("yyyyMMdd");
                var existingFiles = Directory.GetFiles(raportyFolderPath, $"{datePart}*.pdf");

                // Numer raportu (jeśli istnieją już raporty tego dnia, to zwiększamy numer)
                int reportNumber = existingFiles.Length + 1;

                // Tworzymy nazwę pliku raportu z numerem
                string pdfFileName = $"{datePart}_Raport_{reportNumber}.pdf";
                string pdfPath = Path.Combine(raportyFolderPath, pdfFileName);

                // Tworzymy nowy dokument PDF w rozmiarze A4
                Document doc = new Document(PageSize.A4);

                string fontPath = @"C:\Windows\Fonts\arial.ttf"; // Można zmienić na inną czcionkę, jeśli trzeba

                // Ładujemy czcionkę
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, 12); // Rozmiar czcionki

                // Tworzymy PdfWriter, który będzie zapisywał dokument do pliku
                using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open(); // Otwieramy dokument do dodawania treści

                    // Dodajemy nagłówek raportu
                    doc.Add(new Paragraph("Raport Zlewnia", font));
                    doc.Add(new Paragraph($"Data wygenerowania: {DateTime.Now:dd/MM/yyyy HH:mm}\n\n", font));

                    // Tworzymy tabelę z 7 kolumnami
                    PdfPTable table = new PdfPTable(7);
                    table.WidthPercentage = 100; // Ustawiamy szerokość tabeli na 100%
                    table.SetWidths(new float[] { 1.6f, 1.6f, 2.6f, 1.6f, 1.6f, 1.5f, 1.5f }); // Określamy szerokości kolumn

                    // Dodajemy nagłówki tabeli
                    table.AddCell(new PdfPCell(new Phrase("Data Startu", font)));
                    table.AddCell(new PdfPCell(new Phrase("Data Końca", font)));
                    table.AddCell(new PdfPCell(new Phrase("Klient", font)));
                    table.AddCell(new PdfPCell(new Phrase("Pojazd", font)));
                    table.AddCell(new PdfPCell(new Phrase("Kierowca", font)));
                    table.AddCell(new PdfPCell(new Phrase("Ilość", font)));
                    table.AddCell(new PdfPCell(new Phrase("pH", font)));

                    // Wypełniamy tabelę danymi
                    foreach (var data in dane)
                    {
                        table.AddCell(new PdfPCell(new Phrase(data.Item1.ToString("dd/MM/yyyy HH:mm"), font))); // Data startu
                        table.AddCell(new PdfPCell(new Phrase(data.Item4.ToString("dd/MM/yyyy HH:mm"), font))); // Data końca
                        table.AddCell(new PdfPCell(new Phrase(data.Item5, font))); // Klient
                        table.AddCell(new PdfPCell(new Phrase(data.Item6, font))); // Pojazd
                        table.AddCell(new PdfPCell(new Phrase(data.Item7, font))); // Kierowca
                        table.AddCell(new PdfPCell(new Phrase(Math.Round(data.Item2, 2).ToString(), font))); // Ilość
                        table.AddCell(new PdfPCell(new Phrase(Math.Round(data.Item3, 2).ToString(), font))); // pH
                    }

                    // Dodajemy tabelę do dokumentu
                    doc.Add(table);
                    doc.Close(); // Zamykamy dokument

                    // Informujemy użytkownika o zapisaniu raportu
                    MessageBox.Show($"Raport został zapisany jako {pdfFileName}", "Sukces");
                }
            }
            catch (Exception ex)
            {
                // W razie błędu, wyświetlamy komunikat
                MessageBox.Show($"Błąd przy generowaniu raportu: {ex.Message}", "Błąd");
            }
        }

        private void UstawDomyslneGodziny()
        {
            // Ustawiamy godzinę 00:01 dla DateTimePickerOd
            DateTime defaultDateTimeOd = dateTimePickerOd_raport.Value.Date.AddMinutes(1);  // 00:01
            dateTimePickerOd_raport.Value = defaultDateTimeOd;

            // Ustawiamy godzinę 23:59 dla DateTimePickerDo
            DateTime defaultDateTimeDo = dateTimePickerDo_raport.Value.Date.AddHours(23).AddMinutes(59);  // 23:59
            dateTimePickerDo_raport.Value = defaultDateTimeDo;
        }
    }
}
