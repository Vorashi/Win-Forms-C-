using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_04_Option_17
{
    public partial class Form1 : Form
    {
        string fName;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fName = saveFileDialog1.FileName;
                FileStream fs = new FileStream(fName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(SetChar());
                sw.Close();
                fs.Close();
            }
        }

        public string SetChar()
        {
            char[] chars = new char[] {' '};
            string charString = ContentOpenFileLabel.Text;
            string trueChar = charString.Replace(" ", "");
            ContentOpenFileLabel.Text = trueChar;
            return trueChar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("C:\\My work programm\\C#\\char.txt", " @ # % ^ & * $ ~ ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fName = openFileDialog1.FileName;
            WayOpenFileLabel.Visible = true;
            ContentOpenFileLabel.Visible = true;
            WayOpenFileLabel.Text = fName;
            FileStream fs = new FileStream(fName, FileMode.Open);
            //создать объект для записи в текстовый файл
            StreamReader sr = new StreamReader(fs);
            string informationFile = sr.ReadLine();
            ContentOpenFileLabel.Text = informationFile;
            fs.Close();
            sr.Close();
        }
    }
}
