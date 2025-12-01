using System;
using System.Windows.Forms;

namespace AttendanceTracker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DbInitializer.Initialize(); // ✅ create db & tables

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
