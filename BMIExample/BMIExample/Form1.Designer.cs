namespace BMIExample
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.progressBarBMI = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(25, 25);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(81, 15);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Enter Height (cm):";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(25, 60);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(83, 15);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Enter Weight (kg):";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(140, 22);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(130, 23);
            this.txtHeight.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(140, 57);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(130, 23);
            this.txtWeight.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(140, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(25, 140);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 15);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // progressBarBMI
            // 
            this.progressBarBMI.Location = new System.Drawing.Point(25, 170);
            this.progressBarBMI.Name = "progressBarBMI";
            this.progressBarBMI.Size = new System.Drawing.Size(245, 20);
            this.progressBarBMI.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.progressBarBMI);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ProgressBar progressBarBMI;
    }
}
