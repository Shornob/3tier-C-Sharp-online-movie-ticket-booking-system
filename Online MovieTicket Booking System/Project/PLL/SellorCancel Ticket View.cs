using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingSystem.PLL
{
    public partial class SellorCancel_Ticket : MetroFramework.Forms.MetroForm
    {
        public SellorCancel_Ticket()
        {
            InitializeComponent();
        }

        private void SellorCancel_Ticket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Employee_Home eh = new Employee_Home();
            this.Hide();
            eh.Show();

        }

        private void Book_Ticket_button_Click(object sender, EventArgs e)
        {
            
        }

        private void SellorCancel_Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
