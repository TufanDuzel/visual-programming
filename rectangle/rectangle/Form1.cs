using System.Web;

namespace rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCalculate.Enabled = false;

            txtWidth.TextChanged += ToggleButton;
            txtLength.TextChanged += ToggleButton;
        }

        private void ToggleButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWidth.Text) &&
                !string.IsNullOrWhiteSpace(txtLength.Text))
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWidth.Text, out double width) &&  
                double.TryParse(txtLength.Text, out double length))
            {
                double area = width * length;
                double perimeter = 2 * (width + length);

                lblArea.Text = $"Area: {area}     Perimeter: {perimeter}";
            }
        }
    }
}
