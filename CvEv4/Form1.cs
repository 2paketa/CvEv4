using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.Diagnostics;

namespace CvEv4
{
    public partial class Form1 : Form
    {
        private Experience experience;
        string fileName;

        public Form1()
        {
            InitializeComponent();
            experience = new Experience((int)numericDoc.Value, (int)numericFields.Value, (int)numericYearExp.Value);
            numericDoc.Maximum = experience.DocMaxLength();
            numericFields.Maximum = experience.Domain;

        }

        private bool[] checkBoxList() //checkboxes reference
        {
            bool[] checkBox = new bool[5];
            checkBox[0] = legalBox.Checked;
            checkBox[1] = finBox.Checked;
            checkBox[2] = medBox.Checked;
            checkBox[3] = markBox.Checked;
            checkBox[4] = patentBox.Checked;
            return checkBox;
        }

        private bool isBoxChecked() //checks if ANY box is checked
        {
            bool isChecked = new bool();
            foreach (var box in checkBoxList())
            {
                if (box)
                {
                    isChecked = true;
                    break;
                }
                else
                {
                    isChecked = false;
                }
            }
            return isChecked;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = experience.SelectOrRandomizeDomains(isBoxChecked(), checkBoxList());
        }

        private void numericDoc_ValueChanged(object sender, EventArgs e)
        {
            experience.NumberOfDocs = (int)numericDoc.Value;
        }

        private void numericFields_ValueChanged(object sender, EventArgs e)
        {
            experience.NumberOfFields = (int)numericFields.Value;
        }

        private void numericYearExp_ValueChanged(object sender, EventArgs e)
        {
            experience.NumberOfYears = (int)numericYearExp.Value;
        }
    }
}
