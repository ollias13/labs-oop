using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Просимо користувача ввести рядок
            string inputString = textBox1.Text;
            // Створюємо словник, який буде зберігати лічильник символів
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            // Перебираємо кожен символ в рядку та додаємо його до словника
            foreach (char c in inputString)
            {
                if (charCount.ContainsKey(c))
                {
                    // Якщо символ вже є у словнику, збільшуємо його лічильник на 1
                    charCount[c]++;
                }
                else
                {
                    // Якщо символу ще немає у словнику, додаємо його з лічильником 1
                    charCount.Add(c, 1);
                }
            }
            // Очищаємо richTextBox
            richTextBox1.Clear();
            // Виводимо результати підрахунку кількості символів
            foreach (KeyValuePair<char, int> kvp in charCount)
            {
                richTextBox1.AppendText(string.Format("Символ '{0}' зустрічається {1} разів\n", kvp.Key, kvp.Value));
            }
        }
    }
}
