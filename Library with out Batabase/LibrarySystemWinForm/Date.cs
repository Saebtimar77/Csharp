using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemWinForm
{
    public class Date
    {
        int year, month, day;

        public Date() { }
        public Date(int y,int m,int d)
        {
            year = y;
            month = m;
            day = d;
        }

        public void set_date(int y,int m,int d)
        {
            year = y;
            month = m;
            day = d;
        }

        public int get_year()
        {
            return year;
        }
        public int get_month()
        {
            return month;
        }
        public int get_day()
        {
            return day;
        }

        public override string ToString()
        {
            return Convert.ToString(year) + '/' + Convert.ToString(month) + '/' + Convert.ToString(day);
        }
    }
}
