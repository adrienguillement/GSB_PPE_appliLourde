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
    public class VisitorBuild
    {
        protected string _table;
        private string pathAPI = ConfigurationManager.AppSettings.Get("path_API");

        public VisitorBuild()
        {
            this._table = "visitor";
        }

        public List<Visitor> findAll()
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/all");
            List<Visitor> listClass = JsonConvert.DeserializeObject<List<Visitor>>(getJson);
            return listClass;
        }

        public Visitor findOne(String id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/" + id);
            List<Visitor> listClass = JsonConvert.DeserializeObject<List<Visitor>>(getJson);
            return listClass[0];
        }

        public TextResult addOne(String last_name, String first_name, String address, String recrutementDate, String departement_id, String member_id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/add/"+last_name+"/"+first_name+"/"+ address + "/"+ recrutementDate + "/"+ departement_id + "/"+ member_id);
            TextResult result = JsonConvert.DeserializeObject<TextResult>(getJson);

            return result;
        }

        public TextResult delete(int visitor_id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI  + this._table + "/delete/" + visitor_id);
            TextResult result = JsonConvert.DeserializeObject<TextResult>(getJson);
            return result;
        }

        public TextResult update(string id, string lastname, string firstname, string address, string recrutementDate, string departement_id, string member_id)
        {
            address = address.Replace("\n", "");
            WebClient client = new WebClient();
            string getJson = client.DownloadString("http://adrienguillement.fr/GSB/" + this._table + "/update/" + id + "/"+ lastname +"/"+ firstname +"/"+address+"/"+recrutementDate+"/"+departement_id+"/"+member_id);
            TextResult result = JsonConvert.DeserializeObject<TextResult>(getJson);
            return result;
        }
    }
}
