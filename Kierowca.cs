using System;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zlewnia
{
    public partial class Kierowca : Form
    {
        private SQLiteConnection conn;

        public Kierowca(SQLiteConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private async void btn_zapisz_kierowce_Click(object sender, EventArgs e)
        {
            await AddKierowcaToDatabaseAsync();
        }

        private async Task AddKierowcaToDatabaseAsync()
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_kierowca.Text))
                {
                    MessageBox.Show("Proszę wprowadzić nazwisko kierowcy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string kierowca = textBox_kierowca.Text;
                string query = "INSERT INTO Kierowca (Kierowca) VALUES (@Kierowca)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kierowca", kierowca);
                    await cmd.ExecuteNonQueryAsync(); // Wykonanie zapytania asynchronicznie
                }

                MessageBox.Show("Kierowca został dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_kierowca.Clear(); // Wyczyść pole tekstowe
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania kierowcy:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
