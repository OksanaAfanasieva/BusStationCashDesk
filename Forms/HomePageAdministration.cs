using BusStationCashDesk.Classes;
using BusStationCashDesk.Forms;
using BusStationCashDesk.Models;
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
    public partial class HomePageAdministration : Form
    {
        private SaveLoadData<RouteData> route;
        private List<RouteData> routeList;
        private SaveLoadData<TicketData> file1;
        private List<TicketData> ticketList;


        public HomePageAdministration()
        {
            InitializeComponent();
            route = new SaveLoadData<RouteData>("routeData.json");
            routeList = route.Load();
            file1 = new SaveLoadData<TicketData>("ticketData.json");
            ticketList = file1.Load();
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

            for (int i = 0; i < routeList.Count; i++)
            {
                if (routeList[i].DateTimeFrom.Date <= DateTime.Today && DateTime.Parse(routeList[i].TimeFrom) <= DateTime.Now)
                {
                    routeList.RemoveAt(i);
                }
            }
            route.Save(routeList);
            DisplayRoute(routeList);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
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

        private List<RouteData> SelectedRoute(string from, string to, DateTime date)
        {
            List<RouteData> selectedRoute = new List<RouteData>();

            foreach (RouteData route in routeList)
            {
                if (route.FromName == from && route.ToName == to && route.DateTimeFrom == date && route.FreeSeats > 0)
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
                item.SubItems.Add(route1.FreeSeats.ToString());

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

                    for (int i = 0; i < routeList.Count; i++)
                    {
                        if (routeList[i].Number == selected)
                        {
                            routeList.RemoveAt(i);
                            break;
                        }
                    }
                    route.Save(routeList);
                    DisplayRoute(routeList);
                }
            }
            else MessageBox.Show("Виберіть маршрут, який хочете видалити.",
                    "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                string selected = listRoute.SelectedItems[0].Text;

                for (int i = 0; i < routeList.Count; i++)
                {
                    if (routeList[i].Number == selected && selected != null)
                    {
                        Edit form = new Edit(selected);
                        form.Show();
                        this.Hide();
                    }
                }
            }
            else MessageBox.Show("Виберіть маршрут, який хочете відредагувати.",
                    "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAllRoute_Click(object sender, EventArgs e)
        {
            DisplayRoute(routeList);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?",
                "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LogIn form = new LogIn();
                form.Show();
                this.Hide();
            }
        }

        private void buttonBoardingList_Click(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                string selected = listRoute.SelectedItems[0].Text;

                for (int i = 0; i < routeList.Count; i++)
                {
                    if (routeList[i].Number == selected && selected != null)
                    {
                        int found = 0;
                        for (int j = 0; j < ticketList.Count; j++)
                        {
                            if (ticketList[j].Number == selected)
                            {
                                found++;
                            }
                        }

                        if (found == 0)
                        {
                            MessageBox.Show("Ніхто не придбав квиток на цей маршрут.", "Посадкова відомість", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            BoardingList form = new BoardingList(selected);
                            form.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else MessageBox.Show("Виберіть маршрут, посадкову відомість якого хочете переглянути.",
                    "Посадкова відомість", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
