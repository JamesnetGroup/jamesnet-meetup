using Infra.Support.UI.Units;
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

namespace Infra.Forms.UI.Views
{
    public class BlueWindow : DarkWindowBase
    {
        static BlueWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BlueWindow), new FrameworkPropertyMetadata(typeof(BlueWindow)));
        }
    }
}
