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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker1.Value;
            DateTime dateNow = DateTime.Now.AddHours(1);

            int totalDays = (int)(dateNow - selectedTime).TotalDays;
            lblDayCount.Text = "You have been working for " + totalDays + " days";
        }
    }
}
