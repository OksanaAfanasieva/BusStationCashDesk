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
    public partial class HomePage : Form
    {
        private SaveLoadData<RouteData> route;
        private List<RouteData> routeList;

        public HomePage()
        {
            InitializeComponent();
            route = new SaveLoadData<RouteData>("routeData.json");
            routeList = route.Load();
            dateTimePicker.MinDate = DateTime.Today;
        }

        private void HomePage_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.FormClosing += HomePage_FormClosing;
        }

        private void linkLabelMyTravels_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyTravel form = new MyTravel();
            form.Show();
            this.Hide();
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

        private void buttonSearch_Click_1(object sender, EventArgs e)
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

        private void listRoute_DoubleClick(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                RouteData selectedRoute = (RouteData)listRoute.SelectedItems[0].Tag;

                InformationRoute informationRoute = new InformationRoute(selectedRoute);
                informationRoute.ShowDialog();
            }
        }
    }
}
