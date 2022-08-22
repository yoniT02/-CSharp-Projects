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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = Prod.findOne(txtsearch.Text);
            if (products == null)
            {
                MessageBox.Show("The product wasn't found!");
            }
            else
            {
                MessageBox.Show($"Product Exists! \n Name : {products.objName}");

                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
