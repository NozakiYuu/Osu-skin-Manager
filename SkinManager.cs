using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Osu_skin_Manager
{
    class SkinManager
    {
        // First one alway be SystemPath
        private string UserPath;
        private string osuAppData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            @"osu!\Skins"
        );
        public string valid_path;

        public SkinManager() {
            this.UserPath = AppSetting.Default.UserPath;

            if (Directory.Exists(osuAppData))
            {
                this.valid_path = osuAppData;
            }
            else if (Directory.Exists(this.UserPath))
            {
                this.valid_path = UserPath;
            }

            if (this.valid_path == null)
            {
                MessageBox.Show(
                    "Sorry but i couldn't found your osu skins folder, please set it manual in File > Open osu skins folder", 
                    "Invalid skins folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public bool setUserPath(string path) {
            if (Directory.Exists(path))
            {
                string b = path.Substring(path.Length - 5).ToLower();
                if (b == "skins")
                {
                    this.valid_path = path;
                    AppSetting.Default.UserPath = path;
                    AppSetting.Default.Save();
                    return true;
                }
            }
            return false;
        }

        private TreeNode newCustomTreeNode(string name) {
            return null;
        }

        public string GetFullPathNode(TreeNode e) {
            string return_ = e.Text;
            TreeNode eb = null ;
            for (int i = 0; i < e.Level-1; i++)
            {
                if (eb == null)
                {
                    eb = e.Parent;
                    return_ = e.Parent.Text + @"\" + return_;
                }
                else
                {
                    eb = eb.Parent;
                    return_ = eb.Text + @"\" + return_;
                }
            }
            return Path.Combine(this.valid_path, return_);
        }

        internal TreeNode GetNodes()
        {
            TreeNode mainNode = new TreeNode("Skins");

            // First loop for checking skin name!
            foreach (string path_to_folder in Directory.GetDirectories(this.valid_path))
            {
                TreeNode skinNodeTemp = new TreeNode(Path.GetFileName(path_to_folder));
                this.GetFileFromPath(path_to_folder).ForEach(node => {
                    skinNodeTemp.Nodes.Add(node);
                });
                mainNode.Nodes.Add(skinNodeTemp);
            }
            return mainNode;
        }

        private List<TreeNode> GetFileFromPath(string path_to_folder)
        {
            List<TreeNode> tempNode = new List<TreeNode>();
            foreach (string folder_left in Directory.GetDirectories(path_to_folder))
            {
                this.GetFileFromPath(folder_left).ForEach(node => {
                    tempNode.Add(node);
                });
            }
            foreach (string path_to_file in Directory.GetFiles(path_to_folder))
            {
                tempNode.Add(new TreeNode(Path.GetFileName(path_to_file)));
            }
            return tempNode;
        }
    }
}
