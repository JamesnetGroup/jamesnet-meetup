using InfraApp.Main.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InfraApp.Forms.Local.ViewModels
{
    public class InfraWindowViewModel
    {
        private MainContent _mainContent;

        public InfraWindowViewModel(MainContent mainContent)
        {
            _mainContent = mainContent;
        }

        internal void OnLoaded(ContentControl? content)
        {
            content.Content = _mainContent;
        }
    }
}
