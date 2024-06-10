namespace Task_01
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arrayWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayWorkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.functionWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayWorkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arrayWorkToolStripMenuItem
            // 
            this.arrayWorkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayWorkToolStripMenuItem1,
            this.functionWorkToolStripMenuItem,
            this.stringWorkToolStripMenuItem});
            this.arrayWorkToolStripMenuItem.Name = "arrayWorkToolStripMenuItem";
            this.arrayWorkToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.arrayWorkToolStripMenuItem.Text = "12 laba";
            // 
            // arrayWorkToolStripMenuItem1
            // 
            this.arrayWorkToolStripMenuItem1.Name = "arrayWorkToolStripMenuItem1";
            this.arrayWorkToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.arrayWorkToolStripMenuItem1.Text = "Array Work";
            this.arrayWorkToolStripMenuItem1.Click += new System.EventHandler(this.arrayWorkToolStripMenuItem1_Click);
            // 
            // functionWorkToolStripMenuItem
            // 
            this.functionWorkToolStripMenuItem.Name = "functionWorkToolStripMenuItem";
            this.functionWorkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.functionWorkToolStripMenuItem.Text = "Function Work";
            this.functionWorkToolStripMenuItem.Click += new System.EventHandler(this.functionWorkToolStripMenuItem_Click);
            // 
            // stringWorkToolStripMenuItem
            // 
            this.stringWorkToolStripMenuItem.Name = "stringWorkToolStripMenuItem";
            this.stringWorkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stringWorkToolStripMenuItem.Text = "String Work";
            this.stringWorkToolStripMenuItem.Click += new System.EventHandler(this.stringWorkToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(84, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use burger menu or exit form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arrayWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayWorkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem functionWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringWorkToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

