using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace karbantartasAdmin
{
    class DataTransferClass
    {

        public String restMethod;
        public String uri;


        //constructor

        public DataTransferClass(String restMethod, String uri)
        {
            this.restMethod = restMethod;
            this.uri = uri;

        }

        public void ReturnSkalar()
        {
            //egy bizonyos erteked ad vissza, pl szam, string, char stb...
        }

        public String GetList()
        {

            if (ServerDataStore.authUser)
            {
                var req = WebRequest.Create(ServerDataStore.url + uri);
                req.Method = restMethod;
                var resp = req.GetResponse().ToString();

                return resp;
            }
            else
            {
                return "Nincs bejelentkezve!";
            }

        }







    }
}
