using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelychkoOOP_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task1_Button_Click(object sender, EventArgs e)
        {
            try
            {
                char[] separator = { ' ' };
                string[] inputs = Task1_Textbox.Text.Trim(' ').Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[inputs.Length];

                for (int i = 0; i < inputs.Length; i++)
                {
                    integers[i] = Convert.ToInt32(inputs[i]);
                }

                int min = integers[0], minIndex = 0;
                for (int i = 0; i < integers.Length; i++)
                {
                    if (min > integers[i]) {
                        min = integers[i];
                        minIndex = i;
                    }
                }

                int prod = 1, sum = 0;
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] > 0)
                    {
                        prod *= integers[i];
                    }
                    if (i < minIndex)
                    {
                        sum += integers[i];
                    }
                }

                Sum_Label.Text = $"Сума елементів до мінімального: {sum.ToString()}";
                Product_Label.Text = $"Добуток додатніх елементів: {prod.ToString()}";
                Task1_Sorted.Text = "";

                int temp;
                for (int i = 0; i < integers.Length; i++)
                {
                    for (int j = i%2; j < integers.Length - 2; j += 2)
                    {
                        if (integers[j+2] < integers[j])
                        {
                            temp = integers[j];
                            integers[j] = integers[j + 2];
                            integers[j + 2] = temp;
                        }
                    }
                }

                foreach (int integer in integers)
                {
                    Task1_Sorted.Text += integer;
                    Task1_Sorted.Text += " ";
                }
            }
            catch
            {
                Sum_Label.Text = "Переконайтеся, що ви правильно ввели значення.";
                Product_Label.Text = "";
                Task1_Sorted.Text = "";
            }
        }

        private void Task2_Button_Click(object sender, EventArgs e)
        {
            try
            {
                char[] separator = { ' ' };
                string[] inputs = Task2_Textbox.Text.Replace("\n", " ").Trim(' ').Split(separator, StringSplitOptions.RemoveEmptyEntries);

                Task2_ArrayLabel.Text = "";
                int width = Convert.ToInt32(Task2_WidthTextbox.Text);
                int height = Convert.ToInt32(Task2_HeightTextbox.Text);
                int[,] integers = new int[height, width];
                
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        integers[i, j] = Convert.ToInt32(inputs[i*width + j]);
                    }
                }

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Task2_ArrayLabel.Text += integers[i, j];
                        Task2_ArrayLabel.Text += " ";
                    }
                    Task2_ArrayLabel.Text += "\n";
                }

                Task2_BotLabel.Text = $"Елемент лівого нижнього кута: {integers[height-1, 0]}";
                Task2_TopLabel.Text = $"Елемент правого верхнього кута: {integers[0, width-1]}";
            }
            catch
            {
                Task2_ArrayLabel.Text += "Переконайтеся, що ви правильно\nввели масив.";
            }
        }
    }
}
