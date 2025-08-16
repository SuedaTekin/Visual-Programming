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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnShowNotification_Click(object sender, EventArgs e)
        {
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(4000, "test title", "text", ToolTipIcon.Error);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
