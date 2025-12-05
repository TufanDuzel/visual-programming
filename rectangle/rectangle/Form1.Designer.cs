namespace rectangle
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
            label2 = new Label();
            label3 = new Label();
            txtWidth = new TextBox();
            txtLength = new TextBox();
            btnCalculate = new Button();
            lblArea = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 70);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Area of Rectangle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 169);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter width:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 217);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter length:";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(373, 166);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(207, 27);
            txtWidth.TabIndex = 3;
            txtWidth.TextChanged += ToggleButton;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(373, 214);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(207, 27);
            txtLength.TabIndex = 4;
            txtLength.TextChanged += ToggleButton;
            // 
            // btnCalculate
            // 
            btnCalculate.Enabled = false;
            btnCalculate.Location = new Point(341, 292);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(250, 366);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(47, 20);
            lblArea.TabIndex = 6;
            lblArea.Text = "Area: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblArea);
            Controls.Add(btnCalculate);
            Controls.Add(txtLength);
            Controls.Add(txtWidth);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RECTANGLE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtWidth;
        private TextBox txtLength;
        private Button btnCalculate;
        private Label lblArea;
    }
}
