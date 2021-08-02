
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
            this.skinTree = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Button();
            this.treeRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.box1Label = new System.Windows.Forms.Label();
            this.box2Label = new System.Windows.Forms.Label();
            this.toBox2btn = new System.Windows.Forms.Button();
            this.toBox1btn = new System.Windows.Forms.Button();
            this.box1Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.box2Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.minimizedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.treeRightClickMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTree
            // 
            this.skinTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.skinTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTree.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.skinTree.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinTree.Location = new System.Drawing.Point(0, 0);
            this.skinTree.Name = "skinTree";
            this.skinTree.Size = new System.Drawing.Size(296, 423);
            this.skinTree.TabIndex = 0;
            this.skinTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skinTree_NodeMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(314, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(500, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 130);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpMenu});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(640, 24);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "MenuBar";
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            this.MenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseMove);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenu});
            this.filesToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.filesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // refreshMenu
            // 
            this.refreshMenu.Name = "refreshMenu";
            this.refreshMenu.Size = new System.Drawing.Size(151, 22);
            this.refreshMenu.Text = "Refresh all";
            this.refreshMenu.Click += new System.EventHandler(this.refreshAllToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingMenuBar,
            this.aboutMenu});
            this.helpMenu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(47, 20);
            this.helpMenu.Text = "Help";
            // 
            // settingMenuBar
            // 
            this.settingMenuBar.Name = "settingMenuBar";
            this.settingMenuBar.Size = new System.Drawing.Size(152, 22);
            this.settingMenuBar.Text = "Settings";
            this.settingMenuBar.Click += new System.EventHandler(this.settingMenuBar_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(152, 22);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.replaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replaceBtn.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.replaceBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.replaceBtn.Location = new System.Drawing.Point(425, 328);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(96, 23);
            this.replaceBtn.TabIndex = 4;
            this.replaceBtn.Text = "Replace it!";
            this.replaceBtn.UseVisualStyleBackColor = false;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(448, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "-->";
            // 
            // xBtn
            // 
            this.xBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.xBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xBtn.FlatAppearance.BorderSize = 0;
            this.xBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xBtn.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.xBtn.ForeColor = System.Drawing.Color.Red;
            this.xBtn.Location = new System.Drawing.Point(595, 0);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(33, 24);
            this.xBtn.TabIndex = 6;
            this.xBtn.Text = "X";
            this.xBtn.UseVisualStyleBackColor = false;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // treeRightClickMenu
            // 
            this.treeRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFileToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toBox1ToolStripMenuItem,
            this.openInExplorerToolStripMenuItem});
            this.treeRightClickMenu.Name = "treeRightClickMenu";
            this.treeRightClickMenu.Size = new System.Drawing.Size(163, 92);
            // 
            // addNewFileToolStripMenuItem
            // 
            this.addNewFileToolStripMenuItem.Name = "addNewFileToolStripMenuItem";
            this.addNewFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewFileToolStripMenuItem.Text = "Add new file";
            this.addNewFileToolStripMenuItem.Click += new System.EventHandler(this.addNewFileToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toBox1ToolStripMenuItem
            // 
            this.toBox1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.box1ToolStripMenuItem,
            this.box2ToolStripMenuItem});
            this.toBox1ToolStripMenuItem.Name = "toBox1ToolStripMenuItem";
            this.toBox1ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.toBox1ToolStripMenuItem.Text = "To Box";
            // 
            // box1ToolStripMenuItem
            // 
            this.box1ToolStripMenuItem.Name = "box1ToolStripMenuItem";
            this.box1ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.box1ToolStripMenuItem.Text = "Box 1";
            this.box1ToolStripMenuItem.Click += new System.EventHandler(this.Box1Placing);
            // 
            // box2ToolStripMenuItem
            // 
            this.box2ToolStripMenuItem.Name = "box2ToolStripMenuItem";
            this.box2ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.box2ToolStripMenuItem.Text = "Box 2";
            this.box2ToolStripMenuItem.Click += new System.EventHandler(this.Box2Placing);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openInExplorerToolStripMenuItem.Text = "Open in explorer";
            this.openInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInExplorerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.box1Label);
            this.panel1.Controls.Add(this.box2Label);
            this.panel1.Controls.Add(this.toBox2btn);
            this.panel1.Controls.Add(this.toBox1btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.replaceBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.skinTree);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 423);
            this.panel1.TabIndex = 7;
            // 
            // box1Label
            // 
            this.box1Label.AutoSize = true;
            this.box1Label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.box1Label.Location = new System.Drawing.Point(311, 273);
            this.box1Label.Name = "box1Label";
            this.box1Label.Size = new System.Drawing.Size(0, 15);
            this.box1Label.TabIndex = 9;
            this.box1Label.MouseHover += new System.EventHandler(this.box1Label_MouseHover);
            // 
            // box2Label
            // 
            this.box2Label.AutoSize = true;
            this.box2Label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.box2Label.Location = new System.Drawing.Point(497, 273);
            this.box2Label.Name = "box2Label";
            this.box2Label.Size = new System.Drawing.Size(0, 15);
            this.box2Label.TabIndex = 8;
            this.box2Label.MouseHover += new System.EventHandler(this.box2Label_MouseHover);
            // 
            // toBox2btn
            // 
            this.toBox2btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toBox2btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toBox2btn.FlatAppearance.BorderSize = 0;
            this.toBox2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toBox2btn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBox2btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toBox2btn.Location = new System.Drawing.Point(500, 299);
            this.toBox2btn.Name = "toBox2btn";
            this.toBox2btn.Size = new System.Drawing.Size(128, 23);
            this.toBox2btn.TabIndex = 7;
            this.toBox2btn.Text = "Place to Box 2";
            this.toBox2btn.UseVisualStyleBackColor = false;
            this.toBox2btn.Click += new System.EventHandler(this.Box2Placing);
            // 
            // toBox1btn
            // 
            this.toBox1btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toBox1btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toBox1btn.FlatAppearance.BorderSize = 0;
            this.toBox1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toBox1btn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBox1btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toBox1btn.Location = new System.Drawing.Point(314, 299);
            this.toBox1btn.Name = "toBox1btn";
            this.toBox1btn.Size = new System.Drawing.Size(128, 23);
            this.toBox1btn.TabIndex = 6;
            this.toBox1btn.Text = "Place To Box 1";
            this.toBox1btn.UseVisualStyleBackColor = false;
            this.toBox1btn.Click += new System.EventHandler(this.Box1Placing);
            // 
            // box1Tooltip
            // 
            this.box1Tooltip.Active = false;
            // 
            // box2Tooltip
            // 
            this.box2Tooltip.Active = false;
            // 
            // minimizedBtn
            // 
            this.minimizedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.minimizedBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimizedBtn.FlatAppearance.BorderSize = 0;
            this.minimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedBtn.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.minimizedBtn.ForeColor = System.Drawing.Color.Red;
            this.minimizedBtn.Location = new System.Drawing.Point(569, 3);
            this.minimizedBtn.Name = "minimizedBtn";
            this.minimizedBtn.Size = new System.Drawing.Size(29, 21);
            this.minimizedBtn.TabIndex = 8;
            this.minimizedBtn.Text = "-";
            this.minimizedBtn.UseVisualStyleBackColor = false;
            this.minimizedBtn.Click += new System.EventHandler(this.minimizedBtnClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CancelButton = this.xBtn;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.minimizedBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Osu!Skin Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.treeRightClickMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView skinTree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenu;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.ContextMenuStrip treeRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toBox1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem box1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem box2ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button toBox2btn;
        private System.Windows.Forms.Button toBox1btn;
        private System.Windows.Forms.ToolStripMenuItem addNewFileToolStripMenuItem;
        private System.Windows.Forms.Label box1Label;
        private System.Windows.Forms.Label box2Label;
        private System.Windows.Forms.ToolTip box1Tooltip;
        private System.Windows.Forms.ToolTip box2Tooltip;
        private System.Windows.Forms.ToolStripMenuItem openInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem settingMenuBar;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.Button minimizedBtn;
    }
}

