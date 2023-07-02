using BusStationCashDesk.Classes;
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
        private List<string>? timeStop;

        public Route()
        {
            InitializeComponent();
            fromDateTimePicker.MinDate = DateTime.Today;
            toDateTimePicker.MinDate = DateTime.Today;
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
            timeFromDateTimePicker.CustomFormat = "HH:mm";
            timeToDateTimePicker.CustomFormat = "HH:mm";
            timeStopDateTimePicker.CustomFormat = "HH:mm"; 
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дані не будуть збережені! Ви впевнені, що хочете скасувати створення?", "Попередження",
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
                timeStop = new List<string>();
            }

            foreach(ListViewItem item in stopListView.Items)
            {
                nameStop.Add(item.SubItems[0].Text);
                timeStop.Add(item.SubItems[1].Text);
            }

            string number = numberRouteTextBox.Text;
            string fromName = fromTextBox.Text.ToLower();
            string toName = toTextBox.Text.ToLower();
            DateTime dateTimeFrom = fromDateTimePicker.Value.Date;
            string timeFrom = timeFromDateTimePicker.Value.ToString("HH:mm");
            DateTime dateTimeTo = toDateTimePicker.Value.Date;
            string timeTo = timeToDateTimePicker.Value.ToString("HH:mm");
            List<string> stops = nameStop;
            List<string> timeStops = timeStop;
            decimal freeSeats = freeSeatNumeric.Value;
            string price = priceTextBox.Text;

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(fromName) ||
                string.IsNullOrEmpty(toName) || string.IsNullOrEmpty(price))
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
            else for (int i = 0; i < routeList.Count; i++)
            {
                int repeat = 0;
                if (routeList[i].Number == number)
                {
                    repeat++;
                }

                if (repeat == 0 && i == routeList.Count - 1)
                {
                    RouteData newRoute = new RouteData(number, fromName, toName,
                    dateTimeFrom, timeFrom, dateTimeTo, timeTo, stops, timeStop,
                    freeSeats, price);
                    routeList.Add(newRoute);
                    file.Save(routeList);
                    break;
                }
                else if (i == routeList.Count - 1)
                {
                    MessageBox.Show("Вже існує маршурт з таким номером.", "Помилка збереження",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                }

            HomePageAdministration form = new HomePageAdministration();
            form.Show();
            this.Hide();
        }

        private void buttonAddStop_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameStopTextBox.Text) || string.IsNullOrEmpty(timeStopDateTimePicker.Text))
            {
                MessageBox.Show("Введіть назву зупинки.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem item = new ListViewItem(nameStopTextBox.Text);
            item.SubItems.Add(timeStopDateTimePicker.Text);
            stopListView.Items.Add(item);
            nameStopTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stopListView.SelectedItems.Count > 0)
                stopListView.Items.Remove(stopListView.SelectedItems[0]);
        }

        private void textBoxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxNameStop_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void timePickerStop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelTimeStop_Click(object sender, EventArgs e)
        {

        }

        private void labelNameStop_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNameStop_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((sender as TextBox)?.Text?.Contains(",") ?? false))
            {
                e.Handled = true;
            }
        }
    }
}
