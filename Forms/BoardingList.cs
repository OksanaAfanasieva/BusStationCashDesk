using BusStationCashDesk.Classes;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BusStationCashDesk.Windows_Forms
{
    public partial class BoardingList : Form
    {
        private SaveLoadData<TicketData> file;
        private List<TicketData> ticketList;
        private string selected;

        public BoardingList(string number)
        {
            InitializeComponent();
            file = new SaveLoadData<TicketData>("ticketData.json");
            ticketList = file.Load();
            selected = number;
        }

        private void BoardingList_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void BoardingList_Load(object sender, EventArgs e)
        {
            int found = 0;
            numberRouteTextBox.Text = selected;
            for (int i = 0; i < ticketList.Count; i++)
            {
                if (ticketList[i].Number == selected)
                {
                    DisplayRoute(ticketList[i]);
                    found++;
                }
            }

            if (found == 0)
            {
                MessageBox.Show("Ніхто не придбав квиток на цей маршрут.", 
                    "Посадкова відомість", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.FormClosing += BoardingList_FormClosing;
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePageAdministration form = new HomePageAdministration();
            form.Show();
            this.Hide();
        }

        private void DisplayRoute(TicketData ticket)
        {
            ListViewItem item = new ListViewItem(ticket.Name);
            item.SubItems.Add(ticket.Surname);
            item.SubItems.Add(ticket.Seats.ToString());
            item.SubItems.Add(ticket.Price.ToString());

            passengerList.Items.Add(item);
        }
    }
}
