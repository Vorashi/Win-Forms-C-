namespace Task_01
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.форма1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.форма1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // mnu
            // 
            this.mnu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форма1ToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(800, 28);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // форма1ToolStripMenuItem
            // 
            this.форма1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форма1ToolStripMenuItem1,
            this.форма1ToolStripMenuItem2,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.форма1ToolStripMenuItem.Name = "форма1ToolStripMenuItem";
            this.форма1ToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.форма1ToolStripMenuItem.Text = "Laboratory work";
            this.форма1ToolStripMenuItem.Click += new System.EventHandler(this.форма1ToolStripMenuItem_Click);
            // 
            // форма1ToolStripMenuItem1
            // 
            this.форма1ToolStripMenuItem1.Name = "форма1ToolStripMenuItem1";
            this.форма1ToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.форма1ToolStripMenuItem1.Text = "form 1 ";
            this.форма1ToolStripMenuItem1.Click += new System.EventHandler(this.форма1ToolStripMenuItem1_Click);
            // 
            // форма1ToolStripMenuItem2
            // 
            this.форма1ToolStripMenuItem2.Name = "форма1ToolStripMenuItem2";
            this.форма1ToolStripMenuItem2.Size = new System.Drawing.Size(140, 26);
            this.форма1ToolStripMenuItem2.Text = "form 2";
            this.форма1ToolStripMenuItem2.Click += new System.EventHandler(this.форма1ToolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem форма1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem форма1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

