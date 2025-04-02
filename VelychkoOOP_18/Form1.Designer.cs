namespace VelychkoOOP_18
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
            this.Task1_Textbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Task1_Sorted = new System.Windows.Forms.TextBox();
            this.Sum_Label = new System.Windows.Forms.Label();
            this.Task1_Button = new System.Windows.Forms.Button();
            this.Product_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Task2_Textbox = new System.Windows.Forms.RichTextBox();
            this.Task2_HeightTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Task2_WidthTextbox = new System.Windows.Forms.TextBox();
            this.Task2_Button = new System.Windows.Forms.Button();
            this.Task2_TopLabel = new System.Windows.Forms.Label();
            this.Task2_BotLabel = new System.Windows.Forms.Label();
            this.Task2_ArrayLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Величко О. Варіант 2";
            // 
            // Task1_Textbox
            // 
            this.Task1_Textbox.Location = new System.Drawing.Point(6, 6);
            this.Task1_Textbox.Name = "Task1_Textbox";
            this.Task1_Textbox.Size = new System.Drawing.Size(370, 20);
            this.Task1_Textbox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 167);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Task1_Sorted);
            this.tabPage1.Controls.Add(this.Sum_Label);
            this.tabPage1.Controls.Add(this.Task1_Button);
            this.tabPage1.Controls.Add(this.Product_Label);
            this.tabPage1.Controls.Add(this.Task1_Textbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Одновимірний масив";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Відсортований масив:";
            // 
            // Task1_Sorted
            // 
            this.Task1_Sorted.Location = new System.Drawing.Point(6, 115);
            this.Task1_Sorted.Name = "Task1_Sorted";
            this.Task1_Sorted.ReadOnly = true;
            this.Task1_Sorted.Size = new System.Drawing.Size(370, 20);
            this.Task1_Sorted.TabIndex = 5;
            // 
            // Sum_Label
            // 
            this.Sum_Label.AutoSize = true;
            this.Sum_Label.Location = new System.Drawing.Point(6, 79);
            this.Sum_Label.Name = "Sum_Label";
            this.Sum_Label.Size = new System.Drawing.Size(178, 13);
            this.Sum_Label.TabIndex = 4;
            this.Sum_Label.Text = "Сума елементів до мінімального: ";
            // 
            // Task1_Button
            // 
            this.Task1_Button.Location = new System.Drawing.Point(6, 32);
            this.Task1_Button.Name = "Task1_Button";
            this.Task1_Button.Size = new System.Drawing.Size(85, 22);
            this.Task1_Button.TabIndex = 3;
            this.Task1_Button.Text = "Розрахувати";
            this.Task1_Button.UseVisualStyleBackColor = true;
            this.Task1_Button.Click += new System.EventHandler(this.Task1_Button_Click);
            // 
            // Product_Label
            // 
            this.Product_Label.AutoSize = true;
            this.Product_Label.Location = new System.Drawing.Point(6, 66);
            this.Product_Label.Name = "Product_Label";
            this.Product_Label.Size = new System.Drawing.Size(155, 13);
            this.Product_Label.TabIndex = 2;
            this.Product_Label.Text = "Добуток додатніх елементів: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Task2_Textbox);
            this.tabPage2.Controls.Add(this.Task2_HeightTextbox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Task2_WidthTextbox);
            this.tabPage2.Controls.Add(this.Task2_Button);
            this.tabPage2.Controls.Add(this.Task2_TopLabel);
            this.tabPage2.Controls.Add(this.Task2_BotLabel);
            this.tabPage2.Controls.Add(this.Task2_ArrayLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Двовимірний масив";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Task2_Textbox
            // 
            this.Task2_Textbox.Location = new System.Drawing.Point(9, 3);
            this.Task2_Textbox.Name = "Task2_Textbox";
            this.Task2_Textbox.Size = new System.Drawing.Size(169, 83);
            this.Task2_Textbox.TabIndex = 8;
            this.Task2_Textbox.Text = "";
            // 
            // Task2_HeightTextbox
            // 
            this.Task2_HeightTextbox.Location = new System.Drawing.Point(63, 118);
            this.Task2_HeightTextbox.Name = "Task2_HeightTextbox";
            this.Task2_HeightTextbox.Size = new System.Drawing.Size(43, 20);
            this.Task2_HeightTextbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Довжина\r\n\r\nВисота";
            // 
            // Task2_WidthTextbox
            // 
            this.Task2_WidthTextbox.Location = new System.Drawing.Point(63, 92);
            this.Task2_WidthTextbox.Name = "Task2_WidthTextbox";
            this.Task2_WidthTextbox.Size = new System.Drawing.Size(43, 20);
            this.Task2_WidthTextbox.TabIndex = 5;
            // 
            // Task2_Button
            // 
            this.Task2_Button.Location = new System.Drawing.Point(113, 92);
            this.Task2_Button.Name = "Task2_Button";
            this.Task2_Button.Size = new System.Drawing.Size(65, 47);
            this.Task2_Button.TabIndex = 4;
            this.Task2_Button.Text = "Показати";
            this.Task2_Button.UseVisualStyleBackColor = true;
            this.Task2_Button.Click += new System.EventHandler(this.Task2_Button_Click);
            // 
            // Task2_TopLabel
            // 
            this.Task2_TopLabel.AutoSize = true;
            this.Task2_TopLabel.Location = new System.Drawing.Point(184, 124);
            this.Task2_TopLabel.Name = "Task2_TopLabel";
            this.Task2_TopLabel.Size = new System.Drawing.Size(181, 13);
            this.Task2_TopLabel.TabIndex = 3;
            this.Task2_TopLabel.Text = "Елемент правого верхнього кута: ";
            // 
            // Task2_BotLabel
            // 
            this.Task2_BotLabel.AutoSize = true;
            this.Task2_BotLabel.Location = new System.Drawing.Point(184, 111);
            this.Task2_BotLabel.Name = "Task2_BotLabel";
            this.Task2_BotLabel.Size = new System.Drawing.Size(168, 13);
            this.Task2_BotLabel.TabIndex = 2;
            this.Task2_BotLabel.Text = "Елемент лівого нижнього кута: ";
            // 
            // Task2_ArrayLabel
            // 
            this.Task2_ArrayLabel.AutoSize = true;
            this.Task2_ArrayLabel.Location = new System.Drawing.Point(184, 6);
            this.Task2_ArrayLabel.Name = "Task2_ArrayLabel";
            this.Task2_ArrayLabel.Size = new System.Drawing.Size(0, 13);
            this.Task2_ArrayLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 216);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №18";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Task1_Textbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Task1_Sorted;
        private System.Windows.Forms.Label Sum_Label;
        private System.Windows.Forms.Button Task1_Button;
        private System.Windows.Forms.Label Product_Label;
        private System.Windows.Forms.Label Task2_TopLabel;
        private System.Windows.Forms.Label Task2_BotLabel;
        private System.Windows.Forms.Label Task2_ArrayLabel;
        private System.Windows.Forms.Button Task2_Button;
        private System.Windows.Forms.TextBox Task2_HeightTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Task2_WidthTextbox;
        private System.Windows.Forms.RichTextBox Task2_Textbox;
    }
}

