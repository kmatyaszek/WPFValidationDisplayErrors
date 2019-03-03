using Autofac;
using System.Windows;
using WPFValidationDisplayErrors.Startup;

namespace WPFValidationDisplayErrors
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var contrainer = bootstrapper.Bootstrap();

            var mainView = contrainer.Resolve<MainWindow>();
            mainView.Show();
        }
    }
}
