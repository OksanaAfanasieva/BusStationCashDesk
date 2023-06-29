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
        public InformationRoute()
        {
            InitializeComponent();
        }

        private void InformationRoute_Load(object sender, EventArgs e)
        {
            timePickerFrom.CustomFormat = "HH:mm";
            timePickerTo.CustomFormat = "HH:mm";
        }

        private void labelFreePlace_Click(object sender, EventArgs e)
        {

        }
    }
}
