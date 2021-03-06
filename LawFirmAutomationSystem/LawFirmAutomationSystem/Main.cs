using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using HtmlAgilityPack;
using MaterialSkin.Controls;
using Excel = Microsoft.Office.Interop.Excel;

namespace LawFirmAutomationSystem
{
    public partial class Main : MaterialForm
    {
        private CheckedListBox checkedListBox;
        private int level;
        private string name;
        private static DateTime firstDayOfMounth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        private int daysInMounth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        private int dayOfWeek = Convert.ToInt32(firstDayOfMounth.DayOfWeek);
        public Main(int lvl, string nm)
        {
            InitializeComponent();
            calendar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 71, 79);
            if (lvl == 1)
            {
                addRecordToolStripMenuItem.Visible = true;
                addEventToolStripMenuItem.Visible = true;
                myTasksToolStripMenuItem.Visible = false;
                tasksWorkersToolStripMenuItem.Visible = true;
            }
            if (lvl <= 2)
            {
                assignTaskToolStripMenuItem.Visible = true;
            }
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new ColorTable());
            this.level = lvl;
            this.Text = nm;
            name = nm;
            openFileDialog.Filter = "Excel files(*.xls;*.xlsx)|*.xls;*.xlsx";
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //нажатия на кнопки, пункты меню, ячейки таблиц и т.д.
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e) //не доделано
        {
            string[,] list;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog.FileName;
            Excel.Application ObjWorkExcel = new Excel.Application();
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(openFileDialog.FileName);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            int lastColumn = (int)lastCell.Column;
            int lastRow = (int)lastCell.Row;
            
            int columns = 0, rows = 0;
            for (int i = 0; i < lastColumn; i++)
            {
                if (ObjWorkSheet.Cells[1, i + 1].Text.ToString() == "")
                {
                    columns = i;
                    break;
                }
            }
            for (int i = 0; i < lastColumn; i++)
            {
                if (ObjWorkSheet.Cells[i + 1, 1].Text.ToString() == "")
                {
                    rows = i;
                    break;
                }
            }
            list = new string[rows, columns];
            List<Case> Cases = new List<Case>(); 
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    list[i, j] = ObjWorkSheet.Cells[i + 1, j + 1].Text.ToString();
                }
                Case courtCase = new Case(list[j, 0], list[j, 1], long.Parse(list[j, 2]), list[j, 3], long.Parse(list[j, 4]), list[j, 5], list[j, 6], list[j, 7], list[j, 8], list[j, 9]);
                Cases.Add(courtCase);
            }
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjWorkExcel.Quit();
            GC.Collect();
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Case>));
        }

        private void coaoToolStripMenuItem_Click(object sender, EventArgs e) //парсинг КоАП с сайта consultant.ru
        {
            hiddenControls();
            mainDataGridView.Columns.Clear();
            mainDataGridView.DataSource = null;
            PleaseWait pleaseWait = new PleaseWait();
            pleaseWait.Show();
            Application.DoEvents();
            string urlDoc = "http://www.consultant.ru/document/cons_doc_law_34661/";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            try
            {
                doc = web.Load(urlDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//body/div[@class='content document-page']/section[@class='document-page__main width-container page-fields']/div[@class='document-page__toc']/ul");
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Раздел";
            column1.Name = "Раздел";
            column1.CellTemplate = new DataGridViewTextBoxCell();
            column1.SortMode = DataGridViewColumnSortMode.NotSortable;

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Глава";
            column2.Name = "Глава";
            column2.CellTemplate = new DataGridViewTextBoxCell();
            column2.SortMode = DataGridViewColumnSortMode.NotSortable;

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Статья";
            column3.Name = "Статья";
            column3.CellTemplate = new DataGridViewTextBoxCell();
            column3.SortMode = DataGridViewColumnSortMode.NotSortable;

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Содержание";
            column4.Name = "Содержание";
            column4.CellTemplate = new DataGridViewLinkCell();
            column4.SortMode = DataGridViewColumnSortMode.NotSortable;

            mainDataGridView.Columns.Add(column1);
            mainDataGridView.Columns.Add(column2);
            mainDataGridView.Columns.Add(column3);
            mainDataGridView.Columns.Add(column4);
            string section = "", chapter = "", article = "", url = "";
            foreach (HtmlNode n in node.ChildNodes)
            {
                if (n.ChildNodes.Count > 1)
                {
                    foreach (HtmlNode hn in n.ChildNodes)
                    {
                        if (hn.ChildNodes.Count > 1)
                        {
                            foreach (HtmlNode hnode in hn.ChildNodes)
                            {
                                article = hnode.InnerText.Replace("&nbsp;", "");
                                url = "http://www.consultant.ru" + hnode.ChildNodes[0].Attributes["href"].Value;
                                try
                                {
                                    mainDataGridView.Rows.Add(section, chapter, article, url);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            chapter = hn.InnerText.Replace("&nbsp;", "");
                        }
                        pleaseWait.progressBar1.PerformStep();
                        Application.DoEvents();
                    }
                }
                else
                {
                    section = n.InnerText.Replace("&nbsp;", "");
                }
            }
            pleaseWait.Close();

            mainDataGridView.Visible = true;
            labelSearch.Visible = true;
            search.Visible = true;
        }

        private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) //для открытия ссылки на статью КоАП
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                if (mainDataGridView.Columns[e.ColumnIndex].Name != "Содержание")
                {
                    return;
                }
                DataGridViewRow row = mainDataGridView.Rows[e.RowIndex];
                string url = row.Cells[3].Value.ToString();
                System.Diagnostics.Process.Start(url);
            }
        }

        private void search_TextChanged(object sender, EventArgs e) //поиск по таблице
        {
            for (int i = 0; i < mainDataGridView.RowCount; i++)
            {
                mainDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < mainDataGridView.Columns.Count; j++)
                {
                    if (mainDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (mainDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(search.Text.ToLower()))
                        {
                            mainDataGridView.Rows[i].Selected = true;
                            mainDataGridView.CurrentCell = mainDataGridView.Rows[i].Cells[j];
                            i = mainDataGridView.RowCount;
                            break;
                        }
                    }
                }
            }
        }

        private void knowledgeBaseToolStripMenuItem_Click(object sender, EventArgs e) //вывод базы знаний
        {
            hiddenControls();
            mainDataGridView.Columns.Clear();
            Client client = new Client();
            DataTable DATA = client.ReadKBFromServer();
            if (DATA == null)
            {
                return;
            }
            mainDataGridView.DataSource = DATA;
            foreach (DataGridViewColumn column in mainDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            mainDataGridView.Visible = true;
            labelSearch.Visible = true;
            search.Visible = true;
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e) //добавление записи в базу знаний
        {
            AddRecord addRecord = new AddRecord(name);
            addRecord.Show();
        }

        private void kalendarOfEventsStripMenuItem_Click(object sender, EventArgs e) //вывод календаря событий
        {
            hiddenControls();
            splitContainer.Visible = true;
            nextMonth.FlatAppearance.BorderSize = 0;
            previousMonth.FlatAppearance.BorderSize = 0;
            splitContainer.Panel1.BackColor = Color.FromArgb(219, 219, 219);
            splitContainer.Panel2.BackColor = Color.FromArgb(219, 219, 219);
            fillCalendar();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e) //добавление событий в календарь
        {
            AddEvent addEvent = new AddEvent(name);
            addEvent.Show();
        }

        private void exportOfThisTableToolStripMenuItem_Click(object sender, EventArgs e) //экспорт главной таблицы в excel
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files(*.xls, *.xlsx)|*.xls,*.xlsx";
            sfd.DefaultExt = "xlsx";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PleaseWait pleaseWait = new PleaseWait();
                pleaseWait.Show();
                Application.DoEvents();
                DataTable table = new DataTable("table");
                for (int i = 0; i < mainDataGridView.Columns.Count; i++)
                {
                    table.Columns.Add(mainDataGridView.Columns[i].Name);
                }

                foreach (DataGridViewRow row in mainDataGridView.Rows)
                {
                    DataRow datarow = table.NewRow();
                    for (int i = 0; i < mainDataGridView.Columns.Count; i++)
                    {
                        datarow[i] = row.Cells[i].Value;
                    }
                    table.Rows.Add(datarow);
                }
                Excel.Application ex = new Excel.Application();
                ex.SheetsInNewWorkbook = 1;
                Excel.Workbook workBook = ex.Workbooks.Add();
                Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
                sheet.Name = "Report";
                try
                {
                    for (int i = 1; i < table.Rows.Count + 2; i++)
                    {
                        for (int j = 1; j < table.Columns.Count + 1; j++)
                        {
                            if (i == 1)
                            {
                                sheet.Cells[i, j] = table.Columns[j - 1].ColumnName;
                            }
                            else
                            {
                                sheet.Cells[i, j] = table.Rows[i - 2][j - 1];
                            }
                        }
                        pleaseWait.progressBar1.PerformStep();
                        Application.DoEvents();
                    }
                }
                catch
                {
                    ex.Application.ActiveWorkbook.Close();
                    pleaseWait.Close();
                    MessageBox.Show("Возникла ошибка при формировании отчета");
                    return;
                }
                Excel.Range c1 = sheet.Cells[1, 1];
                Excel.Range c2 = sheet.Cells[1, table.Columns.Count];
                Excel.Range c3 = sheet.Cells[table.Rows.Count + 1, table.Columns.Count];
                Excel.Range range1 = (Excel.Range)sheet.get_Range(c1, c2);
                Excel.Range range2 = (Excel.Range)sheet.get_Range(c1, c3);
                range1.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
                range2.Cells.Font.Size = 12;
                range2.Cells.Font.Name = "Times New Roman";
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.EntireColumn.AutoFit();
                range2.EntireRow.AutoFit();
                range2.Cells.Style.WrapText = true;
                try
                {
                    ex.Application.ActiveWorkbook.SaveAs(sfd.FileName);
                }
                catch
                {
                    ex.Application.ActiveWorkbook.Close();
                    pleaseWait.Close();
                    MessageBox.Show("Ошибка записи в файл. Попробуйте снова");
                    return;
                }
                ex.Application.ActiveWorkbook.Close();
                pleaseWait.Close();
            }
        }

        private void mainDataGridView_VisibleChanged(object sender, EventArgs e) //отображение кнопки экспорта при видимости главной таблицы
        {
            exportOfThisTableToolStripMenuItem.Visible = mainDataGridView.Visible;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e) //выход из приложения
        {
            Application.Exit();
        }

        private void exitFromAccountToolStripMenuItem_Click_1(object sender, EventArgs e) //выход из учетной записи
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void calendar_CellClick(object sender, DataGridViewCellEventArgs e) //вывод задач на день при клике на ячейку календаря
        {
            splitContainer.Panel2.Controls.Clear();
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || calendar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            Client client = new Client();
            DataTable DATA = client.ReadEventsFromServer(calendar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), DateTime.ParseExact(monthAndYear.Text.Split(',')[0], "MMMM", CultureInfo.CurrentCulture).Month.ToString(), monthAndYear.Text.Split(',')[1].Trim());           
            if (DATA == null)
            {
                return;
            }
            if (DATA.Rows.Count == 0)
            {
                Label label = new Label();
                label.Text = "На данную дату мероприятий не запланировано";
                label.Font = new Font("Arial", 24);
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.TopCenter;
                label.Dock = DockStyle.Fill;
                splitContainer.Panel2.Controls.Add(label);
            }
            else
            {
                int lastPoint = 0;
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    TextBox tb = new TextBox();
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.Multiline = true;
                    tb.Width = splitContainer.Panel2.Width - 3;
                    string dt1 = DATA.Rows[i][0].ToString().Substring(0, DATA.Rows[i][0].ToString().Length - 3);
                    string dt2 = DATA.Rows[i][1].ToString().Substring(0, DATA.Rows[i][1].ToString().Length - 3);
                    tb.Text = $"Дата и время события: {dt1} - {dt2}\r\nОписание события: {DATA.Rows[i][2]}\r\n" +
                        $"Важность события: {DATA.Rows[i][3]}\r\nАвтор события: {DATA.Rows[i][4]}";
                    tb.Height = tb.Lines.Length * 25;
                    tb.Location = new Point(0, lastPoint);
                    lastPoint += tb.Height + 5;
                    tb.Font = new Font("Arial", 16);
                    
                    tb.AutoSize = true;
                    tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    if (DATA.Rows[i][3].ToString() == "Высокий")
                    {
                        tb.BackColor = Color.FromArgb(61, 153, 184);
                    }
                    else if (DATA.Rows[i][3].ToString() == "Средний")
                    {
                        tb.BackColor = Color.FromArgb(152, 207, 225);
                    }
                    else if (DATA.Rows[i][3].ToString() == "Низкий")
                    {
                        tb.BackColor = Color.FromArgb(207, 229, 237);
                    }
                    splitContainer.Panel2.Controls.Add(tb);
                }
            }
        }

        private void previousMonth_Click(object sender, EventArgs e) //отображение предыдущего месяца
        {
            if (firstDayOfMounth.Month == 1)
            {
                firstDayOfMounth = new DateTime(firstDayOfMounth.Year - 1, 12, 1);
            }
            else
            {
                firstDayOfMounth = new DateTime(firstDayOfMounth.Year, firstDayOfMounth.Month - 1, 1);
            }
            daysInMounth = DateTime.DaysInMonth(firstDayOfMounth.Year, firstDayOfMounth.Month);
            dayOfWeek = Convert.ToInt32(firstDayOfMounth.DayOfWeek);
            fillCalendar();
        }

        private void nextMonth_Click(object sender, EventArgs e) //отображение следующего месяца
        {
            if (firstDayOfMounth.Month == 12)
            {
                firstDayOfMounth = new DateTime(firstDayOfMounth.Year + 1, 1, 1);
            }
            else
            {
                firstDayOfMounth = new DateTime(firstDayOfMounth.Year, firstDayOfMounth.Month + 1, 1);
            }
            daysInMounth = DateTime.DaysInMonth(firstDayOfMounth.Year, firstDayOfMounth.Month);
            dayOfWeek = Convert.ToInt32(firstDayOfMounth.DayOfWeek);
            fillCalendar();
        }

        private void myTasksToolStripMenuItem_Click(object sender, EventArgs e) //вывод задач
        {
            foreach (Control cont in this.Controls)
            {
                if (cont.GetType().FullName == new NewComboBox().GetType().FullName)
                {
                    cont.Dispose();
                    break;
                }
            }
            PrintCheckedListBoxAndTasks(name, 0);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //вспомогательные функции и события, созданные программно
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void hiddenControls()
        {
            Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = false);
            menuStrip.Visible = true;
        }

        private void fillCalendar()
        {
            calendar.Rows.Clear();
            dayOfWeek = Convert.ToInt32(firstDayOfMounth.DayOfWeek);
            monthAndYear.Text = firstDayOfMounth.ToString("MMMM", new CultureInfo("ru-RU")) + ", " + firstDayOfMounth.Year.ToString();
            monthAndYear.Font = new Font("Arial", 18);
            if (dayOfWeek == 0)
            {
                dayOfWeek = 6;
            }
            else
            {
                dayOfWeek--;
            }
            calendar.Rows.Add();
            int numOfRow = 0;
            calendar.Rows[numOfRow].Height = 60;
            for (int i = 1; i < daysInMounth + 1; i++)
            {
                if (dayOfWeek >= 7)
                {
                    calendar.Rows.Add();
                    numOfRow++;
                    calendar.Rows[numOfRow].Height = 60;
                    dayOfWeek = 0;
                }
                calendar.Rows[numOfRow].Cells[dayOfWeek].Value = i;
                if (dayOfWeek >= 5)
                {
                    calendar.Rows[numOfRow].Cells[dayOfWeek].Style.BackColor = Color.FromArgb(109, 130, 141);
                }
                else
                {
                    calendar.Rows[numOfRow].Cells[dayOfWeek].Style.BackColor = Color.FromArgb(181, 191, 196);
                }
                dayOfWeek++;
            }
            for (int i = 0; i < calendar.Columns.Count; i++)
            {
                calendar.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(55, 71, 79);
                calendar.Columns[i].HeaderCell.Style.ForeColor = Color.White;
            }
            calendar.EnableHeadersVisualStyles = false;
            foreach (DataGridViewColumn column in calendar.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            calendar.Height = calendar.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + calendar.ColumnHeadersHeight;
            Client client = new Client();
            DataTable DATA = client.ReadMonthEventsFromServer(DateTime.ParseExact(monthAndYear.Text.Split(',')[0], "MMMM", CultureInfo.CurrentCulture).Month.ToString(), monthAndYear.Text.Split(',')[1].Trim());
            if (DATA == null || DATA.Rows.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < DATA.Rows.Count; i++)
                {
                    for (int j = 0; j < calendar.Columns.Count; j++)
                    {
                        for (int k = 0; k < calendar.Rows.Count; k++)
                        {
                            if (calendar.Rows[k].Cells[j].Value != null && Convert.ToInt32(calendar.Rows[k].Cells[j].Value) == Convert.ToInt32(DATA.Rows[i][0].ToString().Split('.')[0]))
                            {
                                calendar.Rows[k].Cells[j].Style.BackColor = Color.FromArgb(55, 85, 95);
                                calendar.Rows[k].Cells[j].Style.ForeColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        private void PrintCheckedListBoxAndTasks(string name, int shift)
        {
            hiddenControls();
            mainDataGridView.Columns.Clear();
            Client client = new Client();
            DataTable DATA = client.ReadTasksFromServer(name);
            if (DATA == null)
            {
                return;
            }
            mainDataGridView.DataSource = DATA;
            checkedListBox = new CheckedListBox();
            checkedListBox.Items.Add("В работе");
            checkedListBox.Items.Add("Выполнены");
            checkedListBox.Items.Add("Этот день");
            checkedListBox.Items.Add("Эта неделя");
            checkedListBox.Items.Add("Этот месяц");
            checkedListBox.Height = 45;
            checkedListBox.Width = 904;
            checkedListBox.MultiColumn = true;
            checkedListBox.Location = new Point(10, 105 + shift);
            checkedListBox.CheckOnClick = true;
            checkedListBox.ColumnWidth = 180;
            checkedListBox.ItemCheck += checkedListBox_ItemCheck;
            this.Controls.Add(checkedListBox);
            GetTasks(new List<string>(), shift);
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            hiddenControls();
            checkedListBox.Visible = true;
            List<string> checkedItems = new List<string>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }
            if (e.NewValue == CheckState.Checked)
            {
                checkedItems.Add(checkedListBox.Items[e.Index].ToString());
            }
            else
            {
                checkedItems.Remove(checkedListBox.Items[e.Index].ToString());
            }
            int shift = 0;
            foreach (Control contrl in this.Controls)
            {
                if (contrl.GetType().FullName == new NewComboBox().GetType().FullName)
                {
                    shift = 100;
                }
            }
            GetTasks(checkedItems, shift);
        }

        private void GetTasks(List<string> checkedItems, int shift)
        {
            List<DataGridViewRow> tasks = new List<DataGridViewRow>();
            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                bool b = true;
                foreach (string item in checkedItems)
                {
                    if (item == "В работе")
                    {
                        if (mainDataGridView.Rows[i].Cells[5].Value.ToString() != item)
                        {
                            b = false;
                            break;
                        }
                    }
                    if (item == "Выполнены")
                    {
                        if (mainDataGridView.Rows[i].Cells[5].Value.ToString() != "Выполнена")
                        {
                            b = false;
                            break;
                        }
                    }
                    if (item == "Этот день")
                    {
                        if (!(Convert.ToDateTime(mainDataGridView.Rows[i].Cells[2].Value).Year == DateTime.Now.Year
                        && Convert.ToDateTime(mainDataGridView.Rows[i].Cells[2].Value).Month == DateTime.Now.Month
                        && Convert.ToDateTime(mainDataGridView.Rows[i].Cells[2].Value).Day == DateTime.Now.Day))
                        {
                            b = false;
                            break;
                        }
                    }
                    if (item == "Эта неделя")
                    {
                        GregorianCalendar cal = new GregorianCalendar();
                        int weekNumberOfTask = cal.GetWeekOfYear(Convert.ToDateTime(mainDataGridView.Rows[i].Cells[2].Value), CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                        int weekNumberNow = cal.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                        if (weekNumberOfTask != weekNumberNow)
                        {
                            b = false;
                            break;
                        }
                    }
                    if (item == "Этот месяц")
                    {
                        if (!(Convert.ToDateTime(mainDataGridView.Rows[i].Cells[2].Value).Year == DateTime.Now.Year
                        && Convert.ToDateTime(mainDataGridView.Rows[i].Cells[2].Value).Month == DateTime.Now.Month))
                        {
                            b = false;
                            break;
                        }
                    }
                }
                if (b)
                {
                    tasks.Add(mainDataGridView.Rows[i]);
                }
            }
            PrintTask(tasks, shift);
        }

        private void PrintTask(List<DataGridViewRow> tasks, int shift)
        {
            int X = 20, Y = 30, lastY = 0, i = 0;
            Label background = new Label();
            background.Location = new Point(0, Y + 120 + shift);
            background.Width = this.Width;
            background.BackColor = Color.FromArgb(219, 219, 219);
            background.BorderStyle = BorderStyle.FixedSingle;
            foreach (DataGridViewRow task in tasks)
            {
                if (i != 0)
                {
                    if (X + 1240 < this.Width)
                    {
                        X += 620;
                    }
                    else
                    {
                        X = 20;
                        Y = lastY + 50;
                    }
                }
                Label mainLabel = new Label();
                mainLabel.TextAlign = ContentAlignment.TopCenter;
                mainLabel.Text = $"Задача №{task.Cells[0].Value} от {task.Cells[4].Value}\r\n{task.Cells[1].Value}";
                mainLabel.BackColor = Color.FromArgb(55, 85, 95);
                mainLabel.ForeColor = Color.White;
                mainLabel.Location = new Point(X, Y);
                mainLabel.AutoSize = true;
                mainLabel.Font = new Font("Arial", 18);
                mainLabel.MaximumSize = new Size(600, 0);
                mainLabel.BorderStyle = BorderStyle.FixedSingle;
                background.Controls.Add(mainLabel);

                Label newLabel = new Label();
                newLabel.TextAlign = ContentAlignment.MiddleLeft;
                newLabel.Text = $"Крайний срок выполнения: {task.Cells[2].Value}\r\nОписание: {task.Cells[3].Value}\r\nСтатус: {task.Cells[5].Value}";
                if (task.Cells[5].Value.ToString() == "В работе")
                {
                    newLabel.BackColor = Color.FromArgb(109, 130, 141);
                }
                else
                {
                    newLabel.BackColor = Color.FromArgb(181, 191, 196);
                }
                newLabel.AutoSize = true;
                newLabel.Font = new Font("Arial", 16);
                newLabel.Width = mainLabel.Width;
                newLabel.Location = new Point(X, mainLabel.Location.Y + mainLabel.Height);
                newLabel.MaximumSize = new Size(600, 0);
                newLabel.BorderStyle = BorderStyle.FixedSingle;
                background.Controls.Add(newLabel);
                bool but = true;
                foreach (Control cont in this.Controls)
                {
                    if (cont.GetType().FullName == new NewComboBox().GetType().FullName)
                    {
                        but = false;
                        break;
                    }
                }
                Button button = new Button();
                if (task.Cells[5].Value.ToString() == "В работе")
                {
                    button.Text = "Выполнено";
                }
                else
                {
                    button.Text = "Доработать";
                }
                button.BackColor = Color.FromArgb(55, 85, 95);
                button.ForeColor = Color.White;
                button.AutoSize = true;
                button.Font = new Font("Arial", 18);
                button.Cursor = Cursors.Hand;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.Name = task.Cells[0].Value.ToString();
                button.Click += taskButton_Click;
                if (but)
                {
                    background.Controls.Add(button);
                }
                button.Location = new Point(newLabel.Location.X + (newLabel.Width - button.Width) / 2, newLabel.Location.Y + newLabel.Height);
                if (button.Location.Y + button.Height > lastY)
                {
                    lastY = button.Location.Y + button.Height;
                }
                i++;
            }
            foreach (Control cont in this.Controls)
            {
                if (cont.GetType().FullName == new NewComboBox().GetType().FullName)
                {
                    cont.Visible = true;
                    break;
                }
            }
            if (lastY > this.Height)
            {
                background.Height = lastY + 30;
            }
            else
            {
                background.Height = this.Height;
            }
            this.Controls.Add(background);
        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Client client = new Client();
            string process = "";
            if (button.Text == "Выполнено")
            {
                process = "Выполнена";
            }
            else
            {
                process = "В работе";
            }
            string query = $"id={Uri.EscapeDataString(button.Name)}&process={Uri.EscapeDataString(process)}";
            string ans = client.UpdateTask(query);
            myTasksToolStripMenuItem_Click(null, null);
            MessageBox.Show(ans);
        }

        private void assignTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(name, level);
            addTask.Show();
        }

        private void tasksWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hiddenControls();
            PrintComboBox();
        }

        private void PrintComboBox()
        {
            NewComboBox comboBox = new NewComboBox();
            comboBox.Font = new Font("Arial", 16);
            comboBox.BackColor = Color.FromArgb(109, 130, 141);
            comboBox.ForeColor = Color.White;
            comboBox.Width = 300;
            comboBox.Location = new Point(20, 120);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Cursor = Cursors.Hand;

            Client client = new Client();
            DataTable DATA = client.GetListOfWorkers(level);
            comboBox.DataSource = DATA;
            comboBox.DisplayMember = "login";
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            this.Controls.Add(comboBox);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            PrintCheckedListBoxAndTasks(comboBox.Text, 100);
            foreach (Control cont in this.Controls)
            {
                if (cont.GetType().FullName == new Label().GetType().FullName)
                {
                    foreach (Control contrl in cont.Controls)
                    {
                        if (contrl.GetType().FullName == new Button().GetType().FullName)
                        {
                            contrl.Dispose();
                        }
                    }
                }
            }
        }
    }
}