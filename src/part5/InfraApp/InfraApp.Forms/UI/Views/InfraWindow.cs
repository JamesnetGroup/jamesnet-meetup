using InfraApp.Forms.Local.ViewModels;
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

namespace InfraApp.Forms.UI.Views
{
    public class InfraWindow : Window
    {
        private ContentControl? content;

        static InfraWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InfraWindow), new FrameworkPropertyMetadata(typeof(InfraWindow)));
        }

        public InfraWindow()
        {
            Loaded += InfraWindow_Loaded;
        }

        private void InfraWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is InfraWindowViewModel vm)
            {
                vm.OnLoaded(content);
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            content = GetTemplateChild("PART_RegionName") as ContentControl;
        }
    }
}
