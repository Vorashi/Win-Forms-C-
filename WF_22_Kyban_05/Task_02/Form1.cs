using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        List<int> numberList = new List<int>() { 1, 3, 5, 2, 4, 6 };
        List<int> pozitiveNumber = new List<int>();
        List<int> negativeNumber = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                TbxOriginalList.Text += numberList[i] + " ";
            }
            
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0) pozitiveNumber.Add(numberList[i]);
                else negativeNumber.Add(numberList[i]);
            }
            for (int i = 0; i < pozitiveNumber.Count; i++)
            {
                TbxLastList.Text += pozitiveNumber[i] + " ";
            }
            for (int i = 0; i < negativeNumber.Count; i++)
            {
                TbxFirstList.Text += negativeNumber[i] + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
