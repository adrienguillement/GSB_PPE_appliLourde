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
using System.Configuration;

namespace Models.src.build
{
    public class ExpenseReportBuild
    {
        protected string _table;
        private string pathAPI = ConfigurationManager.AppSettings.Get("path_API");

        public ExpenseReportBuild()
        {
            this._table = "expensereport";
        }

        public List<ExpenseReport> findAll()
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/all");
            List<ExpenseReport> listClass = JsonConvert.DeserializeObject<List<ExpenseReport>>(getJson);
            return listClass;
        }

        public List<ExpenseReport> findByDateVisitor(string dateInput, string visitor_id)
        {
            char[] delimiterChars = { ' ', '/' };
            String[] dateInputParsed = dateInput.Split(delimiterChars);
            string output = dateInputParsed[2] + "-" + dateInputParsed[1];

            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/dateAndVisitor/" + output + "/" +visitor_id);
            List<ExpenseReport> listClass = JsonConvert.DeserializeObject<List<ExpenseReport>>(getJson);
            return listClass;
        }
    }
}
