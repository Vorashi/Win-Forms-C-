using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public int[] Arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int MinNumber(int[] x, int m)
        {
            int min = x[m];
            int MinN = m;
            for (int i = m; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN;
        }

        private void btnNewArray_Click(object sender, EventArgs e)
        {
            ClearFields();
            int n = Int32.Parse(tbxN.Text);
            Arr = new int[n];
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                lblOriginalArray.Text += Arr[i];
                if (i != n) lblOriginalArray.Text += ", ";
            }
            btnSort.Enabled = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t;
            for (int i = 0; i < Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                lblReversArray.Text += Arr[i];
                if (i != Arr.Length - 1) { lblReversArray.Text += ", "; }
            }
            btnSort.Enabled = false;

            InsertionSortAlgorithm(Arr); //Вызов сортировки методом вставок
            string sortedArray = string.Join(", ", Arr);
            labelSortInter.Text = sortedArray;
        }
        private void ClearFields()
        {
            lblOriginalArray.Text = "";
            lblReversArray.Text = "";
            btnSort.Enabled = false;
        }

        private void InsertionSortAlgorithm(int[] Arr)
        {
            for (int i = 1; i < Arr.Length; i++)
            {
                Insertion(Arr, i);
            }
        }

        private void Insertion(int[] Arr, int index)
        {
            int current = Arr[index];
            int j = index - 1;
            while (j >= 0 && Arr[j] > current)
            {
                Arr[j + 1] = Arr[j];
                j--;
            }
            Arr[j + 1] = current;
        }


    }
}
