using System;
using System.Collections.Generic;
using System.IO;
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
                MessageBox.Show("Invalid file or folder path: "+filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(e.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ReplaceFile(string path1, string path2) {
            try
            {
                File.Copy(path1, path2, true);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception at ReplaceFile()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
