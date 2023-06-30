using BusStationCashDesk.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    textBoxNumberRoute.Text = routeList[i].Number;
                    textBoxFrom.Text = routeList[i].FromName;
                    textBoxTo.Text = routeList[i].ToName;
                    dateTimePickerFrom.Value = routeList[i].DateTimeFrom;
                    textBoxTimeFrom.Text = routeList[i].TimeFrom;
                    dateTimePickerTo.Value = routeList[i].DateTimeTo;
                    textBoxTimeTo.Text = routeList[i].TimeTo;
                    listViewStop.View = View.Details;

                    for (int j = 0; j < routeList[i].Stops.Count; j++)
                    {
                        ListViewItem item = new ListViewItem(routeList[i].Stops[j]);
                        item.SubItems.Add(routeList[i].TimeStop[j]);
                        listViewStop.Items.Add(item);
                    }

                    textBoxFreePlace.Text = routeList[i].FreeSeats;
                    textBoxPrice.Text = routeList[i].Price;
                }
            }
        }

        private void labelFreePlace_Click(object sender, EventArgs e)
        {
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumberRoute_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
