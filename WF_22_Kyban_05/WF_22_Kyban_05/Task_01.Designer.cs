namespace WF_22_Kyban_05
{
    partial class Task_01
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnDeletePoint = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView2 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelList = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.XNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Location = new System.Drawing.Point(245, 58);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 49);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalc.Location = new System.Drawing.Point(524, 58);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(139, 49);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "Решить задачу";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnDeletePoint
            // 
            this.BtnDeletePoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeletePoint.Location = new System.Drawing.Point(146, 349);
            this.BtnDeletePoint.Name = "BtnDeletePoint";
            this.BtnDeletePoint.Size = new System.Drawing.Size(154, 53);
            this.BtnDeletePoint.TabIndex = 2;
            this.BtnDeletePoint.Text = "Удалить выбранную точку";
            this.BtnDeletePoint.UseVisualStyleBackColor = true;
            this.BtnDeletePoint.Click += new System.EventHandler(this.BtnDeletePoint_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSort.Location = new System.Drawing.Point(499, 349);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(154, 53);
            this.BtnSort.TabIndex = 3;
            this.BtnSort.Text = "Отсортировать";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Location = new System.Drawing.Point(347, 349);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(95, 53);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridView1.Location = new System.Drawing.Point(100, 152);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowHeadersWidth = 51;
            this.GridView1.RowTemplate.Height = 24;
            this.GridView1.Size = new System.Drawing.Size(276, 171);
            this.GridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "x";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "y";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // GridView2
            // 
            this.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.GridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridView2.Location = new System.Drawing.Point(438, 152);
            this.GridView2.Name = "GridView2";
            this.GridView2.RowHeadersWidth = 51;
            this.GridView2.RowTemplate.Height = 24;
            this.GridView2.Size = new System.Drawing.Size(283, 171);
            this.GridView2.TabIndex = 6;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.y.Width = 125;
            // 
            // LabelList
            // 
            this.LabelList.AutoSize = true;
            this.LabelList.Location = new System.Drawing.Point(97, 130);
            this.LabelList.Name = "LabelList";
            this.LabelList.Size = new System.Drawing.Size(119, 16);
            this.LabelList.TabIndex = 7;
            this.LabelList.Text = "Исходный список";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(435, 130);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(77, 16);
            this.LabelResult.TabIndex = 8;
            this.LabelResult.Text = "Результат";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(50, 54);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(23, 16);
            this.LabelX.TabIndex = 9;
            this.LabelX.Text = "x =";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(53, 91);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(27, 16);
            this.LabelY.TabIndex = 10;
            this.LabelY.Text = "y = ";
            // 
            // XNumericUpDown
            // 
            this.XNumericUpDown.DecimalPlaces = 1;
            this.XNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.XNumericUpDown.Location = new System.Drawing.Point(100, 54);
            this.XNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XNumericUpDown.Name = "XNumericUpDown";
            this.XNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.XNumericUpDown.TabIndex = 11;
            // 
            // YNumericUpDown
            // 
            this.YNumericUpDown.DecimalPlaces = 1;
            this.YNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.YNumericUpDown.Location = new System.Drawing.Point(100, 91);
            this.YNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.YNumericUpDown.Name = "YNumericUpDown";
            this.YNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.YNumericUpDown.TabIndex = 12;
            // 
            // Task_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YNumericUpDown);
            this.Controls.Add(this.XNumericUpDown);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelList);
            this.Controls.Add(this.GridView2);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnDeletePoint);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Task_01";
            this.Text = "Task_01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnDeletePoint;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.DataGridView GridView2;
        private System.Windows.Forms.Label LabelList;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.NumericUpDown XNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.NumericUpDown YNumericUpDown;
    }
}

