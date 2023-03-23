using ApplicationApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ApplicationApp
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            JamesWindow window = new();
            window.Title = "JamesWindow";
            window.ShowDialog();
        }
    }
}
