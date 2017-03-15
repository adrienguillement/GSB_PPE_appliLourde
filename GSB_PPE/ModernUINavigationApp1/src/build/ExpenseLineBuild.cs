using ModernUINavigationApp1.src.metiers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModernUINavigationApp1.src.build
{
    class ExpenseLineBuild
    {
        protected string _table;

        public ExpenseLineBuild()
        {
            this._table = "expenseline";
        }

        public List<ExpenseLine> findOne(string expenseReport_id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString("http://adrienguillement.fr/GSB/" + this._table + "/oneReport/" + expenseReport_id);
            List<ExpenseLine> listClass = JsonConvert.DeserializeObject<List<ExpenseLine>>(getJson);
            return listClass;
        }
    }
}
