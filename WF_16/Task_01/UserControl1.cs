using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Task_01
{
    public partial class RunningText : UserControl
    {
        int posX;
        public string Text
        {
            set
            {
                txt.Text = value;
                txt.Text = Text;
            }
            get { return txt.Text; }
        }

        public int Speed { get; set; }


        public void GetNewString(string s)
        {
            txt.Text = s;
        }

        public RunningText()
        {
            InitializeComponent();
        }

        private void RunningText_Resize(object sender, EventArgs e)
        {
            txt.Top = 0;
            txt.Left = 0;
            txt.Width = Width;
            posX = txt.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt.Top = 0;
            txt.Left = posX;
            //txt.Text = Text;
            //GetNewString(Text);
            posX = posX - Speed;
            if (posX < 0)
            {
                posX = txt.Width;
            }
        }

        private void RunningText_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            txt.Text = "Привет";
            Speed = 20; 
        }
    }
}