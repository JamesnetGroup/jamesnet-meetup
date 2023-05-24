using CustomApp.Local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomApp.Local.ViewModels
{
    public class MainViewModel
    {
        public List<LanguageModel> Languages { get; init; }

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
    }
}
