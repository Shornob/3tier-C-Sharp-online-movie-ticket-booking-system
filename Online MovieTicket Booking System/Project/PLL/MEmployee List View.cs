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
    public partial class MEmployee_List : MetroFramework.Forms.MetroForm
    {
        public MEmployee_List()
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

        private void MEmployee_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
