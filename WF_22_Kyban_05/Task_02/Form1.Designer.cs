namespace Task_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSplit = new System.Windows.Forms.Button();
            this.TbxLastList = new System.Windows.Forms.TextBox();
            this.TbxFirstList = new System.Windows.Forms.TextBox();
            this.TbxOriginalList = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оригинальный лист";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Первая часть списка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вторая часть списка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnSplit);
            this.groupBox1.Controls.Add(this.TbxLastList);
            this.groupBox1.Controls.Add(this.TbxFirstList);
            this.groupBox1.Controls.Add(this.TbxOriginalList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Главная Тема";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(150, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSplit
            // 
            this.BtnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSplit.Location = new System.Drawing.Point(127, 214);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(163, 23);
            this.BtnSplit.TabIndex = 7;
            this.BtnSplit.Text = "Разделить";
            this.BtnSplit.UseVisualStyleBackColor = true;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // TbxLastList
            // 
            this.TbxLastList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxLastList.Location = new System.Drawing.Point(100, 175);
            this.TbxLastList.Name = "TbxLastList";
            this.TbxLastList.Size = new System.Drawing.Size(217, 22);
            this.TbxLastList.TabIndex = 6;
            // 
            // TbxFirstList
            // 
            this.TbxFirstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFirstList.Location = new System.Drawing.Point(100, 118);
            this.TbxFirstList.Name = "TbxFirstList";
            this.TbxFirstList.Size = new System.Drawing.Size(217, 22);
            this.TbxFirstList.TabIndex = 5;
            // 
            // TbxOriginalList
            // 
            this.TbxOriginalList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxOriginalList.Location = new System.Drawing.Point(100, 61);
            this.TbxOriginalList.Multiline = true;
            this.TbxOriginalList.Name = "TbxOriginalList";
            this.TbxOriginalList.Size = new System.Drawing.Size(217, 22);
            this.TbxOriginalList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 330);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Task_02_17_22_laba ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxLastList;
        private System.Windows.Forms.TextBox TbxFirstList;
        private System.Windows.Forms.TextBox TbxOriginalList;
        private System.Windows.Forms.Button BtnSplit;
        private System.Windows.Forms.Button button1;
    }
}

