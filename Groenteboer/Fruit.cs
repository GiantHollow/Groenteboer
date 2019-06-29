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
    public partial class Fruit : Form
    {
        public Fruit()
        {
            InitializeComponent();
        }

        private void Fruit_Load(object sender, EventArgs e)
        {
            // Maak data object
            DBConnect myDBConnect = new DBConnect();

            string QueryString = "select * from producten where isGroente";

            MySqlCommand cmdObject = new MySqlCommand(QueryString);
            MySqlDataReader data = cmdObject.ExecuteReader();

            while (data.Read())
            {
                ucProductDisplay container = new ucProductDisplay();
                string productNaam = data["naam"].ToString();
                string price = data["prijs"].ToString();
                string picture = data["plaatje"].ToString();

                container.setData(productNaam, price, picture);
                container.Show();

                ProductPanel.Controls.Add(container);
            }
        }

        private void btnNaarGroente_Click(object sender, EventArgs e)
        {
            Hide();
            frmGroenten newForm = new frmGroenten();
            newForm.Show();
        }
    }
}
