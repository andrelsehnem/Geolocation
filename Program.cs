using System;
using System.Windows.Forms;

namespace Littlemium
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Principal());
        }
    }
}
