using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osu_skin_Manager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (AppSetting.Default.DragMode)
                Application.Run(new DragModeUI());
            else 
                Application.Run(new Main());
        }
    }
}
