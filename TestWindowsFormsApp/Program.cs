using System.Windows.Forms;
using System;

namespace TestWindowsFormsApp {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NonVisualComponentsTestForm());
        }
    }
}