using System.Diagnostics;

namespace Week5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            String message = txtMessage.Text;

            DialogResult result= MessageBox.Show(message,"Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button4,MessageBoxOptions.RtlReading,true);
            if (result == DialogResult.Yes && message == "RED")
            {
                btnShowMessage.BackColor = Color.Red;
            } else if (result == DialogResult.Yes)
            {
                Debug.WriteLine("YES");
            } else if(result == DialogResult.No)
            {
                Debug.WriteLine("NO!!");
            } else if (result == DialogResult.Cancel)
            {
                Debug.WriteLine("CANCEL!!");
            }
        }
    }
}