using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_03_Option_17
{
    public partial class Form1 : Form
    {
        string fName;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenDialog.ShowDialog();
            fName = OpenDialog.FileName;
            WayLabel.Visible = true;
            FileNameLabel.Visible = true;
            FileNameLabel.Text = fName;
            FileStream fs = new FileStream(fName, FileMode.Open);
            //создать объект для записи в текстовый файл
            StreamReader sr = new StreamReader(fs);
            string informationFile = sr.ReadLine();
            FileInputTbx.Text += informationFile;
            sr.Close();
            fs.Close();
        }

        public string Positive() { 
            string numberStrings = FileInputTbx.Text;
            char[] separator = new char[] { ' ' };
            string[] positNumArray = numberStrings.Split(separator);
            int[] num = new int[positNumArray.Length];
            string truePositiveNumber = "";
            for (int i = 0; i < num.Length - 1; i++)
            {
                num[i] = int.Parse(positNumArray[i]);
            }
            for (int j = 0; j < num.Length; j++) 
            {
                if (num[j] > 0)
                {
                    truePositiveNumber += num[j] + " ";
                }
            }
            SaveFileInputLabel.Text = truePositiveNumber;
            WhatSaveFileLabel.Visible = true;
            SaveFileInputLabel.Visible = true;            
            return truePositiveNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if ( SaveDialog.ShowDialog() == DialogResult.OK )
           {
                fName = SaveDialog.FileName;
                WayLabel.Text = "Информация записана по пути: ";
                FileNameLabel.Text = fName;
                FileStream fs = new FileStream(fName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Positive());
                WaySaveFileLabel.Text = fName;
                WaySaveFileLabel.Visible = true;
                FileNameLabel.Visible = false;
                sw.Close();
                fs.Close();
           }
           else 
           {
                WaySaveFileLabel.Text = "Попробуйте сохранить ещё раз!";
           }
        }
    }
}
