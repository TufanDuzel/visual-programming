namespace CurrencyConverter
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
            this.lblDenars = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.textBoxDenars = new System.Windows.Forms.TextBox();
            this.textBoxEur = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDenars
            // 
            this.lblDenars.AutoSize = true;
            this.lblDenars.Location = new System.Drawing.Point(30, 30);
            this.lblDenars.Name = "lblDenars";
            this.lblDenars.Size = new System.Drawing.Size(33, 15);
            this.lblDenars.TabIndex = 0;
            this.lblDenars.Text = "MKD";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Location = new System.Drawing.Point(30, 70);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(29, 15);
            this.lblEur.TabIndex = 1;
            this.lblEur.Text = "EUR";
            // 
            // textBoxDenars
            // 
            this.textBoxDenars.Location = new System.Drawing.Point(90, 27);
            this.textBoxDenars.Name = "textBoxDenars";
            this.textBoxDenars.Size = new System.Drawing.Size(120, 23);
            this.textBoxDenars.TabIndex = 2;
            this.textBoxDenars.TextChanged += new System.EventHandler(this.textBoxDenars_TextChanged);
            this.textBoxDenars.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxEur
            // 
            this.textBoxEur.Location = new System.Drawing.Point(90, 67);
            this.textBoxEur.Name = "textBoxEur";
            this.textBoxEur.Size = new System.Drawing.Size(120, 23);
            this.textBoxEur.TabIndex = 3;
            this.textBoxEur.TextChanged += new System.EventHandler(this.textBoxEur_TextChanged);
            this.textBoxEur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(30, 110);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(80, 28);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(130, 110);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 28);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Visible = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(240, 160);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxEur);
            this.Controls.Add(this.textBoxDenars);
            this.Controls.Add(this.lblEur);
            this.Controls.Add(this.lblDenars);
            this.Name = "Form1";
            this.Text = "MKD-EUR Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDenars;
        private System.Windows.Forms.Label lblEur;
        private System.Windows.Forms.TextBox textBoxDenars;
        private System.Windows.Forms.TextBox textBoxEur;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonReset;
    }
}
