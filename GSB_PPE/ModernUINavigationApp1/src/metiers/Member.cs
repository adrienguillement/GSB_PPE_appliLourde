using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.src.metiers
{
    public class Member
    {
        public string id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string pass { get; set; }
        public string mail { get; set; }
        public string date_inscription { get; set; }
        public string groupe_id { get; set; }

        public string full_name
        {
            get
            {
                return last_name + " " + first_name;
            }
        }
    }
}
