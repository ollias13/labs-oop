using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LBR6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Введення значень
            double a = double.Parse(textBox1.Text);
            double q = double.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);

            // Формула обчислення геометричної прогресії
            double sum = a * (Math.Pow(q, n) - 1) / (q - 1);

            // Виведення результату
            res.Text = "Сума геометричної прогресiї дорiвнює " + sum.ToString();
        }
    }
}
