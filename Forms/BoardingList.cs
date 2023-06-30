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
    public partial class BoardingList : Form
    {
        public BoardingList()
        {
            InitializeComponent();
        }

        private void BoardingList_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void BoardingList_Load(object sender, EventArgs e)
        {
            this.FormClosing += BoardingList_FormClosing;
        }
    }
}
