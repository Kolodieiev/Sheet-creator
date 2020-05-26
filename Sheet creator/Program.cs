using System;
using System.Windows.Forms;

namespace SheetCreator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
