using BusStationCashDesk.Classes;
using BusStationCashDesk.Forms;
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
            DisplayRoute(routeList);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string from = textBoxFrom.Text;
            string to = textBoxTo.Text;
            DateTime date = dateTimePicker.Value.Date;

            if (from == "" || to == "")
            {
                DisplayRoute(routeList);
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
                if (route.FromName == from && route.ToName == to && route.DateTimeFrom == date && int.Parse(route.FreeSeats) > 0)
                {
                    selectedRoute.Add(route);
                }
            }
            return selectedRoute;
        }

        private void DisplayRoute(List<RouteData> route)
        {
            listRoute.Items.Clear();
            
            foreach (RouteData route1 in route)
            {
                ListViewItem item = new ListViewItem(route1.Number);
                item.SubItems.Add(route1.FromName);
                item.SubItems.Add(route1.ToName);
                item.SubItems.Add(route1.DateTimeFrom.ToString("dd/MM/yyyy"));
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
    }
}
