using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Groenteboer
{
    public partial class Winkelmandje : Form
    {
        DBConnect myDBConnect;

        public Winkelmandje()
        {
            InitializeComponent();
            myDBConnect = new DBConnect();
            myDBConnect.OpenConnection();
        }

        private void Winkelmandje_Load(object sender, EventArgs e)
        {
            string QueryString = "select * from producten where isGroente";

            MySqlCommand cmdObject = new MySqlCommand(QueryString, myDBConnect.connection);
            MySqlDataReader data = cmdObject.ExecuteReader();

            while (data.Read())
            {

            }
        }

        private void btnNaarGroente_Click(object sender, EventArgs e)
        {
            myDBConnect.CloseConnection();
            frmGroenten newForm = new frmGroenten();
            newForm.Show();
            this.Hide();
        }

        private void btnNaarFruit_Click(object sender, EventArgs e)
        {
            myDBConnect.CloseConnection();
            Fruit newForm = new Fruit();
            newForm.Show();
            this.Hide();
        }
    }
}
