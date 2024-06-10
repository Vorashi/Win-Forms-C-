using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Add(lstMenu.Text);
        }
        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            lstMenu.Items.Add(textBox1.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Remove(lstZakaz.SelectedItem);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SumDollors();


            MessageBox.Show("Приятного аппетита!", "Ресторан студент");
            this.Close();
        }


        public int SumDollors() {
            int reser;
            int reserEnd;
            string number;
            int sum = 0;
            foreach (string item in lstZakaz.Items)
            {
                reser = item.IndexOf('(');
                reserEnd = item.IndexOf(')');
                number = item.Substring(reser, reserEnd - reser);
                sum += Convert.ToInt32(number);
            };

            return sum;
        }

        private void btnDeletedAll_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Clear();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            lstZakaz.Items.Remove(lstZakaz.SelectedItem);
        }
    }
}
