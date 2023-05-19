
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(340, 30);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(256, 77);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "ОК";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(28, 30);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(306, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // redocTextBox
            // 
            this.redocTextBox.Location = new System.Drawing.Point(28, 113);
            this.redocTextBox.Name = "redocTextBox";
            this.redocTextBox.Size = new System.Drawing.Size(568, 22);
            this.redocTextBox.TabIndex = 2;
            // 
            // shaTextBox
            // 
            this.shaTextBox.Location = new System.Drawing.Point(28, 158);
            this.shaTextBox.Name = "shaTextBox";
            this.shaTextBox.Size = new System.Drawing.Size(568, 22);
            this.shaTextBox.TabIndex = 3;
            // 
            // lucTextBox
            // 
            this.lucTextBox.Location = new System.Drawing.Point(28, 203);
            this.lucTextBox.Name = "lucTextBox";
            this.lucTextBox.Size = new System.Drawing.Size(568, 22);
            this.lucTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "REDOC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "LUC";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lucTextBox);
            this.Controls.Add(this.shaTextBox);
            this.Controls.Add(this.redocTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form2";
            this.Text = "LAB10.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox redocTextBox;
        private System.Windows.Forms.TextBox shaTextBox;
        private System.Windows.Forms.TextBox lucTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}