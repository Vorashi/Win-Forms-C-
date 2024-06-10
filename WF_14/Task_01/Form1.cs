using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Task_01
{
    public partial class Form1 : Form
    {
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txt.Text);
            txt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text; // путь к файлу
            if (File.Exists(fileName))
            {
                File.Delete(fileName); // если файл существует - удаляем его
            }
            using (FileStream fs = File.Create(fileName, 1024))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                for (var i = 0; i < lst.Items.Count; i++) 
                {
                    bw.Write(lst.Items[i].ToString());
                }
                
                bw.Close();
                fs.Close();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            fileName = txtFileName.Text;
            lstFormfile.Items.Clear();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar() != -1)
                {
                    lstFormfile.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }
        }

        private void btn_searhFile_Click(object sender, EventArgs e)
        {
            file1.ShowDialog();
            fileName = file1.FileName;
            txtFileName.Text = fileName;
        }
    }
}
