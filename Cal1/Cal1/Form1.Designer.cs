namespace Cal1
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDiv = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMul = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSub = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(267, 128);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(130, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn7
            // 
            btn7.Location = new Point(267, 168);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 47);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Digit_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(337, 168);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 47);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Digit_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(403, 168);
            btn9.Name = "btn9";
            btn9.Size = new Size(58, 47);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Digit_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(467, 168);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(67, 47);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += Operator_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(267, 221);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 42);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Digit_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(337, 221);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 42);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Digit_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(403, 221);
            btn6.Name = "btn6";
            btn6.Size = new Size(58, 42);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Digit_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(469, 221);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(65, 42);
            btnMul.TabIndex = 8;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += Operator_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(267, 269);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 47);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Digit_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(337, 269);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 47);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Digit_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(403, 269);
            btn3.Name = "btn3";
            btn3.Size = new Size(58, 47);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Digit_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(469, 269);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(65, 47);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += Operator_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(267, 322);
            btn0.Name = "btn0";
            btn0.Size = new Size(120, 45);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Digit_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(394, 322);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(67, 47);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Digit_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(469, 114);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(65, 48);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(469, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 47);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Operator_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(403, 114);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(58, 48);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(847, 504);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnSub);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMul);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDiv);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}
