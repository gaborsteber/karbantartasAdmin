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
        public Occupations(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getAllData_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/occupations";
            Newtonsoft.Json.Linq.JObject jSONResponse = null;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest(userLogedIn);
            //jSONResponse = JObject.Parse(strResponse);
            dataFromDb.Text = strResponse;
        }
    }
}
