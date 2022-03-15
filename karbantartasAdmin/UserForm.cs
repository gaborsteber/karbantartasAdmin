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
        public UserForm(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
        }

        private void queryAllUser_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/users";
            Newtonsoft.Json.Linq.JObject jSONResponse = null;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            responseTxtBox.Text = strResponse;
        }

        private void queryUserButton_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/users/" + Int32.Parse(userIdTxtBox.Text);
            Newtonsoft.Json.Linq.JObject jSONResponse = null;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            responseTxtBox.Text = strResponse;

        }
    }
}
