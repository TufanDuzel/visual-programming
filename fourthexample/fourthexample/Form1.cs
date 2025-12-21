using System;
using System.Windows.Forms;

namespace fourthexample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (radioRed.Checked)
                this.BackColor = System.Drawing.Color.Red;
            else if (radioGreen.Checked)
                this.BackColor = System.Drawing.Color.Green;
            else if (radioBlue.Checked)
                this.BackColor = System.Drawing.Color.Blue;
            else
                MessageBox.Show("Please select a color first!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
