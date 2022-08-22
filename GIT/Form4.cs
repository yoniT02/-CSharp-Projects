using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace lab2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            activePanel.Top = 69;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.BurlyWood;
            activePanel.Top = 92;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Thistle;
            activePanel.Top = 116;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Crimson;
            activePanel.Top = 139;
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (Prod item in Prod.GetAllProducts())
            {
                ProdCard p = new ProdCard();
                p.productName = item.objName;
                p.productDescription = item.inventoryNumber.ToString();
                p.productPrice = item.price.ToString();
                p.Click += (object o4, EventArgs ev) =>
                {
                    //MessageBox.Show("Name: " + p.productName);
                    //MessageBox.Show("Description: " + p.productDescription);
                    //MessageBox.Show("Price: " + p.productPrice);
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                };
                


                flowLayoutPanel2.Controls.Add(p);
            }
        }

        
    }
}
