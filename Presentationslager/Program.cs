using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using affärslager;

namespace Presentationslager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            BusinessManager bm = new BusinessManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inloggning(bm));
        }
    }
}
