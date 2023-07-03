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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BusStationCashDesk.Windows_Forms
{
    public partial class HomePage : Form
    {
        private SaveLoadData<RouteData> route;
        private List<RouteData> routeList;
        private HomePages homePages;

        public HomePage()
        {
            InitializeComponent();

            route = new SaveLoadData<RouteData>("routeData.json");
            routeList = route.Load();
            homePages = new HomePages();
            dateTimePicker.MinDate = DateTime.Today;
            this.FormClosing += HomePage_FormClosing;
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
            homePages.RemoveExpiredRoutes(routeList);
            homePages.DisplayRoute(routeList, listRoute);
        }

        private void linkLabelMyTravels_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            MyTravel form = new MyTravel();
            form.Show();
            this.Hide();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            homePages.Search(fromTextBox.Text.ToLower(), toTextBox.Text.ToLower(), 
                dateTimePicker.Value.Date, listRoute);
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
            homePages.DisplayRoute(routeList, listRoute);
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
            else MessageBox.Show("Виберіть маршрут, на який хочете придбати квиток.",
                    "Бронювання", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
