using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karbantartasAdmin
{
    class DataTransferClass
    {
        #region //REGION: REST keresek (get, post, put, delete)
        public RestClient getClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.GET);
            //rClient.httpMethod = httpVerb.GET;
            //rClient.endPoint = url;
            return rClient;
        }
        public RestClient postClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.POST);
            //rClient.httpMethod = httpVerb.POST;
            //rClient.endPoint = url;
            return rClient;
        }
        public RestClient putClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.PUT);
            //rClient.httpMethod = httpVerb.PUT;
            //rClient.endPoint = url;
            return rClient;
        }
        public RestClient deleteClient(string url)
        {
            RestClient rClient = new RestClient(url, httpVerb.DELETE);
            // rClient.httpMethod = httpVerb.DELETE;
            // rClient.endPoint = url;
            return rClient;
        }
        #endregion
        // return raw JSON data from REST server

        // return JSON data from REST server as DataTable

    }
}
