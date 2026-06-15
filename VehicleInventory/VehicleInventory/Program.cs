using System;
using System.Windows.Forms;

namespace VehicleInventory
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

            // This line tells the program to start by launching your inventory form
            Application.Run(new VehicleInventoryForm());
        }
    }
}