using System.Windows;
using WpfClient.View.ViewModel;

namespace WpfClient.View
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
           // base.OnStartup(e);
            MainWindow window = new MainWindow();
            MainWindowViewModel viewModel = new MainWindowViewModel();

            //binding context to window
            window.DataContext = viewModel;
            window.Show();
        }
    }
}
