using Pizzeria.App.ViewModel;
using System.Windows;

namespace Pizzeria.App.View
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
