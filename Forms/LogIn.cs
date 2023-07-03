using BusStationCashDesk.Classes;
using BusStationCashDesk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStationCashDesk.Windows_Forms
{
    public partial class LogIn : Form
    {
        private SaveLoadData<UserData> file;
        private List<UserData> userList;
        private SaveLoadData<string> file1;
        private List<string> nicknameList;

        public LogIn()
        {
            InitializeComponent();
            file = new SaveLoadData<UserData>("C:\\Users\\My HP\\source\\repos\\BusStationCashDesk\\Data\\userData.json");
            userList = file.Load();
            file1 = new SaveLoadData<string>("C:\\Users\\My HP\\source\\repos\\BusStationCashDesk\\Data\\nicknameData.json");
            nicknameList = new List<string>();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration();
            form.Show();
            this.Hide();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введіть ім'я та пароль.", "Помилка входу", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUserRegistered(name) == false)
            {
                MessageBox.Show("Користувача з таким ім'ям не існує або ім'я було введено неправильно.", 
                    "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPasswordRight(name, password) == true)
            {
                if (IsAdministrator(name) == false)
                {
                    nicknameList.Add(nameTextBox.Text);
                    file1.Save(nicknameList);
                    HomePage form = new HomePage();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    HomePageAdministration form = new HomePageAdministration();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неправильний пароль.", "Помилка входу", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool IsPasswordRight(string name, string password)
        {
            if (userList == null)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].Name == name && userList[i].Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsAdministrator(string name)
        {
            if (userList == null)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].Name == name)
                    {
                        return userList[i].IsAdmin;
                    }
                }
            }
            return false;
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

        private void LogIn_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.FormClosing += LogIn_FormClosing;
        }
    }
}
