using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelychkoOOP_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            char[] chars = Textbox1.Text.Replace(" ", "").ToCharArray();
            if (chars.Length == 3 && char.IsDigit(chars[0]) && char.IsDigit(chars[1]) && char.IsDigit(chars[2]))
            {
                string result = $"{chars[0]}{chars[1]}{chars[2]}";
                Result_Label.Text = $"Результат - {result}";
                int resultInt = Convert.ToInt32(result);
            } else
            {
                Result_Label.Text = "Число не може бути утворене.";
            }
        }
    }
}
