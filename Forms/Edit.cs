using BusStationCashDesk.Classes;
using BusStationCashDesk.Windows_Forms;
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

namespace BusStationCashDesk.Forms
{
    public partial class Edit : Form
    {
        private SaveLoadData<RouteData> file;
        private List<RouteData> routeList;
        private List<string>? nameStop;
        private List<string>? timeStop;
        private string selected;

        public Edit(string number)
        {
            InitializeComponent();
            dateFromDateTimePicker.MinDate = DateTime.Today;
            dateToDateTimePicker.MinDate = DateTime.Today;
            file = new SaveLoadData<RouteData>("routeData.json");
            routeList = file.Load();
            selected = number;
            this.FormClosing += Edit_FormClosing;
        }

        private void Edit_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Оновлені дані не будуть збережені! " +
                    "Ви впевнені, що хочете закрити сторінку?", "Попередження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            timeFromDateTimePicker.CustomFormat = "HH:mm";
            timeToDateTimePicker.CustomFormat = "HH:mm";
            timeStopDateTimePicker.CustomFormat = "HH:mm";

            for (int i = 0; i < routeList.Count; i++)
            {
                if (routeList[i].Number == selected && selected != null)
                {
                    TextInfo title = CultureInfo.InvariantCulture.TextInfo;

                    numberRouteTextBox.Text = routeList[i].Number;
                    fromTextBox.Text = title.ToTitleCase(routeList[i].FromName ?? string.Empty);
                    toTextBox.Text = title.ToTitleCase(routeList[i].ToName ?? string.Empty);
                    dateFromDateTimePicker.Value = routeList[i].DateTimeFrom;
                    timeFromDateTimePicker.Value = DateTime.ParseExact(routeList[i].TimeFrom, 
                        "HH:mm", CultureInfo.InvariantCulture);
                    dateToDateTimePicker.Value = routeList[i].DateTimeTo;
                    timeToDateTimePicker.Value = DateTime.ParseExact(routeList[i].TimeTo, 
                        "HH:mm", CultureInfo.InvariantCulture);
                    stopList.View = View.Details;

                    for (int j = 0; j < routeList[i].Stops.Count; j++)
                    {
                        ListViewItem item = new ListViewItem(routeList[i].Stops[j]);
                        item.SubItems.Add(routeList[i].TimeStop[j]);
                        stopList.Items.Add(item);
                    }

                    freeSeatNumeric.Value = routeList[i].FreeSeats;
                    priceTextBox.Text = routeList[i].Price;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Оновлені дані не будуть збережені! " +
                "Ви впевнені, що хочете скасувати редагування?", "Попередження",
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

        private void buttonAddStop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameStopTextBox.Text) || 
                string.IsNullOrEmpty(timeStopDateTimePicker.Text))
            {
                MessageBox.Show("Введіть назву зупинки.", "Повідомлення", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem item = new ListViewItem(nameStopTextBox.Text);
            item.SubItems.Add(timeStopDateTimePicker.Text);
            stopList.Items.Add(item);
            nameStopTextBox.Clear();
        }

        private void buttonRemoveStop_Click(object sender, EventArgs e)
        {
            if (stopList.SelectedItems.Count > 0)
                stopList.Items.Remove(stopList.SelectedItems[0]);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (nameStop == null && timeStop == null)
            {
                nameStop = new List<string>();
                timeStop = new List<string>();
                foreach (ListViewItem item in stopList.Items)
                {
                    DateTime stopTime = DateTime.Parse(item.SubItems[1].Text);
                    DateTime fromTime = timeFromDateTimePicker.Value;
                    DateTime toTime = timeToDateTimePicker.Value;
                    DateTime fromDateTime = dateFromDateTimePicker.Value.Date;
                    DateTime toDateTime = dateToDateTimePicker.Value.Date;
                    if ((stopTime < fromTime || stopTime > toTime) && fromDateTime == 
                        toDateTime || fromDateTime != toDateTime && stopTime < 
                        fromTime && stopTime > toTime)
                    {
                        MessageBox.Show("Час зупинок має бути після відправлення та до прибуття.", 
                            "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nameStop = null;
                        timeStop = null;
                        return;
                    }
                }

                foreach (ListViewItem item in stopList.Items)
                {
                    nameStop.Add(item.SubItems[0].Text);
                    timeStop.Add(item.SubItems[1].Text);
                }
            }

            string number = numberRouteTextBox.Text;
            string fromName = fromTextBox.Text.ToLower();
            string toName = toTextBox.Text.ToLower();
            DateTime dateTimeFrom = dateFromDateTimePicker.Value.Date;
            string timeFrom = timeFromDateTimePicker.Value.ToString("HH:mm");
            DateTime dateTimeTo = dateToDateTimePicker.Value.Date;
            string timeTo = timeToDateTimePicker.Value.ToString("HH:mm");
            List<string>? stops = nameStop!;
            List<string>? timeStops = timeStop;
            decimal freeSeats = freeSeatNumeric.Value;
            string price = priceTextBox.Text;

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(fromName) ||
                string.IsNullOrEmpty(toName) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Введіть усі необхідні дані.", "Збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dateTimeFrom > dateTimeTo || (timeFromDateTimePicker.Value > 
                timeToDateTimePicker.Value && dateTimeFrom == dateTimeTo))
            {
                MessageBox.Show("Дата та час прибуття мають бути пізніше за відправлення.", 
                    "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int repeat = 0;

            for (int i = 0; i < routeList.Count; i++)
            {
                if (routeList[i].Number == number && routeList[i].Number != selected)
                {
                    repeat++;
                }

                if (repeat == 0 && i == routeList.Count - 1 && stops != null && timeStop != null)
                {
                    RouteData newRoute = new RouteData(number, fromName, toName,
                    dateTimeFrom, timeFrom, dateTimeTo, timeTo, stops, timeStop,
                    freeSeats, price);

                    for (int j = 0; j < routeList.Count; j++)
                    {
                        if (routeList[j].Number == selected && selected != null)
                        {
                            routeList.RemoveAt(j);
                        }
                    }

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

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && 
                e.KeyChar != '\b' && e.KeyChar != '\u007F')
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
