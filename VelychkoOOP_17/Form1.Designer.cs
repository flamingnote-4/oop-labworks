namespace VelychkoOOP_17
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
            this.Operations_Combobox = new System.Windows.Forms.ComboBox();
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.Textbox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Operations_Combobox
            // 
            this.Operations_Combobox.FormattingEnabled = true;
            this.Operations_Combobox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operations_Combobox.Location = new System.Drawing.Point(97, 35);
            this.Operations_Combobox.Name = "Operations_Combobox";
            this.Operations_Combobox.Size = new System.Drawing.Size(32, 21);
            this.Operations_Combobox.TabIndex = 0;
            // 
            // Textbox1
            // 
            this.Textbox1.Location = new System.Drawing.Point(11, 35);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(80, 20);
            this.Textbox1.TabIndex = 1;
            // 
            // Textbox2
            // 
            this.Textbox2.Location = new System.Drawing.Point(135, 35);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(80, 20);
            this.Textbox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Величко О.. Варіант 2";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(221, 38);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(16, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "= ";
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(12, 61);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(79, 22);
            this.Calculate_Button.TabIndex = 5;
            this.Calculate_Button.Text = "Обчислити";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 95);
            this.Controls.Add(this.Calculate_Button);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbox2);
            this.Controls.Add(this.Textbox1);
            this.Controls.Add(this.Operations_Combobox);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Operations_Combobox;
        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.TextBox Textbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button Calculate_Button;
    }
}

