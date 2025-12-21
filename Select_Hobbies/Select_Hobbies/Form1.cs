using System;
using System.Text;
using System.Windows.Forms;

namespace Select_Hobbies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StringBuilder hobbies = new StringBuilder();

            if (chkReading.Checked)
                hobbies.Append("Reading, ");
            if (chkMusic.Checked)
                hobbies.Append("Music, ");
            if (chkSports.Checked)
                hobbies.Append("Sports, ");

            string result = hobbies.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrEmpty(result))
                lblResult.Text = "You didn't select any hobbies.";
            else
                lblResult.Text = "Your hobbies are: " + result;
        }
    }
}
