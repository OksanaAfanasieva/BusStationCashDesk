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
        private List<string> nameStop = new List<string>();
        private List<DateTime> timeStop = new List<DateTime>();
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
            if (!string.IsNullOrEmpty(textBoxNameStop.Text))
            {
                int index = nameStop.Count + 1;
                TextBox textBoxNameStop = new TextBox();
                textBoxNameStop.Location = new Point(90, 265 + (index + 25));
                textBoxNameStop.Width = 196;
                this.Controls.Add(textBoxNameStop);
                nameStop.Add(textBoxNameStop.Text);

                DateTimePicker timePickerStop = new DateTimePicker();
                timePickerStop.Format = DateTimePickerFormat.Custom;
                timePickerStop.CustomFormat = "HH:mm";
                timePickerStop.ShowUpDown = true;
                timePickerStop.Location = new Point(371, 265 + (index + 25));
                timePickerStop.Width = 196;
                this.Controls.Add(timePickerStop);
                timeStop.Add(timePickerStop.Value);

                buttonAddStop.Location = new Point(buttonAddStop.Location.X, buttonAddStop.Location.Y + 28);
                labelFreePlace.Location = new Point(labelFreePlace.Location.X, labelFreePlace.Location.Y + 28);
                textBoxFreePlace.Location = new Point(textBoxFreePlace.Location.X, textBoxFreePlace.Location.Y + 28);
                labelPrice.Location = new Point(labelPrice.Location.X, labelPrice.Location.Y + 28);
                textBoxPrice.Location = new Point(textBoxPrice.Location.X, textBoxPrice.Location.Y + 28);
                buttonCancel.Location = new Point(buttonCancel.Location.X, buttonCancel.Location.Y + 28);
                buttonSave.Location = new Point(buttonSave.Location.X, buttonSave.Location.Y + 28);

                int height = buttonSave.Location.Y + buttonSave.Height + 10;
                this.AutoScrollMinSize = new Size(0, height);
                this.AutoScrollPosition = new Point(0, height);
            }
        }
    }
}
