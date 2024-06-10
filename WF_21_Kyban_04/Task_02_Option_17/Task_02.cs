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
    public partial class Task_02 : Form
    {
        public Task_02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ArgATbx.Text == "" && StartInterbalTbx.Text == "" && EndInterbalTbx.Text == "")
            {
                ErrorLabel.Visible = true;
            }
            else 
            { 
                Lineal equation = new Lineal(double.Parse(ArgATbx.Text));
                try
                {
                    ResultLabel.Visible = true;
                    double res = equation.ComputeSolution(double.Parse(StartInterbalTbx.Text) ,double.Parse(EndInterbalTbx.Text));
                    ResultLabel.Text = res.ToString(); 
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = ex.Message;
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
