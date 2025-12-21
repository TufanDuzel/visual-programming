namespace StudentRegistrationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            txtDepartment = new TextBox();
            btnRegister = new Button();
            listBoxStudents = new ListBox();
            btnDeleteSelected = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 95);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 130);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Department";
            label4.Click += label4_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(115, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(160, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(115, 57);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 23);
            txtName.TabIndex = 6;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(115, 127);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(160, 23);
            txtDepartment.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(115, 165);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(160, 30);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(310, 22);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(210, 124);
            listBoxStudents.TabIndex = 9;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Location = new Point(310, 160);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(210, 30);
            btnDeleteSelected.TabIndex = 10;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(837, 416);
            Controls.Add(btnDeleteSelected);
            Controls.Add(listBoxStudents);
            Controls.Add(btnRegister);
            Controls.Add(txtDepartment);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button btnDeleteSelected;
    }
}
