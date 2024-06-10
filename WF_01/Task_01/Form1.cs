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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Add(lstMenu.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Remove(lstZakaz.SelectedItem);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приятного аппетита!", "Ресторан студент");
            this.Close();
        }

        private void lstZakaz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
