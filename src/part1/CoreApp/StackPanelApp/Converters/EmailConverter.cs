using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace StackPanelApp.Converters
{
    public class EmailConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string company = value == null ? "" : value.ToString();
            string email = "";

            switch (company)
            {
                case "Google": email = "Gmail"; break;
                case "Microsoft": email = "Outlook"; break;
                default: email = "없음"; break;
            }

            return email;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
