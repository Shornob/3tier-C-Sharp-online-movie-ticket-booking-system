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
    public partial class Seat_Booking : MetroFramework.Forms.MetroForm
    {
        Button[] seats = new Button[31];
        Button b = new Button();
        movieHall mh = new movieHall();
        employee aa = new employee();
        movie mvi = new movie();
        int i; int movieId; int hallId; int slot; DateTime movieDate; string seatNo;

        public Seat_Booking(employee a)
        {
            InitializeComponent();
            aa = a;
          
        }

       // public Seat_Booking(int i, movieHall mh)
        public Seat_Booking(employee a,int i, int movieId, int hallId, int slot, DateTime movieDate, string seatNo)
        {
            InitializeComponent();
            InitializeButtons();
            aa = a;
            this.i = i;
            this.movieId = movieId;
            this.hallId = hallId;
            this.slot = slot;
            this.movieDate = movieDate;
            this.seatNo = seatNo;
            GetSeats();

        }

        private void InitializeButtons()
        {
            seats[1] = b1;
            seats[2] = b2;
            seats[3] = b3;
            seats[4] = b4;
            seats[5] = b5;
            seats[6] = b6;
            seats[7] = b7;
            seats[8] = b8;
            seats[9] = b9;
            seats[10] = b10;
            seats[11] = b11;
            seats[12] = b12;
            seats[13] = b13;
            seats[14] = b14;
            seats[15] = b15;
            seats[16] = b16;
            seats[17] = b17;
            seats[18] = b18;
            seats[19] = b19;
            seats[20] = b20;
            seats[21] = b21;

            seats[22] = b22;
            seats[23] = b23;
            seats[24] = b24;
            seats[25] = b25;
            seats[26] = b26;
            seats[27] = b27;
            seats[28] = b28;
            seats[29] = b29;
            seats[30] = b30;


        }

        private void GetSeats()
        {
            List<string> sitList = new List<string>();
           sitList= mh.GetSeats(slot, movieDate);
            for (int i = 0; i < sitList.Count; i++)
            {
                for (int j = 1; j < 31; j++)
                {
                    if(seats[j].Text.Equals(sitList[i]))
                    {
                        seats[j].BackColor = Color.Red;
                      //  seats[j].Enabled = false;

                    }
                    else { }
                }
            }
        }
        
        private void Logout_button_Click(object sender, EventArgs e)
        {

            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            //  Movie_Info mi = new Movie_Info();
            AssignMovieToHall amh = new AssignMovieToHall(3,aa);
            this.Hide();
            amh.Show();
        }

        private void Seat_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Plati_button8_MouseClick(object sender, MouseEventArgs e)
        {
            
            b = (Button)sender;
            Console.WriteLine("" + label4.Text);
            label5.Text = b.Text;
            this.seatNo = b.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Seat_Booking_Load(object sender, EventArgs e)
        {

        }

        private void confTicket_Click(object sender, EventArgs e)
        {
            if (b.BackColor != Color.Red)
            {

                bool x = mh.confirmTicket(i, movieId, hallId, slot, movieDate, seatNo);

                if (x)
                {
                    b.BackColor = Color.Red;
                    
                    MessageBox.Show("Seat Booked");

                    Print_Ticket pt = new Print_Ticket(aa, movieId, hallId, slot, movieDate, seatNo);
                    this.Hide();
                    pt.Show();
                }
                else { }
            }
            else { MessageBox.Show("Seat Already Booked"); }

        }

        private void seatCancle_Click(object sender, EventArgs e)
        {
            if (b.BackColor == Color.Red)
            {

                bool x = mh.cancleTicket(i, movieId, hallId, slot, movieDate, seatNo);

                if (x)
                {
                    b.BackColor = Color.White;
                    MessageBox.Show("Booking Cancled");

                }
                else { }
            }
            else { MessageBox.Show("Seat Not Booked"); }
        }
    }
}
