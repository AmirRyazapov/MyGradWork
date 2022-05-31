namespace LawFirmAutomationSystem
{
    partial class AddTask
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
            this.author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeAppoint = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subordinate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addTaskdButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.White;
            this.author.Enabled = false;
            this.author.Location = new System.Drawing.Point(302, 101);
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Size = new System.Drawing.Size(185, 26);
            this.author.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автор";
            // 
            // dateTimeAppoint
            // 
            this.dateTimeAppoint.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeAppoint.Enabled = false;
            this.dateTimeAppoint.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAppoint.Location = new System.Drawing.Point(302, 167);
            this.dateTimeAppoint.Name = "dateTimeAppoint";
            this.dateTimeAppoint.Size = new System.Drawing.Size(185, 26);
            this.dateTimeAppoint.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата и время назначения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата и время выполнения";
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFinish.Location = new System.Drawing.Point(302, 236);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(185, 26);
            this.dateTimeFinish.TabIndex = 5;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(302, 311);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(185, 96);
            this.description.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Описание задачи";
            // 
            // subordinate
            // 
            this.subordinate.BackColor = System.Drawing.Color.White;
            this.subordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subordinate.FormattingEnabled = true;
            this.subordinate.Location = new System.Drawing.Point(302, 465);
            this.subordinate.Name = "subordinate";
            this.subordinate.Size = new System.Drawing.Size(185, 26);
            this.subordinate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кому назначается";
            // 
            // addTaskdButton
            // 
            this.addTaskdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskdButton.Depth = 0;
            this.addTaskdButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskdButton.Location = new System.Drawing.Point(190, 544);
            this.addTaskdButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addTaskdButton.Name = "addTaskdButton";
            this.addTaskdButton.Primary = true;
            this.addTaskdButton.Size = new System.Drawing.Size(168, 38);
            this.addTaskdButton.TabIndex = 14;
            this.addTaskdButton.Text = "Назначить задачу";
            this.addTaskdButton.UseVisualStyleBackColor = true;
            this.addTaskdButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 604);
            this.Controls.Add(this.addTaskdButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subordinate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description);
            this.Controls.Add(this.dateTimeFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeAppoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.author);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTask";
            this.Text = "Назначить задачу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeAppoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFinish;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox subordinate;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRaisedButton addTaskdButton;
    }
}