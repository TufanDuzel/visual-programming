namespace login
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            btnExit = new Button();
            btnLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 171);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(321, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 27);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 222);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(321, 219);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(439, 273);
            chkRemember.Name = "chkRemember";
            chkRemember.RightToLeft = RightToLeft.Yes;
            chkRemember.Size = new Size(136, 24);
            chkRemember.TabIndex = 4;
            chkRemember.Text = "?Remember me";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(212, 334);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 80);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(488, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 80);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(342, 54);
            label3.Name = "label3";
            label3.Size = new Size(139, 54);
            label3.TabIndex = 7;
            label3.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(chkRemember);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private CheckBox chkRemember;
        private Button btnExit;
        private Button btnLogin;
        private Label label3;
    }
}
