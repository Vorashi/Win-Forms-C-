using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else { 
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tmpS = Int32.Parse(txtSeconds.Text);
            int tmpM = Int32.Parse(txtMinutes.Text);
            if (tmpS == 59) { 
                tmpS = 0;
                tmpM += 1;
            }
            else tmpS += 1;
            txtMinutes.Text = tmpM.ToString();
            txtSeconds.Text = tmpS.ToString();
            txtDateNow.Text = DateTime.UtcNow.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            txtSeconds.Text = "";
            txtMinutes.Text = "";
            txtDateNow.Text = "";
        }
    }
}
