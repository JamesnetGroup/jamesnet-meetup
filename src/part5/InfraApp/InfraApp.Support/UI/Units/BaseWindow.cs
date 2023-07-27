using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InfraApp.Support.UI.Units
{
    public class BaseWindow : Window
    {
        public BaseWindow()
        {
            Loaded += InfraWindow_Loaded;
        }

        private void InfraWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is IViewLoadable vm)
            {
                vm.OnLoaded();
            }
        }
    }
}
