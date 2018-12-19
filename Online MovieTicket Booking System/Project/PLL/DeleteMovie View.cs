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
    public partial class Delete_Movie : MetroFramework.Forms.MetroForm
    {
        movie t= new movie();
        movie t1 = new movie();
        movieHall t2 = new movieHall();

        employee aa = new employee();
     
        public Delete_Movie(employee a)
        {
            InitializeComponent();
            aa = a;

            dataGridView1.DataSource = t1.GetAllMovie();

          /*  dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;*/
           

        }

        public void updateGrid()
        {

            dataGridView1.DataSource = t.GetAllMovie();

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
        private void Delete_Movie_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Delete_Movie_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateMovie_Click(object sender, EventArgs e)
        {
            Add_Movie am=new Add_Movie(aa, t);
            this.Hide();
            am.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          t.movieId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            t.movieDescription = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            t.genre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            t.director = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            t.actor = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            t.imdb = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            t.releaseDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            t.movieName= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            selectMovieName.Text = t.movieName;
        }

        private void Edit_Emp_button_Click(object sender, EventArgs e)
        {
          bool x = t.DeleteMovie(t.movieId);
            if (x)
            {
                MessageBox.Show("Movie Deleted");
                updateGrid();
            }

            else { MessageBox.Show(" Error occured"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
