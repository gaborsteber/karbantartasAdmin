using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karbantartasAdmin
{
    public partial class Occupations : Form
    {
        JObject userLogedIn = new JObject();
        List<JObject> responseOfQuery = new List<JObject>();
        public Occupations(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
            RestClient rClient = new RestClient();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getAllData_Click(object sender, EventArgs e)
        {
            JArray jArray = new JArray();
            jArray.RemoveAll();
            responseOfQuery.Clear();
            listBox1.Items.Clear();
            
            
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            Newtonsoft.Json.Linq.JObject jSONResponse = null;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            
            jArray = JArray.Parse(strResponse);
            foreach (JObject jObject in jArray)
            {
                System.Diagnostics.Debug.WriteLine(jObject.ToString());
                responseOfQuery.Add(jObject);

            }
            foreach (JObject jObject1 in responseOfQuery)
            {
                string listElement = "Végzettség azonosító: " + jObject1.GetValue("id").ToString() + " -  megnevezése: " + jObject1.GetValue("occupationName").ToString();
                listBox1.Items.Add(listElement);
            }
        }
    }
}
