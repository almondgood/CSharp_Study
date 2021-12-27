
namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SumNumbers = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.Sum1 = new System.Windows.Forms.TextBox();
            this.Sum2 = new System.Windows.Forms.TextBox();
            this.SumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SumNumbers
            // 
            this.SumNumbers.Location = new System.Drawing.Point(350, 115);
            this.SumNumbers.Name = "SumNumbers";
            this.SumNumbers.Size = new System.Drawing.Size(75, 23);
            this.SumNumbers.TabIndex = 0;
            this.SumNumbers.Text = "=";
            this.SumNumbers.UseVisualStyleBackColor = true;
            this.SumNumbers.Click += new System.EventHandler(this.SumNumbers_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Location = new System.Drawing.Point(12, 9);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(105, 12);
            this.HelloLabel.TabIndex = 10;
            this.HelloLabel.Text = "여기를 클릭하세요";
            this.HelloLabel.Click += new System.EventHandler(this.HelloLabel_Click);
            // 
            // Sum1
            // 
            this.Sum1.Location = new System.Drawing.Point(50, 115);
            this.Sum1.Name = "Sum1";
            this.Sum1.Size = new System.Drawing.Size(100, 21);
            this.Sum1.TabIndex = 11;
            // 
            // Sum2
            // 
            this.Sum2.Location = new System.Drawing.Point(193, 114);
            this.Sum2.Name = "Sum2";
            this.Sum2.Size = new System.Drawing.Size(100, 21);
            this.Sum2.TabIndex = 12;
            // 
            // SumResult
            // 
            this.SumResult.Location = new System.Drawing.Point(472, 115);
            this.SumResult.Name = "SumResult";
            this.SumResult.Size = new System.Drawing.Size(100, 21);
            this.SumResult.TabIndex = 13;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumResult);
            this.Controls.Add(this.Sum2);
            this.Controls.Add(this.Sum1);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.SumNumbers);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumNumbers;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TextBox Sum1;
        private System.Windows.Forms.TextBox Sum2;
        private System.Windows.Forms.TextBox SumResult;
    }
}

