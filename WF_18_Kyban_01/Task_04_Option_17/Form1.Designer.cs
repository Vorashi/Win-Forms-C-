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
            this.inputTBX = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.defaultText = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTBX
            // 
            this.inputTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTBX.Location = new System.Drawing.Point(6, 40);
            this.inputTBX.Name = "inputTBX";
            this.inputTBX.Size = new System.Drawing.Size(459, 22);
            this.inputTBX.TabIndex = 0;
            // 
            // CalcBtn
            // 
            this.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcBtn.Location = new System.Drawing.Point(176, 148);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(148, 36);
            this.CalcBtn.TabIndex = 1;
            this.CalcBtn.Text = "Расчитать";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // defaultText
            // 
            this.defaultText.AutoSize = true;
            this.defaultText.Location = new System.Drawing.Point(3, 11);
            this.defaultText.Name = "defaultText";
            this.defaultText.Size = new System.Drawing.Size(177, 16);
            this.defaultText.TabIndex = 2;
            this.defaultText.Text = "Введите строку из 5 слов:\r\n";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(3, 82);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(154, 16);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Тут результаты будут";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.defaultText);
            this.panel1.Controls.Add(this.CalcBtn);
            this.panel1.Controls.Add(this.ResultLabel);
            this.panel1.Controls.Add(this.inputTBX);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 205);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 227);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Task_04_18_laba";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputTBX;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label defaultText;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

