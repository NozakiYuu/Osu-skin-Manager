
namespace Osu_skin_Manager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treePanel = new System.Windows.Forms.Panel();
            this.skinTree = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutsideMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Button();
            this.treeRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.treeRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treePanel
            // 
            resources.ApplyResources(this.treePanel, "treePanel");
            this.treePanel.Controls.Add(this.skinTree);
            this.treePanel.Name = "treePanel";
            // 
            // skinTree
            // 
            resources.ApplyResources(this.skinTree, "skinTree");
            this.skinTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.skinTree.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinTree.Name = "skinTree";
            this.skinTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skinTree_NodeMouseClick);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MenuBar
            // 
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            this.MenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseMove);
            // 
            // filesToolStripMenuItem
            // 
            resources.ApplyResources(this.filesToolStripMenuItem, "filesToolStripMenuItem");
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOutsideMenu,
            this.refreshMenu});
            this.filesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            // 
            // openOutsideMenu
            // 
            resources.ApplyResources(this.openOutsideMenu, "openOutsideMenu");
            this.openOutsideMenu.Name = "openOutsideMenu";
            this.openOutsideMenu.Click += new System.EventHandler(this.openExToolStripMenuItem_Click);
            // 
            // refreshMenu
            // 
            resources.ApplyResources(this.refreshMenu, "refreshMenu");
            this.refreshMenu.Name = "refreshMenu";
            this.refreshMenu.Click += new System.EventHandler(this.refreshAllToolStripMenuItem_Click);
            // 
            // replaceBtn
            // 
            resources.ApplyResources(this.replaceBtn, "replaceBtn");
            this.replaceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.replaceBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.UseVisualStyleBackColor = false;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Name = "label1";
            // 
            // xBtn
            // 
            resources.ApplyResources(this.xBtn, "xBtn");
            this.xBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.xBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xBtn.FlatAppearance.BorderSize = 0;
            this.xBtn.ForeColor = System.Drawing.Color.Red;
            this.xBtn.Name = "xBtn";
            this.xBtn.UseVisualStyleBackColor = false;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // treeRightClickMenu
            // 
            resources.ApplyResources(this.treeRightClickMenu, "treeRightClickMenu");
            this.treeRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.toBox1ToolStripMenuItem});
            this.treeRightClickMenu.Name = "treeRightClickMenu";
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toBox1ToolStripMenuItem
            // 
            resources.ApplyResources(this.toBox1ToolStripMenuItem, "toBox1ToolStripMenuItem");
            this.toBox1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.box1ToolStripMenuItem,
            this.box2ToolStripMenuItem});
            this.toBox1ToolStripMenuItem.Name = "toBox1ToolStripMenuItem";
            // 
            // box1ToolStripMenuItem
            // 
            resources.ApplyResources(this.box1ToolStripMenuItem, "box1ToolStripMenuItem");
            this.box1ToolStripMenuItem.Name = "box1ToolStripMenuItem";
            // 
            // box2ToolStripMenuItem
            // 
            resources.ApplyResources(this.box2ToolStripMenuItem, "box2ToolStripMenuItem");
            this.box2ToolStripMenuItem.Name = "box2ToolStripMenuItem";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CancelButton = this.xBtn;
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treePanel);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.treePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.treeRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel treePanel;
        private System.Windows.Forms.TreeView skinTree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOutsideMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshMenu;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.ContextMenuStrip treeRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toBox1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem box1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem box2ToolStripMenuItem;
    }
}

