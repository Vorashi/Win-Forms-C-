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
        //структура "Дата"
        struct Date
        {
            public int number;
            public int month;
            public int year;
        }

        //структура "Человек"
        struct Person
        {
            public string FIO;
            public Date Birthday;
        }
        //описание массива людей
        Person[] mas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //определяем кол-во людей в массиве
            int n = dataGridView1.RowCount;
            mas = new Person[n];
            //записываем данные из таблицы на форме в массив mas
            for (int i = 0; i < n; i++)
            {
                mas[i].FIO = (string) dataGridView1.Rows[i].Cells[0].Value;
                DateTime dt = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value);
                mas[i].Birthday.number = dt.Day;
                mas[i].Birthday.month = dt.Month;
                mas[i].Birthday.year = dt.Year;
            }
            //элемент массива, соответствующий самому младшему человеку
            Person min = mas[0];
            //его порядковый номер в массиве
            int ind = 0;
            //ищем самого младшего
            for (int i = 1; i < n; i++)
                if (mas[i].Birthday.year > min.Birthday.year)
                {
                    min = mas[i];
                    ind = i;
                }
            //выводим его ФИО на форму
            label3.Text = mas[ind].FIO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //берем данные о человеке из компонентов на форме
            string fio = textBox1.Text;
            DateTime birthday = dateTimePicker1.Value;
            //и заносим их в таблицу dataGridView1
            dataGridView1.Rows.Add(fio, birthday.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
