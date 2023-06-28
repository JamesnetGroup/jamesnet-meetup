using System.Windows;
using System.Windows.Controls;

namespace Infra.Support.UI.Units
{
    public class DarkWindowBase : Window
    {
        public static DependencyProperty SearchProperty = DependencyProperty.Register("Search", typeof(object), typeof(DarkWindowBase));
        public static DependencyProperty SearchTemplateProperty = DependencyProperty.Register("SearchTemplate", typeof(DataTemplate), typeof(DarkWindowBase));

        public object Search
        {
            get => (object)GetValue(SearchProperty);
            set => SetValue(SearchProperty, value);
        }

        public DataTemplate SearchTemplate
        {
            get => (DataTemplate)GetValue(SearchTemplateProperty);
            set => SetValue(SearchTemplateProperty, value);
        }

        static DarkWindowBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindowBase), new FrameworkPropertyMetadata(typeof(DarkWindowBase)));
        }
    }
}
