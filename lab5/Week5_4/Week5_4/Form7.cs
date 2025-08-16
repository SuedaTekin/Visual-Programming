using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_4
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int selectedNumber = (int)numericUpDown1.Value;
            lblDouble.Text = "Counter : " + (selectedNumber * 2).ToString();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            decimal candidateResult = numericUpDown1.Value + numericUpDown1.Increment;
            numericUpDown1.Value = candidateResult > numericUpDown1.Maximum ?
                numericUpDown1.Maximum :
                candidateResult;
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            decimal candidateResult = numericUpDown1.Value - numericUpDown1.Increment;
            numericUpDown1.Value = candidateResult < numericUpDown1.Minimum ?
                numericUpDown1.Minimum :
                candidateResult;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Size = new Size((int)numericUpDown2.Value, (int)numericUpDown2.Value);
        }
    }
}
