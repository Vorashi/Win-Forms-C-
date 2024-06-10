using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Работа с текстом";
            label1.Text = "Операции с текстом";
            label1.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.WhiteSmoke;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.White;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.WhiteSmoke;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.White;
        }
    }
}
