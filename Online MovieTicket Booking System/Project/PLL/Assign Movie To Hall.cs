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
    public partial class AssignMovieToHall : MetroFramework.Forms.MetroForm
    {
        movieHall mh = new movieHall();
        movie t = new movie();
        movieHall t2 = new movieHall();

        employee aa = new employee();
        DateTime mviDate = new DateTime();
        int slot = 0;
        int empOrMan = 0;


        public AssignMovieToHall(int i,employee a)
        {
            InitializeComponent();
            aa = a;
            empOrMan = i;
            dataGridViewMovieInfo.DataSource = t.GetAllMovie();

            dataGridViewMovieInfo.Columns[2].Visible = false;
            dataGridViewMovieInfo.Columns[3].Visible = false;
            dataGridViewMovieInfo.Columns[4].Visible = false;
            dataGridViewMovieInfo.Columns[5].Visible = false;
            dataGridViewMovieInfo.Columns[6].Visible = false;
            dataGridViewMovieInfo.Columns[7].Visible = false;

            dataGridViewMovieHallInfo.DataSource = t2.GetMovieHall();

            if(i==3)
            {
                assignHall_button.Text = "Book Seat";
                setSlottime.Enabled = false;
                setHallIdTxt.Enabled = false;
                setMovieIdtxt.Enabled = false;

                dataGridViewMovieHallInfo.DataSource = t2.GetMovieByDate(setMovieDate.Value.Date);

            }
            else { }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void assignHall_Click(object sender, EventArgs e)
        {
        }

        private void setMovieId_Click(object sender, EventArgs e)
        {

        }
        

        private void AssignMovieToHall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void setMovieDate_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewMovieHallInfo.DataSource = t2.GetMovieByDate(setMovieDate.Value.Date);
            MessageBox.Show(setMovieDate.Value.ToString());
        }

        private void dataGridViewMovieHallInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (empOrMan == 3)
            {
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    mviDate = Convert.ToDateTime(dataGridViewMovieHallInfo.Rows[e.RowIndex].Cells[5].Value.ToString());
                    //metroLabel2.Text = dataGridViewMovieHallInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
                    int movieId = int.Parse(dataGridViewMovieHallInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    mh.hallid = int.Parse(dataGridViewMovieHallInfo.Rows[e.RowIndex].Cells[1].Value.ToString());

                    setHallIdTxt.Text = mh.hallid.ToString();
                    setMovieIdtxt.Text = movieId.ToString();

                    if (e.ColumnIndex == 2)
                    {
                        slot = 1;
                        setSlottime.Text = "11-2";
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        slot = 2;
                        setSlottime.Text = "2-5";
                    }
                    else if (e.ColumnIndex == 4)
                    {
                        slot = 3;
                        setSlottime.Text = "5-8";
                    }
                    else {
                        slot = 0;
                    }

                }

            }
            else { }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (empOrMan == 4)
            {
                Schedule_Manager_Home smg = new Schedule_Manager_Home(aa);
                this.Hide();
                smg.Show();
            }
            else
            {
                Employee_Home eh = new Employee_Home(aa);
                this.Hide();
                eh.Show();
            }
        }

        private void assignHall_button_Click(object sender, EventArgs e)
        {


            mh.movieDate = setMovieDate.Value;
            mh.hallid = int.Parse(setHallIdTxt.Text);


            if (setSlottime.Text.Equals("11-2"))
            {
                mh.slot_1 = int.Parse(setMovieIdtxt.Text);
                slot = 1;
            }
            else if (setSlottime.Text.Equals("2-5"))
            {
                slot = 2;
                mh.slot_2 = int.Parse(setMovieIdtxt.Text);
            }
            else if (setSlottime.Text.Equals("5-8"))
            {
                slot = 3;
                mh.slot_3 = int.Parse(setMovieIdtxt.Text);
            }
            else { MessageBox.Show("Please Select Time"); }
            if (slot != 0)
            {
                if (assignHall_button.Text.Equals("Assign Hall"))
                {
                    bool x = mh.insertSchedule(mh);

                    if (x == true)
                    {
                        MessageBox.Show("Movie Added to Schedule");
                        dataGridViewMovieHallInfo.DataSource = t2.GetMovieHall();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
                    }

                }
                else
                {
                    int x = int.Parse(setMovieIdtxt.Text);
                    if (x != 0)
                    {
                        Seat_Booking sb = new Seat_Booking(aa, 3, int.Parse(setMovieIdtxt.Text), mh.hallid, slot, mviDate, "x");
                        this.Hide();
                        sb.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Movie");

                    }
                }
            }
            else { }

        }
    }
}
