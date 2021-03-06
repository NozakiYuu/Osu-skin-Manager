using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Osu_skin_Manager;
using Osu_skin_Manager.Func;

namespace Osu_skin_Manager.GUIs
{
    public partial class SettingForm : Form
    {
        private SkinManager manager = null;
        private Settings settings = null;
        private Point lastPoint;

        public SettingForm(SkinManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            this.settings = new Settings();
            var settings = this.settings.getSettings();
            this.userPathTxt.Text = settings.userPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    if (this.settings.setUserPath(openFolderDialog.SelectedPath))
                    {
                        MessageBox.Show("Changed the skins path to " + openFolderDialog.SelectedPath + ".\nYou should refresh the skins manager with the Files -> Refresh All button.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // LilShieru added the path displaying update when the path is successfully changed.
                        userPathTxt.Text = openFolderDialog.SelectedPath;
                        // And the most important...
                        this.manager.valid_path = openFolderDialog.SelectedPath;
                        return;
                    }
                    else
                    {
                        // LilShieru added this one. Why not?
                        MessageBox.Show("Cannot change the osu! skins path. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            /*
            LilShieru: WTF is this???
             
                MessageBox.Show(
                    "Sorry but i couldn't found your osu skins folder, please set it manual in File > Open osu skins folder",
                    "Invalid skins folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
             */
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            if (this.settings.SaveOnExit()) this.Close();
        }

        private void SettingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - this.lastPoint.X;
                this.Top += e.Y - this.lastPoint.Y;
            }
        }

        private void SettingForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }
    }
}
