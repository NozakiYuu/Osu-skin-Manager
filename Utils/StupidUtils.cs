using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osu_skin_Manager
{
    class StupidUtils
    {
        public static bool OpenInExplorer(string filePath)
        {
            if (!(System.IO.File.Exists(filePath) || System.IO.Directory.Exists(filePath)))
            {
                MessageBox.Show("Invalid file or folder path: "+filePath, "Error, doesnt exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                filePath = System.IO.Path.GetFullPath(filePath);
                System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error exception cause!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Clean up file path so it can be navigated OK
            
        }
    }
}
