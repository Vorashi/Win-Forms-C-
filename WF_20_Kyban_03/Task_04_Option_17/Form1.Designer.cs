namespace Task_04_Option_17
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
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.WayOpenFileLabel = new System.Windows.Forms.Label();
            this.ContentOpenFileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseFileBtn.Location = new System.Drawing.Point(27, 134);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(153, 23);
            this.ChooseFileBtn.TabIndex = 0;
            this.ChooseFileBtn.Text = "Выбрать файл";
            this.ChooseFileBtn.UseVisualStyleBackColor = true;
            this.ChooseFileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveFileBtn.Location = new System.Drawing.Point(212, 134);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(148, 23);
            this.SaveFileBtn.TabIndex = 1;
            this.SaveFileBtn.Text = "Сохранить файл";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WayOpenFileLabel
            // 
            this.WayOpenFileLabel.AutoSize = true;
            this.WayOpenFileLabel.Location = new System.Drawing.Point(24, 36);
            this.WayOpenFileLabel.Name = "WayOpenFileLabel";
            this.WayOpenFileLabel.Size = new System.Drawing.Size(0, 16);
            this.WayOpenFileLabel.TabIndex = 2;
            this.WayOpenFileLabel.Visible = false;
            // 
            // ContentOpenFileLabel
            // 
            this.ContentOpenFileLabel.AutoSize = true;
            this.ContentOpenFileLabel.Location = new System.Drawing.Point(24, 69);
            this.ContentOpenFileLabel.Name = "ContentOpenFileLabel";
            this.ContentOpenFileLabel.Size = new System.Drawing.Size(0, 16);
            this.ContentOpenFileLabel.TabIndex = 3;
            this.ContentOpenFileLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 185);
            this.Controls.Add(this.ContentOpenFileLabel);
            this.Controls.Add(this.WayOpenFileLabel);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.ChooseFileBtn);
            this.Name = "Form1";
            this.Text = "Task_04_20_laba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label WayOpenFileLabel;
        private System.Windows.Forms.Label ContentOpenFileLabel;
    }
}

