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

        private void Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
