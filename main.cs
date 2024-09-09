using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamdeck
{
    internal class main
    {
        [STAThread]
        static void Main(string[] args)
        {
            new SplashScreen().ShowDialog();
        }
    }
}
