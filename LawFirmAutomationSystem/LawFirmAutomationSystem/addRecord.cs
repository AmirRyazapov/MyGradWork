using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    public partial class AddRecord : MaterialForm
    {
        public AddRecord(string author)
        {
            InitializeComponent();
            date.Value = DateTime.Now;
            this.author.Text = author;
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "yyyy.MM.dd";
            string query = $"question={Uri.EscapeDataString(question.Text)}&answer={Uri.EscapeDataString(answer.Text)}" +
                $"&date={Uri.EscapeDataString(date.Text)}&author={Uri.EscapeDataString(author.Text)}";
            Client client = new Client();
            string answerFromServer = client.InsertToRecords(query);
            MessageBox.Show(answerFromServer);
            Close();
        }
    }
}
