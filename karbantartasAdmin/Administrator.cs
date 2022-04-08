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
    public partial class Administrator : Form
    {
        JObject userLogedIn = new JObject();
        public Administrator(JObject logedInUser)
        {
            InitializeComponent();
            userLogedIn = logedInUser;
        }

        private void addMainCategory_Click(object sender, EventArgs e)
        {
            MainCategory newScreen = new MainCategory(userLogedIn);
            newScreen.ShowDialog();
        }
        private void addEquipment_Click(object sender, EventArgs e)
        {
            Assets newScreen = new Assets(userLogedIn);
            newScreen.Show();
        }
        private void addOccupationButton_Click(object sender, EventArgs e)
        {
            Occupations newScreen = new Occupations(userLogedIn);
            newScreen.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserForm newScreen = new UserForm(userLogedIn);
            newScreen.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
