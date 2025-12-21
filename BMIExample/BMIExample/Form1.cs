using System;
using System.Windows.Forms;

namespace BMIExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initialize ProgressBar range
            progressBarBMI.Minimum = 10;
            progressBarBMI.Maximum = 40;
            progressBarBMI.Value = 10;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1) validate empty
            if (string.IsNullOrWhiteSpace(txtHeight.Text) || string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Please enter both height and weight.",
                    "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) validate numeric
            if (!double.TryParse(txtHeight.Text, out double heightCm) ||
                !double.TryParse(txtWeight.Text, out double weightKg))
            {
                MessageBox.Show("Please enter valid numeric values.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // cm ? m
            double height = heightCm / 100.0;
            double bmi = weightKg / (height * height);

            string category;
            if (bmi < 18.5)
                category = "Underweight";
            else if (bmi < 25.0)
                category = "Normal weight";
            else if (bmi < 30.0)
                category = "Overweight";
            else
                category = "Obesity";

            lblResult.Text = $"Your BMI is {bmi:F1} ({category})";

            // progressbar update
            int progressValue = (int)Math.Round(bmi);
            if (progressValue < progressBarBMI.Minimum) progressValue = progressBarBMI.Minimum;
            if (progressValue > progressBarBMI.Maximum) progressValue = progressBarBMI.Maximum;
            progressBarBMI.Value = progressValue;
        }
    }
}
