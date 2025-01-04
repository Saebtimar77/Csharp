using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemWinForm
{
    public class Book
    {
        string name;
        string writer;
        string subject;
        string publisher;
        int count;
        int code;

        public void set_name(string _name)
        {
            name = _name;
        }
        public string get_name()
        {
            return name;
        }

        public void set_writer(string _writer)
        {
            writer = _writer;
        }
        public string get_writer()
        {
            return writer;
        }

        public void set_subject(string _subject)
        {
            subject = _subject;
        }
        public string get_subject()
        {
            return subject;
        }

        public void set_publisher(string _publisher)
        {
            publisher = _publisher;
        }
        public string get_publisher()
        {
            return publisher;
        }

        public void set_count(int _count)
        {
            count = _count;
        }
        public int get_count()
        {
            return count;
        }

        public void set_code(int _code)
        {
            code = _code;
        }
        public int get_code()
        {
            return code;
        }

        public string get_info()
        {
            string data = string.Format("{0,-40} {1,-35} {2,-25} {3,-35} {4,-25} {5,-25}\n", name , writer , subject , publisher
            , Convert.ToString(code) , Convert.ToString(count));

            return data;
        }

    }

}
