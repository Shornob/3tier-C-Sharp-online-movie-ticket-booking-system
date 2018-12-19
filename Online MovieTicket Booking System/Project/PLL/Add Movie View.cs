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
    public partial class Add_Movie : MetroFramework.Forms.MetroForm
    {
        movie m = new movie();
        employee aa = new employee();
        public Add_Movie(employee a)
        {
            InitializeComponent();
            aa = a;
        }

        public Add_Movie(employee a,movie x)
        {
            InitializeComponent();
            aa = a;
            Add_Movie_button.Text = "Update Movie";
            m.movieId = x.movieId;
            textBoxMovieName.Text = x.movieName;
            textBoxActor.Text = x.actor;
            textBoxDirector.Text = x.director;
            textBoxGenre.Text = x.genre;
            textBoxImdb.Text = x.imdb;
            metroReleaseDateTime.Value = x.releaseDate;
            metroTextBoxDescription.Text = x.movieDescription;
        }

        private void Add_Movie_FormClosing(object sender, FormClosingEventArgs e)
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
            Schedule_Manager_Home smg = new Schedule_Manager_Home(aa);
            this.Hide();
            smg.Show();
        }

        private void Add_Movie_button_Click(object sender, EventArgs e)
        {
            //.movieName = textBoxMovieName.Text;
            //m.drector = textBoxDirector.Text;
            //m.imdb = textBoxImdb.Text;
            //m.releaseDate = metroReleaseDateTime.Value;
            if (Add_Movie_button.Text.Equals("Add Movie"))
            {

                bool x = m.insertMovie(textBoxMovieName.Text, textBoxActor.Text, textBoxDirector.Text, textBoxGenre.Text, textBoxImdb.Text, metroReleaseDateTime.Value, metroTextBoxDescription.Text);
                if (x)
                {
                    MessageBox.Show("Movie Added");
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
            else
            {
                bool x = m.UpdateMovie(m.movieId, textBoxMovieName.Text, textBoxActor.Text, textBoxDirector.Text, textBoxGenre.Text, textBoxImdb.Text, metroReleaseDateTime.Value, metroTextBoxDescription.Text);

                if (x)
                {
                    MessageBox.Show("Movie Updated");
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
           textBoxMovieName.Text = textBoxActor.Text = textBoxDirector.Text = textBoxGenre.Text = textBoxImdb.Text = metroTextBoxDescription.Text = string.Empty;
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Movie_Load(object sender, EventArgs e)
        {

        }
    }
}
