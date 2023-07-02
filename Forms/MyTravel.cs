using BusStationCashDesk.Classes;
using BusStationCashDesk.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusStationCashDesk.Windows_Forms
{
    public partial class MyTravel : Form
    {
        private SaveLoadData<RouteData> file;
        private List<RouteData> routeList;
        private SaveLoadData<string> file1;
        private List<string> nicknameList;
        private SaveLoadData<TicketData> file2;
        private List<TicketData> ticketList;

        public MyTravel()
        {
            InitializeComponent();
            file = new SaveLoadData<RouteData>("routeData.json");
            routeList = file.Load();
            file1 = new SaveLoadData<string>("nicknameData.json");
            nicknameList = file1.Load();
            file2 = new SaveLoadData<TicketData>("ticketData.json");
            ticketList = file2.Load();
        }

        private void MyTravel_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void MyTravel_Load(object sender, EventArgs e)
        {
            this.FormClosing += MyTravel_FormClosing;

            List<RouteData> boughtRoute = new List<RouteData>();
            for (int i = 0; i < ticketList.Count; i++)
            {
                if (ticketList[i].Nickname == nicknameList[0])
                {
                    for (int j = 0; j < routeList.Count; j++)
                    {
                        if (ticketList[i].Number == routeList[j].Number)
                        {
                            string? number = routeList[j].Number;
                            string? fromName = routeList[j].FromName;
                            string? toName = routeList[j].ToName;
                            DateTime dateTimeFrom = routeList[j].DateTimeFrom;
                            string timeFrom = routeList[j].TimeFrom;
                            DateTime dateTimeTo = routeList[j].DateTimeTo;
                            string timeTo = routeList[j].TimeTo;
                            List<string> stops = new List<string>();
                            List<string> timeStops = new List<string>();
                            decimal freeSeats = ticketList[i].Seats;
                            string price = routeList[j].Price;
                            RouteData newRoute = new RouteData(number, fromName, toName,
                                dateTimeFrom, timeFrom, dateTimeTo, timeTo, stops, timeStops,
                                freeSeats, price);
                            boughtRoute.Add(newRoute);
                        }
                    }
                }
            }
            DisplayRoute(boughtRoute);


            if (boughtRoute.Count < ticketList.Count)
            {
                for (int i = 0; i < ticketList.Count; i++)
                {
                    bool found = false;
                    for (int j = 0; j <= boughtRoute.Count; j++)
                    {
                        if(ticketList[i].Nickname == nicknameList[0] && j != boughtRoute.Count)
                        {
                            if (ticketList[i].Number == boughtRoute[j].Number)
                            {
                                found = true;
                            }
                        }
                        else found = true;
                    }
                    if (found == false)
                    {
                        ticketList.RemoveAt(i);
                        file2.Save(ticketList);
                    }
                }
            }
            else if (boughtRoute.Count > ticketList.Count)
            {
                for (int i = 0; i < boughtRoute.Count; i++)
                {
                    bool found = false;
                    for (int j = 0; j <= ticketList.Count; j++)
                    {
                        if (ticketList[j].Nickname == nicknameList[0] && j != boughtRoute.Count)
                        {
                            if (ticketList[j].Number == boughtRoute[i].Number)
                            {
                                found = true;
                            }
                        }
                        else found = true;
                    }
                    if (found == false)
                    {
                        boughtRoute.RemoveAt(i);
                    }
                }
            }
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void DisplayRoute(List<RouteData> boughtRoute)
        {
            foreach (RouteData route in boughtRoute)
            {
                TextInfo title = CultureInfo.InvariantCulture.TextInfo;

                ListViewItem item = new ListViewItem(route.Number);
                item.SubItems.Add(title.ToTitleCase(route.FromName ?? string.Empty));
                item.SubItems.Add(title.ToTitleCase(route.ToName ?? string.Empty));
                item.SubItems.Add(route.DateTimeFrom.ToString("dd/MM/yyyy"));
                item.SubItems.Add(route.TimeFrom);
                item.SubItems.Add(route.FreeSeats.ToString());

                listTicket.Items.Add(item);
            }
        }

        private void listTicket_DoubleClick(object sender, EventArgs e)
        {
            if (listTicket.SelectedItems.Count > 0)
            {
                string selected = listTicket.SelectedItems[0].Text;

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

        private void buttonReturnTicket_Click(object sender, EventArgs e)
        {
            if (listTicket.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете скасувати бронювання?",
                    "Підтвердження повернення квитка", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string selected = listTicket.SelectedItems[0].Text;
                    int index = 0;

                    for (int i = 0; i < ticketList.Count; i++)
                    {
                        if (ticketList[i].Number == selected)
                        {
                            index = i;
                        }
                    }
                    
                    for (int i = 0; i < routeList.Count; i++)
                    {
                        if (routeList[i].Number == selected)
                        {
                            routeList[i].FreeSeats += ticketList[index].Seats;
                            ticketList.RemoveAt(index);
                        }
                    }
                    file.Save(routeList);
                    file2.Save(ticketList);
                    MyTravel form = new MyTravel();
                    form.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Виберіть маршрут, який хочете видалити.",
                    "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
