namespace VelychkoOOP_19
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
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Result_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Величко О. Варіант 2\r\n\r\nВведіть три символа. Програма спробує перетворити їх на ч" +
    "исло.";
            // 
            // Textbox1
            // 
            this.Textbox1.Location = new System.Drawing.Point(15, 62);
            this.Textbox1.MaxLength = 3;
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(39, 20);
            this.Textbox1.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(60, 62);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(84, 20);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Перетворити";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Location = new System.Drawing.Point(150, 66);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(68, 13);
            this.Result_Label.TabIndex = 3;
            this.Result_Label.Text = "Результат - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 94);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Textbox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label Result_Label;
    }
}

