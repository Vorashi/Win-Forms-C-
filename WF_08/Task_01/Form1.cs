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
        int[] arr = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        public void btnCalc_Click(object sender, EventArgs e)
        {
            int sum = 0;

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20);
                sum += arr[i];
            }
            
            txtArray.Text = "Array: ";

            for (int i = 0; i < arr.Length; i++)
            {
                txtArray.Text += arr[i].ToString() + " ";
            }

            txtArray.Text += "\r\nSum: ";
            txtArray.Text += sum;

            txtArray.Text += "\r\nArithmetic mean: ";
            txtArray.Text += sum / 10;
        }

        public void btnMax_Click(object sender, EventArgs e)
        {
            txtArray.Text = "Array: ";

            for (int i = 0; i < arr.Length; i++)
            {
                txtArray.Text += arr[i].ToString() + " ";
            }

            txtArray.Text += "\r\nMaximum element in array: ";
            txtArray.Text += arr.Max();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            txtArray.Text = "Array: ";

            for (int i = 0; i < arr.Length; i++)
            {
                txtArray.Text += arr[i].ToString() + " ";
            }

            txtArray.Text += "\r\nMinimum element in array: ";
            txtArray.Text += arr.Min();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            txtArray.Text = "Array: ";

            for (int i = 0; i < arr.Length; i++)
            {
                txtArray.Text += arr[i].ToString() + " ";
            }

            txtArray.Text += "\r\nNew Array: ";
            Array.Sort(arr);

            for (int i = 0;i < arr.Length; i++)
            {
                txtArray.Text += arr[i].ToString() + " ";
            }
        }
    }
}
