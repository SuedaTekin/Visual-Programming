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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        /*
        private void radioCSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCSharp.Checked)
                lblFPL.Text = "Favorite PL : C#";
        }

        private void radioJava_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJava.Checked)
                lblFPL.Text = "Favorite PL : Java";
        }

        private void radioRuby_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRuby.Checked)
                lblFPL.Text = "Favorite PL : Ruby";
        }
        */

        private void radioPLS_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioSender = (RadioButton)sender;
            if (radioSender.Checked)
                lblFPL.Text = "Favorite PL : " + radioSender.Text;
        }
    }
}
