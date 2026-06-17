//Willow Marquez
//wmarquez4@student.cnm.edu
//Depreciation Form P4

using System;
using System.Windows.Forms;

namespace MarquezP4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //enables visual styles and ensures text rendering
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            // To customize application configuration such as set high DPI settings or default font,
            
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(new Form1());
        }
    }
}