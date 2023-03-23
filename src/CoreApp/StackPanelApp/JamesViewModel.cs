using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPanelApp
{
    public class JamesViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string Company1 { get; set; }
        public string Company2 { get; set; }

        public JamesViewModel()
        {
            Name = "James";
            Address= "시흥시";

            Company1 = "Google";
            Company2 = "Microsoft";
        }
    }
}
