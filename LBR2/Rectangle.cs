using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBR2
{
    class Rectangle
    {
        public double X { get; set; }  // координата X верхнього лівого кута прямокутника
        public double Y { get; set; }  // координата Y верхнього лівого кута прямокутника
        public double Width { get; set; } // ширина прямокутника
        public double Height { get; set; } // висота прямокутника
        public void Move(double dx, double dy) // метод для переміщення прямокутника на площині
        {
            X += dx;
            Y += dy;
        }
        public void Resize(double dw, double dh) /// метод для зміни розмірів прямокутника
        {
            Width += dw;
            Height += dh;
        }
        public Rectangle Union(Rectangle other) // метод для побудови найменшого прямокутника, що містить два задані прямокутники
        {
            double x1 = Math.Min(X, other.X);
            double y1 = Math.Min(Y, other.Y);
            double x2 = Math.Max(X + Width, other.X + other.Width);
            double y2 = Math.Max(Y + Height, other.Y + other.Height);
            return new Rectangle { X = x1, Y = y1, Width = x2 - x1, Height = y2 - y1 };
        }
        public Rectangle Intersect(Rectangle other) // метод для побудови прямокутника, який є спільною частиною (перетинанням) двох прямокутників
        {
            double x1 = Math.Max(X, other.X);
            double y1 = Math.Max(Y, other.Y);
            double x2 = Math.Min(X + Width, other.X + other.Width);
            double y2 = Math.Min(Y + Height, other.Y + other.Height);
            if (x2 < x1 || y2 < y1)
            {
                return null;  // якщо прямокутники не перетинаються, повертаємо null
            }
            else
            {
                return new Rectangle { X = x1, Y = y1, Width = x2 - x1, Height = y2 - y1 };
                // якщо прямокутники перетинаються, повертаємо новий прямокутник з відповідними параметрами
            }
        }
    }
}
