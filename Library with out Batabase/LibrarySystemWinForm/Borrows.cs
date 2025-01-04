using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemWinForm
{
    public class Borrows
    {
        Member applicant;
        Book book;
        Date borrow_date;
        bool is_back;

        public Borrows()
        {
            is_back = false;
        }
        public void set_applicant(Member _ap)
        {
            applicant = _ap;
        }
        public Member get_applicant()
        {
            return applicant;
        }

        public void set_book(Book _book)
        {
            book = _book;
        }
        public Book get_book()
        {
            return book;
        }

        public void set_date(Date _date)
        {
            borrow_date = _date;
        }
        public Date get_date()
        {
            return borrow_date;
        }

        public void change_status()
        {
            is_back = true;
        }
        public bool get_status()
        {
            return is_back;
        }

        public string get_info()
        {
            string data = string.Format("{0,-35}{1,-35}{2,-35}{3,-35}{4,-25}\n",
            applicant.get_name(), applicant.get_id(), book.get_name(), book.get_code(), borrow_date.ToString());

            return data;
        }
    }
}
