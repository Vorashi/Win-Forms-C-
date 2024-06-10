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
            this.btn = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.pct = new System.Windows.Forms.PictureBox();
            this.tbx = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Location = new System.Drawing.Point(106, 349);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(163, 35);
            this.btn.TabIndex = 0;
            this.btn.Text = "Load image";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            this.file1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pct
            // 
            this.pct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pct.Location = new System.Drawing.Point(59, 25);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(251, 290);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct.TabIndex = 1;
            this.pct.TabStop = false;
            // 
            // tbx
            // 
            this.tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx.Location = new System.Drawing.Point(12, 321);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(363, 22);
            this.tbx.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(106, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Open image file";
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

