namespace Passwarden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.caseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.nonsensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericCheckBox = new System.Windows.Forms.CheckBox();
            this.punctuationCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 13);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // copyButton
            // 
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.Location = new System.Drawing.Point(213, 13);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(24, 24);
            this.copyButton.TabIndex = 1;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(162, 43);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // caseSensitiveCheckBox
            // 
            this.caseSensitiveCheckBox.AutoSize = true;
            this.caseSensitiveCheckBox.Location = new System.Drawing.Point(12, 43);
            this.caseSensitiveCheckBox.Name = "caseSensitiveCheckBox";
            this.caseSensitiveCheckBox.Size = new System.Drawing.Size(60, 17);
            this.caseSensitiveCheckBox.TabIndex = 3;
            this.caseSensitiveCheckBox.Text = "Aa - Zz";
            this.caseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.caseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.caseSensitiveCheckBox_CheckedChanged);
            // 
            // nonsensitiveCheckBox
            // 
            this.nonsensitiveCheckBox.AutoSize = true;
            this.nonsensitiveCheckBox.Location = new System.Drawing.Point(12, 66);
            this.nonsensitiveCheckBox.Name = "nonsensitiveCheckBox";
            this.nonsensitiveCheckBox.Size = new System.Drawing.Size(46, 17);
            this.nonsensitiveCheckBox.TabIndex = 3;
            this.nonsensitiveCheckBox.Text = "a - z";
            this.nonsensitiveCheckBox.UseVisualStyleBackColor = true;
            this.nonsensitiveCheckBox.CheckedChanged += new System.EventHandler(this.nonsensitiveCheckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 89);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Aa-Zz";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericCheckBox
            // 
            this.numericCheckBox.AutoSize = true;
            this.numericCheckBox.Location = new System.Drawing.Point(12, 89);
            this.numericCheckBox.Name = "numericCheckBox";
            this.numericCheckBox.Size = new System.Drawing.Size(47, 17);
            this.numericCheckBox.TabIndex = 3;
            this.numericCheckBox.Text = "0 - 9";
            this.numericCheckBox.UseVisualStyleBackColor = true;
            // 
            // punctuationCheckBox
            // 
            this.punctuationCheckBox.AutoSize = true;
            this.punctuationCheckBox.Location = new System.Drawing.Point(12, 112);
            this.punctuationCheckBox.Name = "punctuationCheckBox";
            this.punctuationCheckBox.Size = new System.Drawing.Size(87, 17);
            this.punctuationCheckBox.TabIndex = 3;
            this.punctuationCheckBox.Text = "!\"#$%&\'()*+,-./";
            this.punctuationCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 261);
            this.Controls.Add(this.punctuationCheckBox);
            this.Controls.Add(this.numericCheckBox);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.nonsensitiveCheckBox);
            this.Controls.Add(this.caseSensitiveCheckBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox caseSensitiveCheckBox;
        private System.Windows.Forms.CheckBox nonsensitiveCheckBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox numericCheckBox;
        private System.Windows.Forms.CheckBox punctuationCheckBox;
    }
}

