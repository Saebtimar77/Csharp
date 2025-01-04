using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemWinForm
{
    public class Member
    {
        string name;
        string national_code;
        string father_name;
        string membership_model;
        int count;
        int max_count;
        int id;
        Date register_date;

        public Member()
        {
            count = 0;
        }

        public void set_name(string  _name)
        {
            name = _name;
        }
        public string get_name()
        {
            return name;
        }

        public void set_national_code(string _code)
        {
            national_code = _code;
        }
        public string get_national_code()
        {
            return national_code;
        }

        public void set_father_name(string _name)
        {
            father_name = _name;
        }
        public string get_father_name()
        {
            return father_name;
        }

        public void set_membership_model(string _model)
        {
            membership_model = _model;
        }
        public string get_membership_model()
        {
            return membership_model;
        }

        public void set_count(int _count)
        {
            count = _count;
        }
        public int get_count()
        {
            return count;
        }

        public void set_max_count(int _max)
        {
            max_count = _max;
        }
        public int get_max_count()
        {
            return max_count;
        }

        public void set_id(int _id)
        {
            id = _id;
        }
        public int get_id()
        {
            return id;
        }

        public void set_date(Date _date)
        {
            register_date = _date;
        }
        public Date get_date()
        {
            return register_date;
        }

        public string get_info()
        {
            string data = string.Format("{0,-30}{1,-25}{2,-20}{3,-20}{4,-25}{5,-30}{6,-20}\n", name, father_name, national_code, membership_model, Convert.ToString(id),
            Convert.ToString(count), register_date.ToString());

            return data;

        }
    }
}
