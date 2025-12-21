namespace Select_Hobbies
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
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(30, 25);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(69, 19);
            this.chkReading.TabIndex = 0;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(30, 50);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(56, 19);
            this.chkMusic.TabIndex = 1;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkSports
            // 
            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(30, 75);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(57, 19);
            this.chkSports.TabIndex = 2;
            this.chkSports.Text = "Sports";
            this.chkSports.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(30, 110);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 30);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Selected Hobbies";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 155);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chkSports);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.chkReading);
            this.Name = "Form1";
            this.Text = "Select Hobbies";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblResult;
    }
}
