using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Zlewnia
{
    public partial class Pojazd : Form
    {
        // Zakładam, że masz połączenie z bazą danych, np. w zmiennej conn
        private SQLiteConnection conn;

        public Pojazd(SQLiteConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private async Task AddPojazdToDatabaseAsync()
        {
            try
            {
                // Sprawdzenie, czy pole textBox_pojazd nie jest puste
                if (string.IsNullOrEmpty(textBox_pojazd.Text))
                {
                    MessageBox.Show("Proszę wprowadzić nazwę pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string pojazd = textBox_pojazd.Text;
                string query = "INSERT INTO pojazd (pojazd) VALUES (@Pojazd)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Pojazd", pojazd);
                    await cmd.ExecuteNonQueryAsync(); // Wykonanie zapytania asynchronicznie
                }

                MessageBox.Show("Pojazd został dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_pojazd.Clear(); // Wyczyść pole tekstowe
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania pojazdu:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_zapisz_pojazd_Click_1(object sender, EventArgs e)
        {
            await AddPojazdToDatabaseAsync();
        }
    }
}
