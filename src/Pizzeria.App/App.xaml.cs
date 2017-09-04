using System.Windows;
using Pizzeria.App.View;
using Pizzeria.App.ViewModel;

namespace Pizzeria.App
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainView
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
