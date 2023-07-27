using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraApp
{
    static class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            new App().Run();
        }
    }
}
