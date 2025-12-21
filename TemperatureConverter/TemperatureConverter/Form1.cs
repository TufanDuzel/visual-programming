using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Celsius to Fahrenheit", "Fahrenheit to Celsius" });
            comboBox1.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInput.Text, out double temp))
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            double result;
            if (comboBox1.SelectedIndex == 0)
                result = temp * 9 / 5 + 32;
            else
                result = (temp - 32) * 5 / 9;

            lblResult.Text = $"Result: {result:F2}";
        }
    }
}
