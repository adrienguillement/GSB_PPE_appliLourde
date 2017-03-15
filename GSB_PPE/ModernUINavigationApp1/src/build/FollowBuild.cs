using Models.src.build;
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
    class FollowBuild
    {
        protected string _table;
        private string pathAPI = ConfigurationManager.AppSettings.Get("path_API");

        public FollowBuild()
        {
            this._table = "follow";
        }

        public TextResult update(string id, string expense_report_id, string situation_id)
        {
            var date = DateTime.Now.ToString("yyyy-M-d");
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/update/" + id + "/" + expense_report_id + "/" + situation_id + "/" + date);
            TextResult result = JsonConvert.DeserializeObject<TextResult>(getJson);
            return result;
        }
    }
}
