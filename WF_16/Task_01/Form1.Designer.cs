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
            this.btn_debug = new System.Windows.Forms.Button();
            this.lblWrite = new System.Windows.Forms.Label();
            this.tbxRunning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSpeed = new System.Windows.Forms.TextBox();
            this.runningText1 = new Task_01.RunningText();
            this.SuspendLayout();
            // 
            // btn_debug
            // 
            this.btn_debug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_debug.Location = new System.Drawing.Point(155, 209);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(102, 23);
            this.btn_debug.TabIndex = 0;
            this.btn_debug.Text = "Изменить";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Location = new System.Drawing.Point(65, 175);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(70, 16);
            this.lblWrite.TabIndex = 1;
            this.lblWrite.Text = "Write word";
            // 
            // tbxRunning
            // 
            this.tbxRunning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRunning.Location = new System.Drawing.Point(155, 173);
            this.tbxRunning.Name = "tbxRunning";
            this.tbxRunning.Size = new System.Drawing.Size(171, 22);
            this.tbxRunning.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Speed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxSpeed
            // 
            this.tbxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSpeed.Location = new System.Drawing.Point(155, 248);
            this.tbxSpeed.Name = "tbxSpeed";
            this.tbxSpeed.Size = new System.Drawing.Size(171, 22);
            this.tbxSpeed.TabIndex = 12;
            // 
            // runningText1
            // 
            this.runningText1.Location = new System.Drawing.Point(12, 67);
            this.runningText1.Name = "runningText1";
            this.runningText1.Size = new System.Drawing.Size(395, 59);
            this.runningText1.Speed = 20;
            this.runningText1.TabIndex = 4;
            this.runningText1.Load += new System.EventHandler(this.runningText1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 318);
            this.Controls.Add(this.tbxSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runningText1);
            this.Controls.Add(this.tbxRunning);
            this.Controls.Add(this.lblWrite);
            this.Controls.Add(this.btn_debug);
            this.Name = "Form1";
            this.Text = "Runing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_debug;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.TextBox tbxRunning;
        private RunningText runningText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSpeed;
    }
}

