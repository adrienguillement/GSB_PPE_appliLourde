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
    public class MemberBuild
    {
        protected string _table;

        private string pathAPI = ConfigurationManager.AppSettings.Get("path_API");

        public MemberBuild()
        {
            this._table = "member";
        }

        public List<Member> findAll()
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/all");
            List<Member> listClass = JsonConvert.DeserializeObject<List<Member>>(getJson);
            return listClass;
        }

        public Member findOne(String id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/" + id);
            List<Member> listClass = JsonConvert.DeserializeObject<List<Member>>(getJson);
            return listClass[0];
        }

        public TextResult addOne(String last_name, String first_name, String address, String recrutementDate, String departement_id, String member_id)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/add/"+last_name+"/"+first_name+"/"+ address + "/"+ recrutementDate + "/"+ departement_id + "/"+ member_id);
            TextResult result = JsonConvert.DeserializeObject<TextResult>(getJson);

            return result;
        }

        //member can connect
        public List<Member> connect(string mail, string pwd)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(pathAPI + this._table + "/connexion/" + mail + "/" + pwd);
            List<Member> listClass = JsonConvert.DeserializeObject<List<Member>>(getJson);

            return listClass;
        }
    }
}
