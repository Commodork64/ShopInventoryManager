using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventoryManager
{
    public partial class Form2 : Form
    {
        private string helpText;

        public Form2()
        {
            InitializeComponent();

            // TODO: Put this into a text file and load it in, instead.
            helpText = "Inventory Manager is a simple, graphical, CRUD application that allows the user to edit a database."
                + Environment.NewLine + Environment.NewLine +
                "By clicking on items within the datagrid the user can 'grab' the data associated with said item and edit it" +
                " using the boxes to the right hand side of the grid. Clicking the Update button after this will store the changes a user has made."
                + Environment.NewLine + Environment.NewLine +
                "Inventory Manager was created to function in a similar way with all of its commands. By editing an item from the grid" +
                " using the boxes on the right and then clicking create, the user can create an entire new item within the database table." +
                " Deleting an item is even easier. Select the item you wish to dispose of and click Delete. This item cannot be recovered however" +
                " and so discretion is advised!"
                + Environment.NewLine + Environment.NewLine +
               "Using the search bar at the top of the grid, the user can 'trim down' the grid" +
                " enabling them to cut down search time and focus on the entries they care about. Search is compatible with" +
                " the Name, Description and Price columns."
                + Environment.NewLine + Environment.NewLine +
                "Lastly Inventory Manager supports the following shortcuts:"
                + Environment.NewLine + Environment.NewLine +
                "ENTER - Search the database, CTRL + Q - Quit the program, F2 - Access Help";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_HelpBox.AppendText(helpText);
        }

        private void btn_Dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
