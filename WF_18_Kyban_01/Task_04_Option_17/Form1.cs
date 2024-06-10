using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_04_Option_17
{
    public partial class Form1 : Form
    {
        string[] arrayWords;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originString = inputTBX.Text;
            char[] sep = new char[] {' '};
            arrayWords = originString.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int countSmallWords = 0;
            if (arrayWords.Length != 5)
            {
                ResultLabel.Text = "Введите 5 слов в текстовое поле!";
            }
            else
            {
                for (int j = 0; j < arrayWords.Length; j++)
                {
                    if (arrayWords[j].Length < 4)
                    {
                        countSmallWords++;
                    }
                }
                switch (countSmallWords)
                {
                    case 1:
                        ResultLabel.Text = "Процентное соотношение в тексте коротких слов к остальным 20%";
                        break;
                    case 2:
                        ResultLabel.Text = "Процентное соотношение в тексте коротких слов к остальным 40%";
                        break;
                    case 3:
                        ResultLabel.Text = "Процентное соотношение в тексте коротких слов к остальным 60%";
                        break;
                    case 4:
                        ResultLabel.Text = "Процентное соотношение в тексте коротких слов к остальным 80%";
                        break;
                    case 5:
                        ResultLabel.Text = "Процентное соотношение в тексте коротких слов к остальным 100%";
                        break;
                    default:
                        ResultLabel.Text = "Ну такого быть не может";
                        break;
                }
            }
        }
    }
}
