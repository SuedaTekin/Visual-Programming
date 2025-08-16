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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void tabSignup_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginWarning_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnCreateNewTab_Click(object sender, EventArgs e)
        {
            TabPage customTab = new TabPage();
            customTab.BackColor = Color.Orange;
            customTab.Text = "Tab"+ (tabControl1.TabPages.Count + 1);


            Label lblCustomTabMessage = new Label();
            lblCustomTabMessage.Text = "This label is generated programatically";
            lblCustomTabMessage.ForeColor = Color.White;
            lblCustomTabMessage.Size = new Size(300,200);
            customTab.Controls.Add(lblCustomTabMessage);


            tabControl1.TabPages.Add(customTab);

            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
        }

    }
}
