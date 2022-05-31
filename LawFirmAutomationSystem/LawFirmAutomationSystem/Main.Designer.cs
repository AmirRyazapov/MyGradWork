namespace LawFirmAutomationSystem
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.workingWithFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportOfThisTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knowledgeBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalendarOfEventsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFromAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.previousMonth = new System.Windows.Forms.Button();
            this.nextMonth = new System.Windows.Forms.Button();
            this.monthAndYear = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingWithFilesToolStripMenuItem,
            this.makeAReportToolStripMenuItem,
            this.additionalInformationToolStripMenuItem,
            this.kalendarOfEventsStripMenuItem,
            this.tasksToolStripMenuItem,
            this.exitFromAccountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 64);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // workingWithFilesToolStripMenuItem
            // 
            this.workingWithFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem,
            this.exportOfThisTableToolStripMenuItem});
            this.workingWithFilesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workingWithFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.workingWithFilesToolStripMenuItem.Name = "workingWithFilesToolStripMenuItem";
            this.workingWithFilesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.workingWithFilesToolStripMenuItem.Text = "Работа с файлами";
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.selectFileToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.selectFileToolStripMenuItem.Text = "Выбрать файл";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // exportOfThisTableToolStripMenuItem
            // 
            this.exportOfThisTableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.exportOfThisTableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exportOfThisTableToolStripMenuItem.Name = "exportOfThisTableToolStripMenuItem";
            this.exportOfThisTableToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.exportOfThisTableToolStripMenuItem.Text = "Экспорт текущей таблицы";
            this.exportOfThisTableToolStripMenuItem.Visible = false;
            this.exportOfThisTableToolStripMenuItem.Click += new System.EventHandler(this.exportOfThisTableToolStripMenuItem_Click);
            // 
            // makeAReportToolStripMenuItem
            // 
            this.makeAReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.makeAReportToolStripMenuItem.Name = "makeAReportToolStripMenuItem";
            this.makeAReportToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.makeAReportToolStripMenuItem.Text = "Составить отчет";
            // 
            // additionalInformationToolStripMenuItem
            // 
            this.additionalInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coaoToolStripMenuItem,
            this.knowledgeBaseToolStripMenuItem});
            this.additionalInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.additionalInformationToolStripMenuItem.Name = "additionalInformationToolStripMenuItem";
            this.additionalInformationToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.additionalInformationToolStripMenuItem.Text = "Дополнительная информация";
            // 
            // coaoToolStripMenuItem
            // 
            this.coaoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.coaoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.coaoToolStripMenuItem.Name = "coaoToolStripMenuItem";
            this.coaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coaoToolStripMenuItem.Text = "КОАП";
            this.coaoToolStripMenuItem.Click += new System.EventHandler(this.coaoToolStripMenuItem_Click);
            // 
            // knowledgeBaseToolStripMenuItem
            // 
            this.knowledgeBaseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.knowledgeBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem});
            this.knowledgeBaseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.knowledgeBaseToolStripMenuItem.Name = "knowledgeBaseToolStripMenuItem";
            this.knowledgeBaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.knowledgeBaseToolStripMenuItem.Text = "База знаний";
            this.knowledgeBaseToolStripMenuItem.Click += new System.EventHandler(this.knowledgeBaseToolStripMenuItem_Click);
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.addRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addRecordToolStripMenuItem.Text = "Добавить запись";
            this.addRecordToolStripMenuItem.Visible = false;
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // kalendarOfEventsStripMenuItem
            // 
            this.kalendarOfEventsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem});
            this.kalendarOfEventsStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kalendarOfEventsStripMenuItem.Name = "kalendarOfEventsStripMenuItem";
            this.kalendarOfEventsStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.kalendarOfEventsStripMenuItem.Text = "Календарь событий";
            this.kalendarOfEventsStripMenuItem.Click += new System.EventHandler(this.kalendarOfEventsStripMenuItem_Click);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.addEventToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addEventToolStripMenuItem.Text = "Добавить событие";
            this.addEventToolStripMenuItem.Visible = false;
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myTasksToolStripMenuItem,
            this.assignTaskToolStripMenuItem,
            this.tasksWorkersToolStripMenuItem});
            this.tasksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.tasksToolStripMenuItem.Text = "Задачи";
            // 
            // myTasksToolStripMenuItem
            // 
            this.myTasksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.myTasksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.myTasksToolStripMenuItem.Name = "myTasksToolStripMenuItem";
            this.myTasksToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.myTasksToolStripMenuItem.Text = "Мои задачи";
            this.myTasksToolStripMenuItem.Click += new System.EventHandler(this.myTasksToolStripMenuItem_Click);
            // 
            // assignTaskToolStripMenuItem
            // 
            this.assignTaskToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.assignTaskToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.assignTaskToolStripMenuItem.Name = "assignTaskToolStripMenuItem";
            this.assignTaskToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.assignTaskToolStripMenuItem.Text = "Назначить задачу";
            this.assignTaskToolStripMenuItem.Visible = false;
            this.assignTaskToolStripMenuItem.Click += new System.EventHandler(this.assignTaskToolStripMenuItem_Click);
            // 
            // tasksWorkersToolStripMenuItem
            // 
            this.tasksWorkersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tasksWorkersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tasksWorkersToolStripMenuItem.Name = "tasksWorkersToolStripMenuItem";
            this.tasksWorkersToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.tasksWorkersToolStripMenuItem.Text = "Задачи сотрудников";
            this.tasksWorkersToolStripMenuItem.Visible = false;
            this.tasksWorkersToolStripMenuItem.Click += new System.EventHandler(this.tasksWorkersToolStripMenuItem_Click);
            // 
            // exitFromAccountToolStripMenuItem
            // 
            this.exitFromAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitFromAccountToolStripMenuItem.Name = "exitFromAccountToolStripMenuItem";
            this.exitFromAccountToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitFromAccountToolStripMenuItem.Text = "Выйти из учетной записи";
            this.exitFromAccountToolStripMenuItem.Click += new System.EventHandler(this.exitFromAccountToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Выйти из приложения";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AllowUserToResizeColumns = false;
            this.mainDataGridView.AllowUserToResizeRows = false;
            this.mainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.mainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.mainDataGridView.GridColor = System.Drawing.Color.Black;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 103);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.mainDataGridView.Size = new System.Drawing.Size(1200, 521);
            this.mainDataGridView.TabIndex = 4;
            this.mainDataGridView.Visible = false;
            this.mainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentClick);
            this.mainDataGridView.VisibleChanged += new System.EventHandler(this.mainDataGridView_VisibleChanged);
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Location = new System.Drawing.Point(145, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(327, 19);
            this.search.TabIndex = 5;
            this.search.Visible = false;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(0, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(139, 19);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "Поиск по таблице";
            this.labelSearch.Visible = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 95);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.previousMonth);
            this.splitContainer.Panel1.Controls.Add(this.nextMonth);
            this.splitContainer.Panel1.Controls.Add(this.monthAndYear);
            this.splitContainer.Panel1.Controls.Add(this.calendar);
            this.splitContainer.Panel1MinSize = 600;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2MinSize = 400;
            this.splitContainer.Size = new System.Drawing.Size(1200, 529);
            this.splitContainer.SplitterDistance = 600;
            this.splitContainer.TabIndex = 7;
            this.splitContainer.Visible = false;
            // 
            // previousMonth
            // 
            this.previousMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.previousMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousMonth.ForeColor = System.Drawing.Color.White;
            this.previousMonth.Location = new System.Drawing.Point(0, 0);
            this.previousMonth.Margin = new System.Windows.Forms.Padding(0);
            this.previousMonth.Name = "previousMonth";
            this.previousMonth.Size = new System.Drawing.Size(135, 46);
            this.previousMonth.TabIndex = 5;
            this.previousMonth.Text = "Предыдущий месяц";
            this.previousMonth.UseVisualStyleBackColor = false;
            this.previousMonth.Click += new System.EventHandler(this.previousMonth_Click);
            // 
            // nextMonth
            // 
            this.nextMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.nextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextMonth.ForeColor = System.Drawing.Color.White;
            this.nextMonth.Location = new System.Drawing.Point(463, -1);
            this.nextMonth.Margin = new System.Windows.Forms.Padding(0);
            this.nextMonth.Name = "nextMonth";
            this.nextMonth.Size = new System.Drawing.Size(135, 46);
            this.nextMonth.TabIndex = 4;
            this.nextMonth.Text = "Следующий месяц";
            this.nextMonth.UseVisualStyleBackColor = false;
            this.nextMonth.Click += new System.EventHandler(this.nextMonth_Click);
            // 
            // monthAndYear
            // 
            this.monthAndYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthAndYear.AutoSize = true;
            this.monthAndYear.Location = new System.Drawing.Point(368, 13);
            this.monthAndYear.Name = "monthAndYear";
            this.monthAndYear.Size = new System.Drawing.Size(50, 18);
            this.monthAndYear.TabIndex = 3;
            this.monthAndYear.Text = "label2";
            // 
            // calendar
            // 
            this.calendar.AllowUserToAddRows = false;
            this.calendar.AllowUserToDeleteRows = false;
            this.calendar.AllowUserToResizeColumns = false;
            this.calendar.AllowUserToResizeRows = false;
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calendar.BackgroundColor = System.Drawing.Color.White;
            this.calendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendar.ColumnHeadersHeight = 36;
            this.calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.calendar.GridColor = System.Drawing.Color.Black;
            this.calendar.Location = new System.Drawing.Point(0, 50);
            this.calendar.Name = "calendar";
            this.calendar.ReadOnly = true;
            this.calendar.RowHeadersVisible = false;
            this.calendar.Size = new System.Drawing.Size(598, 478);
            this.calendar.TabIndex = 0;
            this.calendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendar_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ПН";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ВТ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "СР";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ЧТ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ПТ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "СБ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ВС";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 624);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem workingWithFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFromAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coaoToolStripMenuItem;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ToolStripMenuItem knowledgeBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalendarOfEventsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label monthAndYear;
        private System.Windows.Forms.ToolStripMenuItem exportOfThisTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button previousMonth;
        private System.Windows.Forms.Button nextMonth;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksWorkersToolStripMenuItem;
    }
}