using Infra.Forms.UI.Views;
using Infra.Support.UI.Units;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using System.Windows.Media;

namespace Infra
{
    internal class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            BlueWindow window = new BlueWindow();
            window.Title = "Blue Window!";
            return window;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
