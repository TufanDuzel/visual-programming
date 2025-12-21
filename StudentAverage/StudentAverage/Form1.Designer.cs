namespace StudentAverage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblG1 = new System.Windows.Forms.Label();
            this.lblG2 = new System.Windows.Forms.Label();
            this.lblG3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(90, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Average";
            // 
            // lblG1
            // 
            this.lblG1.AutoSize = true;
            this.lblG1.Location = new System.Drawing.Point(35, 55);
            this.lblG1.Name = "lblG1";
            this.lblG1.Size = new System.Drawing.Size(52, 15);
            this.lblG1.TabIndex = 1;
            this.lblG1.Text = "Grade 1:";
            // 
            // lblG2
            // 
            this.lblG2.AutoSize = true;
            this.lblG2.Location = new System.Drawing.Point(35, 85);
            this.lblG2.Name = "lblG2";
            this.lblG2.Size = new System.Drawing.Size(52, 15);
            this.lblG2.TabIndex = 2;
            this.lblG2.Text = "Grade 2:";
            // 
            // lblG3
            // 
            this.lblG3.AutoSize = true;
            this.lblG3.Location = new System.Drawing.Point(35, 115);
            this.lblG3.Name = "lblG3";
            this.lblG3.Size = new System.Drawing.Size(52, 15);
            this.lblG3.TabIndex = 3;
            this.lblG3.Text = "Grade 3:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(110, 52);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(130, 23);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(110, 82);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(130, 23);
            this.txt2.TabIndex = 5;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(110, 112);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(130, 23);
            this.txt3.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(110, 145);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(130, 30);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(35, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(49, 15);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Average:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(35, 220);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(310, 260);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblG3);
            this.Controls.Add(this.lblG2);
            this.Controls.Add(this.lblG1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Student Average";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblG1;
        private System.Windows.Forms.Label lblG2;
        private System.Windows.Forms.Label lblG3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStatus;
    }
}
