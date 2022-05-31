using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    public partial class AddEvent : MaterialForm
    {
        public AddEvent(string author)
        {
            InitializeComponent();
            this.author.Text = author;
            levelOfImportant.SelectedIndex = 1;
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if (dateTimeStart.Value > dateTimeFinish.Value)
            {
                MessageBox.Show("Дата начала превышает дату окончания");
                return;
            }
            if (description.Text == "")
            {
                MessageBox.Show("Задано пустое описание");
                return;
            }
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "yyyy.MM.dd.HH.mm";
            dateTimeFinish.Format = DateTimePickerFormat.Custom;
            dateTimeFinish.CustomFormat = "yyyy.MM.dd.HH.mm";

            string query = $"datetimestart={Uri.EscapeDataString(dateTimeStart.Text)}&datetimefinish={Uri.EscapeDataString(dateTimeFinish.Text)}" +
                $"&text={Uri.EscapeDataString(description.Text)}&level={Uri.EscapeDataString(levelOfImportant.SelectedItem.ToString())}" +
                $"&idauthor={Uri.EscapeDataString(author.Text)}";
            Client client = new Client();
            string answer = client.InsertToEvents(query);
            MessageBox.Show(answer);
            Close();
        }
    }
}
