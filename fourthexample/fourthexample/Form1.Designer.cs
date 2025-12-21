namespace fourthexample
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
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(40, 40);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(68, 19);
            this.radioRed.TabIndex = 0;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "radioRed";
            this.radioRed.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(140, 40);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(82, 19);
            this.radioGreen.TabIndex = 1;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "radioGreen";
            this.radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(250, 40);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(74, 19);
            this.radioBlue.TabIndex = 2;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "radioBlue";
            this.radioBlue.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(40, 80);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(284, 30);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(370, 140);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.radioBlue);
            this.Controls.Add(this.radioGreen);
            this.Controls.Add(this.radioRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.Button btnApply;
    }
}
