using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Osu_skin_Manager
{
    public class SkinManager
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
                /*
                 LilShieru: WRONG instructions, what is "File -> Open osu! skins folder"?
                            Also, incorrect grammar, "manually" not "manual".
                 The OLD code:
                    MessageBox.Show(
                        "Sorry but i couldn't found your osu skins folder, please set it manual in File > Open osu skins folder", 
                        "Invalid skins folder",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                */
                MessageBox.Show(
                    "Sorry but i couldn't found your osu! skins folder, please set it manually in the Help -> Settings part.",
                    "Invalid skins folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private TreeNode newCustomTreeNode(string name) {
            return null;
        }

        public string GetFullNodePath(TreeNode e) {
            if (e.Text == "Skins") return this.valid_path;

            string return_ = this.valid_path;
            TreeNode eb = null ;
            for (int i = 0; i < e.Level-1; i++)
            {
                if (eb == null)
                {
                    eb = e.Parent;
                    return_ = Path.Combine(return_, e.Parent.Text);
                }
                else
                {
                    eb = eb.Parent;
                    return_ = eb.Text;
                }
            }
            return_ = Path.GetFullPath(Path.Combine(return_,e.Text));
            if (File.Exists(return_))
            {
                return return_;
            } else if (Directory.Exists(return_)) {
                return return_;
            }
            Console.WriteLine("Invalid path: " + return_);
            return "";
        }

        internal TreeNode GetNodes()
        {
            TreeNode mainNode = new TreeNode("Skins");

            // LilShieru: When the application cannot find the skins folder (this.valid_path == null), DON't run the foreach command, otherwise it will cause an exception error.

            if (this.valid_path != null && Directory.Exists(this.valid_path))
            {
                // First loop for checking skin name!
                foreach (string path_to_folder in Directory.GetDirectories(this.valid_path))
                {
                    TreeNode skinNodeTemp = new TreeNode(Path.GetFileName(path_to_folder));
                    this.GetFileFromPath(path_to_folder).ForEach(node =>
                    {
                        skinNodeTemp.Nodes.Add(node);
                    });
                    mainNode.Nodes.Add(skinNodeTemp);
                }
            }
            return mainNode;
        }

        private List<TreeNode> GetFileFromPath(string path_to_folder)
        {
            List<TreeNode> tempNode = new List<TreeNode>();
            foreach (string folder_left in Directory.GetDirectories(path_to_folder))
            {
                TreeNode directoryNode = new TreeNode(Path.GetFileName(folder_left));
                this.GetFileFromPath(folder_left).ForEach(node => {
                    directoryNode.Nodes.Add(node);
                });
                tempNode.Add(directoryNode);
            }
            foreach (string path_to_file in Directory.GetFiles(path_to_folder))
            {
                tempNode.Add(new TreeNode(Path.GetFileName(path_to_file)));
            }
            return tempNode;
        }

        public bool Delete(TreeNode node) {
            string path_to_file = this.GetFullNodePath(node);
            try
            {
                File.Delete(path_to_file);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            return true;
        }

    }
}
