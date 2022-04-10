using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace karbantartasAdmin
{
    class DataTransferClass
    {
        JObject userLogedIn = new JObject(); //todo: static classra kell majd atalakitani
        #region //REGION: REST keresek (get, post, put, delete)
        public RestClient getClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.GET);
            return rClient;
        }
        public RestClient postClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.POST);
            return rClient;
        }
        public RestClient putClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.PUT);
            return rClient;
        }
        public RestClient deleteClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.DELETE);
            return rClient;
        }
        #endregion
        //todo: adatbazis lekerdezeket is innen kell majd megkapnia, kulon fuggvenybol
        public List<JObject> queryFromDB(RestClient kliens)
        {
            List<JObject> queryList = new List<JObject>();
            JArray jArray = new JArray();
            jArray.RemoveAll();
            string strResponse = string.Empty;
            strResponse = kliens.makeRequest(userLogedIn);
            jArray = JArray.Parse(strResponse);
            foreach (JObject jObject in jArray)
            {
                System.Diagnostics.Debug.WriteLine(jObject.ToString());
                queryList.Add(jObject);
            }
            return queryList;
        }

    }
}
