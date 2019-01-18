using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopInventoryManager
{
    public partial class Form1 : Form
    {

        private ProductDataManager prodDataManager;
        private LocationDataManager locDataManager;
        public Form2 HelpPage;

        private List<Product> products;

        // returns the SelectedRow, casted as a type of Product
        private Product SelectedProduct
        {
            get
            {
                if (dataGridViewInventory.SelectedRows.Count > 0)
                {
                    return (Product)dataGridViewInventory.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        public Form1()
        {
            InitializeComponent();

            prodDataManager = new ProductDataManager();
            locDataManager = new LocationDataManager();
            
            // prevents either numericbox from overflowing their datatype values. 
            numUpDownPrice.Maximum = Decimal.MaxValue;
            numUpDownStockCount.Maximum = Int32.MaxValue;

            comboBox_Location.DisplayMember = "LocationName";
            comboBox_Location.ValueMember = "LocationID";
            comboBox_Location.DataSource = locDataManager.GetLocations();
            dataGridViewInventory.DataSource = products; // bind datagrid to products. Everytime products is updated, datagrid will also be updated.

            RefreshDatabaseGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // When the program begins, get all entries in the database.
            txt_DatabaseSearch.Text = string.Empty;
            RefreshDatabaseGrid();
            AssignBoxes();
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignBoxes();         
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txt_DatabaseSearch.Text;
                products = prodDataManager.Search(searchTerm);
                RefreshDatabaseGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                prodDataManager.Create(SelectedProduct);
                MessageBox.Show($"{SelectedProduct.Name} created!", "Success");
                RefreshDatabaseGrid();
                // Sets the selected item in the datagridview to the newly created item.
                int lastRowIndex = dataGridViewInventory.Rows.Count - 1;
                dataGridViewInventory.Rows[lastRowIndex].Selected = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                prodDataManager.Delete(SelectedProduct.Id);
                MessageBox.Show($"{SelectedProduct.Name} deleted!", "Success");
                RefreshDatabaseGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                prodDataManager.Update(SelectedProduct.Id, SelectedProduct);
                MessageBox.Show($"{SelectedProduct.Name} updated!", "Success");
                RefreshDatabaseGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_DatabaseSearch.Text = string.Empty;
            RefreshDatabaseGrid();
        }

        private void RefreshDatabaseGrid()
        {
            string searchTerm = txt_DatabaseSearch.Text;
            products = prodDataManager.Search(searchTerm);
            dataGridViewInventory.DataSource = products;
            dataGridViewInventory.Refresh();
        }

        private void AssignBoxes()
        {
            // sets boxes on the right to the SelectedProducts params.
            txt_Item.Text = SelectedProduct.Name;
            numUpDownPrice.Value = SelectedProduct.Price;
            txtBox_Description.Text = SelectedProduct.Description;
            numUpDownStockCount.Value = SelectedProduct.StockCount;
            comboBox_Location.Text = SelectedProduct.Location.LocationName;
        }


        // the below methods are for safety. Insuring the program doesn't crash from unhandled null exceptions.
        private void txt_Item_TextChanged(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;
            SelectedProduct.Name = txt_Item.Text;
        }

        private void txtBox_Description_TextChanged(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;
            SelectedProduct.Description = txtBox_Description.Text;
        }

        private void numUpDownStockCount_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;
            SelectedProduct.StockCount = (int)numUpDownStockCount.Value;
        }

        private void comboBox_Location_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;
            SelectedProduct.Location.LocationID = (int)comboBox_Location.SelectedValue;
            SelectedProduct.Location.LocationName = comboBox_Location.SelectedText;
        }

        private void numericUpDown_Price_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;
            SelectedProduct.Price = numUpDownPrice.Value;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnHelp_Click(sender, e);
            }
            else if (e.Control & e.KeyCode == Keys.Q)
            {
                Application.Exit(); // safely terminates message prompts, closes all aplication windows after processing.
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(sender, e);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpPage = new Form2();
            HelpPage.ShowDialog(); // Creates a Modal form. This must be dealt with before control of the program will return to Form1.
        }
    }
}
