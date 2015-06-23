namespace CProcess_
{
    partial class MainForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxApps = new System.Windows.Forms.ListBox();
            this.butAddProgram = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butRemoveApp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butRun = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxApps
            // 
            this.listBoxApps.FormattingEnabled = true;
            this.listBoxApps.ItemHeight = 16;
            this.listBoxApps.Location = new System.Drawing.Point(13, 45);
            this.listBoxApps.Name = "listBoxApps";
            this.listBoxApps.Size = new System.Drawing.Size(322, 388);
            this.listBoxApps.TabIndex = 0;
            // 
            // butAddProgram
            // 
            this.butAddProgram.Location = new System.Drawing.Point(348, 45);
            this.butAddProgram.Name = "butAddProgram";
            this.butAddProgram.Size = new System.Drawing.Size(158, 23);
            this.butAddProgram.TabIndex = 1;
            this.butAddProgram.Text = "Add";
            this.butAddProgram.UseVisualStyleBackColor = true;
            this.butAddProgram.Click += new System.EventHandler(this.butAddProgram_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(349, 75);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(157, 23);
            this.butEdit.TabIndex = 2;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butRemoveApp
            // 
            this.butRemoveApp.Location = new System.Drawing.Point(349, 104);
            this.butRemoveApp.Name = "butRemoveApp";
            this.butRemoveApp.Size = new System.Drawing.Size(157, 23);
            this.butRemoveApp.TabIndex = 3;
            this.butRemoveApp.Text = "Remove";
            this.butRemoveApp.UseVisualStyleBackColor = true;
            this.butRemoveApp.Click += new System.EventHandler(this.butRemoveApp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sAveToolStripMenuItem
            // 
            this.sAveToolStripMenuItem.Name = "sAveToolStripMenuItem";
            this.sAveToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.sAveToolStripMenuItem.Text = "Save";
            this.sAveToolStripMenuItem.Click += new System.EventHandler(this.sAveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(341, 379);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(165, 54);
            this.butRun.TabIndex = 5;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 464);
            this.Controls.Add(this.butRun);
            this.Controls.Add(this.butRemoveApp);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAddProgram);
            this.Controls.Add(this.listBoxApps);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CProcess+";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.Button butAddProgram;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butRemoveApp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button butRun;
    }
}

