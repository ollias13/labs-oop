using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9
{
    public partial class Form1 : Form
    {
        private const int plotWidth = 800;
        private const int plotHeight = 600;
        private const int axisPadding = 30;

        private double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Запускаємо діалогове вікно для введення коефіцієнтів
            InputCoefficientsDialog dialog = new InputCoefficientsDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                a = dialog.A;
                b = dialog.B;
                c = dialog.C;
                PlotGraph();
            }
            else
            {
                Close();
            }
        }

        private void PlotGraph()
        {
            // Створюємо новий об'єкт Bitmap для графіки
            Bitmap bmp = new Bitmap(plotWidth, plotHeight);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Встановлюємо чорний колір для ліній і тексту
                g.Clear(Color.White);
                Pen pen = new Pen(Color.Black);

                // Малюємо осі координат
                g.DrawLine(pen, axisPadding, plotHeight / 2, plotWidth - axisPadding, plotHeight / 2); // Ось X
                g.DrawLine(pen, axisPadding, 0, axisPadding, plotHeight); // Ось Y

                // Малюємо підписи осей
                Font font = new Font("Arial", 10);
                g.DrawString("X", font, Brushes.Black, plotWidth - axisPadding, plotHeight / 2 + 5);
                g.DrawString("Y", font, Brushes.Black, axisPadding - 10, 0);

                // Обчислюємо та малюємо точки на графіку
                double t = -10;
                double dt = 0.1;

                while (t <= 10)
                {
                    double x = a * Math.Cos(b * t);
                    double y = c * Math.Sin(b * t);

                    int pixelX = (int)(plotWidth / 2 + x * 20); // Масштабуємо для зручного відображення
                    int pixelY = (int)(plotHeight / 2 - y * 20);

                    g.DrawRectangle(pen, pixelX, pixelY, 1, 1);

                    // Додаємо підписи значень на осі
                    if (t % 1 == 0)
                    {
                        g.DrawString(t.ToString(), font, Brushes.Black, pixelX, plotHeight / 2 + 5);
                        g.DrawString((-t).ToString(), font, Brushes.Black, pixelX, plotHeight / 2 - 15);
                    }

                    t += dt;
                }
            }
        // Відображаємо графіку на формі
        graphPictureBox.Image = bmp;
        }
    }

    public class InputCoefficientsDialog : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Button buttonOK;
        private Button buttonCancel;

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public InputCoefficientsDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коеф. a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Коеф. b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Коеф. c:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(63, 12);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(63, 42);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(63, 72);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 110);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(93, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // InputCoefficientsDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(184, 145);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputCoefficientsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введіть коефіцієнти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) &&
                double.TryParse(textBoxB.Text, out double b) &&
                double.TryParse(textBoxC.Text, out double c))
            {
                A = a;
                B = b;
                C = c;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неправильний формат введених даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}