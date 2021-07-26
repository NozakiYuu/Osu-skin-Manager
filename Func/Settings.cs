using System;
using System.IO;
using System.Windows.Forms;

namespace Osu_skin_Manager.Func
{
    public class Settings
    {
        private string userPath = AppSetting.Default.UserPath;
        private bool isChanged = false;
        #region Public method only
        public dynamic Set(string key, dynamic args) {
            switch (key.ToLower())
            {
                case "userpath":
                    return (bool)this.SetUserPath((string)args);
                case "dragmode":
                    return (bool)this.SetDragMode((bool)args);
                default:
                    throw new System.Exception("Invalid value: "+key);
            }
        }

        public dynamic getSettings()
        {
            return new
            {
                userPath = this.userPath
            };
        }
        #endregion

        private bool SetDragMode(bool args)
        {
            this.isChanged = true;
            AppSetting.Default.DragMode = args;
            return true;
        }

        private bool SetUserPath(string path)
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

        ///<returns>true if yes or no, false if cancel</returns>
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
