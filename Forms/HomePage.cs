using BusStationCashDesk.Classes;
using BusStationCashDesk.Forms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            DisplayRoute(routeList);
        }

        private void linkLabelMyTravels_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyTravel form = new MyTravel();
            form.Show();
            this.Hide();
        }

        private List<RouteData> SelectedRoute(string from, string to, DateTime date)
        {
            List<RouteData> selectedRoute = new List<RouteData>();

            foreach (RouteData route in routeList)
            {
                if (route.FromName == from && route.ToName == to && route.DateTimeFrom == date && int.Parse(route.FreeSeats) > 0)
                {
                    selectedRoute.Add(route);
                }
            }

            if (selectedRoute.Count > 1)
            {
                for (int i = 0; i < selectedRoute.Count - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < selectedRoute.Count; j++)
                    {
                        if (DateTime.ParseExact(selectedRoute[j].TimeFrom, "HH:mm", CultureInfo.InvariantCulture) < DateTime.ParseExact(selectedRoute[min].TimeFrom, "HH:mm", CultureInfo.InvariantCulture))
                        {
                            min = j;
                        }
                    }

                    RouteData k = selectedRoute[i];
                    selectedRoute[i] = selectedRoute[min];
                    selectedRoute[min] = k;
                }
            }
            return selectedRoute;
        }

        private void DisplayRoute(List<RouteData> route)
        {
            listRoute.Items.Clear();

            foreach (RouteData route1 in route)
            {
                TextInfo title = CultureInfo.InvariantCulture.TextInfo;

                ListViewItem item = new ListViewItem(route1.Number);
                item.SubItems.Add(title.ToTitleCase(route1.FromName ?? string.Empty));
                item.SubItems.Add(title.ToTitleCase(route1.ToName ?? string.Empty));
                item.SubItems.Add(route1.DateTimeFrom.ToString("dd/MM/yyyy"));
                item.SubItems.Add(route1.TimeFrom);
                item.SubItems.Add(route1.FreeSeats);

                listRoute.Items.Add(item);
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string from = textBoxFrom.Text.ToLower();
            string to = textBoxTo.Text.ToLower();
            DateTime date = dateTimePicker.Value.Date;

            if (from == "" || to == "")
            {
                MessageBox.Show("Введіть дані для пошуку.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                List<RouteData> selectedRoute = SelectedRoute(from, to, date);

                if (selectedRoute.Count == 0)
                {
                    MessageBox.Show("Жодного маршруту не знайдено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else DisplayRoute(selectedRoute);
            }
        }

        private void listRoute_DoubleClick(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                string selected = listRoute.SelectedItems[0].Text;

                for (int i = 0; i < routeList.Count; i++)
                {
                    if (routeList[i].Number == selected && selected != null)
                    {
                        InformationRoute informationRoute = new InformationRoute(selected);
                        informationRoute.ShowDialog();
                    }
                }   
            }
        }

        private void buttonAllRoute_Click(object sender, EventArgs e)
        {
            DisplayRoute(routeList);
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                string selected = listRoute.SelectedItems[0].Text;

                for (int i = 0; i < routeList.Count; i++)
                {
                    if (routeList[i].Number == selected && selected != null)
                    {
                        BuyTicket form = new BuyTicket(selected);
                        form.Show();
                        this.Hide();
                    }
                }
            }
            else MessageBox.Show("Виберіть маршрут, який хочете відредагувати.",
                    "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
