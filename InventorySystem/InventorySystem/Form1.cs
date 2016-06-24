using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.inv_users' table. You can move, or remove it, as needed.
            this.inv_usersTableAdapter.Fill(this.inventoryDataSet.inv_users);
            // TODO: This line of code loads data into the 'inventoryDataSet.inv_products' table. You can move, or remove it, as needed.

            this.inv_productsTableAdapter.Fill(this.inventoryDataSet.inv_products);

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxID_Add.SelectedValue);
            string SerialNumber = Convert.ToString(comboBoxSerial_Add.SelectedItem);
            int amount = Convert.ToInt32(textBox1.Text);
            AddAmount.insertToDB(id, SerialNumber, amount);
            /* Example code
            int userID = Convert.ToInt32(comboBox1.SelectedValue);
            int TransactionCode = Convert.ToInt32(comboBox2.SelectedItem);
            int itemID = Convert.ToInt32(textBox1.Text);
            FinalDB.insertToDB(userID, itemID, TransactionCode);
            */
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxID_Remove.SelectedValue);
            string SerialNumber = Convert.ToString(comboBoxSerial_Remove.SelectedItem);
            int amount = Convert.ToInt32(textBox2.Text);
            RemoveAmount.insertToDB(id, SerialNumber, amount);
        }
    }
}
