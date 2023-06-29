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
    public partial class HomePageAdministration : Form
    {
        public HomePageAdministration()
        {
            InitializeComponent();
            dateTimePicker.MinDate = DateTime.Today;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Route form = new Route();
            form.Show();
            this.Hide();
        }

        private void HomePageAdministration_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void HomePageAdministration_Load(object sender, EventArgs e)
        {
            this.FormClosing += HomePageAdministration_FormClosing;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
