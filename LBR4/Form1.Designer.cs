
namespace LBR4
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.allmassive = new System.Windows.Forms.Label();
            this.massive2 = new System.Windows.Forms.Label();
            this.colstr = new System.Windows.Forms.Label();
            this.massm = new System.Windows.Forms.Label();
            this.rowstr2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(39, 21);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(0, 17);
            this.labelA.TabIndex = 2;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(39, 57);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 17);
            this.labelB.TabIndex = 3;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(39, 88);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(0, 17);
            this.labelC.TabIndex = 4;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(39, 118);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(0, 17);
            this.labelD.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Enter2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // allmassive
            // 
            this.allmassive.AutoSize = true;
            this.allmassive.Location = new System.Drawing.Point(39, 164);
            this.allmassive.Name = "allmassive";
            this.allmassive.Size = new System.Drawing.Size(0, 17);
            this.allmassive.TabIndex = 7;
            // 
            // massive2
            // 
            this.massive2.AutoSize = true;
            this.massive2.Location = new System.Drawing.Point(39, 237);
            this.massive2.Name = "massive2";
            this.massive2.Size = new System.Drawing.Size(0, 17);
            this.massive2.TabIndex = 9;
            // 
            // colstr
            // 
            this.colstr.AutoSize = true;
            this.colstr.Location = new System.Drawing.Point(39, 266);
            this.colstr.Name = "colstr";
            this.colstr.Size = new System.Drawing.Size(0, 17);
            this.colstr.TabIndex = 10;
            // 
            // massm
            // 
            this.massm.AutoSize = true;
            this.massm.Location = new System.Drawing.Point(39, 294);
            this.massm.Name = "massm";
            this.massm.Size = new System.Drawing.Size(0, 17);
            this.massm.TabIndex = 11;
            // 
            // rowstr2
            // 
            this.rowstr2.AutoSize = true;
            this.rowstr2.Location = new System.Drawing.Point(39, 320);
            this.rowstr2.Name = "rowstr2";
            this.rowstr2.Size = new System.Drawing.Size(0, 17);
            this.rowstr2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.rowstr2);
            this.Controls.Add(this.massm);
            this.Controls.Add(this.colstr);
            this.Controls.Add(this.massive2);
            this.Controls.Add(this.allmassive);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "LBR4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label allmassive;
        private System.Windows.Forms.Label massive2;
        private System.Windows.Forms.Label colstr;
        private System.Windows.Forms.Label massm;
        private System.Windows.Forms.Label rowstr2;
    }
}

