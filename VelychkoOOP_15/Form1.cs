using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelychkoOOP_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Point
        {
            public double X, Y;
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        static double CrossProduct(Point A, Point B)
        {
            return A.X * B.Y - A.Y * B.X;
        }

        static bool IsConvex(Point[] points)
        {
            int n = points.Length;
            bool isPositive = false;

            for (int i = 0; i < n; i++)
            {
                Point A = points[i];
                Point B = points[(i + 1) % n];
                Point C = points[(i + 2) % n];

                Point vec1 = new Point(B.X - A.X, B.Y - A.Y);
                Point vec2 = new Point(C.X - B.X, C.Y - B.Y);

                double cross = CrossProduct(vec1, vec2);

                if (i == 0)
                    isPositive = cross > 0;
                else if ((cross > 0) != isPositive)
                    return false;
            }

            return true;
        }

        static double CubicRoot(double x)
        {
            return x >= 0 ? Math.Pow(x, 1.0 / 3.0) : -Math.Pow(-x, 1.0 / 3.0);
        }

        static string FindRoots(double a, double b, double c, double d) {
        double A = b / a;
        double B = c / a;
        double C = d / a;

        double Q = (3 * B - Math.Pow(A, 2)) / 9;
        double R = (9 * A * B - 27 * C - 2 * Math.Pow(A, 3)) / 54;
        double D = Math.Pow(Q, 3) + Math.Pow(R, 2);

        if (D >= 0) {
            double S = CubicRoot(R + Math.Sqrt(D));
            double T = CubicRoot(R - Math.Sqrt(D));

            double x1 = -A / 3 + (S + T);
            return $"Один дійсний корінь: x = {x1}";
        } else {
            double theta = Math.Acos(R / Math.Sqrt(-Math.Pow(Q, 3)));
            double x1 = 2 * Math.Sqrt(-Q) * Math.Cos(theta / 3) - A / 3;
            double x2 = 2 * Math.Sqrt(-Q) * Math.Cos((theta / 3) + (2 * Math.PI / 3)) - A / 3;
            double x3 = 2 * Math.Sqrt(-Q) * Math.Cos((theta / 3) - (2 * Math.PI / 3)) - A / 3;
            return $"Три дійсні корені: x1 = {x1}, x2 = {x2}, x3 = {x3}";
        }
    }

        private void Task1_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(Task1_TextboxA.Text);
                double b = Convert.ToDouble(Task1_TextboxB.Text);
                double c = Convert.ToDouble(Task1_TextboxC.Text);
                double d = Convert.ToDouble(Task1_TextboxD.Text);
                double result = (a / b) * (b / d) - ((a * b - c) / (c * d));
                Task1_ResultLabel.ForeColor = Color.Black;
                Task1_ResultLabel.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                Task1_ResultLabel.ForeColor = Color.Red;
                Task1_ResultLabel.Text = $"Результат: {ex.Message}";
            }
        }

        private void Task2_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double boatV = Convert.ToDouble(Task2_TextboxV1.Text);
                double t1 = Convert.ToDouble(Task2_TextboxT1.Text);
                double s1 = boatV * t1;
                Task2_Label1.Text = $"{s1.ToString()} км";

                double streamV = Convert.ToDouble(Task2_TextboxV2.Text);
                double t2 = Convert.ToDouble(Task2_TextboxT2.Text);
                double s2 = (boatV - streamV) * t2;
                Task2_Label2.Text = $"{s2.ToString()} км";

                Task2_ResultLabel.ForeColor = Color.Black;
                Task2_ResultLabel.Text = $"Шлях обчислено";
            }
            catch (Exception ex)
            {
                Task2_ResultLabel.ForeColor = Color.Red;
                Task2_ResultLabel.Text = $"Помилка: {ex.Message}";
            }
        }

        private void Task3_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(Task3_Textbox.Text);
                if (number < 100) {
                    throw new Exception("BadArgument");
                }

                int sum = 0;
                sum += number % 10;
                sum += number % 100 / 10;
                sum += number / 100;

                bool result = ! Convert.ToBoolean(sum % 2);
                Task3_ResultLabel.ForeColor = Color.Black;
                Task3_ResultLabel.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                Task3_ResultLabel.ForeColor = Color.Red;
                if (ex.Message == "BadArgument")
                {
                    Task3_ResultLabel.Text = "Число не тризначне.";
                } else
                {
                    Task3_ResultLabel.Text = $"Помилка: {ex.Message}";
                }
            }
        }

        private void Task4_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int aX = Convert.ToInt32(Task4_TextboxAX.Text);
                int aY = Convert.ToInt32(Task4_TextboxAY.Text);
                int bX = Convert.ToInt32(Task4_TextboxBX.Text);
                int bY = Convert.ToInt32(Task4_TextboxBY.Text);
                int cX = Convert.ToInt32(Task4_TextboxCX.Text);
                int cY = Convert.ToInt32(Task4_TextboxCY.Text);
                int dX = Convert.ToInt32(Task4_TextboxDX.Text);
                int dY = Convert.ToInt32(Task4_TextboxDY.Text);

                Point[] points = new Point[4];
                points[0] = new Point(aX, aY);
                points[1] = new Point(bX, bY);
                points[2] = new Point(cX, cY);
                points[3] = new Point(dX, dY);

                Task4_ResultLabel.ForeColor = Color.Black;
                if (IsConvex(points))
                {
                    Task4_ResultLabel.Text = "Чотирикутник опуклий.";
                } else
                {
                    Task4_ResultLabel.Text = "Чотирикутник не опуклий.";
                }
            } 
            catch (Exception ex)
            {
                Task4_ResultLabel.ForeColor = Color.Red;
                Task4_ResultLabel.Text = $"Помилка: {ex.Message}";
            }
        }

        private void Task5_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(Task5_TextboxA.Text);
                double b = Convert.ToDouble(Task5_TextboxB.Text);
                double c = Convert.ToDouble(Task5_TextboxC.Text);
                double d = Convert.ToDouble(Task5_TextboxD.Text);

                if (a == 0)
                {
                    throw new Exception("BadArgumentA");
                } else if (d == 0)
                {
                    throw new Exception("BadArgumentD");
                }

                    string result = FindRoots(a, b, c, d);
                Task5_ResultLabel.ForeColor = Color.Black;
                Task5_ResultLabel.Text = result;
            }
            catch (Exception ex)
            {
                Task5_ResultLabel.ForeColor = Color.Red;
                if (ex.Message == "BadArgumentA")
                {
                    Task5_ResultLabel.Text = "Помилка: а не повинна дорівнювати 0.";
                }
                else if(ex.Message == "BadArgumentD")
                {
                    Task5_ResultLabel.Text = "Помилка: d не повинна дорівнювати 0.";
                } else
                {
                    Task5_ResultLabel.Text = $"Помилка: {ex.Message}";
                }
            }
        }

        private void Task6_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sequenceA = Task6_TextboxA.Text.ToLower().Replace(",", "").Replace(".", "").Split(' ');
                string[] sequenceB = Task6_TextboxB.Text.ToLower().Replace(",", "").Replace(".", "").Split(' ');

                bool result = true;

                foreach (string str in sequenceB)
                {
                    if (!sequenceA.Contains(str))
                    {
                        result = false; break;
                    }
                }

                Task6_ResultLabel.ForeColor = Color.Black;
                Task6_ResultLabel.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                Task6_ResultLabel.ForeColor = Color.Red;
                Task6_ResultLabel.Text = $"Результат: {ex.Message}";
            }
        }

        private void Task7_Button_Click(object sender, EventArgs e)
        {
            string[] sequence = Task7_Textbox.Text.ToLower().Split(' ');
            int count = 0;

            foreach (string str in sequence)
            {
                if (str.StartsWith("b"))
                {
                    count++;
                }
            }

            Task7_ResultLabel.Text = $"Результат: {count}";
        }
    }
}
