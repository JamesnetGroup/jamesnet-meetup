using CustomApp.Local.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Dictionary<string, ResourceDictionary> _languages;
        private ResourceDictionary _currentLanguage;

        public App()
        {
            _languages = new();
            ResourceDictionary korean = GetResource("Korean");
            ResourceDictionary english = GetResource("English");
            ResourceDictionary chinese = GetResource("Chinese");
            ResourceDictionary japanese = GetResource("Japanese");
            _languages.Add("KOR", korean);
            _languages.Add("ENG", english);
            _languages.Add("CHN", chinese);
            _languages.Add("JPN", japanese);

            _currentLanguage = korean;
            Resources.MergedDictionaries.Add(_currentLanguage);
        }

        internal void Switch(LanguageModel value)
        {
            ResourceDictionary current = _languages[value.Id];

            Resources.MergedDictionaries.Remove(_currentLanguage);
            Resources.MergedDictionaries.Add(current);
            _currentLanguage = current;
        }

        private ResourceDictionary GetResource(string name)
        {
            ResourceDictionary resource = new();
            resource.Source = new Uri($"/CustomApp;component/Themes/Cultures/{name}.xaml", UriKind.RelativeOrAbsolute);

            return resource;
        }
    }
}
