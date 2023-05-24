using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomApp.Local.Models
{
    public class LanguageModel
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        internal LanguageModel DataGen(string id, string name)
        {
            Id = id;
            Name = name;
            return this;
        }
    }
}
