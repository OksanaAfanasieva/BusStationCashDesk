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
    public partial class MyTravel : Form
    {
        public MyTravel()
        {
            InitializeComponent();
        }

        private void MyTravel_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void MyTravel_Load(object sender, EventArgs e)
        {
            this.FormClosing += MyTravel_FormClosing;
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
            this.Hide();
        }
    }
}
