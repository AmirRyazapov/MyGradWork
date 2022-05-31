using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    public partial class AddTask : MaterialForm
    {
        public AddTask(string author, int level)
        {
            InitializeComponent();
            this.author.Text = author;
            Client client = new Client();
            DataTable DATA = client.GetListOfWorkers(level);
            subordinate.DataSource = DATA;
            subordinate.DisplayMember = "login";
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (dateTimeAppoint.Value > dateTimeFinish.Value)
            {
                MessageBox.Show("Дата начала превышает дату окончания");
                return;
            }
            if (description.Text == "")
            {
                MessageBox.Show("Задано пустое описание");
                return;
            }
            dateTimeAppoint.Format = DateTimePickerFormat.Custom;
            dateTimeAppoint.CustomFormat = "yyyy.MM.dd.HH.mm";
            dateTimeFinish.Format = DateTimePickerFormat.Custom;
            dateTimeFinish.CustomFormat = "yyyy.MM.dd.HH.mm";

            Client client = new Client();
            string query = $"datetimeappointment={Uri.EscapeDataString(dateTimeAppoint.Text)}&datetimefinish={Uri.EscapeDataString(dateTimeFinish.Text)}" +
                $"&text={Uri.EscapeDataString(description.Text)}&author={Uri.EscapeDataString(author.Text)}&subordinate={Uri.EscapeDataString(subordinate.Text)}";
            string answer = client.InsertToTasks(query);
            MessageBox.Show(answer);
            Close();
        }
    }
}
