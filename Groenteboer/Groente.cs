using System;
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
    public partial class frmGroenten : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public frmGroenten()
        {
            InitializeComponent();
        }

        

        //When Groenten laad, laadt je ook de objecten in
        private void frmGroenten_Load(object sender, EventArgs e)
        {
            // Maak data object
            DBConnect myDBConnect = new DBConnect();

            string QueryString = "select * from producten where isGroente";

            MySqlCommand cmdObject = new MySqlCommand(QueryString);
            MySqlDataReader data = cmdObject.ExecuteReader();

            while (data.Read())
            {
                ucProductDisplay container = new ucProductDisplay();

            }
        }

        private void btnNaarFruit_Click(object sender, EventArgs e)
        {
            Fruit.Show();
        }
    }
}
