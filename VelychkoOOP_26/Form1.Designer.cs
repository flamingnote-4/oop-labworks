namespace VelychkoOOP_26
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateDocument = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeDatePlaceLabel = new System.Windows.Forms.Label();
            this.friendLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedTemplateLabel = new System.Windows.Forms.Label();
            this.nextPicButton = new System.Windows.Forms.Button();
            this.prevPicButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.previewButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Місце";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // buttonCreateDocument
            // 
            this.buttonCreateDocument.Location = new System.Drawing.Point(12, 208);
            this.buttonCreateDocument.Name = "buttonCreateDocument";
            this.buttonCreateDocument.Size = new System.Drawing.Size(168, 27);
            this.buttonCreateDocument.TabIndex = 2;
            this.buttonCreateDocument.Text = "Створити";
            this.buttonCreateDocument.UseVisualStyleBackColor = true;
            this.buttonCreateDocument.Click += new System.EventHandler(this.buttonCreateDocument_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Імена друзів";
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(48, 62);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(132, 20);
            this.placeTextBox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(168, 101);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(48, 36);
            this.timeTextBox.MaxLength = 5;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(132, 20);
            this.timeTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Час";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Preview00.png");
            this.imageList1.Images.SetKeyName(1, "Preview01.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeDatePlaceLabel);
            this.panel1.Controls.Add(this.friendLabel);
            this.panel1.Location = new System.Drawing.Point(198, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 135);
            this.panel1.TabIndex = 9;
            // 
            // timeDatePlaceLabel
            // 
            this.timeDatePlaceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeDatePlaceLabel.AutoSize = true;
            this.timeDatePlaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeDatePlaceLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeDatePlaceLabel.Location = new System.Drawing.Point(15, 92);
            this.timeDatePlaceLabel.MaximumSize = new System.Drawing.Size(210, 0);
            this.timeDatePlaceLabel.MinimumSize = new System.Drawing.Size(210, 0);
            this.timeDatePlaceLabel.Name = "timeDatePlaceLabel";
            this.timeDatePlaceLabel.Size = new System.Drawing.Size(210, 16);
            this.timeDatePlaceLabel.TabIndex = 1;
            this.timeDatePlaceLabel.Text = "Тут буде дата, місце та час.";
            this.timeDatePlaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // friendLabel
            // 
            this.friendLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.friendLabel.AutoSize = true;
            this.friendLabel.BackColor = System.Drawing.Color.Transparent;
            this.friendLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendLabel.Location = new System.Drawing.Point(17, 16);
            this.friendLabel.MaximumSize = new System.Drawing.Size(120, 0);
            this.friendLabel.MinimumSize = new System.Drawing.Size(120, 0);
            this.friendLabel.Name = "friendLabel";
            this.friendLabel.Size = new System.Drawing.Size(120, 18);
            this.friendLabel.TabIndex = 0;
            this.friendLabel.Text = "Друже";
            this.friendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Обраний шаблон\r\n";
            // 
            // selectedTemplateLabel
            // 
            this.selectedTemplateLabel.AutoSize = true;
            this.selectedTemplateLabel.Location = new System.Drawing.Point(195, 183);
            this.selectedTemplateLabel.Name = "selectedTemplateLabel";
            this.selectedTemplateLabel.Size = new System.Drawing.Size(55, 13);
            this.selectedTemplateLabel.TabIndex = 11;
            this.selectedTemplateLabel.Text = "Шаблон 1";
            // 
            // nextPicButton
            // 
            this.nextPicButton.Location = new System.Drawing.Point(393, 177);
            this.nextPicButton.Name = "nextPicButton";
            this.nextPicButton.Size = new System.Drawing.Size(48, 25);
            this.nextPicButton.TabIndex = 12;
            this.nextPicButton.Text = "Далі";
            this.nextPicButton.UseVisualStyleBackColor = true;
            this.nextPicButton.Click += new System.EventHandler(this.nextPicButton_Click);
            // 
            // prevPicButton
            // 
            this.prevPicButton.Location = new System.Drawing.Point(339, 177);
            this.prevPicButton.Name = "prevPicButton";
            this.prevPicButton.Size = new System.Drawing.Size(48, 25);
            this.prevPicButton.TabIndex = 13;
            this.prevPicButton.Text = "Назад";
            this.prevPicButton.UseVisualStyleBackColor = true;
            this.prevPicButton.Click += new System.EventHandler(this.prevPicButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(267, 215);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(172, 20);
            this.pathTextBox.TabIndex = 14;
            this.pathTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Зберегти в:";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(285, 177);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(48, 25);
            this.previewButton.TabIndex = 16;
            this.previewButton.Text = "Огляд";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 247);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.prevPicButton);
            this.Controls.Add(this.nextPicButton);
            this.Controls.Add(this.selectedTemplateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateDocument);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Створювач запрошень - л.р. №26";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label selectedTemplateLabel;
        private System.Windows.Forms.Button nextPicButton;
        private System.Windows.Forms.Button prevPicButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label friendLabel;
        private System.Windows.Forms.Label timeDatePlaceLabel;
        private System.Windows.Forms.Button previewButton;
    }
}

