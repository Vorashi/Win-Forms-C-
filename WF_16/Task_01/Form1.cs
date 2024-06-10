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
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            //Text = tbxRunning.Text;
            // runningText1.GetNewString(Text);
            runningText1.Text = tbxRunning.Text;
            runningText1.Speed = int.Parse(tbxSpeed.Text);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void runningText1_Load(object sender, EventArgs e)
        {

        }
    }
}
