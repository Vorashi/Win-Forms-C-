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

        string fname;
        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            file1.ShowDialog();
            fname = file1.FileName;
            pct.Image = Image.FromFile(fname);
            tbx.Text = fname;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbx.Text != "") 
            { 
                sfd.ShowDialog();
                pct.Image.Save(sfd.FileName);
            }
        }
    }
}
