﻿using System;
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
            rClient.endPoint = "https://localhost:44371/api/roles" + text1.Text;
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
                textValasz.Text = textValasz.Text + strDebugText + Environment.NewLine;
                textValasz.SelectionStart = textValasz.TextLength;
                textValasz.ScrollToCaret();
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
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.GET;
            rClient.endPoint = "https://localhost:44336/api/users?luname="+ user.Username + "&lpass=" + user.Password;          
            Newtonsoft.Json.Linq.JObject jSONResponse = null;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();
            jSONResponse = JObject.Parse(strResponse);

            userLogedIn.Add("id", jSONResponse.GetValue("id"));
            userLogedIn.Add("fullName", jSONResponse.GetValue("fullName"));
            userLogedIn.Add("roleId", jSONResponse.GetValue("roleId"));
            userLogedIn.Add("token", jSONResponse.GetValue("token"));
            userLogedIn.Add("occupationId", jSONResponse.GetValue("occupationId"));
            
            debugOutput(strResponse);
            jsonTxtBox.Text = userLogedIn.GetValue("token").ToString();
            Administrator newScreen = new Administrator(userLogedIn);
            newScreen.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            userLogedIn.Remove("token");
            jsonTxtBox.Text = userLogedIn.ToString();
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.PUT;
            rClient.endPoint = "https://localhost:44336/api/users/"+(Int16)userLogedIn.GetValue("id");
            rClient.takeRequest(userLogedIn);
            userLogedIn.RemoveAll();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (userLogedIn.GetValue("token") != null)
            { 
            userLogedIn.Remove("token");
            RestClient rClient = new RestClient();
            rClient.httpMethod = httpVerb.PUT;
            rClient.endPoint = "https://localhost:44336/api/users/" + (Int16)userLogedIn.GetValue("id");
            rClient.takeRequest(userLogedIn);
            userLogedIn.RemoveAll();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
