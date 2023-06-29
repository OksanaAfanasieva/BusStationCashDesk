using BusStationCashDesk.Classes;
using BusStationCashDesk.Windows_Forms.Warnings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace BusStationCashDesk.Windows_Forms
{
    public partial class Route : Form
    {
        private SaveLoadData<RouteData> file;
        private List<RouteData> routeList;
        private List<string>? nameStop;
        private List<DateTime>? timeStop; 

        public Route()
        {
            InitializeComponent();
            dateTimePickerFrom.MinDate = DateTime.Today;
            dateTimePickerTo.MinDate = DateTime.Today;
            file = new SaveLoadData<RouteData>("routeData.json");
            routeList = file.Load();
        }

        private void Route_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Дані не будуть збережені! Ви впевнені, що хочете закрити сторінку?", "Попередження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
        }

        private void Route_Load(object sender, EventArgs e)
        {
            this.FormClosing += Route_FormClosing;
            timePickerFrom.CustomFormat = "HH:mm";
            timePickerTo.CustomFormat = "HH:mm";
            timePickerStop.CustomFormat = "HH:mm";
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дані не будуть збережені! Ви впевнені, що хочете закрити сторінку?", "Попередження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                HomePageAdministration form = new HomePageAdministration();
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

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if(nameStop == null)
            {
                nameStop = new List<string>();
            }

            if(timeStop == null)
            {
                timeStop = new List<DateTime>();
            }

            foreach(ListViewItem item in listViewStop.Items)
            {
                nameStop.Add(item.SubItems[0].Text);
                timeStop.Add(DateTime.Parse(item.SubItems[1].Text));
            }

            string number = textBoxNumberRoute.Text;
            string fromName = textBoxFrom.Text;
            string toName = textBoxTo.Text;
            DateTime dateTimeFrom = dateTimePickerFrom.Value;
            DateTime timeFrom = timePickerFrom.Value;
            DateTime dateTimeTo = dateTimePickerTo.Value;
            DateTime timeTo = timePickerTo.Value;
            List<string> stops = nameStop ?? new List<string>();
            List<DateTime> timeStops = timeStop ?? new List<DateTime>();
            string freeSeats = textBoxFreePlace.Text;
            string price = textBoxPrice.Text;

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(fromName) ||
                string.IsNullOrEmpty(toName) || string.IsNullOrEmpty(freeSeats) ||
                string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Введіть усі необхідні дані.", "Помилка збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (routeList == null)
            {
                List<RouteData> routeList = new List<RouteData>();
                RouteData newRoute = new RouteData(number, fromName, toName,
                    dateTimeFrom, timeFrom, dateTimeTo, timeTo, stops, timeStop,
                    freeSeats, price);
                routeList.Add(newRoute);
                file.Save(routeList);
            }
            else
            {
                RouteData newRoute = new RouteData(number, fromName, toName,
                    dateTimeFrom, timeFrom, dateTimeTo, timeTo, stops, timeStop,
                    freeSeats, price);
                routeList.Add(newRoute);
                file.Save(routeList);
            }

            HomePageAdministration form = new HomePageAdministration();
            form.Show();
            this.Hide();
        }

        private void buttonAddStop_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxNameStop.Text) || string.IsNullOrEmpty(timePickerStop.Text))
            {
                MessageBox.Show("Введіть назву зупинки.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem item = new ListViewItem(textBoxNameStop.Text);
            item.SubItems.Add(timePickerStop.Text);
            listViewStop.Items.Add(item);
            textBoxNameStop.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewStop.Items.Count > 0)
                listViewStop.Items.Remove(listViewStop.SelectedItems[0]);
        }
    }
}
