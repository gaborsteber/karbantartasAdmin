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
    public partial class Assets : Form
    {
        JObject userLogedIn = new JObject();
        List<JObject> responseOfQuery = new List<JObject>();
        JObject assetDeleteFromDb = new JObject();
        List<JObject> responseOfDeleteQuery = new List<JObject>();
        JObject assetEditToDb = new JObject();
        List<JObject> responseOfEditQuery = new List<JObject>();
        public Assets(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
            RestClient rClient = getClient("https://localhost:44336/api/assets");
            responseOfDeleteQuery = queryFromDB(rClient);
            fillDelLists(responseOfDeleteQuery);
            responseOfEditQuery = queryFromDB(rClient);
            fillEditLists(responseOfEditQuery);
        }

        private void queryAllAssets_Click(object sender, EventArgs e)
        {
            responseOfQuery.Clear();
            queryListBox.Items.Clear();

            RestClient rClient = getClient("https://localhost:44336/api/assets");
            responseOfQuery = queryFromDB(rClient);
            fillQueryListBox(responseOfQuery);
        }
        
        private void queryAssetButton_Click(object sender, EventArgs e)
        {
            responseOfQuery.Clear();
            queryListBox.Items.Clear();
            if (assetsIdTxtBox.Text != "")
            {
                RestClient rClient = getClient("https://localhost:44336/api/assets/" + Int32.Parse(assetsIdTxtBox.Text));
                string strResponse = string.Empty;
                strResponse = rClient.makeRequest(userLogedIn);
                JObject jObject1 = JObject.Parse(strResponse);
                string listElement = "Azonosító: " + jObject1.GetValue("id").ToString() + " -  Neve: " + jObject1.GetValue("name").ToString() + " - Helye: " + jObject1.GetValue("location").ToString();
                queryListBox.Items.Add(listElement);
            }
        }
        
        private void deleteAssetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            assetDeleteFromDb.Remove("id");
            assetDeleteFromDb.Add("id", responseOfDeleteQuery[deleteAssetComboBox.SelectedIndex].GetValue("id"));
        }
        
        private void deleteAssetButton_Click(object sender, EventArgs e)
        {
            RestClient rClient = deleteClient("https://localhost:44336/api/assets/" + Int32.Parse(assetDeleteFromDb.GetValue("id").ToString()));
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(userLogedIn);
            System.Diagnostics.Debug.WriteLine(strResponse);
            assetDeleteFromDb.RemoveAll();
            deleteAssetComboBox.Items.Clear();
            
            rClient = getClient("https://localhost:44336/api/assets");
            responseOfDeleteQuery = queryFromDB(rClient);
            fillDelLists(responseOfDeleteQuery);
        }

        //-------------------------------------------------------------------------------------------------------------------------
        private void fillQueryListBox(List<JObject> list)
        {
            foreach (JObject jObject1 in responseOfQuery)
            {
                string listElement = "Azonosító: " + jObject1.GetValue("id").ToString() + " -  Neve: " + jObject1.GetValue("name").ToString() + " - Helye: " + jObject1.GetValue("location").ToString();
                queryListBox.Items.Add(listElement);
            }
        }
        private void fillDelLists(List<JObject> list)
        {
            foreach (JObject jObject1 in responseOfDeleteQuery)
            {
                string listElement = jObject1.GetValue("name").ToString();
                deleteAssetComboBox.Items.Add(listElement);
            }
        }
        private void fillEditLists(List<JObject> list)
        {
            foreach (JObject jObject1 in responseOfEditQuery)
            {
                string listElement = jObject1.GetValue("name").ToString();
                assetForEditComboBox.Items.Add(listElement);
            }
        }

        private RestClient getClient(string url)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = url;
            return rClient;
        }
        private RestClient postClient(string url)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.POST;
            rClient.endPoint = url;
            return rClient;
        }
        private RestClient putClient(string url)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.PUT;
            rClient.endPoint = url;
            return rClient;
        }
        private RestClient deleteClient(string url)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.DELETE;
            rClient.endPoint = url;
            return rClient;
        }

        private List<JObject> queryFromDB(RestClient kliens)
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
