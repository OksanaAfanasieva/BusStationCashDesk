using BusStationCashDesk.Classes;
using BusStationCashDesk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;

namespace BusStationCashDesk.Windows_Forms
{
    public partial class BuyTicket : Form
    {
        private SaveLoadData<RouteData> file;
        private List<RouteData> routeList;
        private string selected;
        private SaveLoadData<string> file1;
        private List<string> nicknameList;
        private SaveLoadData<TicketData> file2;
        private List<TicketData> ticketList;
        private int index;

        public BuyTicket(string number)
        {
            InitializeComponent();
            file = new SaveLoadData<RouteData>("routeData.json");
            routeList = file.Load();
            selected = number;
            file1 = new SaveLoadData<string>("nicknameData.json");
            nicknameList = file1.Load();
            file2 = new SaveLoadData<TicketData>("ticketData.json");
            ticketList = file2.Load();
            index = 0;
        }

        private void BuyTicket_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Дані не будуть збережені! " +
                    "Ви впевнені, що хочете закрити сторінку?", "Попередження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            this.FormClosing += BuyTicket_FormClosing;

            for (int i = 0; i < routeList.Count; i++)
            {
                if (routeList[i].Number == selected && selected != null)
                {
                    TextInfo title = CultureInfo.InvariantCulture.TextInfo;

                    numberRouteTextBox.Text = routeList[i].Number;
                    fromTextBox.Text = title.ToTitleCase(routeList[i].FromName ?? string.Empty);
                    toTextBox.Text = title.ToTitleCase(routeList[i].ToName ?? string.Empty);
                    fromDateTimePicker.Value = routeList[i].DateTimeFrom;
                    timeFromTextBox.Text = routeList[i].TimeFrom;
                    toDateTimePicker.Value = routeList[i].DateTimeTo;
                    timeToTextBox.Text = routeList[i].TimeTo;
                    priceTextBox.Text = routeList[i].Price;
                    index = i;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете скасувати бронювання?", 
                "Попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                HomePage form = new HomePage();
                form.Show();
                this.Hide();
            }
            else
            {
                var close = e as FormClosingEventArgs;
                if (close != null)
                    close.Cancel = true;
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            string? number = selected;
            string? name = nameTextBox.Text;
            string? surname = surnameTextBox.Text;
            decimal seats = passengerNumeric.Value;
            string price = priceTextBox.Text;
            string? nickname = nicknameList[0];


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Введіть усі необхідні дані.", "Збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (routeList[index].FreeSeats >= seats)
            {
                if (ticketList == null)
                {
                    routeList[index].FreeSeats = routeList[index].FreeSeats - seats;
                    List<TicketData> ticketList = new List<TicketData>();
                    TicketData newTicket = new TicketData(number, name, surname, seats, 
                        price, nickname);
                    ticketList.Add(newTicket);
                    file.Save(routeList);
                    file2.Save(ticketList);
                }
                else
                {
                    routeList[index].FreeSeats = routeList[index].FreeSeats - seats;
                    TicketData newTicket = new TicketData(number, name, surname, seats, 
                        price, nickname);
                    ticketList.Add(newTicket);
                    file.Save(routeList);
                    file2.Save(ticketList);
                }
            }
            else
            {
                MessageBox.Show("Недостатньо місць в автобусі.", "Помилка збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }

        private void numericPassenger_ValueChanged(object sender, EventArgs e)
        {
            priceTextBox.Text = (Math.Round(decimal.Parse(routeList[index].Price) * 
                passengerNumeric.Value, 2)).ToString();
        }
    }
}
