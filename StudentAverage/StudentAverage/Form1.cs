using System;
using System.Windows.Forms;
using System.Drawing;

namespace StudentAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt1.Text, out double a) ||
                !double.TryParse(txt2.Text, out double b) ||
                !double.TryParse(txt3.Text, out double c))
            {
                MessageBox.Show("Please enter valid numbers!");
                return;
            }

            double avg = (a + b + c) / 3;
            lblResult.Text = $"Average: {avg:F2}";

            if (avg >= 50)
            {
                lblStatus.Text = "Passed";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Failed";
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
