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
    public class DepartementBuild
    {
        protected string _table;
        private string path_api = ConfigurationManager.AppSettings["path_api"];

        public DepartementBuild()
        {
            this._table = "departement";
        }

        public List<Departement> findAll()
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(path_api + this._table + "/all");
            List<Departement> listClass = JsonConvert.DeserializeObject<List<Departement>>(getJson);
            return listClass;
        }

        public int findOneByName(String name)
        {
            WebClient client = new WebClient();
            string getJson = client.DownloadString(path_api + this._table + "/name/" + name);
            List<Departement> listClass = JsonConvert.DeserializeObject<List<Departement>>(getJson);

            int idDepartment = 0;
            foreach (Departement element in listClass)
            {
                idDepartment = Convert.ToInt32(element.id);
            }
            return idDepartment;
        }
    }
}
