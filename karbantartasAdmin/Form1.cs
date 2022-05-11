using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace karbantartasAdmin
{
    public partial class Form1 : Form
    {
        Login user = new Login();
        JObject userLogedIn = new JObject();
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event Handlers;
        private void GET_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            //rClient.endPoint = "https://localhost:44371/api/roles" + text1.Text;
            debugOutput("Rest Client Created");
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();
            debugOutput(strResponse);

        }
        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            user.Username = usernameTxtBox.Text;
            user.Password = passTxtBox.Text;
            userLogedIn.Add("username", usernameTxtBox.Text);
            userLogedIn.Add("password", passTxtBox.Text);

            string linkString = $"https://localhost:44336/api/Users?luname={user.Username}&lpass={user.Password}"; // igy egyszerubb a string
                                                                                                                   //keszitese, nem kell a +-jel meg a tobbi idozojel, eszkepeles stb... ha a string tobb soros, akkor mehet a
                                                                                                                   // $@" ... " megoldassal akarhany sorba es a vegen a ; kell meg. A parameterek mindig a {} koze keruljenek.

            RestClient rClient = new RestClient(linkString, httpVerb.GET);

            //rClient.httpMethod = httpVerb.GET;
            //rClient.endPoint = "https://localhost:44336/api/users?luname="+ user.Username + "&lpass=" + user.Password;          
            JArray jSONResponse = null;  //Newtonsoft.Json.Linq. kiemelve, az importban benne van, felesleges LB
            //string strResponse = string.Empty; // felesleges LB

            string strResponse = rClient.makeRequest();
           

            if (strResponse != "{}")
            {
                UserLoginAdministrator._LoginOK = true;
                //UserLoginAdministrator._roleId = 1; //nem kell, csak proba volt
            }
            else
            {
                UserLoginAdministrator._LoginOK = false;
                //UserLoginAdministrator._roleId = 0; //nem kell, csak proba volt
            }
            System.Diagnostics.Debug.Write(strResponse);

            jSONResponse = JArray.Parse(strResponse);      //ezek kerulhetnenek a static classba
            userLogedIn.Add("id", jSONResponse[0].SelectToken("usersId"));
            System.Diagnostics.Debug.WriteLine("!!!!!!" + userLogedIn.GetValue("id"));
            UserLoginAdministrator._userId = (int)userLogedIn.GetValue("id");
            userLogedIn.Add("fullName", jSONResponse[0].SelectToken("fullName"));
            UserLoginAdministrator._username = (string)jSONResponse[0].SelectToken("username");
            UserLoginAdministrator._fullName = (string)jSONResponse[0].SelectToken("fullName");
            userLogedIn.Add("roleId", jSONResponse[0].SelectToken("roleId"));
            UserLoginAdministrator._roleId = (int)jSONResponse[0].SelectToken("roleId");
            userLogedIn.Add("token", jSONResponse[0].SelectToken("token"));
            UserLoginAdministrator._token = (string)jSONResponse[0].SelectToken("token");
            userLogedIn.Add("occupationId", jSONResponse[0].SelectToken("occupationId"));
            UserLoginAdministrator._occupationId = (int)jSONResponse[0].SelectToken("occupationId");


            debugOutput(strResponse);

            if (UserLoginAdministrator._LoginOK) //ez a jovoben mindenhonnan elrheto lenne, nem kellene minden kodot ujbol megismetelni a belepeskor
            {
                Console.WriteLine("Rendben bejelentkezett\n");
            }
            else
            {
                Console.WriteLine("Nem tudott bejelentkezni!\n");
            }

            if (strResponse != "{}")
            {
                Administrator newScreen = new Administrator(userLogedIn);
                userNameLbl.Text = userLogedIn.GetValue("fullName").ToString();
                loginAsGroup.Visible = true;
                userNameLbl.Visible = true;
                newScreen.ShowDialog(); //ezzel nem zarja a regi ablakot, igy a hatterben megmarad
                usernameTxtBox.Clear();
                passTxtBox.Clear();
                unauthLbl.Visible = false;
                loginButton.Enabled = false;
            }
            else
            {
                userLogedIn.RemoveAll();
                unauthLbl.Visible = true;
                usernameTxtBox.Clear();
                passTxtBox.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JObject userLogOut = new JObject(userLogedIn);
            userLogOut.Remove("token");
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.PUT;
            rClient.endPoint = "https://localhost:44336/api/users/" + (Int16)userLogedIn.GetValue("id");
            rClient.takeRequest(userLogOut, userLogedIn);
            userNameLbl.Visible = false;
            loginAsGroup.Visible = false;
            userLogedIn.RemoveAll();
            userLogOut.RemoveAll();
            loginButton.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (userLogedIn.GetValue("token") != null)
            {
                JObject userLogOut = new JObject(userLogedIn);
                userLogOut.Remove("token");
                userLogOut.Add("token", "");
                System.Console.WriteLine(userLogOut);
                System.Console.WriteLine(userLogedIn);
                RestClient rClient = new RestClient();
                rClient.httpMethod = httpVerb.PUT;
                rClient.endPoint = "https://localhost:44336/api/users/" + (Int16)userLogedIn.GetValue("id");
                rClient.takeRequest(userLogOut, userLogedIn);
                userLogedIn.RemoveAll();
            }
        }

        private void passTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
