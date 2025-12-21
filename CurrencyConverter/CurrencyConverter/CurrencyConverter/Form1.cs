using System;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public const double MyConstant = 61.3; // 1 EUR = 61.3 MKD (örnek)

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxDenars_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxDenars.Text.Length != 0)
            {
                this.textBoxEur.Enabled = false;
                this.buttonConvert.Enabled = true;
                this.buttonReset.Visible = true;
            }
            else
            {
                this.textBoxEur.Enabled = true;
                this.buttonConvert.Enabled = false;
                this.buttonReset.Visible = false;
            }
        }

        private void textBoxEur_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxEur.Text.Length != 0)
            {
                this.textBoxDenars.Enabled = false;
                this.buttonConvert.Enabled = true;
                this.buttonReset.Visible = true;
            }
            else
            {
                this.textBoxDenars.Enabled = true;
                this.buttonConvert.Enabled = false;
                this.buttonReset.Visible = false;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double mkdValue = 0.0;
            double eurValue = 0.0;

            // MKD ? EUR
            if (textBoxDenars.Text.Length != 0)
            {
                mkdValue = double.Parse(textBoxDenars.Text);
                eurValue = mkdValue / MyConstant;
                textBoxEur.Text = eurValue.ToString();
            }
            // EUR ? MKD
            else if (textBoxEur.Text.Length != 0)
            {
                eurValue = double.Parse(textBoxEur.Text);
                mkdValue = eurValue * MyConstant;
                textBoxDenars.Text = mkdValue.ToString();
            }

            this.textBoxDenars.Enabled = true;
            this.textBoxEur.Enabled = true;
            this.buttonConvert.Enabled = false;
            this.buttonReset.Visible = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxDenars.Text = "";
            textBoxEur.Text = "";
            textBoxDenars.Enabled = true;
            textBoxEur.Enabled = true;
            buttonConvert.Enabled = false;
            buttonReset.Visible = false;
        }

        // optional: to allow only digits and one dot
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only one dot
            TextBox tb = sender as TextBox;
            if (e.KeyChar == '.' && tb.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
