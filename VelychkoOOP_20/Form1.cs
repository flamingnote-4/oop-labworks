using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelychkoOOP_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                a = Convert.ToDouble(TextboxA.Text);
                b = Convert.ToDouble(TextboxB.Text);

                if (a == 0)
                {
                    throw new Exception("BadArgumentA");
                }

                double result = a / (-b);

                Result_Label.ForeColor = Color.Black;
                Result_Label.Text = $"Корінь: {result}";
            }
            catch (Exception ex)
            {
                Result_Label.ForeColor = Color.Red;
                Result_Label.Text = "Помилка: ";

                if (ex.Message == "BadArgumentA")
                {
                    Result_Label.Text += "рівняння не є лінійним.";
                    return;
                }
                
                Result_Label.Text += ex.Message;
            }
        }
    }
}