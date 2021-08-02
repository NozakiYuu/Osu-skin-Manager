
namespace Osu_skin_Manager.GUIs
{
    partial class SettingForm
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
            this.userPathTxt = new System.Windows.Forms.TextBox();
            this.userPathLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.xBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userPathTxt
            // 
            this.userPathTxt.Location = new System.Drawing.Point(90, 51);
            this.userPathTxt.Name = "userPathTxt";
            this.userPathTxt.ReadOnly = true;
            this.userPathTxt.Size = new System.Drawing.Size(166, 20);
            this.userPathTxt.TabIndex = 0;
            // 
            // userPathLabel
            // 
            this.userPathLabel.AutoSize = true;
            this.userPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPathLabel.Location = new System.Drawing.Point(12, 54);
            this.userPathLabel.Name = "userPathLabel";
            this.userPathLabel.Size = new System.Drawing.Size(72, 13);
            this.userPathLabel.TabIndex = 1;
            this.userPathLabel.Text = "Skin folder:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xBtn
            // 
            this.xBtn.Location = new System.Drawing.Point(334, 12);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(23, 20);
            this.xBtn.TabIndex = 3;
            this.xBtn.Text = "X";
            this.xBtn.UseVisualStyleBackColor = true;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Settings";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userPathLabel);
            this.Controls.Add(this.userPathTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "Settings!";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userPathTxt;
        private System.Windows.Forms.Label userPathLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Label label1;
    }
}