using BusStationCashDesk.Classes;
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
    public partial class InformationRoute : Form
    {
        private SaveLoadData<RouteData> file;
        private List<RouteData> routeList;
        private string selected;

        public InformationRoute(string number)
        {
            InitializeComponent();
            file = new SaveLoadData<RouteData>("routeData.json");
            routeList = file.Load();
            selected = number;
        }

        private void InformationRoute_Load(object sender, EventArgs e)
        {
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
                    listStop.View = View.Details;

                    for (int j = 0; j < routeList[i].Stops.Count; j++)
                    {
                        ListViewItem item = new ListViewItem(title.ToTitleCase(routeList[i].Stops[j] 
                            ?? string.Empty));
                        item.SubItems.Add(routeList[i].TimeStop[j]);
                        listStop.Items.Add(item);
                    }

                    freePlaceTextBox.Text = (routeList[i].FreeSeats).ToString();
                    priceTextBox.Text = routeList[i].Price;
                }
            }
        }
    }
}
