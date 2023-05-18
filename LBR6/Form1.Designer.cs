
namespace LBR6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.labelq = new System.Windows.Forms.Label();
            this.labeln = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(42, 192);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(28, 17);
            this.res.TabIndex = 1;
            this.res.Text = "res";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(42, 32);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(58, 17);
            this.labela.TabIndex = 5;
            this.labela.Text = "Enter a:";
            // 
            // labelq
            // 
            this.labelq.AutoSize = true;
            this.labelq.Location = new System.Drawing.Point(42, 80);
            this.labelq.Name = "labelq";
            this.labelq.Size = new System.Drawing.Size(58, 17);
            this.labelq.TabIndex = 6;
            this.labelq.Text = "Enter q:";
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(42, 123);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(58, 17);
            this.labeln.TabIndex = 7;
            this.labeln.Text = "Enter n:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 228);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.labelq);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "LBR5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label labelq;
        private System.Windows.Forms.Label labeln;
    }
}

