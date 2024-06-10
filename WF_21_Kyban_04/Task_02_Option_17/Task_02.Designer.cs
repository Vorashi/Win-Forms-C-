namespace Task_02_Option_17
{
    partial class Task_02
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ArgumentALabel = new System.Windows.Forms.Label();
            this.ArgATbx = new System.Windows.Forms.TextBox();
            this.ArgumentXLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.StartInterbalLabel = new System.Windows.Forms.Label();
            this.EndInterbalLabal = new System.Windows.Forms.Label();
            this.StartInterbalTbx = new System.Windows.Forms.TextBox();
            this.EndInterbalTbx = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcBtn.Location = new System.Drawing.Point(105, 170);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(120, 23);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "Рассчитать";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArgumentALabel
            // 
            this.ArgumentALabel.AutoSize = true;
            this.ArgumentALabel.Location = new System.Drawing.Point(86, 37);
            this.ArgumentALabel.Name = "ArgumentALabel";
            this.ArgumentALabel.Size = new System.Drawing.Size(82, 16);
            this.ArgumentALabel.TabIndex = 1;
            this.ArgumentALabel.Text = "Аргумент A";
            // 
            // ArgATbx
            // 
            this.ArgATbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArgATbx.Location = new System.Drawing.Point(174, 35);
            this.ArgATbx.Name = "ArgATbx";
            this.ArgATbx.Size = new System.Drawing.Size(100, 22);
            this.ArgATbx.TabIndex = 2;
            // 
            // ArgumentXLabel
            // 
            this.ArgumentXLabel.AutoSize = true;
            this.ArgumentXLabel.Location = new System.Drawing.Point(47, 138);
            this.ArgumentXLabel.Name = "ArgumentXLabel";
            this.ArgumentXLabel.Size = new System.Drawing.Size(25, 16);
            this.ArgumentXLabel.TabIndex = 4;
            this.ArgumentXLabel.Text = "X =";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(86, 138);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 16);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(86, 115);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(139, 16);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Заполните все поля";
            this.ErrorLabel.Visible = false;
            // 
            // StartInterbalLabel
            // 
            this.StartInterbalLabel.AutoSize = true;
            this.StartInterbalLabel.Location = new System.Drawing.Point(37, 64);
            this.StartInterbalLabel.Name = "StartInterbalLabel";
            this.StartInterbalLabel.Size = new System.Drawing.Size(131, 16);
            this.StartInterbalLabel.TabIndex = 7;
            this.StartInterbalLabel.Text = "Начало интервала";
            // 
            // EndInterbalLabal
            // 
            this.EndInterbalLabal.AutoSize = true;
            this.EndInterbalLabal.Location = new System.Drawing.Point(47, 90);
            this.EndInterbalLabal.Name = "EndInterbalLabal";
            this.EndInterbalLabal.Size = new System.Drawing.Size(121, 16);
            this.EndInterbalLabal.TabIndex = 8;
            this.EndInterbalLabal.Text = "Конец интервала";
            // 
            // StartInterbalTbx
            // 
            this.StartInterbalTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartInterbalTbx.Location = new System.Drawing.Point(174, 62);
            this.StartInterbalTbx.Name = "StartInterbalTbx";
            this.StartInterbalTbx.Size = new System.Drawing.Size(100, 22);
            this.StartInterbalTbx.TabIndex = 9;
            // 
            // EndInterbalTbx
            // 
            this.EndInterbalTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndInterbalTbx.Location = new System.Drawing.Point(174, 90);
            this.EndInterbalTbx.Name = "EndInterbalTbx";
            this.EndInterbalTbx.Size = new System.Drawing.Size(100, 22);
            this.EndInterbalTbx.TabIndex = 10;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Location = new System.Drawing.Point(105, 200);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(120, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Task_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 247);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EndInterbalTbx);
            this.Controls.Add(this.StartInterbalTbx);
            this.Controls.Add(this.EndInterbalLabal);
            this.Controls.Add(this.StartInterbalLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ArgumentXLabel);
            this.Controls.Add(this.ArgATbx);
            this.Controls.Add(this.ArgumentALabel);
            this.Controls.Add(this.CalcBtn);
            this.Name = "Task_02";
            this.Text = "Task_02_17_21_laba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label ArgumentALabel;
        private System.Windows.Forms.TextBox ArgATbx;
        private System.Windows.Forms.Label ArgumentXLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label StartInterbalLabel;
        private System.Windows.Forms.Label EndInterbalLabal;
        private System.Windows.Forms.TextBox StartInterbalTbx;
        private System.Windows.Forms.TextBox EndInterbalTbx;
        private System.Windows.Forms.Button ExitBtn;
    }
}

