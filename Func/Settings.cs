using System.IO;
using System.Windows.Forms;

namespace Osu_skin_Manager.Func
{
    public class Settings
    {
        private string userPath = AppSetting.Default.UserPath;
        private bool isChanged = false;
        public bool setUserPath(string path)
        {
            if (Directory.Exists(path))
            {
                string b = path.Substring(path.Length - 5).ToLower();
                if (b == "skins")
                {
                    AppSetting.Default.UserPath = path;
                    this.isChanged = true;
                    return true;
                }
            }
            return false;
        }

        public dynamic getSettings() {
            return new {
                userPath = this.userPath
            };
        }

        //<summary>
        //<returns>If user choosed yes, no or setting havent change then return true, else cancel then false</returns>
        //</summary>
        internal bool SaveOnExit()
        {
            if (!this.isChanged) return true;
            DialogResult dialogResult =  MessageBox.Show("Save settings?", "Setting popup", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AppSetting.Default.Save();
                return true;
            }
            else if (dialogResult == DialogResult.No) return true;
            return false;
        }
    }
}
