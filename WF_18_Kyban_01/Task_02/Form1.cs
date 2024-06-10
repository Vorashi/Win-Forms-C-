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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //исходная строка
            string s1 = textBox1.Text;
            string s2 = "";
            //просмотр символов исходной строки
            for (int i = 0; i < s1.Length; i++)
                //если выполняются заданные условия,
                if (i % 2 != 0 && !char.IsDigit(s1[i]))
                    //то добавляем символ в новую строку
                    s2 += s1[i];
            textBox2.Text = s2;
        }
    }
}
