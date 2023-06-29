using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStationCashDesk.Windows_Forms.Warnings
{
    public partial class WarningCancel : Form
    {
        public WarningCancel()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            HomePageAdministration form = new HomePageAdministration();
            form.Show();
            this.Hide();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Route form = new Route();
            form.Show();
            this.Hide();
        }
    }
}
