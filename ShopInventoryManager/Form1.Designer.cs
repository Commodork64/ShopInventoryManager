namespace ShopInventoryManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label_Item = new System.Windows.Forms.Label();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.txt_DatabaseSearch = new System.Windows.Forms.TextBox();
            this.label_itemDescription = new System.Windows.Forms.Label();
            this.txtBox_Description = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.shopInventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopInventoryDataSet = new ShopInventoryManager.ShopInventoryDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Location = new System.Windows.Forms.ComboBox();
            this.numUpDownStockCount = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.btn_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStockCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(13, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(74, 32);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(995, 450);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(74, 32);
            this.btn_Create.TabIndex = 8;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1155, 450);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(74, 32);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(797, 15);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(74, 32);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label_Item
            // 
            this.label_Item.AutoSize = true;
            this.label_Item.Location = new System.Drawing.Point(879, 142);
            this.label_Item.Name = "label_Item";
            this.label_Item.Size = new System.Drawing.Size(33, 13);
            this.label_Item.TabIndex = 5;
            this.label_Item.Text = "Item :";
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(942, 142);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(287, 20);
            this.txt_Item.TabIndex = 3;
            this.txt_Item.TextChanged += new System.EventHandler(this.txt_Item_TextChanged);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(879, 179);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(37, 13);
            this.label_Price.TabIndex = 7;
            this.label_Price.Text = "Price :";
            // 
            // txt_DatabaseSearch
            // 
            this.txt_DatabaseSearch.Location = new System.Drawing.Point(93, 22);
            this.txt_DatabaseSearch.Name = "txt_DatabaseSearch";
            this.txt_DatabaseSearch.Size = new System.Drawing.Size(689, 20);
            this.txt_DatabaseSearch.TabIndex = 1;
            // 
            // label_itemDescription
            // 
            this.label_itemDescription.AutoSize = true;
            this.label_itemDescription.Location = new System.Drawing.Point(879, 222);
            this.label_itemDescription.Name = "label_itemDescription";
            this.label_itemDescription.Size = new System.Drawing.Size(38, 13);
            this.label_itemDescription.TabIndex = 10;
            this.label_itemDescription.Text = "Desc :";
            // 
            // txtBox_Description
            // 
            this.txtBox_Description.Location = new System.Drawing.Point(942, 222);
            this.txtBox_Description.Multiline = true;
            this.txtBox_Description.Name = "txtBox_Description";
            this.txtBox_Description.Size = new System.Drawing.Size(287, 110);
            this.txtBox_Description.TabIndex = 5;
            this.txtBox_Description.TextChanged += new System.EventHandler(this.txtBox_Description_TextChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(1075, 450);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(74, 32);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewInventory.MultiSelect = false;
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInventory.Size = new System.Drawing.Size(849, 440);
            this.dataGridViewInventory.TabIndex = 13;
            this.dataGridViewInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellContentClick);
            // 
            // shopInventoryDataSetBindingSource
            // 
            this.shopInventoryDataSetBindingSource.DataSource = this.shopInventoryDataSet;
            this.shopInventoryDataSetBindingSource.Position = 0;
            // 
            // shopInventoryDataSet
            // 
            this.shopInventoryDataSet.DataSetName = "ShopInventoryDataSet";
            this.shopInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(867, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "StockCount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Location";
            // 
            // comboBox_Location
            // 
            this.comboBox_Location.FormattingEnabled = true;
            this.comboBox_Location.Location = new System.Drawing.Point(942, 390);
            this.comboBox_Location.Name = "comboBox_Location";
            this.comboBox_Location.Size = new System.Drawing.Size(167, 21);
            this.comboBox_Location.TabIndex = 7;
            this.comboBox_Location.SelectedIndexChanged += new System.EventHandler(this.comboBox_Location_SelectedIndexChanged);
            // 
            // numUpDownStockCount
            // 
            this.numUpDownStockCount.Location = new System.Drawing.Point(942, 351);
            this.numUpDownStockCount.Name = "numUpDownStockCount";
            this.numUpDownStockCount.Size = new System.Drawing.Size(167, 20);
            this.numUpDownStockCount.TabIndex = 6;
            this.numUpDownStockCount.ValueChanged += new System.EventHandler(this.numUpDownStockCount_ValueChanged);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(942, 15);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(287, 111);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 22;
            this.pictureBox_Logo.TabStop = false;
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.DecimalPlaces = 2;
            this.numUpDownPrice.Location = new System.Drawing.Point(942, 177);
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(167, 20);
            this.numUpDownPrice.TabIndex = 4;
            this.numUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDown_Price_ValueChanged);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(882, 450);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(74, 32);
            this.btn_Help.TabIndex = 23;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1249, 507);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.numUpDownPrice);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.numUpDownStockCount);
            this.Controls.Add(this.comboBox_Location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txtBox_Description);
            this.Controls.Add(this.label_itemDescription);
            this.Controls.Add(this.txt_DatabaseSearch);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.txt_Item);
            this.Controls.Add(this.label_Item);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStockCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label_Item;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox txt_DatabaseSearch;
        private System.Windows.Forms.Label label_itemDescription;
        private System.Windows.Forms.TextBox txtBox_Description;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.BindingSource shopInventoryDataSetBindingSource;
        private ShopInventoryDataSet shopInventoryDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Location;
        private System.Windows.Forms.NumericUpDown numUpDownStockCount;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.Button btn_Help;
    }
}

