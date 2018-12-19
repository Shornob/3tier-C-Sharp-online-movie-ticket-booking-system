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
    public partial class Add_Hall : MetroFramework.Forms.MetroForm
    {
        public Add_Hall()
        {
            InitializeComponent();
        }
        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Manager_Home mh = new Manager_Home();
            this.Hide();
            mh.Show();
        }

        private void Add_Hall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
