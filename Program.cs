using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbuy_Desktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            API.checkHostIntegrity();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
