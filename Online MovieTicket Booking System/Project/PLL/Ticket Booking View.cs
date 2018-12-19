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
    public partial class Ticket_Booking : MetroFramework.Forms.MetroForm
    {
        movie t = new movie();
        employee aa = new employee();
        public Ticket_Booking(employee a)
        {
            InitializeComponent();
            aa = a;
            movieListdataGridView.DataSource = t.GetAllMovie();
        }


        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Employee_Home eh = new Employee_Home(aa);
            this.Hide();
            eh.Show();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Movie_Info mi = new Movie_Info(t,aa);
            //mi.getMovieId(t);
            this.Hide();
            mi.Show();
        }

        private void Ticket_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void movieListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            t.movieId = int.Parse(movieListdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            t.movieName = movieListdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            t.director = movieListdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            t.genre = movieListdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            t.actor = movieListdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            //labelMovieId.Text = t.movieId.ToString();

        }

        private void Ticket_Booking_Load(object sender, EventArgs e)
        {

        }

        private void Search_Movie_button_Click(object sender, EventArgs e)
        {
            String ss = "" + textBoxSearch.Text;

            movieListdataGridView.DataSource = t.searchMovie(ss);
        }
    }
}
