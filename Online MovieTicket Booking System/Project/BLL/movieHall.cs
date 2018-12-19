using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DLL;

namespace Project.BLL
{
    public class movieHall
    {
        public int id { get; set; }
        public int hallid { get; set; }
        public int slot_1 { get; set; }
        public int slot_2 { get; set; }
        public int slot_3 { get; set; }
        public DateTime movieDate { get; set; }

        movieHall t2;
        MovieDataaccess mda = new MovieDataaccess();

        public List<movieHall> GetMovieHall()
        {
            var Movie = mda.GetAllMovieHall();
            List<movieHall> movieHalllist = new List<movieHall>();
            for (int i = 0; i < Movie.Rows.Count; i++)
            {
                t2 = new movieHall();
                t2.id = int.Parse(Movie.Rows[i][0].ToString());
                t2.hallid = int.Parse(Movie.Rows[i][1].ToString());
                t2.slot_1 = int.Parse(Movie.Rows[i][2].ToString());
                t2.slot_2 = int.Parse(Movie.Rows[i][3].ToString());
                t2.slot_3 = int.Parse(Movie.Rows[i][4].ToString());
                t2.movieDate = Convert.ToDateTime(Movie.Rows[i][5]);

                //t.startDate =Convert.ToDateTime( Movie.Rows[i][7]);
                //t.endDate =Convert.ToDateTime( Movie.Rows[i][8]);

                movieHalllist.Add(t2);
            }
            return movieHalllist;
        }

        public List<movieHall> GetMovieByDate(DateTime date)
        {
            var Movie = mda.GetAllMovieDates(date);
            List<movieHall> movieHalllist = new List<movieHall>();
            for (int i = 0; i < Movie.Rows.Count; i++)
            {
                t2 = new movieHall();
                t2.id = int.Parse(Movie.Rows[i][0].ToString());
                t2.hallid = int.Parse(Movie.Rows[i][1].ToString());
                t2.slot_1 = int.Parse(Movie.Rows[i][2].ToString());
                t2.slot_2 = int.Parse(Movie.Rows[i][3].ToString());
                t2.slot_3 = int.Parse(Movie.Rows[i][4].ToString());
                t2.movieDate = Convert.ToDateTime(Movie.Rows[i][5]);

                //t.startDate =Convert.ToDateTime( Movie.Rows[i][7]);
                //t.endDate =Convert.ToDateTime( Movie.Rows[i][8]);

                movieHalllist.Add(t2);
            }
            return movieHalllist;
        }
        public List<string> GetSeats(int slot,DateTime date)
        {
            string sit = "";
            var seats = mda.GetHallSeats(slot,date);
            List<string> sitList = new List<string>();
            for (int i = 0; i < seats.Rows.Count; i++)
            {
                sit = seats.Rows[i][0].ToString();
                sitList.Add(sit);
            }
            return sitList;
        }


        public bool insertSchedule(movieHall m)
        {
            
            bool a;

            a = mda.dbInsertSchedule(m.hallid,m.slot_1,m.slot_2,m.slot_3,m.movieDate);
         

            if (a == true)
            {
                return true;
            }
            else
            {
                return false;

            }
           
           
          
        }



        public bool confirmTicket(int i, int movieId, int hallId, int slot, DateTime movieDate, string seatNo)
        {


            bool a;

            a = mda.confTicket(i, movieId, hallId, slot, movieDate, seatNo);


            if (a == true)
            {
                return true;
            }
            else
            {
                return false;

            }
            


        }

        public bool cancleTicket(int i, int movieId, int hallId, int slot, DateTime movieDate, string seatNo)
        {
            return mda.cancleTicket(i, movieId, hallId, slot, movieDate, seatNo);
        }

    }
}
