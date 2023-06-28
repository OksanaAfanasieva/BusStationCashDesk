using BusStationCashDesk.Windows_Forms;

namespace BusStationCashDesk
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Hide();
        }
    }
}