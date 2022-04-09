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
        JObject occToDb = new JObject();
        JObject occEditToDb = new JObject();
        JObject occDeleteFromDb = new JObject();
        List<JObject> responseOfQuery = new List<JObject>();
        List<JObject> responseOfOccQuery = new List<JObject>();
        List<JObject> responseOfDeleteQuery = new List<JObject>();
        public Occupations(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
            
            RestClient rClient = new RestClient();
            rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            responseOfOccQuery = queryFromDB(rClient);
            fillOccLists(responseOfOccQuery);
            responseOfDeleteQuery = queryFromDB(rClient);
            fillDelOccLists(responseOfDeleteQuery);
        }

        private void getAllData_Click(object sender, EventArgs e)
        {
            responseOfQuery.Clear();
            listBox1.Items.Clear();
                        
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            responseOfQuery = queryFromDB(rClient);
            fillListBox(responseOfQuery);
            
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
        private void fillOccLists(List<JObject> list)
        {
            foreach (JObject jObject1 in list)
            {
                string listElement = jObject1.GetValue("occupationName").ToString();
                chooseOccForEditComboBox.Items.Add(listElement);
            }
        }
        private void fillDelOccLists(List<JObject> list)
        {
            foreach (JObject jObject1 in list)
            {
                string listElement = jObject1.GetValue("occupationName").ToString();
                deleteOccComboBox.Items.Add(listElement);
            }
        }
        private void fillListBox(List<JObject> list)
        {
            foreach (JObject jObject1 in responseOfQuery)
            {
                string listElement = "Végzettség azonosító: " + jObject1.GetValue("id").ToString() + " -  megnevezése: " + jObject1.GetValue("occupationName").ToString();
                listBox1.Items.Add(listElement);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void queryOccButton_Click(object sender, EventArgs e)
        {
            responseOfQuery.Clear();
            listBox1.Items.Clear();
            if (occIdTxtBox.Text != "")
            {
                RestClient rClient = new RestClient();
                rClient.httpMethod = httpVerb.GET;
                rClient.endPoint = "https://localhost:44336/api/occupations/" + Int32.Parse(occIdTxtBox.Text);
                Newtonsoft.Json.Linq.JObject jSONResponse = null;
                string strResponse = string.Empty;
                strResponse = rClient.makeRequest(userLogedIn);
                JObject jObject1 = JObject.Parse(strResponse);
                string listElement = "Azonosító: " + jObject1.GetValue("id").ToString() + " -  Megnevezése: " + jObject1.GetValue("occupationName").ToString() + " - leírása: " + jObject1.GetValue("occupationDescrition").ToString();
                listBox1.Items.Add(listElement);
            }
        }

        private void addOccToDbButton_Click(object sender, EventArgs e)
        {
            occToDb.Add("occupationName", newOccTxtBox.Text);
            occToDb.Add("occupationDescrition", newOccDescTxtBox.Text);
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.POST;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(occToDb, userLogedIn);
            
            newOccTxtBox.Clear();
            newOccDescTxtBox.Clear();
            
            deleteOccComboBox.Items.Clear();
            chooseOccForEditComboBox.Items.Clear();

            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            responseOfOccQuery = queryFromDB(rClient);
            fillOccLists(responseOfOccQuery);
            responseOfDeleteQuery = queryFromDB(rClient);
            fillDelOccLists(responseOfDeleteQuery);

        }

        private void editOccButton_Click(object sender, EventArgs e)
        {
            occEditToDb.Add("id", responseOfOccQuery[chooseOccForEditComboBox.SelectedIndex].GetValue("id"));
            occEditToDb.Add("occupationName", editOccNameTxtBox.Text);
            occEditToDb.Add("occupationDescrition", editOccDescTxtBox.Text);
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.PUT;
            rClient.endPoint = "https://localhost:44336/api/occupations/" + Int32.Parse(occEditToDb.GetValue("id").ToString());
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(occEditToDb, userLogedIn);
            System.Diagnostics.Debug.WriteLine(occEditToDb);
            System.Diagnostics.Debug.WriteLine(strResponse);
            occEditToDb.RemoveAll();

            deleteOccComboBox.Items.Clear();
            chooseOccForEditComboBox.Items.Clear();
            
            editOccNameTxtBox.Clear();
            editOccDescTxtBox.Clear();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            responseOfOccQuery = queryFromDB(rClient);
            fillOccLists(responseOfOccQuery);
            responseOfDeleteQuery = queryFromDB(rClient);
            fillDelOccLists(responseOfDeleteQuery);

        }

        private void deleteOccButton_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.DELETE;
            rClient.endPoint = "https://localhost:44336/api/occupations/" + Int32.Parse(occDeleteFromDb.GetValue("id").ToString());
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(userLogedIn);
            System.Diagnostics.Debug.WriteLine(strResponse);
            occDeleteFromDb.RemoveAll();
            
            deleteOccComboBox.Items.Clear();
            chooseOccForEditComboBox.Items.Clear();

            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            responseOfOccQuery = queryFromDB(rClient);
            fillOccLists(responseOfOccQuery);
            responseOfDeleteQuery = queryFromDB(rClient);
            fillDelOccLists(responseOfDeleteQuery);
        }

        private void deleteOccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            occDeleteFromDb.Remove("id");
            occDeleteFromDb.Add("id", responseOfDeleteQuery[deleteOccComboBox.SelectedIndex].GetValue("id"));
        }
    }
}

/*JArray jArray = new JArray();
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
}*/