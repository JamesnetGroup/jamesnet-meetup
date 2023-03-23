using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GridApp
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            StackPanelWindow window = new();
            window.Title = "StackPanel Window";
            window.ShowDialog();
        }
    }
}
