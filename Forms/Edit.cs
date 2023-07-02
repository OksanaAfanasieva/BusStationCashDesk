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
            dateTimePickerFrom.MinDate = DateTime.Today;
            dateTimePickerTo.MinDate = DateTime.Today;
            file = new SaveLoadData<RouteData>("routeData.json");
            routeList = file.Load();
            selected = number;
        }

        private void Route_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Оновлені дані не будуть збережені! Ви впевнені, що хочете закрити сторінку?", "Попередження",
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
            this.FormClosing += Route_FormClosing;
            timePickerFrom.CustomFormat = "HH:mm";
            timePickerTo.CustomFormat = "HH:mm";
            timePickerStop.CustomFormat = "HH:mm";
            for (int i = 0; i < routeList.Count; i++)
            {
                if (routeList[i].Number == selected && selected != null)
                {
                    TextInfo title = CultureInfo.InvariantCulture.TextInfo;

                    textBoxNumberRoute.Text = routeList[i].Number;
                    textBoxFrom.Text = title.ToTitleCase(routeList[i].FromName ?? string.Empty);
                    textBoxTo.Text = title.ToTitleCase(routeList[i].ToName ?? string.Empty);
                    dateTimePickerFrom.Value = routeList[i].DateTimeFrom;
                    timePickerFrom.Value = DateTime.ParseExact(routeList[i].TimeFrom, "HH:mm", CultureInfo.InvariantCulture);
                    dateTimePickerTo.Value = routeList[i].DateTimeTo;
                    timePickerTo.Value = DateTime.ParseExact(routeList[i].TimeTo, "HH:mm", CultureInfo.InvariantCulture);
                    listViewStop.View = View.Details;

                    for (int j = 0; j < routeList[i].Stops.Count; j++)
                    {
                        ListViewItem item = new ListViewItem(routeList[i].Stops[j]);
                        item.SubItems.Add(routeList[i].TimeStop[j]);
                        listViewStop.Items.Add(item);
                    }

                    numericFreeSeat.Value = routeList[i].FreeSeats;
                    textBoxPrice.Text = routeList[i].Price;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Оновдені дані не будуть збережені! Ви впевнені, що хочете скасувати редагування?", "Попередження",
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
            if (string.IsNullOrEmpty(textBoxNameStop.Text) || string.IsNullOrEmpty(timePickerStop.Text))
            {
                MessageBox.Show("Введіть назву зупинки.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem item = new ListViewItem(textBoxNameStop.Text);
            item.SubItems.Add(timePickerStop.Text);
            listViewStop.Items.Add(item);
            textBoxNameStop.Clear();
        }

        private void buttonRemoveStop_Click(object sender, EventArgs e)
        {
            if (listViewStop.SelectedItems.Count > 0)
                listViewStop.Items.Remove(listViewStop.SelectedItems[0]);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (nameStop == null && timeStop == null)
            {
                nameStop = new List<string>();
                timeStop = new List<string>();
                foreach (ListViewItem item in listViewStop.Items)
                {
                    nameStop.Add(item.SubItems[0].Text);
                    timeStop.Add(item.SubItems[1].Text);
                }
            }

            string number = textBoxNumberRoute.Text;
            string fromName = textBoxFrom.Text.ToLower();
            string toName = textBoxTo.Text.ToLower();
            DateTime dateTimeFrom = dateTimePickerFrom.Value.Date;
            string timeFrom = timePickerFrom.Value.ToString("HH:mm");
            DateTime dateTimeTo = dateTimePickerTo.Value.Date;
            string timeTo = timePickerTo.Value.ToString("HH:mm");
            List<string>? stops = nameStop;
            List<string>? timeStops = timeStop;
            decimal freeSeats = numericFreeSeat.Value;
            string price = textBoxPrice.Text;

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(fromName) ||
                string.IsNullOrEmpty(toName) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Введіть усі необхідні дані.", "Помилка збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
