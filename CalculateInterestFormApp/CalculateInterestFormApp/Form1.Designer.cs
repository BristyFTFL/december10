namespace CalculateInterestFormApp
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
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.interestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(112, 68);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(180, 21);
            this.bankNameComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Name";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(112, 110);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(144, 20);
            this.yearTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time In Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Amount";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(64, 231);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(49, 13);
            this.interestLabel.TabIndex = 1;
            this.interestLabel.Text = "Interest *";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(112, 157);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(144, 20);
            this.amountTextBox.TabIndex = 2;
            // 
            // interestButton
            // 
            this.interestButton.Location = new System.Drawing.Point(138, 221);
            this.interestButton.Name = "interestButton";
            this.interestButton.Size = new System.Drawing.Size(144, 23);
            this.interestButton.TabIndex = 3;
            this.interestButton.Text = "Calculate Interest";
            this.interestButton.UseVisualStyleBackColor = true;
            this.interestButton.Click += new System.EventHandler(this.interestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 291);
            this.Controls.Add(this.interestButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankNameComboBox);
            this.Name = "Form1";
            this.Text = "Interest Calculation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button interestButton;
    }
}

