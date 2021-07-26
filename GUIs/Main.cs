using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Osu_skin_Manager.GUIs;

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
        private string pic1_path = null;
        private string pic2_path = null;
        private Point lastPoint;

        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void refreshAllToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (pic1_path == null || pic2_path == null)
                MessageBox.Show("You havent select file to the box 1 and 2 bruh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (StupidUtils.ReplaceFile(pic1_path, pic2_path))
            {
                this.pictureBox1.Image = null;
                this.pictureBox1.ImageLocation = null;

                this.pictureBox2.Image = null;
                this.pictureBox2.ImageLocation = null;
                string pic1_name = Path.GetFileName(this.pic1_path);
                string pic2_name = Path.GetFileName(this.pic2_path);
                MessageBox.Show("Succeed replaced file "+pic2_name+" by "+pic1_name, "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                        MessageBox.Show("Are you trying to add a folder to this???", "Error!??!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string[] name = openFileDialog.FileName.Split('\\');
                    TreeNode tempNode = new TreeNode(name[name.Length - 1]);
                    skinTree.SelectedNode.Nodes.Add(tempNode);

                    string srcFile = openFileDialog.FileName;
                    string destFile = Path.Combine(this.manager.GetFullNodePath(skinTree.SelectedNode), Path.GetFileName(srcFile));
                    if (!File.Exists(destFile))
                    {
                        MessageBox.Show("Error: "+ destFile, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
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

        private void settingMenuBar_Click(object sender, EventArgs e)
        {
            new SettingForm(this.manager).ShowDialog(this);
        }

        private void minimizedBtnClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
