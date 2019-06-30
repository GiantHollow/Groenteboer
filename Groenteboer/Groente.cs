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
    public partial class frmGroenten : Form
    {
        public frmGroenten()
        {
            InitializeComponent();
        }
        
        //When Groenten laad, laadt je ook de objecten in
        private void frmGroenten_Load(object sender, EventArgs e)
        {
            // Maak data object
            DBConnect myDBConnect = new DBConnect();
            myDBConnect.OpenConnection();

            string QueryString = "select * from producten where isGroente";

            MySqlCommand cmdObject = new MySqlCommand(QueryString, myDBConnect.connection);
            MySqlDataReader data = cmdObject.ExecuteReader();

            while (data.Read())
            {
                ucProductDisplay container = new ucProductDisplay();
                string productNaam = data["naam"].ToString();
                string price = data["prijs"].ToString();
                //Image picture = data["plaatje"];
                MemoryStream ms = new MemoryStream((byte[])data["plaatje"]);

                container.setData(productNaam, price, ms);
                container.Show();

                ProductPanel.Controls.Add(container);
            }

            myDBConnect.CloseConnection();
        }

        private void btnNaarFruit_Click(object sender, EventArgs e)
        {
            Hide();
            Fruit newForm = new Fruit();
            newForm.Show();
        }
    }
}
