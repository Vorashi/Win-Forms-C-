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
        string[] mas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                string t = "";
                //сортировка слов методом "пузырька"
                for (int i = 0; i < mas.Length; i++)
                    for (int j = mas.Length - 1; j > i; j--)
                        if (mas[j].CompareTo(mas[j - 1]) < 0)
                        {
                            t = mas[j];
                            mas[j] = mas[j - 1];
                            mas[j - 1] = t;
                        }
                //выводим отсортированные слова в список на форме
                listBox1.Items.Clear();
                for (int i = 0; i < mas.Length; i++)
                    listBox1.Items.Add(mas[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //исходная строка
            string s = textBox1.Text;
            //массив разделителей состоит из одного элемента - пробела
            char[] sep = new char[] { ' ' };
            //разбиваем строку на слова и удаляем пустые строки
            mas = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            //выводим слова в список на форме
            listBox1.Items.Clear();
            for (int i = 0; i < mas.Length; i++)
                listBox1.Items.Add(mas[i]);
        }
    }
}
