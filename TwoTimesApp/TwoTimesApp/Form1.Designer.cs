namespace TwoTimesApp
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
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.twoTimesValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(97, 186);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(123, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show Two Times";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anumber";
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(117, 47);
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(137, 20);
            this.aNumberTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Two Times Value";
            // 
            // twoTimesValueTextBox
            // 
            this.twoTimesValueTextBox.Location = new System.Drawing.Point(117, 91);
            this.twoTimesValueTextBox.Name = "twoTimesValueTextBox";
            this.twoTimesValueTextBox.Size = new System.Drawing.Size(137, 20);
            this.twoTimesValueTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.twoTimesValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox twoTimesValueTextBox;
    }
}

