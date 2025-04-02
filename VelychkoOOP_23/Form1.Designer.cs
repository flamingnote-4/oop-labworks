namespace VelychkoOOP_23
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Task_Button = new System.Windows.Forms.Button();
            this.TextboxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxY = new System.Windows.Forms.TextBox();
            this.TextboxA = new System.Windows.Forms.TextBox();
            this.TextboxB = new System.Windows.Forms.TextBox();
            this.TextboxT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EquationY_Label = new System.Windows.Forms.Label();
            this.EquationX_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Task_Button
            // 
            this.Task_Button.Location = new System.Drawing.Point(100, 101);
            this.Task_Button.Name = "Task_Button";
            this.Task_Button.Size = new System.Drawing.Size(70, 24);
            this.Task_Button.TabIndex = 0;
            this.Task_Button.Text = "Обчислити";
            this.Task_Button.UseVisualStyleBackColor = true;
            this.Task_Button.Click += new System.EventHandler(this.Task_Button_Click);
            // 
            // TextboxX
            // 
            this.TextboxX.Location = new System.Drawing.Point(31, 25);
            this.TextboxX.Name = "TextboxX";
            this.TextboxX.Size = new System.Drawing.Size(51, 20);
            this.TextboxX.TabIndex = 1;
            this.TextboxX.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Початкова точка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 91);
            this.label2.TabIndex = 3;
            this.label2.Text = "x\r\n\r\n\r\na\r\n\r\n\r\nt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "y\r\n\r\n\r\nb";
            // 
            // TextboxY
            // 
            this.TextboxY.Location = new System.Drawing.Point(119, 25);
            this.TextboxY.Name = "TextboxY";
            this.TextboxY.Size = new System.Drawing.Size(51, 20);
            this.TextboxY.TabIndex = 5;
            this.TextboxY.Text = "1";
            // 
            // TextboxA
            // 
            this.TextboxA.Location = new System.Drawing.Point(31, 65);
            this.TextboxA.Name = "TextboxA";
            this.TextboxA.Size = new System.Drawing.Size(51, 20);
            this.TextboxA.TabIndex = 6;
            this.TextboxA.Text = "1";
            // 
            // TextboxB
            // 
            this.TextboxB.Location = new System.Drawing.Point(119, 65);
            this.TextboxB.Name = "TextboxB";
            this.TextboxB.Size = new System.Drawing.Size(51, 20);
            this.TextboxB.TabIndex = 8;
            this.TextboxB.Text = "1";
            // 
            // TextboxT
            // 
            this.TextboxT.Location = new System.Drawing.Point(31, 104);
            this.TextboxT.Name = "TextboxT";
            this.TextboxT.Size = new System.Drawing.Size(51, 20);
            this.TextboxT.TabIndex = 10;
            this.TextboxT.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Величко О. Варіант 2";
            // 
            // EquationY_Label
            // 
            this.EquationY_Label.AutoSize = true;
            this.EquationY_Label.ForeColor = System.Drawing.Color.Red;
            this.EquationY_Label.Location = new System.Drawing.Point(244, 138);
            this.EquationY_Label.Name = "EquationY_Label";
            this.EquationY_Label.Size = new System.Drawing.Size(79, 13);
            this.EquationY_Label.TabIndex = 15;
            this.EquationY_Label.Text = "y = y0 + b*sin(t)";
            // 
            // EquationX_Label
            // 
            this.EquationX_Label.AutoSize = true;
            this.EquationX_Label.ForeColor = System.Drawing.Color.Blue;
            this.EquationX_Label.Location = new System.Drawing.Point(494, 25);
            this.EquationX_Label.Name = "EquationX_Label";
            this.EquationX_Label.Size = new System.Drawing.Size(79, 13);
            this.EquationX_Label.TabIndex = 16;
            this.EquationX_Label.Text = "x = x0 + a*sin(t)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 325);
            this.Controls.Add(this.EquationX_Label);
            this.Controls.Add(this.EquationY_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextboxT);
            this.Controls.Add(this.TextboxB);
            this.Controls.Add(this.TextboxA);
            this.Controls.Add(this.TextboxY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxX);
            this.Controls.Add(this.Task_Button);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №23";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Task_Button;
        private System.Windows.Forms.TextBox TextboxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxY;
        private System.Windows.Forms.TextBox TextboxA;
        private System.Windows.Forms.TextBox TextboxB;
        private System.Windows.Forms.TextBox TextboxT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label EquationY_Label;
        private System.Windows.Forms.Label EquationX_Label;
    }
}

