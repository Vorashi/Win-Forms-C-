using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_03
{
    public partial class Task_03 : Form
    {
        public Task_03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal n = numericUpDown1.Value;
            string s = n.ToString();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
                sum += Convert.ToInt32(s[i].ToString());
            label2.Text = "Сумма цифр = " + sum;
        }
    }
}
