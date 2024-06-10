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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ArrayAlgoritm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ArrayAlgoritm() 
        {
            int[] intArray = new int[10] /*{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}*/;
            int plusNumber = 0;
            Random rnd = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(10);
            }

            for (int j = intArray.Length - 1; j >= 0; j--)
            {
                if ( intArray[j] % 2 == 0 )
                {
                    if ( intArray[j] != 0 ) {
                        label4.Text += intArray[j];
                        label4.Text += " ";
                        lbl_1.Text += j;
                        lbl_1.Text += " ";
                        plusNumber++;
                    }
                }
            }
            lbl_2.Text = plusNumber.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
