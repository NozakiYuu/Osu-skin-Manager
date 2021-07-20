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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinTree.Nodes.Remove(this.skinTree.SelectedNode);
        }
        private void skinTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.treeRightClickMenu.Show(Cursor.Position);
            } 
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
