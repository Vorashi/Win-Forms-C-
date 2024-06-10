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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void форма1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void форма3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void форма1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm1 newForm1 = new frm1();
            newForm1.Show();
        }

        private void форма1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm2 newForm2 = new frm2();
            newForm2.Show();
        }
    }
}
