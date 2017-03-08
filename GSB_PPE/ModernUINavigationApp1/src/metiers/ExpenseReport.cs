using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.src.metiers
{
    public class ExpenseReport
    {
        public string id { get; set; }
        public string month_year { get; set; }
        public string visitor_id { get; set; }
        public string nb_hors_classif { get; set; }
        public string montant_hors_classif { get; set; }
    }
}
