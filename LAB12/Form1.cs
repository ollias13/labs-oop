using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace LAB12
{
    public partial class Form1 : Form
    {
        private string templatePath = "C:\\Users\\mrden\\OneDrive\\Рабочий стол\\csharp\\LAB12\\list.docx";
        private string outputPath = "C:\\Users\\mrden\\OneDrive\\Рабочий стол\\GeneratedDocument.docx";
        public Form1()
        {
            InitializeComponent();
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Створення об'єкту додатку Microsoft Word
                var wordApp = new Application();

                // Відкриття шаблону документа
                var document = wordApp.Documents.Open(templatePath);

                // Отримання секцій документа
                var sections = document.Sections;

                // Застосування різних шаблонів до секцій документа
                foreach (Section section in sections)
                {
                    ApplyTemplateToSection(section);
                }
                // Заміна тексту в шаблоні 1 на введений користувачем текст
                var range = document.Content;
                range.Find.Execute(FindText: "Назва", ReplaceWith: nazvaTextBox.Text);

                var range1 = document.Content;
                range1.Find.Execute(FindText: "Опис", ReplaceWith: opusTextBox.Text);

                var range2 = document.Content;
                range2.Find.Execute(FindText: "Дата", ReplaceWith: dateTimePicker.Text);

                var range3 = document.Content;
                range3.Find.Execute(FindText: "час", ReplaceWith: timeTextBox.Text);

                var range4 = document.Content;
                range4.Find.Execute(FindText: "Пошта", ReplaceWith: emailTextBox.Text);

                var range5 = document.Content;
                range5.Find.Execute(FindText: "Телефон", ReplaceWith: phoneTextBox.Text);
                // Заміна тексту в шаблоні 2 на введений користувачем текст
                var range6 = document.Content;
                range6.Find.Execute(FindText: "Назва2", ReplaceWith: nazvaTextBox.Text);

                var range7 = document.Content;
                range7.Find.Execute(FindText: "Опис2", ReplaceWith: opusTextBox.Text);

                var range8 = document.Content;
                range8.Find.Execute(FindText: "Дата2", ReplaceWith: dateTimePicker.Text);

                var range9 = document.Content;
                range9.Find.Execute(FindText: "Час2", ReplaceWith: timeTextBox.Text);

                var range10 = document.Content;
                range10.Find.Execute(FindText: "Пошта2", ReplaceWith: emailTextBox.Text);

                var range11 = document.Content;
                range11.Find.Execute(FindText: "Телефон2", ReplaceWith: phoneTextBox.Text);

                // Збереження згенерованого документа
                document.SaveAs(outputPath);

                // Закриття документа та додатку Microsoft Word
                document.Close();
                wordApp.Quit();

                MessageBox.Show("Документ згенеровано успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при генерації документа: " + ex.Message);
            }
        }

        private void ApplyTemplateToSection(Section section)
        {
            // Вставлення зображення в тіло секції
            var bodyRange = section.Range;
            InlineShape picture = bodyRange.InlineShapes.AddPicture("C:\\Users\\mrden\\OneDrive\\Рабочий стол\\csharp\\LAB12\\cat.png");
            picture.Width = 50; // ширина зображення
            picture.Height = 50; // висота зображення
        }
    }
}
