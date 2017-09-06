using System.Windows;
using Pizzeria.App.View;

namespace Pizzeria.App
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainView();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
