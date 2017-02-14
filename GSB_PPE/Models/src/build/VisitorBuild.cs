using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Models.src.metiers;

namespace Models.src.build
{
    public class VisitorBuild
    {
        protected string _table;

        public VisitorBuild()
        {
            this._table = "visitor";
        }

        public List<Visitor> findAll()
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString("http://adrienguillement.fr/GSB/" + this._table + "/all");
            List<Visitor> listClass = JsonConvert.DeserializeObject<List<Visitor>>(getJson);
            return listClass;
        }

        public Visitor findOne(int id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString("http://adrienguillement.fr/GSB/" + this._table + "/" + id);
            Visitor listClass = JsonConvert.DeserializeObject<Visitor>(getJson);
            return listClass;
        }
    }
}
