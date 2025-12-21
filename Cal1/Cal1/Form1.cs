using System;
using System.Windows.Forms;

namespace Cal1
{
    public partial class Form1 : Form
    {
        private decimal? _first = null;
        private string _op = null;
        private bool _resetNext = false;

        public Form1()
        {
            InitializeComponent();
        }

        // digits and dot
        private void Digit_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            if (_resetNext || txtDisplay.Text == "0" || txtDisplay.Text == "Error")
            {
                txtDisplay.Text = "";
                _resetNext = false;
            }

            // prevent double dot
            if (btn.Text == "." && txtDisplay.Text.Contains("."))
                return;

            txtDisplay.Text += btn.Text;
        }

        // operators + - * /
        private void Operator_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            if (_first.HasValue && !string.IsNullOrWhiteSpace(txtDisplay.Text) && !_resetNext)
            {
                Compute();
            }
            else
            {
                if (decimal.TryParse(txtDisplay.Text, out decimal n))
                    _first = n;
            }

            _op = btn.Text;
            _resetNext = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Compute();
        }

        private void Compute()
        {
            if (!_first.HasValue) return;
            if (!decimal.TryParse(txtDisplay.Text, out decimal second))
                return;

            decimal result = 0m;

            switch (_op)
            {
                case "+":
                    result = _first.Value + second;
                    break;
                case "-":
                    result = _first.Value - second;
                    break;
                case "*":
                    result = _first.Value * second;
                    break;
                case "/":
                    if (second == 0)
                    {
                        txtDisplay.Text = "Error";
                        _first = null;
                        _op = null;
                        _resetNext = true;
                        return;
                    }
                    result = _first.Value / second;
                    break;
                default:
                    txtDisplay.Text = second.ToString();
                    return;
            }

            txtDisplay.Text = result.ToString();
            _first = result;
            _resetNext = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            _first = null;
            _op = null;
            _resetNext = false;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
