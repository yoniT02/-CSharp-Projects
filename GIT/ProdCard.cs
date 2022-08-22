using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class ProdCard : UserControl
    {

        private string _productName;
        private string _productDescription;
        private string _productPrice;


        public string productName {
            get { return _productName; }
            set { _productName = lblName.Text = value; }
        }
        public string productDescription
        {
            get { return _productDescription; }
            set { _productDescription = lblDescription.Text = value; }
        }
        public string productPrice
        {
            get { return _productPrice; }
            set { _productPrice = lblPrice.Text = value; }
        }
        public ProdCard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
