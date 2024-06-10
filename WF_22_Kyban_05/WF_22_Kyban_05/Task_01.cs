using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

namespace WF_22_Kyban_05
{
    public partial class Task_01 : Form
    {
        ArrayList points, res;
        public Task_01()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //берем значения из компонентов-счетчиков
            float x = (float)XNumericUpDown.Value;
            float y = (float)YNumericUpDown.Value;
            //создаем новую точку
            Point p = new Point(x, y);
            //добавляем ее в коллекцию
            points.Add(p);
            //добавляем в таблицу на форме
            GridView1.Rows.Add(p.x, p.y);
        }

        private void BtnDeletePoint_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем номер выбранной строки
                int num = GridView1.SelectedRows[0].Index;
                //удаляем точку с данным номером из коллекции
                points.RemoveAt(num);
                //удаляем выбранную строку из таблицы
                GridView1.Rows.Remove(GridView1.SelectedRows[0]);
            }
            catch
            {
                MessageBox.Show("Выберите строку!!!");
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            //очистить коллекцию res
            res.Clear();
            //очистить содержимое таблиц на форме
            GridView1.Rows.Clear();
            GridView2.Rows.Clear();
            //просматриваем исходный массив
            foreach (Point p in points)
                if (p.x < 0) //при выполнении условия
                    res.Add(p); //добавляем точку в массив-результат
            foreach (Point p in res)
            {
                //удаляем найденные точки из исходного массива
                points.Remove(p);
                //отображаем 2-й массив в таблице на форме
                GridView2.Rows.Add(p.x, p.y);
            }
            foreach (Point p in points)
                //отображаем 1-й массив в таблице на форме
                GridView1.Rows.Add(p.x, p.y);
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            //сортируем
            res.Sort();
            //очищаем содержимое таблицы на форме
            GridView2.Rows.Clear();
            foreach (Point p in res)
                //обновляем таблицу на форме
                GridView2.Rows.Add(p.x, p.y);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            points = new ArrayList(); //выделение памяти
            res = new ArrayList();
        }
    }
}
