using RecipeApp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.ConsoleRunner;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Run the console-based recipe management application
            //WpfApp1.ConsoleRunner.ConsoleRunner.RunConsole();

            // Optionally, you can launch your WPF main window after console execution
             MainWindow mainWindow = new MainWindow();
             mainWindow.Show();
        }
    }
}
