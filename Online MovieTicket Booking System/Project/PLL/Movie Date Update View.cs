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
    public partial class Movie_Date_Update : MetroFramework.Forms.MetroForm
    {
        employee aa=new employee();
        public Movie_Date_Update(employee a)
        {
            InitializeComponent();
            aa = a;
        }


        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Schedule_Manager_Home smg = new Schedule_Manager_Home(aa);
            this.Hide();
            smg.Show();
        }

        private void Movie_Date_Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Movie_Date_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
