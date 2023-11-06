using System;
using System.Windows.Forms;

namespace Sharplist
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm(
                new DatabaseOperations(new SqlServerConnection()), 
                new EmailNotifier(), 
                new Validation()));
        }
    }
}
