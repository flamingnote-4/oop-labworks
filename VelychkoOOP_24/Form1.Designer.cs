namespace VelychkoOOP_24
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 136);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Запустити потік 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startThreadLucifer);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Запустити потік 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.startThreadNHash);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "Запустити потік 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.startThreadRSA);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 25);
            this.button4.TabIndex = 6;
            this.button4.Text = "Пауза";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.haltThread1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(165, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 25);
            this.button7.TabIndex = 9;
            this.button7.Text = "Запустити усі потоки";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.startThreads);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(307, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 25);
            this.button8.TabIndex = 10;
            this.button8.Text = "Пауза";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.haltAllThreads);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(161, 66);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(140, 136);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(307, 66);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(140, 136);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(67, 239);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 25);
            this.button9.TabIndex = 13;
            this.button9.Text = "Продовжити";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.resumeThread1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(362, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 25);
            this.button10.TabIndex = 14;
            this.button10.Text = "Продовжити";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.resumeAllThreads);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Керування всіма потоками:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(216, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 25);
            this.button5.TabIndex = 17;
            this.button5.Text = "Продовжити";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.resumeThread2);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(161, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 25);
            this.button6.TabIndex = 16;
            this.button6.Text = "Пауза";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.haltThread2);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(362, 239);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 25);
            this.button11.TabIndex = 19;
            this.button11.Text = "Продовжити";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.resumeThread3);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(307, 239);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 25);
            this.button12.TabIndex = 18;
            this.button12.Text = "Пауза";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.haltThread3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lucifer (1971)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "N-Hash (1990)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "RSA (1977)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

