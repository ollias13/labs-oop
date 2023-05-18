using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            npSave.Enabled = false;
            ComboBoxFonts.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFonts.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());
            ComboBoxRozmir.DropDownStyle = ComboBoxStyle.DropDownList;
            int[] fontSizes = Enumerable.Range(2, 127).ToArray();
            object[] fontSizeObjects = fontSizes.Cast<object>().ToArray();
            ComboBoxRozmir.Items.AddRange(fontSizeObjects);
            langEN.Enabled = false;
            langUA.Enabled = true;
        }
        private void npNew_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр формы frm
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            //Указываем, что родительским контейнером 
            //нового экземпляра будет эта, главная форма.
            frm.MdiParent = this;
            //Вызываем форму
            frm.Show();
        }
        private int openDocuments = 0;

        private void npCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void npHori_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void npVert_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void npCut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }
        private void npCopy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }
        private void npPaste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }
        private void npDelete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }
        private void npSelectAll_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }
        private void npOpen_Click(object sender, EventArgs e)
        {
            //Можно программно задавать доступные для обзора расширения файлов 
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            //Если выбран диалог открытия файла, выполняем условие
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Создаем новый документ
                blank frm = new blank();
                //Вызываем метод Open формы blank
                frm.Open(openFileDialog1.FileName);
                //Указываем, что родительской формой является форма frmmain
                frm.MdiParent = this;
                //Присваиваем переменной DocName имя открываемого файла
                frm.DocName = openFileDialog1.FileName;
                //Свойству Text формы присваиваем переменную DocName
                frm.Text = frm.DocName;
                //Вызываем форму frm
                frm.Show();
                mnuSave.Enabled = true;
            }
        }
        private void npSave_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            //Вызываем метод Save формы blank
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }
        private void npSaveAs_Click(object sender, EventArgs e)
        {
            // Переключаємо фокус на активну форму
            blank frm = (blank)this.ActiveMdiChild;
            // Показуємо діалогове вікно збереження файлу
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Отримуємо розширення файлу
                string fileExt = Path.GetExtension(saveFileDialog1.FileName);
                // Зберігаємо файл у форматі RTF
                if (fileExt == ".rtf")
                {
                    frm.richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                // Зберігаємо файл у форматі TXT
                else if (fileExt == ".txt")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.Write(frm.richTextBox1.Text);
                    }
                }
                // Оновлюємо назву та статус збереження форми
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.IsSaved = true;
            }
        }
        private void npFont_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            //Указываем, что родительской формой является форма frmmain 
            frm.MdiParent = this;
            //Вызываем диалог
            fontDialog1.ShowColor = true;
            //Связываем свойства SelectionFont и SelectionColor элемента RichTextBox 
            //с соответствующими свойствами диалога
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            //Если выбран диалог открытия файла, выполняем условие
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            //Показываем форму
            frm.Show();
        }
        // Меню смены цвета текста
        private void npColor_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }
        // Функция выхода с приложения
        private void npExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Функция поиска
        private void npFind_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр формы FindForm
            FindForm frm = new FindForm();
            //Если выбран результат DialogResult.Cancel, закрываем форму (до этого 
            //мы использовали DialogResult.OK)
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            ////Переключаем фокус на данную форму.
            blank form = (blank)this.ActiveMdiChild;
            ////Указываем, что родительской формой является форма frmmain 
            form.MdiParent = this;
            //Вводим переменную для поиска в определенной части текста —
            //поиск слова будет осуществляться от текущей позиции курсора
            int start = form.richTextBox1.SelectionStart;
            //Вызываем предопределенный метод Find элемента richTextBox1.
            int v = form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }
        // Про программу
        private void npAbout_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр формы About
            About frm = new About();
            frm.ShowDialog();
        }
        // Иконки нового файла, открытия, сохранения и т.д.
        private void tabNew_Click(object sender, EventArgs e)
        {
            npNew_Click(this, new EventArgs());
        }
        private void tabOpen_Click(object sender, EventArgs e)
        {
            npOpen_Click(this, new EventArgs());
        }
        private void tabSave_Click(object sender, EventArgs e)
        {
            npSave_Click(this, new EventArgs());
        }
        private void tabCut_Click(object sender, EventArgs e)
        {
            npCut_Click(this, new EventArgs());
        }
        private void tabCopy_Click(object sender, EventArgs e)
        {
            npCopy_Click(this, new EventArgs());
        }
        private void tabPaste_Click(object sender, EventArgs e)
        {
            npPaste_Click(this, new EventArgs());
        }
        // Перевод на украинский
        private void langUA_Click(object sender, EventArgs e)
        {
            npFile.Text = Properties.Resources.mnuFileUA;
            npEdit.Text = Properties.Resources.editUA;
            npFormat.Text = Properties.Resources.formatUA;
            npWindow.Text = Properties.Resources.windowUA;
            npNew.Text = Properties.Resources.mnuNewUA;
            npOpen.Text = Properties.Resources.mnuOpenUA;
            npSave.Text = Properties.Resources.mnuSaveUA;
            npSaveAs.Text = Properties.Resources.mnuSaveAsUA;
            npExit.Text = Properties.Resources.mnuExitUA;
            npCut.Text = Properties.Resources.cutUA;
            npCopy.Text = Properties.Resources.CopyUA;
            npPaste.Text = Properties.Resources.PasteUA;
            npDelete.Text = Properties.Resources.DeleteUA;
            npSelectAll.Text = Properties.Resources.SelectAllUA;
            npFind.Text = Properties.Resources.FindUA;
            npFont.Text = Properties.Resources.FontUA;
            npColor.Text = Properties.Resources.ColorUA;
            npCascade.Text = Properties.Resources.CascadeUA;
            npHori.Text = Properties.Resources.HorizonUA;
            npVert.Text = Properties.Resources.VertUA;
            npAbout.Text = Properties.Resources.AboutUA;
            tabNew.Text = "Новий";
            langUA.Enabled = false;
            langEN.Enabled = true;
        }
        // Перевод на английский язык
        private void langEN_Click(object sender, EventArgs e)
        {
            npFile.Text = "&File";
            npEdit.Text = "&Edit";
            npFormat.Text = "F&ormat";
            npWindow.Text = "&Window";
            npNew.Text = "New";
            npOpen.Text = "Open";
            npSave.Text = "Save";
            npSaveAs.Text = "Save As";
            npExit.Text = "Exit";
            npCut.Text = "Cut";
            npCopy.Text = "Copy";
            npPaste.Text = "Paste";
            npDelete.Text = "Delete";
            npSelectAll.Text = "Select All";
            npFind.Text = "Find";
            npFont.Text = "Font";
            npColor.Text = "Color";
            npCascade.Text = "Cascade";
            npHori.Text = "Tile Horizontal";
            npVert.Text = "Tile Vertical";
            npAbout.Text = "About Programm...";
            langUA.Enabled = true;
            langEN.Enabled = false;
        }
        // Выравнивание текста
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Отримуємо активну дочірню форму
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlignCenter_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void AlignRight_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void AlignJustify_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionIndent = 0;
            frm.richTextBox1.SelectionRightIndent = 0;
            frm.richTextBox1.SelectionHangingIndent = 0;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            var font = new Font((string)ComboBoxFonts.SelectedItem, frm.richTextBox1.Font.Size);
            frm.richTextBox1.Font = font;
        }

        private void ComboBoxRozmir_SelectedIndexChanged(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            int fontSize = Convert.ToInt32(ComboBoxRozmir.SelectedItem); // Отримання значення вибраного елемента ComboBox
            frm.richTextBox1.Font = new Font(frm.richTextBox1.Font.FontFamily, fontSize); // Встановлення розміру шрифту richTextBox1
        }
        private bool isBold = false; // Початково шрифт не жирний
        private void btBold_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            if (isBold)
            {
                frm.richTextBox1.SelectionFont = new Font(frm.richTextBox1.Font, FontStyle.Regular); // Застосувати звичайний шрифт
                isBold = false; // Змінити стан на не жирний
            }
            else
            {
                frm.richTextBox1.SelectionFont = new Font(frm.richTextBox1.Font, FontStyle.Bold); // Застосувати жирний шрифт
                isBold = true; // Змінити стан на жирний
            }
        }
        private bool isItalic = false; // Початково шрифт не курсив
        private void btItalic_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            if (isBold)
            {
                frm.richTextBox1.SelectionFont = new Font(frm.richTextBox1.Font, FontStyle.Regular); // Застосувати звичайний шрифт
                isBold = false; // Змінити стан на не курсив
            }
            else
            {
                frm.richTextBox1.SelectionFont = new Font(frm.richTextBox1.Font, FontStyle.Italic); // Застосувати жирний шрифт
                isBold = true; // Змінити стан на курсив
            }
        }
        private bool isUnderlined = false; // Початково шрифт не подчеркнутый
        private void btUnderlined_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            if (isBold)
            {
                frm.richTextBox1.SelectionFont = new Font(frm.richTextBox1.Font, FontStyle.Regular); // Застосувати звичайний шрифт
                isBold = false; // Змінити стан на не подчеркнутый
            }
            else
            {
                frm.richTextBox1.SelectionFont = new Font(frm.richTextBox1.Font, FontStyle.Underline); // Застосувати жирний шрифт
                isBold = true; // Змінити стан на подчеркнутый
            }
        }
    }
}
