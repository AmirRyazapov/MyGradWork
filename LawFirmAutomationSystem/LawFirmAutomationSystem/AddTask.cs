using MaterialSkin.Controls;
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
    public partial class AddTask : MaterialForm
    {
        public AddTask(string author, int level)
        {
            InitializeComponent();
            textBox1.Text = author;
            Client client = new Client();
            DataTable DATA = client.GetListOfWorkers(level);
            comboBox1.DataSource = DATA;
            comboBox1.DisplayMember = "login";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата начала превышает дату окончания");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Задано пустое описание");
                return;
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd.HH.mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy.MM.dd.HH.mm";

            Client client = new Client();
            string answer = client.InsertToTasks(textBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text, textBox2.Text, comboBox1.Text);
            MessageBox.Show(answer);
            Close();
        }
    }
}
