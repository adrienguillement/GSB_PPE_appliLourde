using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Models.src.metiers;
using Models.src.build;

namespace Models.src.build
{
    public class ExpenseReportBuild
    {
        protected string _table;

        public ExpenseReportBuild()
        {
            this._table = "expensereport";
        }

        public List<ExpenseReport> findAll()
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString("http://adrienguillement.fr/GSB/" + this._table + "/all");
            List<ExpenseReport> listClass = JsonConvert.DeserializeObject<List<ExpenseReport>>(getJson);
            return listClass;
        }
    }
}
