using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using TwinCAT.Ads;

namespace Zlewnia
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private SQLiteConnection conn;
        private AdsClient adsClient;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private async void InitializeDatabaseConnection()
        {
            try
            {
                // Ścieżka do bazy danych
                string dbPath = @"C:\ZlewniaMarex\Zlewnia.db";
                connectionString = $"Data Source={dbPath};Version=3;";

                // Sprawdzenie, czy plik bazy istnieje
                if (!File.Exists(dbPath))
                {
                    MessageBox.Show("Baza danych nie istnieje! Sprawdź ścieżkę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inicjalizacja i otwarcie połączenia
                conn = new SQLiteConnection(connectionString);
                await conn.OpenAsync(); // Użyj OpenAsync, aby być bardziej konsekwentnym

                MessageBox.Show("Połączono z bazą danych!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ładowanie danych asynchronicznie
                await LoadDriversAsync();
                await LoadVehiclesAsync();
                await LoadClientsAsync();

                _ = InitializeAdsConnectionAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task InitializeAdsConnectionAsync()
        {
            try
            {
                // Odczytanie wartości z App.config
                string amsNetId = System.Configuration.ConfigurationManager.AppSettings["AMSNetID"];
                string adsPortStr = System.Configuration.ConfigurationManager.AppSettings["ADSPort"];
                int adsPort = 851; // Domyślny port

                // Sprawdzamy, czy odczytano port ADS i konwertujemy
                if (!string.IsNullOrEmpty(adsPortStr))
                {
                    if (!int.TryParse(adsPortStr, out adsPort))
                    {
                        MessageBox.Show("Nieprawidłowy port ADS w pliku konfiguracyjnym.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Inicjalizacja połączenia ADS
                adsClient = new AdsClient();
                await Task.Run(() => adsClient.Connect(amsNetId, adsPort)); // Użycie odczytanych wartości

                MessageBox.Show("Połączono z ADS!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z ADS:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Zamykanie połączenia z bazą danych
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    MessageBox.Show("Połączenie z bazą zostało zamknięte.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Dispose();
                conn = null;
            }

            // Zamykanie połączenia ADS, tylko jeśli zostało otwarte
            if (adsClient != null)
            {
                try
                {
                    adsClient.Dispose();  // Zwalniamy zasoby ADS
                    MessageBox.Show("Połączenie z ADS zostało zamknięte.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas zamykania połączenia ADS:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                adsClient = null;
            }
        }

        private async Task LoadDriversAsync()
        {
            try
            {
                if (conn == null || conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Brak połączenia z bazą danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT kierowca FROM kierowca ORDER BY kierowca ASC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = (SQLiteDataReader)await cmd.ExecuteReaderAsync())  // asynchroniczne wykonanie zapytania
                {
                    comboBox_kierowca.Items.Clear();

                    while (await reader.ReadAsync())  // asynchroniczne czytanie wierszy
                    {
                        comboBox_kierowca.Items.Add(reader["kierowca"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania danych kierowców:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task LoadVehiclesAsync()
        {
            try
            {
                if (conn == null || conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Brak połączenia z bazą danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT pojazd FROM pojazd ORDER BY pojazd ASC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = (SQLiteDataReader)await cmd.ExecuteReaderAsync())
                {
                    comboBox_pojazd.Items.Clear();

                    while (await reader.ReadAsync()) // Asynchroniczne odczytywanie wierszy
                    {
                        comboBox_pojazd.Items.Add(reader["pojazd"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania danych pojazdów:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task LoadClientsAsync()
        {
            try
            {
                if (conn == null || conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Brak połączenia z bazą danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT klient FROM klient ORDER BY klient ASC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = (SQLiteDataReader)await cmd.ExecuteReaderAsync())
                {
                    comboBox_klient.Items.Clear();

                    while (await reader.ReadAsync()) // Asynchroniczne odczytywanie wierszy
                    {
                        comboBox_klient.Items.Add(reader["klient"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania danych klientów:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task InsertRecordIntoZlewniaAsync()
        {
            try
            {
                // Sprawdzenie połączenia w głównym wątku
                if (conn == null || conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Brak połączenia z bazą danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pobranie danych z formularza w głównym wątku UI
                string klient = string.Empty;
                string kierowca = string.Empty;
                string pojazd = string.Empty;

                // Przypisz wartości z kontrolek do zmiennych w głównym wątku
                this.Invoke((MethodInvoker)(() =>
                {
                    klient = comboBox_klient.SelectedItem?.ToString() ?? "";
                    kierowca = comboBox_kierowca.SelectedItem?.ToString() ?? "";
                    pojazd = comboBox_pojazd.SelectedItem?.ToString() ?? "";
                }));

                string dataStartu = dateTimePickerOd.Value.ToString("yyyy-MM-dd HH:mm:ss"); // Data startu
                string dataKonca = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Data zakończenia
                int ilosc = 5; // Stała wartość 5

                // Sprawdzenie, czy wartości są poprawne
                if (string.IsNullOrWhiteSpace(klient) || string.IsNullOrWhiteSpace(kierowca) || string.IsNullOrWhiteSpace(pojazd))
                {
                    MessageBox.Show("Wybierz klienta, kierowcę i pojazd przed dodaniem rekordu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Zapytanie SQL do dodania nowego wpisu
                string query = "INSERT INTO Zlewnia (Datastartu, datakonca, Klient, Kierowca, Pojazd, Ilosc) " +
                               "VALUES (@Datastartu, @datakonca, @Klient, @Kierowca, @Pojazd, @Ilosc)";

                // Asynchroniczna operacja zapisu
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Datastartu", dataStartu);
                    cmd.Parameters.AddWithValue("@datakonca", dataKonca);
                    cmd.Parameters.AddWithValue("@Klient", klient);
                    cmd.Parameters.AddWithValue("@Kierowca", kierowca);
                    cmd.Parameters.AddWithValue("@Pojazd", pojazd);
                    cmd.Parameters.AddWithValue("@Ilosc", ilosc);

                    await cmd.ExecuteNonQueryAsync(); // Wykonaj zapytanie asynchronicznie
                }

                // Zaktualizowanie UI po zakończeniu operacji
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Dane zostały zapisane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            catch (Exception ex)
            {
                // Obsługa błędu w głównym wątku
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Błąd podczas zapisywania danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }
        }





        private async Task OdswiezDaneAsync()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Brak połączenia z bazą danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Zmieniamy zapytanie, aby posortować dane po połączeniu
                string query = @"
                SELECT 'Kierowca' AS Typ, Kierowca AS Nazwa FROM Kierowca
                UNION ALL
                SELECT 'Pojazd', Pojazd FROM Pojazd
                UNION ALL
                SELECT 'Klient', Klient FROM Klient
                ORDER BY Nazwa ASC";  // Sortowanie po nazwie po UNION ALL

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = (SQLiteDataReader)await cmd.ExecuteReaderAsync()) // Asynchroniczne wykonanie zapytania
                {
                    // Asynchronicznie wykonujemy dostęp do kontrolek w głównym wątku
                    await Task.Run(() =>
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            // Czyszczenie poprzednich danych
                            comboBox_kierowca.Items.Clear();
                            comboBox_pojazd.Items.Clear();
                            comboBox_klient.Items.Clear();

                            // Dodawanie danych posortowanych alfabetycznie
                            while (reader.Read())
                            {
                                string typ = reader["Typ"].ToString();
                                string nazwa = reader["Nazwa"].ToString();

                                if (typ == "Kierowca") comboBox_kierowca.Items.Add(nazwa);
                                else if (typ == "Pojazd") comboBox_pojazd.Items.Add(nazwa);
                                else if (typ == "Klient") comboBox_klient.Items.Add(nazwa);
                            }
                        });
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas odświeżania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btn_kierowca_Click(object sender, EventArgs e)
        {
            // Tworzymy nową instancję formularza Kierowca
            Kierowca kierowcaForm = new Kierowca(conn);

            // Otwieramy formularz (możemy użyć Show lub ShowDialog)
            kierowcaForm.Show(); // lub kierowcaForm.ShowDialog(); jeśli formularz ma być modalny
        }

        private void btn_klient_Click(object sender, EventArgs e)
        {
            // Tworzymy nową instancję formularza Kierowca
            Klient klientForm = new Klient(conn);

            // Otwieramy formularz (możemy użyć Show lub ShowDialog)
            klientForm.Show(); // lub kierowcaForm.ShowDialog(); jeśli formularz ma być modalny

        }

        private void btn_pojazd_Click(object sender, EventArgs e)
        {
            // Tworzymy nową instancję formularza Kierowca
            Pojazd pojazdForm = new Pojazd(conn);

            // Otwieramy formularz (możemy użyć Show lub ShowDialog)
            pojazdForm.Show(); // lub kierowcaForm.ShowDialog(); jeśli formularz ma być modalny
        }

        private async void btn_zakoncz_Click(object sender, EventArgs e)
        {
            await Task.Run(() => InsertRecordIntoZlewniaAsync());
        }


        private async void btn_odswiez_Click(object sender, EventArgs e)
        {
            await Task.Run(() => OdswiezDaneAsync()); // Zmieniono na OdswiezDaneAsync
        }

    }
}