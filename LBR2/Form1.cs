using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try // якщо все вірно программа працює.
            {
                // вводимо x1, x2, ширину та висоту.
                double x1 = double.Parse(this.x1.Text); // зберігаємо дані x1
                double y1 = double.Parse(this.y1.Text); // зберігаємо дані y1
                double w1 = double.Parse(this.w1.Text); // зберігаємо дані ширини1
                double h1 = double.Parse(this.h1.Text); // зберігаємо дані висоти1
                Rectangle rect1 = new Rectangle { X = x1, Y = y1, Width = w1, Height = h1 };
                double x2 = double.Parse(this.x2.Text); // зберігаємо дані x2
                double y2 = double.Parse(this.y2.Text); // зберігаємо дані y2
                double w2 = double.Parse(this.w2.Text); // зберігаємо дані ширини2
                double h2 = double.Parse(this.h2.Text); // зберігаємо дані висоти2
                // створюємо об'єкт прямокутників та зберігаємо в ньому дані
                Rectangle rect2 = new Rectangle { X = x2, Y = y2, Width = w2, Height = h2 };
                PrintRectangle(rect1, this.rect1); // вивід даних rect1 на консоль
                PrintRectangle(rect2, this.rect2); // вивід даних rect2 на консоль
                // об'єднання двох прямокутників із створенням найменшого прямокутника, що містить обидва прямокутники
                Rectangle union = rect1.Union(rect2);
                PrintRectangle(union, smallst);
                // визначення спільної частини двох прямокутників (їх перетинання).
                // якщо перетинання є, виводимо спільну частину, якщо ні - повідомляємо про це.
                Rectangle intersection = rect1.Intersect(rect2);
                if (intersection != null)
                {
                    PrintRectangle(intersection, general); // вивід прямокутника-перетину.
                }
                else
                {
                    general.Text = "do not intersect."; // якщо перетину немає
                }
            }
            catch (Exception ex) // в інакшому випадку буде помилка.
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        // функція, яка виводить дані про прямокутник на консоль.
        static void PrintRectangle(Rectangle rect, Label label)
        {
            label.Text = $"X: {rect.X}, Y: {rect.Y}, Width: {rect.Width}, Height: {rect.Height}";
        }
    }
}
