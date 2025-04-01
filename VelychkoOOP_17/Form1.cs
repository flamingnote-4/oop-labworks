using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VelychkoOOP_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            string input1 = Textbox1.Text;
            string input2 = Textbox2.Text;
            Number a, b, result;

            if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
            {
                a = new Integer(int1);
                b = new Integer(int2);
            }
            else if (double.TryParse(input1, out double d1) && double.TryParse(input2, out double d2))
            {
                a = new Real(d1);
                b = new Real(d2);
            } else
            {
                ResultLabel.Text = "Помилка: неправильне введення.";
                return;
            }

            try
            {
                switch (Operations_Combobox.SelectedIndex)
                {
                    case 0: result = a.Add(b); break;
                    case 1: result = a.Subtract(b); break;
                    case 2: result = a.Multiply(b); break;
                    case 3: result = a.Divide(b); break;
                    default: ResultLabel.Text = "(Оберіть операцію)"; return;
                }

                ResultLabel.Text = $"= {result.ToString()}";
            }
            catch
            {
                ResultLabel.Text = $"Помилка ділення на нуль.";
            }
        }
    }
}
