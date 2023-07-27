using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InfraApp.Support.UI.Units
{
    public class InfraRegion : ContentControl
    {
        static InfraRegion()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InfraRegion), new FrameworkPropertyMetadata(typeof(InfraRegion)));
        }

        public static DependencyProperty RegionNameProperty = DependencyProperty.Register("RegionName", typeof(string), typeof(InfraRegion), new PropertyMetadata(RegionNamePropertyChanged));

        public string RegionName
        { 
            get=> (string)GetValue(RegionNameProperty);
            set => SetValue(RegionNameProperty, value);
        }

        private static void RegionNamePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            InfraRegion region = d as InfraRegion;

            var win = Application.Current.MainWindow;            
            IRegionManager regionManager = RegionManager.GetRegionManager(win);

            RegionManager.SetRegionName(d, region.RegionName);
            RegionManager.SetRegionManager(d, regionManager);
        }
    }
}
