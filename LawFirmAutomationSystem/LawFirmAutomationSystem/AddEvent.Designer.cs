namespace LawFirmAutomationSystem
{
    partial class AddEvent
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
            this.description = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.levelOfImportant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addEventButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(364, 244);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(185, 96);
            this.description.TabIndex = 1;
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.White;
            this.author.Enabled = false;
            this.author.Location = new System.Drawing.Point(364, 456);
            this.author.Margin = new System.Windows.Forms.Padding(4);
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Size = new System.Drawing.Size(185, 26);
            this.author.TabIndex = 2;
            // 
            // levelOfImportant
            // 
            this.levelOfImportant.BackColor = System.Drawing.Color.White;
            this.levelOfImportant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelOfImportant.FormattingEnabled = true;
            this.levelOfImportant.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.levelOfImportant.Location = new System.Drawing.Point(364, 388);
            this.levelOfImportant.Margin = new System.Windows.Forms.Padding(4);
            this.levelOfImportant.Name = "levelOfImportant";
            this.levelOfImportant.Size = new System.Drawing.Size(185, 26);
            this.levelOfImportant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание задачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Уровень важности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Автор";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(364, 98);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(185, 26);
            this.dateTimeStart.TabIndex = 9;
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFinish.Location = new System.Drawing.Point(364, 167);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(185, 26);
            this.dateTimeFinish.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата и время начала события";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата и время окончания события";
            // 
            // addEventButton
            // 
            this.addEventButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEventButton.Depth = 0;
            this.addEventButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventButton.Location = new System.Drawing.Point(228, 520);
            this.addEventButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Primary = true;
            this.addEventButton.Size = new System.Drawing.Size(168, 38);
            this.addEventButton.TabIndex = 13;
            this.addEventButton.Text = "Добавить событие";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 597);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeFinish);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levelOfImportant);
            this.Controls.Add(this.author);
            this.Controls.Add(this.description);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEvent";
            this.Text = "Добавить событие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.ComboBox levelOfImportant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeFinish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton addEventButton;
    }
}