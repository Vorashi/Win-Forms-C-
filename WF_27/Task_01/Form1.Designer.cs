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
            this.BtnClose = new System.Windows.Forms.Button();
            this.GbSetA = new System.Windows.Forms.GroupBox();
            this.SetA7 = new System.Windows.Forms.CheckBox();
            this.SetA6 = new System.Windows.Forms.CheckBox();
            this.SetA5 = new System.Windows.Forms.CheckBox();
            this.SetA4 = new System.Windows.Forms.CheckBox();
            this.SetA3 = new System.Windows.Forms.CheckBox();
            this.SetA2 = new System.Windows.Forms.CheckBox();
            this.SetA1 = new System.Windows.Forms.CheckBox();
            this.GbSetB = new System.Windows.Forms.GroupBox();
            this.SetB7 = new System.Windows.Forms.CheckBox();
            this.SetB6 = new System.Windows.Forms.CheckBox();
            this.SetB5 = new System.Windows.Forms.CheckBox();
            this.SetB4 = new System.Windows.Forms.CheckBox();
            this.SetB3 = new System.Windows.Forms.CheckBox();
            this.SetB2 = new System.Windows.Forms.CheckBox();
            this.SetB1 = new System.Windows.Forms.CheckBox();
            this.GbSetC = new System.Windows.Forms.GroupBox();
            this.SetC7 = new System.Windows.Forms.CheckBox();
            this.SetC6 = new System.Windows.Forms.CheckBox();
            this.SetC5 = new System.Windows.Forms.CheckBox();
            this.SetC4 = new System.Windows.Forms.CheckBox();
            this.SetC3 = new System.Windows.Forms.CheckBox();
            this.SetC2 = new System.Windows.Forms.CheckBox();
            this.SetC1 = new System.Windows.Forms.CheckBox();
            this.CbxOperation = new System.Windows.Forms.ComboBox();
            this.CbxPortype = new System.Windows.Forms.CheckedListBox();
            this.GbSetA.SuspendLayout();
            this.GbSetB.SuspendLayout();
            this.GbSetC.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Location = new System.Drawing.Point(570, 301);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(110, 34);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GbSetA
            // 
            this.GbSetA.Controls.Add(this.SetA7);
            this.GbSetA.Controls.Add(this.SetA6);
            this.GbSetA.Controls.Add(this.SetA5);
            this.GbSetA.Controls.Add(this.SetA4);
            this.GbSetA.Controls.Add(this.SetA3);
            this.GbSetA.Controls.Add(this.SetA2);
            this.GbSetA.Controls.Add(this.SetA1);
            this.GbSetA.Location = new System.Drawing.Point(12, 12);
            this.GbSetA.Name = "GbSetA";
            this.GbSetA.Size = new System.Drawing.Size(200, 219);
            this.GbSetA.TabIndex = 1;
            this.GbSetA.TabStop = false;
            this.GbSetA.Text = "Set A";
            this.GbSetA.Enter += new System.EventHandler(this.GbSetA_Enter);
            // 
            // SetA7
            // 
            this.SetA7.AutoSize = true;
            this.SetA7.Location = new System.Drawing.Point(37, 180);
            this.SetA7.Name = "SetA7";
            this.SetA7.Size = new System.Drawing.Size(114, 20);
            this.SetA7.TabIndex = 6;
            this.SetA7.Text = "Воскресенье";
            this.SetA7.UseVisualStyleBackColor = true;
            // 
            // SetA6
            // 
            this.SetA6.AutoSize = true;
            this.SetA6.Location = new System.Drawing.Point(37, 153);
            this.SetA6.Name = "SetA6";
            this.SetA6.Size = new System.Drawing.Size(85, 20);
            this.SetA6.TabIndex = 5;
            this.SetA6.Text = "Суббота";
            this.SetA6.UseVisualStyleBackColor = true;
            // 
            // SetA5
            // 
            this.SetA5.AutoSize = true;
            this.SetA5.Location = new System.Drawing.Point(37, 126);
            this.SetA5.Name = "SetA5";
            this.SetA5.Size = new System.Drawing.Size(85, 20);
            this.SetA5.TabIndex = 4;
            this.SetA5.Text = "Пятница";
            this.SetA5.UseVisualStyleBackColor = true;
            // 
            // SetA4
            // 
            this.SetA4.AutoSize = true;
            this.SetA4.Location = new System.Drawing.Point(37, 99);
            this.SetA4.Name = "SetA4";
            this.SetA4.Size = new System.Drawing.Size(83, 20);
            this.SetA4.TabIndex = 3;
            this.SetA4.Text = "Четверг";
            this.SetA4.UseVisualStyleBackColor = true;
            // 
            // SetA3
            // 
            this.SetA3.AutoSize = true;
            this.SetA3.Location = new System.Drawing.Point(37, 72);
            this.SetA3.Name = "SetA3";
            this.SetA3.Size = new System.Drawing.Size(70, 20);
            this.SetA3.TabIndex = 2;
            this.SetA3.Text = "Среда";
            this.SetA3.UseVisualStyleBackColor = true;
            // 
            // SetA2
            // 
            this.SetA2.AutoSize = true;
            this.SetA2.Location = new System.Drawing.Point(37, 45);
            this.SetA2.Name = "SetA2";
            this.SetA2.Size = new System.Drawing.Size(84, 20);
            this.SetA2.TabIndex = 1;
            this.SetA2.Text = "Вторник";
            this.SetA2.UseVisualStyleBackColor = true;
            // 
            // SetA1
            // 
            this.SetA1.AutoSize = true;
            this.SetA1.Location = new System.Drawing.Point(37, 18);
            this.SetA1.Name = "SetA1";
            this.SetA1.Size = new System.Drawing.Size(117, 20);
            this.SetA1.TabIndex = 0;
            this.SetA1.Text = "Понедельник";
            this.SetA1.UseVisualStyleBackColor = true;
            // 
            // GbSetB
            // 
            this.GbSetB.Controls.Add(this.SetB7);
            this.GbSetB.Controls.Add(this.SetB6);
            this.GbSetB.Controls.Add(this.SetB5);
            this.GbSetB.Controls.Add(this.SetB4);
            this.GbSetB.Controls.Add(this.SetB3);
            this.GbSetB.Controls.Add(this.SetB2);
            this.GbSetB.Controls.Add(this.SetB1);
            this.GbSetB.Location = new System.Drawing.Point(247, 12);
            this.GbSetB.Name = "GbSetB";
            this.GbSetB.Size = new System.Drawing.Size(200, 219);
            this.GbSetB.TabIndex = 7;
            this.GbSetB.TabStop = false;
            this.GbSetB.Text = "Set B";
            // 
            // SetB7
            // 
            this.SetB7.AutoSize = true;
            this.SetB7.Location = new System.Drawing.Point(42, 180);
            this.SetB7.Name = "SetB7";
            this.SetB7.Size = new System.Drawing.Size(114, 20);
            this.SetB7.TabIndex = 13;
            this.SetB7.Text = "Воскресенье";
            this.SetB7.UseVisualStyleBackColor = true;
            // 
            // SetB6
            // 
            this.SetB6.AutoSize = true;
            this.SetB6.Location = new System.Drawing.Point(42, 153);
            this.SetB6.Name = "SetB6";
            this.SetB6.Size = new System.Drawing.Size(85, 20);
            this.SetB6.TabIndex = 12;
            this.SetB6.Text = "Суббота";
            this.SetB6.UseVisualStyleBackColor = true;
            // 
            // SetB5
            // 
            this.SetB5.AutoSize = true;
            this.SetB5.Location = new System.Drawing.Point(42, 126);
            this.SetB5.Name = "SetB5";
            this.SetB5.Size = new System.Drawing.Size(85, 20);
            this.SetB5.TabIndex = 11;
            this.SetB5.Text = "Пятница";
            this.SetB5.UseVisualStyleBackColor = true;
            // 
            // SetB4
            // 
            this.SetB4.AutoSize = true;
            this.SetB4.Location = new System.Drawing.Point(42, 99);
            this.SetB4.Name = "SetB4";
            this.SetB4.Size = new System.Drawing.Size(83, 20);
            this.SetB4.TabIndex = 10;
            this.SetB4.Text = "Четверг";
            this.SetB4.UseVisualStyleBackColor = true;
            // 
            // SetB3
            // 
            this.SetB3.AutoSize = true;
            this.SetB3.Location = new System.Drawing.Point(42, 72);
            this.SetB3.Name = "SetB3";
            this.SetB3.Size = new System.Drawing.Size(70, 20);
            this.SetB3.TabIndex = 9;
            this.SetB3.Text = "Среда";
            this.SetB3.UseVisualStyleBackColor = true;
            // 
            // SetB2
            // 
            this.SetB2.AutoSize = true;
            this.SetB2.Location = new System.Drawing.Point(42, 45);
            this.SetB2.Name = "SetB2";
            this.SetB2.Size = new System.Drawing.Size(84, 20);
            this.SetB2.TabIndex = 8;
            this.SetB2.Text = "Вторник";
            this.SetB2.UseVisualStyleBackColor = true;
            // 
            // SetB1
            // 
            this.SetB1.AutoSize = true;
            this.SetB1.Location = new System.Drawing.Point(42, 18);
            this.SetB1.Name = "SetB1";
            this.SetB1.Size = new System.Drawing.Size(117, 20);
            this.SetB1.TabIndex = 7;
            this.SetB1.Text = "Понедельник";
            this.SetB1.UseVisualStyleBackColor = true;
            // 
            // GbSetC
            // 
            this.GbSetC.Controls.Add(this.SetC7);
            this.GbSetC.Controls.Add(this.SetC6);
            this.GbSetC.Controls.Add(this.SetC5);
            this.GbSetC.Controls.Add(this.SetC4);
            this.GbSetC.Controls.Add(this.SetC3);
            this.GbSetC.Controls.Add(this.SetC2);
            this.GbSetC.Controls.Add(this.SetC1);
            this.GbSetC.Location = new System.Drawing.Point(480, 12);
            this.GbSetC.Name = "GbSetC";
            this.GbSetC.Size = new System.Drawing.Size(200, 219);
            this.GbSetC.TabIndex = 7;
            this.GbSetC.TabStop = false;
            this.GbSetC.Text = "Set C";
            // 
            // SetC7
            // 
            this.SetC7.AutoSize = true;
            this.SetC7.Location = new System.Drawing.Point(42, 180);
            this.SetC7.Name = "SetC7";
            this.SetC7.Size = new System.Drawing.Size(114, 20);
            this.SetC7.TabIndex = 13;
            this.SetC7.Text = "Воскресенье";
            this.SetC7.UseVisualStyleBackColor = true;
            // 
            // SetC6
            // 
            this.SetC6.AutoSize = true;
            this.SetC6.Location = new System.Drawing.Point(42, 153);
            this.SetC6.Name = "SetC6";
            this.SetC6.Size = new System.Drawing.Size(85, 20);
            this.SetC6.TabIndex = 12;
            this.SetC6.Text = "Суббота";
            this.SetC6.UseVisualStyleBackColor = true;
            // 
            // SetC5
            // 
            this.SetC5.AutoSize = true;
            this.SetC5.Location = new System.Drawing.Point(42, 126);
            this.SetC5.Name = "SetC5";
            this.SetC5.Size = new System.Drawing.Size(85, 20);
            this.SetC5.TabIndex = 11;
            this.SetC5.Text = "Пятница";
            this.SetC5.UseVisualStyleBackColor = true;
            // 
            // SetC4
            // 
            this.SetC4.AutoSize = true;
            this.SetC4.Location = new System.Drawing.Point(42, 99);
            this.SetC4.Name = "SetC4";
            this.SetC4.Size = new System.Drawing.Size(83, 20);
            this.SetC4.TabIndex = 10;
            this.SetC4.Text = "Четверг";
            this.SetC4.UseVisualStyleBackColor = true;
            // 
            // SetC3
            // 
            this.SetC3.AutoSize = true;
            this.SetC3.Location = new System.Drawing.Point(42, 72);
            this.SetC3.Name = "SetC3";
            this.SetC3.Size = new System.Drawing.Size(70, 20);
            this.SetC3.TabIndex = 9;
            this.SetC3.Text = "Среда";
            this.SetC3.UseVisualStyleBackColor = true;
            // 
            // SetC2
            // 
            this.SetC2.AutoSize = true;
            this.SetC2.Location = new System.Drawing.Point(42, 45);
            this.SetC2.Name = "SetC2";
            this.SetC2.Size = new System.Drawing.Size(84, 20);
            this.SetC2.TabIndex = 8;
            this.SetC2.Text = "Вторник";
            this.SetC2.UseVisualStyleBackColor = true;
            // 
            // SetC1
            // 
            this.SetC1.AutoSize = true;
            this.SetC1.Location = new System.Drawing.Point(42, 18);
            this.SetC1.Name = "SetC1";
            this.SetC1.Size = new System.Drawing.Size(117, 20);
            this.SetC1.TabIndex = 7;
            this.SetC1.Text = "Понедельник";
            this.SetC1.UseVisualStyleBackColor = true;
            // 
            // CbxOperation
            // 
            this.CbxOperation.FormattingEnabled = true;
            this.CbxOperation.Items.AddRange(new object[] {
            "+",
            "*",
            "-"});
            this.CbxOperation.Location = new System.Drawing.Point(480, 265);
            this.CbxOperation.Name = "CbxOperation";
            this.CbxOperation.Size = new System.Drawing.Size(200, 24);
            this.CbxOperation.TabIndex = 9;
            this.CbxOperation.SelectedIndexChanged += new System.EventHandler(this.CbxOperation_SelectedIndexChanged);
            // 
            // CbxPortype
            // 
            this.CbxPortype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CbxPortype.FormattingEnabled = true;
            this.CbxPortype.Items.AddRange(new object[] {
            "A = B",
            "A <= B",
            "A >= B"});
            this.CbxPortype.Location = new System.Drawing.Point(12, 244);
            this.CbxPortype.Margin = new System.Windows.Forms.Padding(10);
            this.CbxPortype.MultiColumn = true;
            this.CbxPortype.Name = "CbxPortype";
            this.CbxPortype.Size = new System.Drawing.Size(200, 87);
            this.CbxPortype.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 359);
            this.Controls.Add(this.CbxPortype);
            this.Controls.Add(this.CbxOperation);
            this.Controls.Add(this.GbSetB);
            this.Controls.Add(this.GbSetC);
            this.Controls.Add(this.GbSetA);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "WF_27_Множества";
            this.GbSetA.ResumeLayout(false);
            this.GbSetA.PerformLayout();
            this.GbSetB.ResumeLayout(false);
            this.GbSetB.PerformLayout();
            this.GbSetC.ResumeLayout(false);
            this.GbSetC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GbSetA;
        private System.Windows.Forms.GroupBox GbSetB;
        private System.Windows.Forms.GroupBox GbSetC;
        private System.Windows.Forms.ComboBox CbxOperation;
        private System.Windows.Forms.CheckedListBox CbxPortype;
        private System.Windows.Forms.CheckBox SetA7;
        private System.Windows.Forms.CheckBox SetA6;
        private System.Windows.Forms.CheckBox SetA5;
        private System.Windows.Forms.CheckBox SetA4;
        private System.Windows.Forms.CheckBox SetA3;
        private System.Windows.Forms.CheckBox SetA2;
        private System.Windows.Forms.CheckBox SetA1;
        private System.Windows.Forms.CheckBox SetB7;
        private System.Windows.Forms.CheckBox SetB6;
        private System.Windows.Forms.CheckBox SetB5;
        private System.Windows.Forms.CheckBox SetB4;
        private System.Windows.Forms.CheckBox SetB3;
        private System.Windows.Forms.CheckBox SetB2;
        private System.Windows.Forms.CheckBox SetB1;
        private System.Windows.Forms.CheckBox SetC7;
        private System.Windows.Forms.CheckBox SetC6;
        private System.Windows.Forms.CheckBox SetC5;
        private System.Windows.Forms.CheckBox SetC4;
        private System.Windows.Forms.CheckBox SetC3;
        private System.Windows.Forms.CheckBox SetC2;
        private System.Windows.Forms.CheckBox SetC1;
    }
}

