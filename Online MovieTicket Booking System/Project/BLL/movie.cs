using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DLL;

namespace Project.BLL
{
    public class movie
    {
        public int movieId { get; set; }
        public String movieName { get; set; }
        public String actor { get; set; }
        public String director { get; set; }
        public String genre { get; set; }
        public String imdb { get; set; }
        public DateTime releaseDate { get; set; }
        public String movieDescription { get; set; }
        
        MovieDataaccess mda = new MovieDataaccess();
        movie t;
        movie s;

        public List<movie> GetAllMovie()
        {
            var Movie = mda.GetAllMovies();
            List<movie> list = new List<movie>();
            for (int i = 0; i < Movie.Rows.Count; i++)
            {
                t = new movie();
                t.movieId = int.Parse(Movie.Rows[i][0].ToString());
                t.movieName = Movie.Rows[i][1].ToString();
                t.actor = Movie.Rows[i][2].ToString();
                t.director = Movie.Rows[i][3].ToString();
                t.genre = Movie.Rows[i][4].ToString();
                t.imdb = Movie.Rows[i][5].ToString();
                t.releaseDate = Convert.ToDateTime(Movie.Rows[i][6]);
                t.movieDescription = Movie.Rows[i][7].ToString();
                
                //t.startDate =Convert.ToDateTime( Movie.Rows[i][7]);
                //t.endDate =Convert.ToDateTime( Movie.Rows[i][8]);
               
                list.Add(t);
            }
            return list;
        }

        public List<movie> GetAllMovieName()
        {
            var Movie = mda.GetAllMovieNames();
            List<movie> nameList = new List<movie>();
            for (int i = 0; i < Movie.Rows.Count; i++)
            {
                t = new movie();
                t.movieId = int.Parse(Movie.Rows[i][0].ToString());
                t.movieName = Movie.Rows[i][1].ToString();

                nameList.Add(t);
            }
            return nameList;
        }

        public bool insertMovie(String a, String b, String c, String d, String e, DateTime f,  String g)
        {

         bool x=   mda.insertMovieIntoDB(a,b,c,d,e,f,g);
            if(x)
            {
                return true;
            }
            else { return false; }
        }
        

        public string GetMovieName(int id)
        {
            //string x = mda.getMovieName(id);
            var Movie = mda.getMovieName(id);

            t = new movie();
        //    t.movieId = int.Parse(Movie.Rows[0][0].ToString());
            t.movieName = Movie.Rows[0][0].ToString();

            return t.movieName;
        }

        public bool DeleteMovie(int id)
        {
            return mda.Delete(id);
        }
        
        public bool UpdateMovie(int i,String a, String b, String c, String d, String e, DateTime f, String g)
        {

            bool x = mda.updateMovieIntoDB(i,a, b, c, d, e, f, g);
            if (x)
            {
                return true;
            }
            else { return false; }
        }

        public List<movie> searchMovie(String searchText)
        {
            var mov = mda.Search(searchText);
            List<movie> searchList = new List<movie>();
            for (int i = 0; i < mov.Rows.Count; i++)
            {
                s = new movie();
                s.movieId = int.Parse(mov.Rows[i][0].ToString());
                s.movieName = mov.Rows[i][1].ToString();
                s.actor = mov.Rows[i][2].ToString();
                s.director = mov.Rows[i][3].ToString();
                s.genre = mov.Rows[i][4].ToString();
                s.imdb = mov.Rows[i][5].ToString();
                s.releaseDate = Convert.ToDateTime(mov.Rows[i][6]);
                s.movieDescription = mov.Rows[i][7].ToString();
                searchList.Add(s);
            }
            return searchList;
        }
    }
}
