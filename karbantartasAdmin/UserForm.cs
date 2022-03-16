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
    public partial class UserForm : Form
    {
        JObject userLogedIn = new JObject();
        List<JObject> responseOfQuery = new List<JObject>();
        List<JObject> responseOfRolesQuery = new List<JObject>();
        List<JObject> responseOfOccQuery = new List<JObject>();
        JObject userToDb = new JObject();
        public UserForm(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;

            JArray jArray = new JArray();
            jArray.RemoveAll();
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/roles";
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            jArray = JArray.Parse(strResponse);
            foreach (JObject jObject in jArray)
            {
                System.Diagnostics.Debug.WriteLine(jObject.ToString());
                responseOfRolesQuery.Add(jObject);
            }
            foreach (JObject jObject1 in responseOfRolesQuery)
            {
                string listElement = jObject1.GetValue("roleName").ToString();
                rolesComboBox.Items.Add(listElement);
            }

            
            jArray.RemoveAll();
            rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            //JObject jsonResponse = JObject.Parse(strResponse);
            jArray = JArray.Parse(strResponse);
            //System.Diagnostics.Debug.WriteLine(jsonResponse.ToString());
            foreach (JObject jObject in jArray)
            {
                System.Diagnostics.Debug.WriteLine(jObject.ToString());
                responseOfOccQuery.Add(jObject);
            }
            foreach (JObject jObject1 in responseOfOccQuery)
            {
                string listElement = jObject1.GetValue("occupationName").ToString();
                occComboBox.Items.Add(listElement);
            }


        }

        private void queryAllUser_Click(object sender, EventArgs e)
        {
            JArray jArray = new JArray();
            jArray.RemoveAll();
            responseOfQuery.Clear();
            queryListBox.Items.Clear();

            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/users";
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
                string listElement = "Azonosító: " + jObject1.GetValue("id").ToString() + " -  Neve: " + jObject1.GetValue("fullName").ToString() + " - Felhasználónév: " + jObject1.GetValue("username").ToString();
                queryListBox.Items.Add(listElement);
            }

        }

        private void queryUserButton_Click(object sender, EventArgs e)
        {
            responseOfQuery.Clear();
            queryListBox.Items.Clear();
            if (userIdTxtBox.Text != "")
            {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/users/" + Int32.Parse(userIdTxtBox.Text);
            Newtonsoft.Json.Linq.JObject jSONResponse = null;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            JObject jObject1 = JObject.Parse(strResponse);
            string listElement = "Azonosító: " + jObject1.GetValue("id").ToString() + " -  Neve: " + jObject1.GetValue("fullName").ToString() + " - Felhasználónév: " + jObject1.GetValue("username").ToString();
            queryListBox.Items.Add(listElement);
            }
            //responseTxtBox.Text = strResponse;

        }

        private void rolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userToDb.Remove("roleId");
            userToDb.Add("roleId", responseOfRolesQuery[rolesComboBox.SelectedIndex].GetValue("id"));
            System.Diagnostics.Debug.WriteLine(userToDb.GetValue("roleId").ToString());
        }

        private void occComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userToDb.Remove("occupationId");
            userToDb.Add("occupationId", responseOfOccQuery[occComboBox.SelectedIndex].GetValue("id"));
            System.Diagnostics.Debug.WriteLine(userToDb.GetValue("occupationId").ToString());
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            userToDb.Add("username", usernameTxtBox.Text);
            userToDb.Add("fullName", fullNameTxtBox.Text);
            userToDb.Add("password", passTxtBox.Text);
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.POST;
            rClient.endPoint = "https://localhost:44336/api/users";
            Newtonsoft.Json.Linq.JObject jSONResponse = null;
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(userToDb);
            usernameTxtBox.Clear();
            fullNameTxtBox.Clear();
            passTxtBox.Clear();
        }
    }
}
