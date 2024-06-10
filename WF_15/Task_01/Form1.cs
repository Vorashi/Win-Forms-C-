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
        bool btnPressed;
        bool squareTool;
        bool ellipsTool;
        string color = "White";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics myg = this.CreateGraphics();
            int CursorX = Cursor.Position.X - 10;
            int CursorY = Cursor.Position.Y - 20;
            Color myColor = Color.FromName(color);
            SolidBrush myb = new SolidBrush(myColor);
            Rectangle myrect = new Rectangle(CursorX, CursorY, 10, 10);
            if (btnPressed == true && ellipsTool == true)
            {
                myg.FillEllipse(myb, myrect);
            }
            if (btnPressed == true && squareTool == true)
            {
                myg.FillRectangle(myb, myrect);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            btnPressed = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            btnPressed = false;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareTool = true;
            ellipsTool = false;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareTool = false;
            ellipsTool = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "";
            color = "Red";
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "";
            color = "Green";
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "";
            color = "Blue";
        }
    }
}
