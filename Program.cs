using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zlewnia
{
    internal static class Program
    {
        /// <summary>
        private const string MutexName = "Global\\MyUniqueMutexNameZlewnia";
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            // Utwórz globalny Mutex
            using (Mutex mutex = new Mutex(true, MutexName, out createdNew))
            {
                // Sprawdź, czy aplikacja jest już uruchomiona
                if (!createdNew)
                {
                    MessageBox.Show("Aplikacja jest już uruchomiona.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
