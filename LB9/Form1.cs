using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB9
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

                    t += dt;
                }
            }

            // Відображаємо графіку на формі
            pictureBox1.Image = bmp;
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
            // Ініціалізуємо компоненти форми
            // ...

            // Налаштовуємо події для кнопок OK і Cancel
            buttonOK.Click += buttonOK_Click;
            buttonCancel.Click += buttonCancel_Click;
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
                Close();
            }
            else
            {
                MessageBox.Show("Некоректні введені дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
