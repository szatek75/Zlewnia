using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Zlewnia
{
    public partial class Wykresy : Form
    {
        // Konstruktor przyjmujący dane z ComboBox
        public Wykresy(object[] kierowcaItems, object[] pojazdItems, object[] klientItems)
        {
            InitializeComponent();

            // Ustawiamy dane w ComboBox
            comboBox_kierowca_wykres.Items.AddRange(kierowcaItems);
            comboBox_pojazd_wykres.Items.AddRange(pojazdItems);
            comboBox_klient_wykres.Items.AddRange(klientItems);

            // Sprawdzamy, czy tablice nie są null
            if (kierowcaItems != null)
                comboBox_kierowca_wykres.Items.AddRange(kierowcaItems);
            if (pojazdItems != null)
                comboBox_pojazd_wykres.Items.AddRange(pojazdItems);
            if (klientItems != null)
                comboBox_klient_wykres.Items.AddRange(klientItems);

            // Ustawienie domyślnych godzin
            UstawDomyslneGodziny();
        }

        // Obsługa kliknięcia przycisku "Generuj"
        private void btn_generuj_wykres_Click(object sender, EventArgs e)
        {
            // Pobieramy wartości z ComboBox i DateTimePicker
            string selectedKierowca = comboBox_kierowca_wykres.SelectedItem?.ToString();
            string selectedPojazd = comboBox_pojazd_wykres.SelectedItem?.ToString();
            string selectedKlient = comboBox_klient_wykres.SelectedItem?.ToString();

            DateTime startDate = dateTimePickerOd_wykres.Value;
            DateTime endDate = dateTimePickerDo_wykres.Value;

            // Tworzymy zapytanie SQL
            string query = @"SELECT Id, Datastartu, datakonca, klient, kierowca, pojazd, ilosc, ph
                     FROM zlewnia
                     WHERE Datastartu >= @startDate
                     AND datakonca <= @endDate";

            // Lista do przechowywania parametrów zapytania
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            // Dodajemy warunki tylko dla wybranych ComboBox
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

            // Ścieżka do bazy danych
            string dbPath = @"C:\ZlewniaMarex\Zlewnia.db";

            // Tworzymy połączenie do bazy danych
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                // Przygotowujemy zapytanie z parametrami
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Dodajemy wszystkie parametry
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    // Wykonujemy zapytanie i pobieramy wyniki
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Tworzymy listę do przechowywania pełnych danych wykresu
                            List<Tuple<DateTime, double, double, DateTime, string, string, string>> chartData =
                                new List<Tuple<DateTime, double, double, DateTime, string, string, string>>();

                            while (reader.Read())
                            {
                                DateTime datastartu = Convert.ToDateTime(reader["Datastartu"]);
                                double ilosc = Convert.ToDouble(reader["ilosc"]);
                                double ph = Convert.ToDouble(reader["ph"]);
                                DateTime dataKonca = Convert.ToDateTime(reader["DataKonca"]);
                                string klient = reader["Klient"].ToString();
                                string pojazd = reader["Pojazd"].ToString();
                                string kierowca = reader["Kierowca"].ToString();

                                // Dodajemy pełne dane do listy
                                chartData.Add(new Tuple<DateTime, double, double, DateTime, string, string, string>(
                                    datastartu, ilosc, ph, dataKonca, klient, pojazd, kierowca));
                            }

                            // Tworzymy nowy formularz wykresu i przekazujemy pełne dane
                            FormWykres wykresForm = new FormWykres(chartData);
                            wykresForm.Show(); // Pokazuje wykres

                        }
                        else
                        {
                            MessageBox.Show("Brak wyników dla podanych kryteriów.", "Brak danych");
                        }
                    }
                }
            }
        }




        private void UstawDomyslneGodziny()
        {
            // Ustawiamy godzinę 00:01 dla DateTimePickerOd
            DateTime defaultDateTimeOd = dateTimePickerOd_wykres.Value.Date.AddMinutes(1);  // 00:01
            dateTimePickerOd_wykres.Value = defaultDateTimeOd;

            // Ustawiamy godzinę 23:59 dla DateTimePickerDo
            DateTime defaultDateTimeDo = dateTimePickerDo_wykres.Value.Date.AddHours(23).AddMinutes(59);  // 23:59
            dateTimePickerDo_wykres.Value = defaultDateTimeDo;
        }

    }
}
