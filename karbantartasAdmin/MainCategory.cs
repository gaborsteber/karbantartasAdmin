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
    public partial class MainCategory : Form
    {
        JObject userLogedIn = new JObject();
        public MainCategory(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
        }

        private void MainCategory_Load(object sender, EventArgs e)
        {

        }

        private void editUserDataButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
