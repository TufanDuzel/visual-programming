using System.Windows.Forms.VisualStyles;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
            this.CancelButton = btnExit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPassword.Text;

            MessageBox.Show(
                "Login Successful.",
                "Success",

                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
