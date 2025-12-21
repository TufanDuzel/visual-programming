using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string name = txtName.Text;
                string department = txtDepartment.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                    throw new Exception("Username and password cannot be empty.");

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(department))
                    throw new Exception("Name and department cannot be empty.");

                string studentDetails = $"Name: {name}, Department: {department}";
                listBoxStudents.Items.Add(studentDetails);

                // clear all inputs
                txtUsername.Clear();
                txtPassword.Clear();
                txtName.Clear();
                txtDepartment.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem != null)
            {
                listBoxStudents.Items.Remove(listBoxStudents.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a student to delete.",
                    "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // bunlar formdan týklanmýþ boþ event’ler olabilir, istersen silebilirsin
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
