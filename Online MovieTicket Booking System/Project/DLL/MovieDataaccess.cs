using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DLL;
using System.Data.SqlClient;
using System.Data;

namespace Project.DLL
{
    class MovieDataaccess
    {
        SqlConnection con;
        public MovieDataaccess()
        {

            con = new SqlConnection(@"Data Source=TITLY-PC\SQLEXPRESS;Initial Catalog=Central_Cinema;Integrated Security=True;Max Pool Size=50000;Pooling=True");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public DataTable GetAllMovies()
        {
            string query = string.Format("select * from moviesDetail;");

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetHallSeats(int slot,DateTime date)
        {
            string query = string.Format("select seat from ticketTable where slot='{0}' and showDate='{1}';",slot,date);

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetAllMovieDates(DateTime date)
        {
            string sqlFormattedDate = date.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DateTime d = Convert.ToDateTime(sqlFormattedDate);

            string query2 = string.Format("select * from movieHalls Where movieDate>'{0}';",d);

            SqlCommand cmd = new SqlCommand(query2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            con.Close();
            return dt2;
        }
        
        public DataTable GetAllMovieNames()
        {
            string query = string.Format("select movieId, movieName from moviesDetail;");

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
        public DataTable getMovieName(int id)
        {
            con.Close();
            con.Open();
            string query = string.Format("select movieName from moviesDetail where movieId='{0}';",id);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
        public bool insertMovieIntoDB(String a, String b, String c, String d, String e, DateTime f, String g)
        {
            string query = string.Format("insert into moviesDetail(movieNaME, actor, director, genre, imdb, releaseDate, movieDescription) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", a,b,c,d,e,f,g );

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
            con.Close();
            
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetAllMovieHall()
        {
            string query2 = string.Format("select * from movieHalls;");

            SqlCommand cmd = new SqlCommand(query2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            con.Close();
            return dt2;
        }

        public bool dbInsertSchedule(int hallid,int s1,int s2,int s3,DateTime d)
        {

            string query = string.Format("insert into movieHalls(hall_id, slot_1, slot_2, slot_3, movieDate) values('{0}','{1}','{2}','{3}','{4}')", hallid, s1, s2, s3, d);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }

        public bool confTicket(int i, int movieId, int hallId, int slot, DateTime movieDate, string seatNo)
        {
            con.Close();
            con.Open();
            string query = string.Format("insert into ticketTable(movieId, hall_id, slot, showDate, seat) values('{0}','{1}','{2}','{3}','{4}')", movieId, hallId, slot, movieDate, seatNo);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            con.Close();
            con.Open();
            string query = string.Format("DELETE FROM moviesDetail WHERE movieId={0} ", id);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }
        
        public bool updateMovieIntoDB(int i, String a, String b, String c, String d, String e, DateTime f, String g)
        {
            con.Close();
            con.Open();
          //  string query = string.Format("UPDATE employeesContact SET email='{0}',address='{1}',mobileNo='{2}' WHERE employeeId='{3}' ", a,b,c,d,e,f,g, i);
            string query = string.Format("UPDATE moviesDetail SET   movieNaME='{0}', actor='{1}', director='{2}', genre='{3}', imdb='{4}', releaseDate='{5}', movieDescription='{6}' WHERE movieId='{7}'", a, b, c, d, e, f, g, i);
           
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool cancleTicket(int i, int movieId, int hallId, int slot, DateTime movieDate, string seatNo)
        {
            con.Close();
            con.Open();
            string query = string.Format("DELETE from ticketTable where movieId='{0}' and hall_id ='{1}' and slot='{2}' and showDate='{3}' and seat='{4}'; ", movieId, hallId, slot, movieDate, seatNo);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }

        public DataTable GetAllSellHistory()
        {
            string query = string.Format("select movieId, hall_id, slot, showDate, seat from ticketTable;");

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable Search(String searchText)
        {
            string query = string.Format("select * from moviesDetail where moviesDetail.movieName like '%{0}%'", searchText);

            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            return dt1;
        }
    }
}
