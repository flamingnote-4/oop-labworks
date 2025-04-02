using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelychkoOOP_23
{
    public partial class Form1 : Form
    {
        public double x = 1, y = 1, a = 1, b = 1, t = 0;
        public float posx = 440, posy = 130, scale = 20;

        public Form1()
        {
            InitializeComponent();
        }
        private void Task_Button_Click(object sender, EventArgs e)
        {
            double xValue, yValue;
            try
            {
                x = Convert.ToDouble(TextboxX.Text);
                y = Convert.ToDouble(TextboxY.Text);
                a = Convert.ToDouble(TextboxA.Text);
                b = Convert.ToDouble(TextboxB.Text);
                t = Convert.ToDouble(TextboxT.Text);
            }
            catch { }
            xValue = x + a * Math.Cos(t);
            yValue = y + b * Math.Sin(t);
            posx = (float)(400 + xValue * scale);
            posy = (float)(150 - yValue * scale);

            EquationX_Label.Location = new Point((int)posx, 10);
            EquationY_Label.Location = new Point(210, (int)posy);

            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            e.Graphics.DrawRectangle(pen, new Rectangle(200, 0, 400, 300));
            e.Graphics.DrawLine(pen, new Point(200, 150), new Point(600, 150));
            e.Graphics.DrawLine(pen, new Point(400, 0), new Point(400, 300));

            for (int i = 220; i < 600; i+=20)
            {
                e.Graphics.DrawLine(pen, new Point(i, 146), new Point(i, 154));
            }
            for (int i = 10; i < 300; i += 20)
            {
                e.Graphics.DrawLine(pen, new Point(396, i), new Point(404, i));
            }

            pen.Color = Color.Blue;
            e.Graphics.DrawLine(pen, new PointF(posx, 0), new PointF(posx, 300));

            pen.Color = Color.Red;
            e.Graphics.DrawLine(pen, new PointF(200, posy), new PointF(600, posy));
        }
    }
}
