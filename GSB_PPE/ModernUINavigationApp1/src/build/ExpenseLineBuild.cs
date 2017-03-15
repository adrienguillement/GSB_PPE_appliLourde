using Models.src.build;
using ModernUINavigationApp1.src.metiers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModernUINavigationApp1.src.build
{
    class ExpenseLineBuild
    {
        protected string _table;
        private string pathAPI = ConfigurationManager.AppSettings.Get("path_API");

        public ExpenseLineBuild()
        {
            this._table = "expenseline";
        }

        public List<ExpenseLine> findById(string expenseLine_id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/" + expenseLine_id);
            List<ExpenseLine> listClass = JsonConvert.DeserializeObject<List<ExpenseLine>>(getJson);
            return listClass;
        }

        //return all expenseLine from an expenseReport
        public List<ExpenseLine> findOne(string expenseReport_id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/oneReport/" + expenseReport_id);
            List<ExpenseLine> listClass = JsonConvert.DeserializeObject<List<ExpenseLine>>(getJson);
            return listClass;
        }

        public TextResult update(string id, string type, string name, string expense_date, string amount, string expense_report_id)
        {
            String[] dateInputParsed = expense_date.Split(' ');
            String[] dateInputParse = dateInputParsed[0].Split('/');
            string output = dateInputParse[2] + "-" + dateInputParse[1]+"-"+dateInputParse[0];

            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/update/" + id + "/" + type + "/" + name + "/" + output + "/" + amount + "/" + expense_report_id);
            TextResult result = JsonConvert.DeserializeObject<TextResult>(getJson);
            return result;
        }
    }
}
