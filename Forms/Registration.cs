using BusStationCashDesk.Windows_Forms;
using System.Text.Json;
using System.IO;
using BusStationCashDesk.Classes;

namespace BusStationCashDesk
{
    public partial class Registration : Form
    {
        private SaveLoadData<UserData> file;
        private List<UserData> userList;

        public Registration()
        {
            InitializeComponent();
            file = new SaveLoadData<UserData>("userData.json");
            userList = file.Load();
        }

        private void Registration_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += Registration_FormClosing;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Hide();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введіть ім'я та пароль.", "Помилка реєстрації", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUserRegistered(name) == true)
            {
                MessageBox.Show("Користувач з таким ім'ям вже існує.", "Помилка реєстрації", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userList == null)
            {
                List<UserData> userList = new List<UserData>();
                UserData newUser = new UserData(name, password, false);
                userList.Add(newUser);
                file.Save(userList);
            }
            else
            {
                UserData newUser = new UserData(name, password, false);
                userList.Add(newUser);
                file.Save(userList);
            }

            MessageBox.Show("Ви зареєстровані.", "Реєстрація", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            LogIn form = new LogIn();
            form.Show();
            this.Hide();
        }

        private bool IsUserRegistered(string name)
        {
            if (userList == null)
            {
                return false;
            }
            else
            {
                foreach (var user in userList)
                {
                    if (user.Name == name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}