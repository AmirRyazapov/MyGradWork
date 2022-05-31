using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LawFirmAutomationSystem
{
    public partial class Authorization : MaterialForm
    {
        public Authorization()
        {
            InitializeComponent();
            //this.Hide();
            //Main main = new Main(1, "admin");
            //main.Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            DataTable DATA = client.GetHashPassword(login.Text, password.Text);
            if (DATA == null)
            {
                return;
            }
            else if (DATA.Rows.Count != 1)
            {
                MessageBox.Show("Проверьте правильность ввода логина или пароля");
            }
            else if (DATA.Rows.Count == 1)
            {
                this.Hide();
                Main main = new Main(Convert.ToInt32(DATA.Rows[0][0]), DATA.Rows[0][1].ToString());
                main.Show();
            }
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
