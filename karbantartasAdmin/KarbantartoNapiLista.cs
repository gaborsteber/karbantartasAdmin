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
    public partial class KarbantartoNapiLista : Form
    {
        public KarbantartoNapiLista()
        {
            InitializeComponent();
            string[] karbantartok = { "Janos", "Peter", "Vilmos", "Andras" };
            CbxKarbantartoLista.Items.AddRange(karbantartok);
        }

        private void BtnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
