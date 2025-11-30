using System;
using System.Windows.Forms;

namespace AttendanceTracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with LoginForm
            Application.Run(new LoginForm());
        }
    }
}
