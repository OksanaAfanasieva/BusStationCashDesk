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
        private RouteData selectedRoute;

        public InformationRoute(RouteData route)
        {
            InitializeComponent();
            file = new SaveLoadData<RouteData>("routeData.json");
            routeList = file.Load();
            selectedRoute = route;
        }

        private void InformationRoute_Load(object sender, EventArgs e)
        {
            
        }

        private void labelFreePlace_Click(object sender, EventArgs e)
        {
            textBoxNumberRoute.Text = selectedRoute.Number;

        }
    }
}
