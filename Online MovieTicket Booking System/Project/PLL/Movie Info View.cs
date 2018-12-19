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
    public partial class Movie_Info : MetroFramework.Forms.MetroForm

    {
        employee aa = new employee();
        movie t = new movie();
        public Movie_Info()
        {
            InitializeComponent();
            // comboBoxDate = (DateTime.Now) ;
        }
        public Movie_Info(movie t,employee a)
        {
            InitializeComponent();
            this.t = t;
            aa = a;
            // comboBoxDate = (DateTime.Now) ;
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Seat_Booking sb = new Seat_Booking(aa);
            this.Hide();
            sb.Show();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Ticket_Booking tb = new Ticket_Booking(aa);
            this.Hide();
            tb.Show();
        }

        private void Movie_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Movie_Info_Load(object sender, EventArgs e)
        {
             
            List<DateTime> listDate = new List<DateTime>();
            listDate.Add(DateTime.Today);
            for(int i=1; i<=8; i++)
            {
                listDate.Add(DateTime.Today.AddDays(i));
            }


            comboBoxDate.DataSource = new BindingSource( listDate, null);
            labelMovie.Text = t.movieName;
            labelDirector.Text = t.director;
            labelGenre.Text = t.genre;
            labelActor.Text = t.actor;

        }
    }
}
