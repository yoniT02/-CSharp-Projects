using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btn_Add(object sender, EventArgs e)
        {

            try
            {
                errorProvider1.Clear();
                if (String.IsNullOrEmpty(txt_Number.Text) || ! new Regex(@"^[0-9]{3}$").IsMatch(txt_Number.Text))
                    errorProvider1.SetError(txt_Number, "Field is required");
                else if (String.IsNullOrEmpty(txt_InventoryNumber.Text))
                    errorProvider1.SetError(txt_InventoryNumber, "Field is required");
                else if (String.IsNullOrEmpty(txt_ObjName.Text))
                    errorProvider1.SetError(txt_ObjName, "Field is required");
                else if (String.IsNullOrEmpty(txt_count.Text))
                    errorProvider1.SetError(txt_count , "Field is required");
                else if (String.IsNullOrEmpty(txt_price.Text))
                    errorProvider1.SetError(txt_price, "Field is required");
                else
                {
                    Prod p = new Prod
                    {
                        number = int.Parse(txt_Number.Text),
                        date = DateTime.Parse(txt_Date.Text),
                        inventoryNumber = int.Parse(txt_InventoryNumber.Text),
                        objName = txt_ObjName.Text,
                        count = int.Parse(txt_count.Text),
                        price = int.Parse(txt_price.Text),
                        isAvailable = isAvailable.Checked
                    };
                    p.save();
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = Prod.GetAllProducts();
                    MessageBox.Show("Product " + p.objName + " saved!");
                    errorProvider1.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input type!"); 
            }
        }

        private void btn_cancel(object sender, EventArgs e)
        {
            txt_Number.Clear();
            txt_InventoryNumber.Clear();
            txt_ObjName.Clear();
            txt_count.Clear();
            txt_price.Clear();
        }

        private void chk_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string checkedItems = " ";
            foreach (var item in chk_list.CheckedItems)
            {
                checkedItems = checkedItems + item.ToString() + " ";

            }
            MessageBox.Show(checkedItems);
        }

        private void isAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckList_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

