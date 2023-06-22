using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Infra
{
    internal class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            Window window = new Window();
            window.Title = "Infra Window!";
            return window;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
