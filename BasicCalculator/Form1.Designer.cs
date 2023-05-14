namespace BasicCalculator
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
            this.Calculator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.devision = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.Location = new System.Drawing.Point(305, 9);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(117, 40);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number 1";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(173, 79);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(249, 23);
            this.txtnumber1.TabIndex = 2;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(173, 161);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(249, 23);
            this.txtnumber2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 2";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(173, 327);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(249, 23);
            this.txtresult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result -->";
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(81, 208);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(76, 58);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplication.Location = new System.Drawing.Point(305, 208);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(76, 58);
            this.multiplication.TabIndex = 8;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // devision
            // 
            this.devision.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.devision.Location = new System.Drawing.Point(425, 208);
            this.devision.Name = "devision";
            this.devision.Size = new System.Drawing.Size(76, 58);
            this.devision.TabIndex = 9;
            this.devision.Text = ":";
            this.devision.UseVisualStyleBackColor = true;
            this.devision.Click += new System.EventHandler(this.devision_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(193, 208);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(76, 58);
            this.minus.TabIndex = 10;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // pow
            // 
            this.pow.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pow.Location = new System.Drawing.Point(549, 208);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(76, 58);
            this.pow.TabIndex = 11;
            this.pow.Text = "Power";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(620, 307);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(76, 58);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(704, 365);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.devision);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculator);
            this.MaximumSize = new System.Drawing.Size(828, 502);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 404);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Calculator;
        private Label label1;
        private TextBox txtnumber1;
        private TextBox txtnumber2;
        private Label label2;
        private TextBox txtresult;
        private Label label3;
        private Button plus;
        private Button multiplication;
        private Button devision;
        private Button minus;
        private Button pow;
        private Button resetButton;
    }
}