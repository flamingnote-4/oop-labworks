namespace VelychkoOOP_20
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxA = new System.Windows.Forms.TextBox();
            this.TextboxB = new System.Windows.Forms.TextBox();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Task_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x + ";
            // 
            // TextboxA
            // 
            this.TextboxA.Location = new System.Drawing.Point(12, 29);
            this.TextboxA.Name = "TextboxA";
            this.TextboxA.Size = new System.Drawing.Size(30, 20);
            this.TextboxA.TabIndex = 1;
            // 
            // TextboxB
            // 
            this.TextboxB.Location = new System.Drawing.Point(69, 30);
            this.TextboxB.Name = "TextboxB";
            this.TextboxB.Size = new System.Drawing.Size(30, 20);
            this.TextboxB.TabIndex = 2;
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Location = new System.Drawing.Point(9, 52);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(43, 13);
            this.Result_Label.TabIndex = 3;
            this.Result_Label.Text = "Корінь:";
            // 
            // Task_Button
            // 
            this.Task_Button.Location = new System.Drawing.Point(146, 29);
            this.Task_Button.Name = "Task_Button";
            this.Task_Button.Size = new System.Drawing.Size(87, 20);
            this.Task_Button.TabIndex = 4;
            this.Task_Button.Text = "Знайти корені";
            this.Task_Button.UseVisualStyleBackColor = true;
            this.Task_Button.Click += new System.EventHandler(this.Task_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "= 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Величко О. Варіант 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 77);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Task_Button);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.TextboxB);
            this.Controls.Add(this.TextboxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxA;
        private System.Windows.Forms.TextBox TextboxB;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button Task_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

