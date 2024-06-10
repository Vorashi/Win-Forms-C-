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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletedAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bthAddMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstZakaz = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeletedAll);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lstMenu);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.lstZakaz);
            this.panel1.Location = new System.Drawing.Point(23, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 293);
            this.panel1.TabIndex = 10;
            // 
            // btnDeletedAll
            // 
            this.btnDeletedAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedAll.Location = new System.Drawing.Point(684, 188);
            this.btnDeletedAll.Name = "btnDeletedAll";
            this.btnDeletedAll.Size = new System.Drawing.Size(85, 44);
            this.btnDeletedAll.TabIndex = 11;
            this.btnDeletedAll.Text = "Убрать всё";
            this.btnDeletedAll.UseVisualStyleBackColor = true;
            this.btnDeletedAll.Click += new System.EventHandler(this.btnDeletedAll_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bthAddMenu);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(97, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 178);
            this.panel2.TabIndex = 10;
            // 
            // bthAddMenu
            // 
            this.bthAddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthAddMenu.Location = new System.Drawing.Point(45, 74);
            this.bthAddMenu.Name = "bthAddMenu";
            this.bthAddMenu.Size = new System.Drawing.Size(125, 60);
            this.bthAddMenu.TabIndex = 11;
            this.bthAddMenu.Text = "Добавить в Меню";
            this.bthAddMenu.UseVisualStyleBackColor = true;
            this.bthAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(19, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 9;
            // 
            // lstMenu
            // 
            this.lstMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 16;
            this.lstMenu.Items.AddRange(new object[] {
            "жаренный гусь (14)",
            "суп спаггетти  (10)",
            "соляночка  (20)",
            "жаренная свинья  (65)",
            "бич домохозяек  (76)",
            "биг поп троицких ворот  (4)",
            "солённые сигареты  (23)",
            "Жебраковские поля   (42)"});
            this.lstMenu.Location = new System.Drawing.Point(410, 54);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(234, 178);
            this.lstMenu.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(941, 248);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 30);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Заказать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(495, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(887, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Заказ";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(684, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(684, 119);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 31);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // lstZakaz
            // 
            this.lstZakaz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstZakaz.FormattingEnabled = true;
            this.lstZakaz.ItemHeight = 16;
            this.lstZakaz.Location = new System.Drawing.Point(796, 54);
            this.lstZakaz.Name = "lstZakaz";
            this.lstZakaz.Size = new System.Drawing.Size(228, 178);
            this.lstZakaz.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 345);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstZakaz;
        private System.Windows.Forms.Button btnDeletedAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bthAddMenu;
        private System.Windows.Forms.TextBox textBox1;
    }
}

