using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02_Option_17
{
    public partial class Form1 : Form
    {
        struct Date
        {
            public int number;
            public int month;
            public int year;
        }

        struct Person
        {
            public string FIO;
            public int Weight;
            public int Luggage;
        }

        Person[] mas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = nameTxb.Text;
            int luggage = int.Parse(luggerTxb.Text);
            int weight = int.Parse(weightTbx.Text);     
            GridConteinerData.Rows.Add(fio, luggage, weight);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int n = GridConteinerData.RowCount;
            mas = new Person[n];
            for (int i = 0; i < n; i++)
            {
                mas[i].FIO = (string) GridConteinerData.Rows[i].Cells[0].Value;      
                mas[i].Luggage = Convert.ToInt32(GridConteinerData.Rows[i].Cells[1].Value);
                mas[i].Weight = Convert.ToInt32(GridConteinerData.Rows[i].Cells[2].Value);
            }
            
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Luggage == 1 && mas[i].Weight >= 30)
                {
                    ResultBtn.Text += mas[i].FIO + " ";
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridConteinerData.Rows.Clear();
        }
    }
}
