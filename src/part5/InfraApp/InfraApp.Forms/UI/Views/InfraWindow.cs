using InfraApp.Forms.Local.ViewModels;
using InfraApp.Support;
using InfraApp.Support.UI.Units;
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
    public class InfraWindow : BaseWindow
    {
        static InfraWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InfraWindow), new FrameworkPropertyMetadata(typeof(InfraWindow)));
        }
    }
}
