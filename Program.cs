using System;
using System.Windows.Forms;


namespace spital
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CentralDisplay centralDisplay = CentralDisplay.Instance;

            Application.Run(centralDisplay);

        }
    }
}
