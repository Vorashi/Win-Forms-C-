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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        public void DigitCountSum() { 
            int K = int.Parse(tbx_1.Text);
            int couterPositiveNumber = 0;
            int sumPositiveNumber = 0;
            for (int i = 2; i <= K; i++) 
            {
                if (i % 2 == 0) { 
                    sumPositiveNumber += i;
                    couterPositiveNumber++;
                }
            }
            label3.Text = couterPositiveNumber.ToString();
            label5.Text = sumPositiveNumber.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DigitCountSum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
