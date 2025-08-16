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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
                lblMessage.Font = selectedFont;
                btnChangeFont.Font = selectedFont;
            }
        }
    }
}
