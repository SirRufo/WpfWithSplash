using System.Threading.Tasks;
using System.Windows;

using WpfWithSplash.ViewModels;
using WpfWithSplash.Views;

namespace WpfWithSplash
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += App_Startup;
        }

        private async void App_Startup(object sender, StartupEventArgs e)
        {
            var splashVM = new SplashViewModel();
            var splash = new SplashWindow
            {
                DataContext = splashVM,
            };
            splash.Show();

            await Task.Yield();
            await splashVM.InitializeAsync(null);

            splashVM.Info = "service1 initializing...";
            // await service1.InitializeAsync();
            await Task.Delay(150);
            splashVM.Info = "service2 initializing...";
            await Task.Delay(250);
            splashVM.Info = "service3 initializing...";
            await Task.Delay(350);
            splashVM.Info = "service4 initializing...";
            await Task.Delay(450);
            splashVM.Info = "service5 initializing...";
            await Task.Delay(550);
            splashVM.Info = "finished.";

            var mainVM = new MainViewModel();
            MainWindow = new MainWindow
            {
                DataContext = mainVM,
            };
            MainWindow.Show();
            await mainVM.InitializeAsync(null);

            await Task.Delay(1000);

            splash.Close();
        }
    }
}
