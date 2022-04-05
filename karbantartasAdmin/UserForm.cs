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
        List<JObject> responseOfEditQuery = new List<JObject>();
        List<JObject> responseOfDeleteQuery = new List<JObject>();
        JObject userToDb = new JObject();
        JObject userEditToDb = new JObject();
        JObject userDeleteFromDb = new JObject();
        public UserForm(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
            reloadOtherLists();
            reloadUserLists();
        }

        private void queryAllUser_Click(object sender, EventArgs e)
        {
            responseOfQuery.Clear();
            queryListBox.Items.Clear();
            RestClient rClient = getClient("https://localhost:44336/api/users");
            responseOfQuery = queryFromDB(rClient);
            fillQueryListBox(responseOfQuery);                 
        }      

        private void queryUserButton_Click(object sender, EventArgs e)
        {
            responseOfQuery.Clear();
            queryListBox.Items.Clear();
            if (userIdTxtBox.Text != "")
            {
                RestClient rClient = getClient("https://localhost:44336/api/users/" + Int32.Parse(userIdTxtBox.Text));
                string strResponse = string.Empty;
                strResponse = rClient.makeRequest(userLogedIn);
                JObject jObject1 = JObject.Parse(strResponse);
                string listElement = "Azonosító: " + jObject1.GetValue("id").ToString() + " -  Neve: " + jObject1.GetValue("fullName").ToString() + " - Felhasználónév: " + jObject1.GetValue("username").ToString();
                queryListBox.Items.Add(listElement);
            }
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
            RestClient rClient = postClient("https://localhost:44336/api/users/");
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(userToDb, userLogedIn);
            System.Diagnostics.Debug.WriteLine(userToDb);
            usernameTxtBox.Clear();
            fullNameTxtBox.Clear();
            passTxtBox.Clear();
            reloadUserLists();
        }

        private void editUserDataButton_Click(object sender, EventArgs e)
        {
            userEditToDb.Add("id", responseOfEditQuery[userForEditComboBox.SelectedIndex].GetValue("id"));
            userEditToDb.Add("username", userEditUsernameTxtBox.Text);
            userEditToDb.Add("fullName", userForEditComboBox.Text);
            userEditToDb.Add("password", userEditPassTxtBox.Text);
            userEditToDb.Add("token", null);
            
            RestClient rClient = putClient("https://localhost:44336/api/users/" + Int32.Parse(userEditToDb.GetValue("id").ToString()));
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(userEditToDb, userLogedIn);
            userEditToDb.RemoveAll();
            reloadUserLists();
        }

        private void editUserRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userEditToDb.Remove("roleId");
            userEditToDb.Add("roleId", responseOfRolesQuery[editUserRoleComboBox.SelectedIndex].GetValue("id"));
        }

        private void editUserOccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userEditToDb.Remove("occupationId");
            userEditToDb.Add("occupationId", responseOfOccQuery[editUserOccComboBox.SelectedIndex].GetValue("id"));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {

            RestClient rClient = deleteClient("https://localhost:44336/api/users/" + Int32.Parse(userDeleteFromDb.GetValue("id").ToString()));
            string strResponse = string.Empty;
            strResponse = rClient.takeRequest(userLogedIn);
            System.Diagnostics.Debug.WriteLine(strResponse);
            userDeleteFromDb.RemoveAll();
            reloadUserLists();

        }

        private void deleteUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userDeleteFromDb.Remove("id");
            userDeleteFromDb.Add("id", responseOfDeleteQuery[deleteUserComboBox.SelectedIndex].GetValue("id"));
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
        private void fillRolesLists(List<JObject> list)
        {
            foreach (JObject jObject1 in list)
            {
                string listElement = jObject1.GetValue("roleName").ToString();
                rolesComboBox.Items.Add(listElement);
                editUserRoleComboBox.Items.Add(listElement);
            }
        }
        private void fillOccLists(List<JObject> list)
        {
            foreach (JObject jObject1 in list)
            {
                string listElement = jObject1.GetValue("occupationName").ToString();
                occComboBox.Items.Add(listElement);
                editUserOccComboBox.Items.Add(listElement);
            }
        }
        private void fillEditLists(List<JObject> list)
        {
            foreach (JObject jObject1 in responseOfEditQuery)
            {
                string listElement = jObject1.GetValue("fullName").ToString();
                userForEditComboBox.Items.Add(listElement);
            }
        }
        private void fillDelLists(List<JObject> list)
        {
            foreach (JObject jObject1 in responseOfDeleteQuery)
            {
                string listElement = jObject1.GetValue("fullName").ToString();
                deleteUserComboBox.Items.Add(listElement);
            }
        }
        private void fillQueryListBox(List<JObject> list)
        {
            foreach (JObject jObject1 in responseOfQuery)
            {
                string listElement = "Azonosító: " + jObject1.GetValue("id").ToString() + " -  Neve: " + jObject1.GetValue("fullName").ToString() + " - Felhasználónév: " + jObject1.GetValue("username").ToString() + " - FoglalkozasId: " + jObject1.GetValue("occupationId");
                queryListBox.Items.Add(listElement);
            }
        }
        private void reloadUserLists()
        {
            userForEditComboBox.Items.Clear();
            deleteUserComboBox.Items.Clear();

            RestClient rClient = getClient("https://localhost:44336/api/users");
            responseOfEditQuery = queryFromDB(rClient);
            fillEditLists(responseOfEditQuery);
            responseOfDeleteQuery = queryFromDB(rClient);
            fillDelLists(responseOfDeleteQuery);
        }
        private void reloadOtherLists()
        {
            occComboBox.Items.Clear();
            rolesComboBox.Items.Clear();
            editUserOccComboBox.Items.Clear();
            editUserRoleComboBox.Items.Clear();
            
            RestClient rClient = getClient("https://localhost:44336/api/roles");
            responseOfRolesQuery = queryFromDB(rClient);
            fillRolesLists(responseOfRolesQuery);

            rClient = getClient("https://localhost:44336/api/occupations");
            responseOfOccQuery = queryFromDB(rClient);
            fillOccLists(responseOfOccQuery);
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


    }

}


/*strResponse = rClient.makeRequest(userLogedIn);
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
               editUserRoleComboBox.Items.Add(listElement);
           }*/

/*
            strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            jArray = JArray.Parse(strResponse);
            foreach (JObject jObject in jArray)
            {
                System.Diagnostics.Debug.WriteLine(jObject.ToString());
                responseOfOccQuery.Add(jObject);
            }
            foreach (JObject jObject1 in responseOfOccQuery)
            {
                string listElement = jObject1.GetValue("occupationName").ToString();
                occComboBox.Items.Add(listElement);
                editUserOccComboBox.Items.Add(listElement);
            }*/

/* JArray jArray = new JArray();
            jArray.RemoveAll();
strResponse = string.Empty;
strResponse = rClient.makeRequest(userLogedIn);
jArray = JArray.Parse(strResponse);
foreach (JObject jObject in jArray)
{
   System.Diagnostics.Debug.WriteLine(jObject.ToString());
   responseOfEditQuery.Add(jObject);
}
foreach (JObject jObject1 in responseOfEditQuery)
{
   string listElement = jObject1.GetValue("fullName").ToString();
   userForEditComboBox.Items.Add(listElement);
}*/

/*
            strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            jArray = JArray.Parse(strResponse);
            foreach (JObject jObject in jArray)
            {
                System.Diagnostics.Debug.WriteLine(jObject.ToString());
                responseOfDeleteQuery.Add(jObject);
            }
            foreach (JObject jObject1 in responseOfDeleteQuery)
            {
                string listElement = jObject1.GetValue("fullName").ToString();
                deleteUserComboBox.Items.Add(listElement);
            }*/