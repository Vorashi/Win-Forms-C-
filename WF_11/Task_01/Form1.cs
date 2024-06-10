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
        private int NumberSymbols(string stroka, string symbol)
        {
            int k = 0;
            int index = 0;
            while ((index = stroka.IndexOf(symbol, index)) != -1)
            {
                index += symbol.Length;
                k++;
            }
            return k;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtKolvo.Text = NumberSymbols(strings.Text, txtSymbol.Text).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
