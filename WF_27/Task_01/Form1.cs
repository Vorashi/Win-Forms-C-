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
        public Form1()
        {
            InitializeComponent();
            DisableCheckBoxes();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private HashSet<int> SetA = new HashSet<int>();
        private HashSet<int> SetB = new HashSet<int>();
        private HashSet<int> SetC = new HashSet<int>();


        private void DisableCheckBoxes()
        {
            foreach (CheckBox checkBox in GbSetC.Controls)
            {
                checkBox.Enabled = false;
            }
        }

        private void UpdateSetCAndRelationships()
        {
            SetC.Clear();
            SetC.UnionWith(SetA);

            switch (CbxOperation.SelectedItem.ToString())
            {
                case "Union":
                    SetC.UnionWith(SetB);
                    break;
                case "Intersection":
                    SetC.IntersectWith(SetB);
                    break;
                case "Difference A-B":
                    SetC.ExceptWith(SetB);
                    break;
                case "Difference B-A":
                    SetC.ExceptWith(SetA);
                    break;
            }

            if (SetA.SetEquals(SetB)) CbxPortype.SetItemChecked(0, true);
            if (SetA.IsSubsetOf(SetB)) CbxPortype.SetItemChecked(2, true);
            if (SetA.IsSupersetOf(SetB)) CbxPortype.SetItemChecked(1, true);

            UpdateCheckBoxes();
        }

        private void UpdateCheckBoxes()
        {
            foreach (CheckBox checkBox in GbSetC.Controls)
            {
                int value = Convert.ToInt32(checkBox.Text);
                checkBox.Checked = SetC.Contains(value);
            }
        }

        private void checkBoxSetA_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int value = Convert.ToInt32(checkBox.Text);

            if (checkBox.Checked)
                SetA.Add(value);
            else
                SetA.Remove(value);

            UpdateSetCAndRelationships();
        }

        private void checkBoxSetB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int value = Convert.ToInt32(checkBox.Text);

            if (checkBox.Checked)
                SetB.Add(value);
            else
                SetB.Remove(value);

            UpdateSetCAndRelationships();
        }

        private void CbxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSetCAndRelationships();
        }

        private void GbSetA_Enter(object sender, EventArgs e)
        {

        }
    }
}
