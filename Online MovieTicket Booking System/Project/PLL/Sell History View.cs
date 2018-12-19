using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BLL;

namespace MovieTicketBookingSystem.PLL
{
    public partial class Sell_History : MetroFramework.Forms.MetroForm
    {
        employee a = new employee();
        ticketInfo t = new ticketInfo();

        public Sell_History(employee aa)
        {
            InitializeComponent();
            a = aa;

            SellHistorydataGridView.DataSource = t.sellHistory();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            if (a.role.Equals("2"))
            {
                Manager_Home ah = new Manager_Home(a);
                this.Hide();
                ah.Show();
            }
            else
            {
                FormAdminHome fah = new FormAdminHome(a);
                this.Hide();
                fah.Show();
            }
        }

        private void Sell_History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Sell_History_Load(object sender, EventArgs e)
        {

        }
    }
}
