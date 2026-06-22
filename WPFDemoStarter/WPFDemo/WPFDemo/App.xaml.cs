using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo
{
    public partial class App : Application
    {
        // This overrides the internal launch engine programmatically
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Explicitly force SchoolWindow to be the application master entry point
            SchoolWindow mainDashboard = new SchoolWindow();
            mainDashboard.Show();
        }
    }
}
}
