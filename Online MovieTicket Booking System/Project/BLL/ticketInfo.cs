using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DLL;

namespace Project.BLL
{
    public class ticketInfo
    {
        public String movieId { get; set; }
        public String hallId { get; set; }
        public String slot { get; set; }
        public DateTime showDate { get; set; }
        public String seat { get; set; }

        MovieDataaccess da = new MovieDataaccess();
        ticketInfo t;

        public List<ticketInfo> sellHistory()
        {
            var sells = da.GetAllSellHistory();
            List<ticketInfo> list = new List<ticketInfo>();
            for (int i = 0; i < sells.Rows.Count; i++)
            {
                t = new ticketInfo();
                t.movieId = sells.Rows[i][0].ToString();
                t.hallId = sells.Rows[i][1].ToString();
                t.slot = sells.Rows[i][2].ToString();
                t.showDate = Convert.ToDateTime(sells.Rows[i][3]);
                t.seat = sells.Rows[i][4].ToString();
                
                list.Add(t);
            }
            return list;
        }
    }
}
