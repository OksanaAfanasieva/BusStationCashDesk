using BusStationCashDesk.Classes;
using Microsoft.VisualBasic.Devices;
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
    public partial class HomePageAdministration : Form
    {
        private SaveLoadData<RouteData> route;
        private List<RouteData> routeList;

        public HomePageAdministration()
        {
            InitializeComponent();
            route = new SaveLoadData<RouteData>("routeData.json");
            routeList = route.Load();
            dateTimePicker.MinDate = DateTime.Today;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Route form = new Route();
            form.Show();
            this.Hide();
        }

        private void HomePageAdministration_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void HomePageAdministration_Load(object sender, EventArgs e)
        {
            this.FormClosing += HomePageAdministration_FormClosing;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string from = textBoxFrom.Text;
            string to = textBoxTo.Text;
            DateTime date = dateTimePicker.Value.Date;

            if (from == "" || to == "")
            {
                MessageBox.Show("Введіть дані для пошуку.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                List<RouteData> selectRoute = SelectedRoute(from, to, date);

                if (selectRoute.Count == 0)
                {
                    listRoute.Items.Clear();
                    MessageBox.Show("Жодного маршруту не знайдено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else DisplayRoute(selectRoute);
            }
        }

        private List<RouteData> SelectedRoute(string from, string to, DateTime date)
        {
            List<RouteData> sortRoute = new List<RouteData>();

            foreach (RouteData route in routeList)
            {
                if (route.FromName == from && route.ToName == to && route.DateTimeFrom == date)
                {
                    sortRoute.Add(route);
                }
            }
            return sortRoute;
        }

        private void DisplayRoute(List<RouteData> route)
        {
            listRoute.Items.Clear();

            route.Sort((r1, r2) => r1.DateTimeFrom.CompareTo(r2.DateTimeFrom));
            
            foreach (RouteData route1 in routeList)
            {
                ListViewItem item = new ListViewItem(route1.Number);
                item.SubItems.Add(route1.FromName);
                item.SubItems.Add(route1.ToName);
                item.SubItems.Add(route1.TimeFrom);
                item.SubItems.Add(route1.FreeSeats);

                listRoute.Items.Add(item);
            }
        }

        private void listRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                buttonRemove.Enabled = true;
            }
            else buttonRemove.Enabled = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей маршрут?", 
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    string selected = listRoute.SelectedItems[0].Text;
                    listRoute.Items.Clear();
                    
                    for (int i = 0; i < routeList.Count; i++)
                    {
                        if (routeList[i].Number == selected)
                        {
                            routeList.RemoveAt(i);
                            break;
                        }
                    }
                    route.Save(routeList);
                }
            }
        }
    }
}
