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
        private HomePages homePages;

        public HomePageAdministration()
        {
            InitializeComponent();
            route = new SaveLoadData<RouteData>("C:\\Users\\My HP\\source\\repos\\BusStationCashDesk\\Data\\routeData.json");
            routeList = route.Load();
            file1 = new SaveLoadData<TicketData>("C:\\Users\\My HP\\source\\repos\\BusStationCashDesk\\Data\\ticketData.json");
            ticketList = file1.Load();
            homePages = new HomePages();
            dateTimePicker.MinDate = DateTime.Today;
            this.FormClosing += HomePageAdministration_FormClosing;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Route form = new Route();
            form.Show();
            this.Hide();
        }

        private void HomePageAdministration_FormClosing(object? sender, 
            FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void HomePageAdministration_Load(object sender, EventArgs e)
        {
            homePages.RemoveExpiredRoutes(routeList);
            homePages.DisplayRoute(routeList, listRoute);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            homePages.Search(fromTextBox.Text.ToLower(), toTextBox.Text.ToLower(), 
                dateTimePicker.Value.Date, listRoute);
        }

        private void listRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRoute.SelectedItems.Count > 0)
            {
                remove.Enabled = true;
            }
            else remove.Enabled = false;
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
                    homePages.DisplayRoute(routeList, listRoute);
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
            homePages.DisplayRoute(routeList, listRoute);
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
                            MessageBox.Show("Ніхто не придбав квиток на цей маршрут.", 
                                "Посадкова відомість", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
