using System;
using System.Drawing;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace VelychkoOOP_26
{
    public partial class Form1 : Form
    {
        public int greetingIndex = 0;
        public string filename = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WordTemplates", "Greeting00.dotx");
        public Word.Application word = new Word.Application();
        public Word.Document doc = new Word.Document();
        public void RefreshGreetingCard()
        {
            filename = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WordTemplates", $"Greeting0{greetingIndex}.dotx");
            selectedTemplateLabel.Text = $"Шаблон {greetingIndex + 1}";
            panel1.BackgroundImage = imageList1.Images[greetingIndex];
            switch (greetingIndex)
            {
                case 0:
                    friendLabel.TextAlign = ContentAlignment.MiddleLeft;
                    friendLabel.ForeColor = Color.White;
                    timeDatePlaceLabel.TextAlign = ContentAlignment.MiddleRight;
                    timeDatePlaceLabel.ForeColor = Color.White;
                    timeDatePlaceLabel.Location = new Point(17, 89);
                    break;
                case 1:
                    friendLabel.TextAlign = ContentAlignment.MiddleRight;
                    friendLabel.ForeColor = Color.Black;
                    timeDatePlaceLabel.TextAlign = ContentAlignment.MiddleLeft;
                    timeDatePlaceLabel.ForeColor = Color.Black;
                    timeDatePlaceLabel.Location = new Point(17, 62);
                    break;
                default:
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
            RefreshGreetingCard();
        }

        private void buttonCreateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker1.Value.ToShortDateString();
                string time = timeTextBox.Text;
                string place = placeTextBox.Text;
                Object missingObj = System.Reflection.Missing.Value;
                Object trueObj = true;
                Object falseObj = false;
                Object templatePathObj = filename;

                doc = word.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                doc.Activate();

                foreach (Word.FormField fld in doc.FormFields)
                {
                    switch (fld.Name)
                    {
                        case "time":
                            fld.Range.Text = time;
                            break;
                        case "date":
                            fld.Range.Text = date;
                            break;
                        case "place":
                            fld.Range.Text = place;
                            break;
                        default:
                            if (fld.Name.Length < 10)
                            {
                                Console.WriteLine(fld.Name);
                                break;
                            }
                            int friendIndex = Convert.ToInt32(fld.Name.Substring(10));
                            fld.Range.Text = richTextBox1.Lines[friendIndex-1].ToString();
                            break;
                    }
                }

                word.Visible = true;
                if (pathTextBox.Text.Length > 0)
                {
                    doc.SaveAs2(@pathTextBox.Text + @"\GreetingCards.docx");
                }
            }
            catch (Exception ex) {
                doc.Close();
                word.Quit();
                doc = null;
                word = null;
                throw(ex);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (doc != null)
                {
                    object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
                    doc.Close(ref saveChanges);
                    doc = null;
                }
            }
            catch { }
            try
            {
                if (word != null)
                {
                    word.Quit();
                    word = null;
                }
            }
            catch { }
            doc = null;
            word = null;
        }

        private void nextPicButton_Click(object sender, EventArgs e)
        {
            if (greetingIndex < 1) greetingIndex++; else greetingIndex = 1;
            RefreshGreetingCard();
        }

        private void prevPicButton_Click(object sender, EventArgs e)
        {
            if (greetingIndex > 0) greetingIndex--; else greetingIndex = 0;
            RefreshGreetingCard();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult diagResult = folderBrowserDialog1.ShowDialog(this);
            if (diagResult == DialogResult.OK)
            {
                pathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Lines.Length > 0) friendLabel.Text = richTextBox1.Lines[0].ToString();
            else friendLabel.Text = "Друже";

            timeDatePlaceLabel.Text = $"{dateTimePicker1.Value.ToShortDateString()} о " +
                $"{timeTextBox.Text}\n{placeTextBox.Text}";
        }
    }
}
