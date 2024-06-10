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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SearchString() 
        {
            string userString = (textBox1.Text);
            string searchString = "вино";

            int index = userString.IndexOf(searchString);
            if (index != -1)
            {
                userString = userString.Remove(index, searchString.Length);
                label5.Text = userString;
            }
            else 
            { 
                label5.Text = userString;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
