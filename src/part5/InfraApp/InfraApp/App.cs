using InfraApp.Forms.Local.ViewModels;
using InfraApp.Forms.UI.Views;
using InfraApp.Main.UI.Views;
using InfraApp.Support;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace InfraApp
{
    internal class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return new InfraWindow();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // containerRegistry.Register
            // containerRegistry.RegisterInstance
            // containerRegistry.RegisterSingleton
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            ViewModelLocationProvider.Register<InfraWindow, InfraWindowViewModel>();
        }
    }
}
