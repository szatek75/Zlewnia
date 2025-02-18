using System;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zlewnia
{
    public partial class Klient : Form
    {
        // Zakładam, że masz połączenie z bazą danych, np. w zmiennej conn
        private SQLiteConnection conn;

        public Klient(SQLiteConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private async Task AddKlientToDatabaseAsync()
        {
            try
            {
                // Sprawdzenie, czy pole textBox_klient nie jest puste
                if (string.IsNullOrEmpty(textBox_klient.Text))
                {
                    MessageBox.Show("Proszę wprowadzić nazwisko klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string klient = textBox_klient.Text;
                string query = "INSERT INTO klient (klient, adres) VALUES (@Klient, '')";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Klient", klient);
                    await cmd.ExecuteNonQueryAsync(); // Wykonanie zapytania asynchronicznie
                }

                MessageBox.Show("Klient został dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_klient.Clear(); // Wyczyść pole tekstowe
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania klienta:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_zapisz_klienta_Click_1(object sender, EventArgs e)
        {
            await AddKlientToDatabaseAsync();
        }
    }
}
