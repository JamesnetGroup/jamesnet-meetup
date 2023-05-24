using CommunityToolkit.Mvvm.ComponentModel;
using CustomApp.Local.Models;
using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomApp.Local.ViewModels
{
    public partial class MainViewModel : ObservableBase
    {
        public List<LanguageModel> Languages { get; init; }

        [ObservableProperty]
        private LanguageModel _currentLanguage;

        public MainViewModel()
        {
            Languages = GetLanguages();
        }

        private List<LanguageModel>? GetLanguages()
        {
            List<LanguageModel> source = new();
            source.Add(new LanguageModel().DataGen("KOR", "Korean"));
            source.Add(new LanguageModel().DataGen("ENG", "English"));
            source.Add(new LanguageModel().DataGen("CHN", "Chinese"));
            source.Add(new LanguageModel().DataGen("JPN", "Japanese"));
            return source;
        }

        partial void OnCurrentLanguageChanged(LanguageModel value)
        {
            Application app = App.Current;

            if (app is App myApp)
            {
                myApp.Switch(value);
            }
        }
    }
}
