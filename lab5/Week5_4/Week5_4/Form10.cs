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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1 > progressBar1.Maximum ? progressBar1.Maximum : progressBar1.Value + 1;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("The task is done!!!");
            }
        }
    }
}
