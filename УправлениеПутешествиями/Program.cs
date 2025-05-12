using System;
using System.Windows.Forms;

namespace УправлениеПутешествиями
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false);
            var trip = new Trip("Париж", DateTime.Now, DateTime.Now.AddDays(7), 50000m); Application.Run(new TripForm(trip));
        }
    }
}
