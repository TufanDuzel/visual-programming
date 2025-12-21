namespace TemperatureConverter
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(65, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Temperature Converter";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(25, 55);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(115, 15);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Enter temperature:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(150, 52);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(130, 23);
            this.txtInput.TabIndex = 2;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(25, 90);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(111, 15);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "Choose conversion:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(150, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(150, 125);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(130, 30);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(25, 175);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(320, 220);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
    }
}
