using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    public partial class AddEvent : MaterialForm
    {
        public AddEvent(string author)
        {
            InitializeComponent();
            textBox2.Text = author;
            comboBox1.SelectedIndex = 1;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата начала превышает дату окончания");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Задано пустое описание");
                return;
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd.HH.mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy.MM.dd.HH.mm";

            string query = $"datetimestart={Uri.EscapeDataString(dateTimePicker1.Text)}&datetimefinish={Uri.EscapeDataString(dateTimePicker2.Text)}" +
                $"&text={Uri.EscapeDataString(textBox1.Text)}&level={Uri.EscapeDataString(comboBox1.SelectedItem.ToString())}&idauthor={Uri.EscapeDataString(textBox2.Text)}";
            Client client = new Client();
            string answer = client.InsertToEvents(query);
            MessageBox.Show(answer);
            Close();
        }
    }
}
