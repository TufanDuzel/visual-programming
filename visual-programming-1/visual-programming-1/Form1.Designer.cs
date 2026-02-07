namespace visual_programming_1
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
            btnStudent = new Button();
            label1 = new Label();
            btnProfessor = new Button();
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(352, 195);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(94, 29);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Welcome";
            btnStudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 159);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Welcome Students!";
            // 
            // btnProfessor
            // 
            btnProfessor.Location = new Point(352, 230);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Size = new Size(94, 29);
            btnProfessor.TabIndex = 2;
            btnProfessor.Text = "Welcome";
            btnProfessor.UseVisualStyleBackColor = true;
            // btnStudent
            btnStudent.Text = "Welcome";
            btnStudent.Click += button_Click;

            // btnProfessor
            btnProfessor.Text = "Welcome";
            btnProfessor.Click += button_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProfessor);
            Controls.Add(label1);
            Controls.Add(btnStudent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudent;
        private Label label1;
        private Button btnProfessor;
    }
}
