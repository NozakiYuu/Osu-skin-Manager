using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Osu_skin_Manager
{
    public partial class Main : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        private SkinManager manager;
        private string pic2_path;
        private string pic1_path;
        private Point lastPoint;

        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void openExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    if (this.manager.setUserPath(openFolderDialog.SelectedPath)) {
                        this.skinTree.Nodes.Clear();
                        this.skinTree.Nodes.Add(this.manager.GetNodes());
                        MessageBox.Show("Changed to "+openFolderDialog.SelectedPath, "Success!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            MessageBox.Show(
                "Sorry but i couldn't found your osu skins folder, please set it manual in File > Open osu skins folder",
                "Invalid skins folder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void refreshAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinTree.Nodes.Clear();
            this.skinTree.Nodes.Add(this.manager.GetNodes());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.manager = new SkinManager();
            this.skinTree.Nodes.Add(this.manager.GetNodes());
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {

        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - this.lastPoint.X;
                this.Top += e.Y - this.lastPoint.Y;
            }
        }

        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        private void skinTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                skinTree.SelectedNode = e.Node;
                this.treeRightClickMenu.Show(Cursor.Position);
            } 
        }
        #region All about Picture Box and it subthing :)\
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.pic2_path = openFileDialog.FileName;
                    this.pictureBox2.Image = System.Drawing.Image.FromStream(openFileDialog.OpenFile());
                }
            }
        }

        private void Box1Placing(object sender, EventArgs e) {
            string pathFile = this.manager.GetFullNodePath(skinTree.SelectedNode);
            try
            {
                using (FileStream stream = File.OpenRead(pathFile))
                {
                    this.pic1_path = pathFile;
                    this.pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                    this.pictureBox1.ImageLocation = pathFile;
                    this.box1Label.Text = Path.GetFileName(pathFile);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "This is invalid file, please the file must be image or gif",
                    "Error Argument invalid!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
        private void Box2Placing(object sender, EventArgs e)
        {
            string pathFile = this.manager.GetFullNodePath(skinTree.SelectedNode);
            try
            {
                using (FileStream stream = File.OpenRead(pathFile))
                {
                    this.pic2_path = pathFile;
                    this.pictureBox2.Image = System.Drawing.Image.FromStream(stream);
                    this.pictureBox2.ImageLocation = pathFile;
                    this.box2Label.Text = Path.GetFileName(pathFile);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                    "This is invalid file, please the file must be image or gif",
                    "Error Argument invalid!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void box2Label_MouseHover(object sender, EventArgs e)
        {
            if (this.box2Tooltip.Active)
            {
                this.box2Tooltip.Active = false;
            }
            this.box2Tooltip.Active = true;
            this.box2Tooltip.SetToolTip(this.box2Label, this.pictureBox2.ImageLocation);
        }

        private void box1Label_MouseHover(object sender, EventArgs e)
        {
            if (this.box1Tooltip.Active)
            {
                this.box1Tooltip.Active = false;
            }
            this.box1Tooltip.Active = true;
            this.box1Tooltip.SetToolTip(this.box1Label, this.pictureBox1.ImageLocation);
        }
        #endregion

        private void addNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (skinTree.SelectedNode.Text.Contains(".")) return;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Path.HasExtension(openFileDialog.FileName))
                    {
                        MessageBox.Show("Are you trying to add the folder to this???", "Error!??!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string[] name = openFileDialog.FileName.Split('\\');
                    TreeNode tempNode = new TreeNode(name[name.Length - 1]);
                    skinTree.SelectedNode.Nodes.Add(tempNode);

                    string srcFile = openFileDialog.FileName;
                    string destFile = Path.Combine(this.manager.GetFullNodePath(skinTree.SelectedNode), Path.GetFileName(srcFile));
                    File.Copy(openFileDialog.FileName, destFile, true);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.manager.Delete(this.skinTree.SelectedNode);
            this.skinTree.Nodes.Remove(this.skinTree.SelectedNode);
            string pathFile = this.manager.GetFullNodePath(skinTree.SelectedNode);
            if (File.Exists(pathFile))
            {
                MessageBox.Show("Look like this file doesnt exist, guess i delete this for you :)", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine(pathFile);
            File.Delete(pathFile);

        }

        private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string b = this.manager.GetFullNodePath(skinTree.SelectedNode);
            StupidUtils.OpenInExplorer(b);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /* This thing for right click menu, but it's now kinda broken :(
* 
private void previewFileToolStripMenuItem_Click(object sender, EventArgs e)
{
string path = this.manager.GetFullPathNode(skinTree.SelectedNode);
if (Path.HasExtension(path))
{
Process.Start(path);
}
}

private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
{
Utils.OpenInExplorer(this.manager.GetFullPathNode(skinTree.SelectedNode));
}*/
    }
}
