namespace LawFirmAutomationSystem
{
    partial class AddRecord
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
            this.question = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.author = new System.Windows.Forms.TextBox();
            this.addRecordButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.White;
            this.question.Font = new System.Drawing.Font("Arial", 12F);
            this.question.Location = new System.Drawing.Point(167, 100);
            this.question.Margin = new System.Windows.Forms.Padding(4);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.question.Size = new System.Drawing.Size(535, 89);
            this.question.TabIndex = 0;
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.White;
            this.answer.Font = new System.Drawing.Font("Arial", 12F);
            this.answer.Location = new System.Drawing.Point(167, 220);
            this.answer.Margin = new System.Windows.Forms.Padding(4);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer.Size = new System.Drawing.Size(535, 104);
            this.answer.TabIndex = 1;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy.MM.dd";
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Arial", 12F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(167, 355);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(138, 26);
            this.date.TabIndex = 2;
            this.date.Value = new System.DateTime(2022, 4, 25, 16, 38, 10, 0);
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.White;
            this.author.Enabled = false;
            this.author.Font = new System.Drawing.Font("Arial", 12F);
            this.author.Location = new System.Drawing.Point(167, 417);
            this.author.Margin = new System.Windows.Forms.Padding(4);
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Size = new System.Drawing.Size(395, 26);
            this.author.TabIndex = 3;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRecordButton.Depth = 0;
            this.addRecordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecordButton.Location = new System.Drawing.Point(308, 496);
            this.addRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.addRecordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Primary = true;
            this.addRecordButton.Size = new System.Drawing.Size(210, 54);
            this.addRecordButton.TabIndex = 4;
            this.addRecordButton.Text = "Добавить запись";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вопрос:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ответ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(86, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Автор:";
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.author);
            this.Controls.Add(this.date);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.question);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddRecord";
            this.Text = "Добавление записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox author;
        private MaterialSkin.Controls.MaterialRaisedButton addRecordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}