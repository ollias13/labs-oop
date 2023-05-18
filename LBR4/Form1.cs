using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBR4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 5; // розмір масиву
            double[] arr = { -1.5, 2.7, 0, -3.8, 1.2 }; // ініціалізація масиву
                                                        // Завдання A
            int negativeCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    negativeCount++;
                }
            }
            labelA.Text = $"Кількість від'ємних елементів: {negativeCount}";
            // Завдання Б
            double sum = 0;
            double minModulus = double.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < n; i++)
            {
                double modulus = Math.Abs(arr[i]);
                if (modulus < minModulus)
                {
                    minModulus = modulus;
                    minIndex = i;
                }
                if (i > minIndex)
                {
                    sum += modulus;
                }
            }
            labelB.Text = $"Сума модулів елементів після мінімального за модулем елементу: {sum}";
            // Заміна від'ємних елементів квадратами
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * arr[i];
                }
            }
            // Сортування за зростанням
            Array.Sort(arr);
            // Виведення результатів
            labelC.Text = "Масив після заміни від'ємних елементів квадратами і сортування за зростанням:";
            for (int i = 0; i < n; i++)
            {
                labelD.Text += arr[i] + " ";
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // ініціалізація двовимірного масиву
            int rows = arr.GetLength(0); // кількість рядків масиву
            int cols = arr.GetLength(1); // кількість стовбців масиву
                                         // Виведення всього масиву
            allmassive.Text = "Весь масив:\n";

            for (int i = 0; i < rows; i++)
            {
                string rowStr = "";
                for (int j = 0; j < cols; j++)
                {
                    rowStr += arr[i, j] + " ";
                }
                allmassive.Text += rowStr + "\n";
            }
            // Виведення всіх елементів другого стовбця масиву
            massive2.Text = "Усі елементи другого стовбця масиву:";

            string colStr = "";
            for (int i = 0; i < rows; i++)
            {
                colStr += arr[i, 1] + " ";
            }
            colstr.Text = colStr;

            // Виведення всіх елементів m-го рядка масиву
            int m = 1; // номер рядка, який потрібно вивести
            massm.Text = $"Усі елементи {m}-го рядка масиву:";

            string rowStr2 = "";
            for (int j = 0; j < cols; j++)
            {
                rowStr2 += arr[m, j] + " ";
            }
            rowstr2.Text = rowStr2;
        }
    }
}
