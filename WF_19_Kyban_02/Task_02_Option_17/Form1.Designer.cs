namespace Task_02_Option_17
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.GridConteinerData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LuggerLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ResultBtn = new System.Windows.Forms.Label();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.luggerTxb = new System.Windows.Forms.TextBox();
            this.weightTbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridConteinerData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Location = new System.Drawing.Point(366, 62);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Location = new System.Drawing.Point(366, 169);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 23);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.Location = new System.Drawing.Point(366, 115);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(94, 23);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // GridConteinerData
            // 
            this.GridConteinerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridConteinerData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridConteinerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConteinerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GridConteinerData.Location = new System.Drawing.Point(22, 213);
            this.GridConteinerData.Name = "GridConteinerData";
            this.GridConteinerData.RowHeadersWidth = 51;
            this.GridConteinerData.RowTemplate.Height = 24;
            this.GridConteinerData.Size = new System.Drawing.Size(438, 158);
            this.GridConteinerData.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Пассажир";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Багаж";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Вес";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 64);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 16);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "ФИО";
            // 
            // LuggerLabel
            // 
            this.LuggerLabel.AutoSize = true;
            this.LuggerLabel.Location = new System.Drawing.Point(19, 117);
            this.LuggerLabel.Name = "LuggerLabel";
            this.LuggerLabel.Size = new System.Drawing.Size(47, 16);
            this.LuggerLabel.TabIndex = 5;
            this.LuggerLabel.Text = "Багаж";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(19, 171);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(77, 16);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Общий Вес";
            // 
            // ResultBtn
            // 
            this.ResultBtn.AutoSize = true;
            this.ResultBtn.Location = new System.Drawing.Point(222, 399);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(0, 16);
            this.ResultBtn.TabIndex = 7;
            // 
            // nameTxb
            // 
            this.nameTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxb.Location = new System.Drawing.Point(102, 62);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(217, 22);
            this.nameTxb.TabIndex = 8;
            // 
            // luggerTxb
            // 
            this.luggerTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luggerTxb.Location = new System.Drawing.Point(102, 115);
            this.luggerTxb.Name = "luggerTxb";
            this.luggerTxb.Size = new System.Drawing.Size(217, 22);
            this.luggerTxb.TabIndex = 9;
            // 
            // weightTbx
            // 
            this.weightTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightTbx.Location = new System.Drawing.Point(102, 169);
            this.weightTbx.Name = "weightTbx";
            this.weightTbx.Size = new System.Drawing.Size(217, 22);
            this.weightTbx.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GridConteinerData);
            this.panel1.Controls.Add(this.ResultBtn);
            this.panel1.Controls.Add(this.weightTbx);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.luggerTxb);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.nameTxb);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.WeightLabel);
            this.panel1.Controls.Add(this.LuggerLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 467);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 493);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Task_2_17_19_laba";
            ((System.ComponentModel.ISupportInitialize)(this.GridConteinerData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView GridConteinerData;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LuggerLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label ResultBtn;
        private System.Windows.Forms.TextBox nameTxb;
        private System.Windows.Forms.TextBox luggerTxb;
        private System.Windows.Forms.TextBox weightTbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

