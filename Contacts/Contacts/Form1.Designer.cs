namespace Contacts
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
            this.labelNS = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textNS = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.listContacts = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNS
            // 
            this.labelNS.AutoSize = true;
            this.labelNS.Location = new System.Drawing.Point(25, 25);
            this.labelNS.Name = "labelNS";
            this.labelNS.Size = new System.Drawing.Size(106, 15);
            this.labelNS.TabIndex = 0;
            this.labelNS.Text = "Name and Surname";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(25, 70);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(85, 15);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Phone number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(25, 115);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // textNS
            // 
            this.textNS.Location = new System.Drawing.Point(25, 43);
            this.textNS.Name = "textNS";
            this.textNS.Size = new System.Drawing.Size(180, 23);
            this.textNS.TabIndex = 3;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(25, 88);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(180, 23);
            this.textPhone.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(25, 133);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(180, 23);
            this.textEmail.TabIndex = 5;
            // 
            // listContacts
            // 
            this.listContacts.FormattingEnabled = true;
            this.listContacts.ItemHeight = 15;
            this.listContacts.Location = new System.Drawing.Point(240, 25);
            this.listContacts.Name = "listContacts";
            this.listContacts.Size = new System.Drawing.Size(170, 139);
            this.listContacts.TabIndex = 6;
            this.listContacts.SelectedIndexChanged += new System.EventHandler(this.listContacts_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(25, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 28);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(120, 180);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 28);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(240, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 28);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(430, 230);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listContacts);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textNS);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelNS);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelNS;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textNS;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.ListBox listContacts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}
