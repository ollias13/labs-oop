
namespace LB10
{
    partial class Form2
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.redocTextBox = new System.Windows.Forms.TextBox();
            this.shaTextBox = new System.Windows.Forms.TextBox();
            this.lucTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(28, 293);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "button1";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(160, 294);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // redocTextBox
            // 
            this.redocTextBox.Location = new System.Drawing.Point(350, 173);
            this.redocTextBox.Name = "redocTextBox";
            this.redocTextBox.Size = new System.Drawing.Size(406, 22);
            this.redocTextBox.TabIndex = 2;
            // 
            // shaTextBox
            // 
            this.shaTextBox.Location = new System.Drawing.Point(350, 215);
            this.shaTextBox.Name = "shaTextBox";
            this.shaTextBox.Size = new System.Drawing.Size(406, 22);
            this.shaTextBox.TabIndex = 3;
            // 
            // lucTextBox
            // 
            this.lucTextBox.Location = new System.Drawing.Point(350, 254);
            this.lucTextBox.Name = "lucTextBox";
            this.lucTextBox.Size = new System.Drawing.Size(406, 22);
            this.lucTextBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lucTextBox);
            this.Controls.Add(this.shaTextBox);
            this.Controls.Add(this.redocTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox redocTextBox;
        private System.Windows.Forms.TextBox shaTextBox;
        private System.Windows.Forms.TextBox lucTextBox;
    }
}