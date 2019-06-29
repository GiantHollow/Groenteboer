﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groenteboer
{
    public partial class ucProductDisplay : UserControl
    {
        public ucProductDisplay()
        {
            InitializeComponent();
        }

        public void setData(string productNaam, string prijs, string plaatje)
        {
            pbProduct.Image = System.Drawing.Image.FromFile(plaatje);
            lblProductNaam.Text = productNaam;
            lblPrijs.Text = prijs;
        }

        public void btnWinkelmand_Click(object sender, EventArgs e)
        {

        }
    }
}
