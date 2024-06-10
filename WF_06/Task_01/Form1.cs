using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            CalcXN.Visible = false;
            N.Visible = false;
            txtN.Visible = false;
        }

        public long Factorial(int n)
        {
            long p = 2;
            for (int i = 3; i <= n; i++)
                p = p * i;
            return p;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numb;
            if (int.TryParse(txtFactorial.Text, out numb))
            {
                Result.Text = Factorial(numb).ToString();
            }
            else
                MessageBox.Show("введите число");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcXN_Click(object sender, EventArgs e)
        {
            int numa = int.Parse(txtFactorial.Text);
            int numc = int.Parse(txtN.Text);
            double resultx = Math.Pow(numa, numc);
            Result.Text = resultx.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CalcXN.Visible = true;
                N.Visible = true;
                txtN.Visible = true;
            }
            else
            { 
                CalcXN.Visible = false;
                N.Visible = false; 
                txtN.Visible = false;
            }
        }
    }
}
