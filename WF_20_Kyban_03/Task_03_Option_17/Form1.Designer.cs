namespace Task_03_Option_17
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
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WaySaveFileLabel = new System.Windows.Forms.Label();
            this.SaveFileInputLabel = new System.Windows.Forms.TextBox();
            this.WhatSaveFileLabel = new System.Windows.Forms.Label();
            this.FileInputTbx = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.WayLabel = new System.Windows.Forms.Label();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenFileBtn.Location = new System.Drawing.Point(21, 331);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(130, 36);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "Открыть файл";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveFileBtn.Location = new System.Drawing.Point(207, 331);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(131, 36);
            this.SaveFileBtn.TabIndex = 1;
            this.SaveFileBtn.Text = "Сохранить файл";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.WaySaveFileLabel);
            this.groupBox1.Controls.Add(this.SaveFileInputLabel);
            this.groupBox1.Controls.Add(this.WhatSaveFileLabel);
            this.groupBox1.Controls.Add(this.FileInputTbx);
            this.groupBox1.Controls.Add(this.FileNameLabel);
            this.groupBox1.Controls.Add(this.WayLabel);
            this.groupBox1.Controls.Add(this.OpenFileBtn);
            this.groupBox1.Controls.Add(this.SaveFileBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 386);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Преобразователь";
            // 
            // WaySaveFileLabel
            // 
            this.WaySaveFileLabel.AutoSize = true;
            this.WaySaveFileLabel.Location = new System.Drawing.Point(26, 242);
            this.WaySaveFileLabel.Name = "WaySaveFileLabel";
            this.WaySaveFileLabel.Size = new System.Drawing.Size(0, 16);
            this.WaySaveFileLabel.TabIndex = 9;
            this.WaySaveFileLabel.Visible = false;
            // 
            // SaveFileInputLabel
            // 
            this.SaveFileInputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveFileInputLabel.Location = new System.Drawing.Point(22, 268);
            this.SaveFileInputLabel.Multiline = true;
            this.SaveFileInputLabel.Name = "SaveFileInputLabel";
            this.SaveFileInputLabel.Size = new System.Drawing.Size(314, 57);
            this.SaveFileInputLabel.TabIndex = 8;
            this.SaveFileInputLabel.Visible = false;
            // 
            // WhatSaveFileLabel
            // 
            this.WhatSaveFileLabel.AutoSize = true;
            this.WhatSaveFileLabel.Location = new System.Drawing.Point(21, 215);
            this.WhatSaveFileLabel.Name = "WhatSaveFileLabel";
            this.WhatSaveFileLabel.Size = new System.Drawing.Size(106, 16);
            this.WhatSaveFileLabel.TabIndex = 7;
            this.WhatSaveFileLabel.Text = "Что сохранили:";
            this.WhatSaveFileLabel.Visible = false;
            // 
            // FileInputTbx
            // 
            this.FileInputTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileInputTbx.Location = new System.Drawing.Point(22, 79);
            this.FileInputTbx.Multiline = true;
            this.FileInputTbx.Name = "FileInputTbx";
            this.FileInputTbx.ReadOnly = true;
            this.FileInputTbx.Size = new System.Drawing.Size(314, 93);
            this.FileInputTbx.TabIndex = 6;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(26, 57);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 16);
            this.FileNameLabel.TabIndex = 5;
            this.FileNameLabel.Visible = false;
            // 
            // WayLabel
            // 
            this.WayLabel.AutoSize = true;
            this.WayLabel.Location = new System.Drawing.Point(21, 32);
            this.WayLabel.Name = "WayLabel";
            this.WayLabel.Size = new System.Drawing.Size(83, 16);
            this.WayLabel.TabIndex = 4;
            this.WayLabel.Text = "Вы открыли";
            this.WayLabel.Visible = false;
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 409);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Task_03_20_laba";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label WayLabel;
        private System.Windows.Forms.TextBox FileInputTbx;
        private System.Windows.Forms.Label WhatSaveFileLabel;
        private System.Windows.Forms.TextBox SaveFileInputLabel;
        private System.Windows.Forms.Label WaySaveFileLabel;
    }
}

