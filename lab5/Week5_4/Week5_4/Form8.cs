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
    public partial class Form8 : Form
    {

        int counter = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = "Counter : " + counter;

        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnCatchme.Location = new Point(rnd.Next(0,Size.Width), rnd.Next(0, Size.Height));
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
