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
    public partial class HibalistaFelulet : Form


    {
        

        public HibalistaFelulet()
        {
            InitializeComponent();
        }

        private void BtnHibalista_Click(object sender, EventArgs e)
        {
            
            DataTransferClass dtransfer = new DataTransferClass("GET", (ServerDataStore.url + "/api/Logs"));
            var resp = dtransfer.GetList();

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(resp, typeof(DataTable));
            dataGridView1.DataSource = dt;
        }
    }
}
