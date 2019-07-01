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
    public partial class Fruit : Form
    {
        DBConnect myDBConnect;

        public Fruit()
        {
            InitializeComponent();
            myDBConnect = new DBConnect();
            myDBConnect.OpenConnection();
        }

        private void Fruit_Load(object sender, EventArgs e)
        {
            string QueryString = "select * from producten where not isGroente";

            MySqlCommand cmdObject = new MySqlCommand(QueryString, myDBConnect.connection);
            MySqlDataReader data = cmdObject.ExecuteReader();

            while (data.Read())
            {
                ucProductDisplay container = new ucProductDisplay();
                string productNaam = data["naam"].ToString();
                string price = data["prijs"].ToString();
                MemoryStream ms = new MemoryStream((byte[])data["plaatje"]);

                container.setData(productNaam, price, ms);
                container.Show();

                ProductPanel.Controls.Add(container);
            }
        }

        private void btnNaarGroente_Click(object sender, EventArgs e)
        {
            myDBConnect.CloseConnection();
            frmGroenten newForm = new frmGroenten();
            newForm.Show();
            this.Hide();
        }
    }
}
