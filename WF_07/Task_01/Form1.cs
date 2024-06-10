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

        private void tmr_Tick(object sender, EventArgs e)
        {
            pct.Left = pct.Left + 20;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!tmr.Enabled)
            {
                tmr.Enabled = true;
                tmr.Interval = 50;
                btnStart.Text = "Stop";
            }
            else
            { 
                tmr.Enabled = false;
                pct.Location = new Point(31, 25);
                btnStart.Text = "Start";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
