namespace project2v3_csc330
{
    partial class Customer
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
            System.Windows.Forms.Label property_IdLabel;
            System.Windows.Forms.Label property_PriceLabel;
            System.Windows.Forms.Label property_SquareLabel;
            System.Windows.Forms.Label property_LotLabel;
            System.Windows.Forms.Label property_StyleLabel;
            System.Windows.Forms.Label property_BedroomsLabel;
            System.Windows.Forms.Label property_BathroomsLabel;
            System.Windows.Forms.Label property_ApplianceLabel;
            System.Windows.Forms.Label property_GarageLabel;
            System.Windows.Forms.Label property_BasementLabel;
            System.Windows.Forms.Label property_AgeLabel;
            System.Windows.Forms.Label property_StatusLabel;
            System.Windows.Forms.Label property_StreetAddressLabel;
            System.Windows.Forms.Label property_CityLabel;
            System.Windows.Forms.Label property_StateLabel;
            System.Windows.Forms.Label property_CountryLabel;
            System.Windows.Forms.Label property_PostalCodeLabel;
            System.Windows.Forms.Label agent_IdLabel;
            System.Windows.Forms.Label offerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.propertyDBDataSet = new project2v3_csc330.PropertyDBDataSet();
            this.propertyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyTableTableAdapter = new project2v3_csc330.PropertyDBDataSetTableAdapters.PropertyTableTableAdapter();
            this.tableAdapterManager = new project2v3_csc330.PropertyDBDataSetTableAdapters.TableAdapterManager();
            this.offerTableTableAdapter = new project2v3_csc330.PropertyDBDataSetTableAdapters.OfferTableTableAdapter();
            this.propertyTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertyTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property_IdTextBox = new System.Windows.Forms.TextBox();
            this.property_PriceTextBox = new System.Windows.Forms.TextBox();
            this.property_SquareTextBox = new System.Windows.Forms.TextBox();
            this.property_LotTextBox = new System.Windows.Forms.TextBox();
            this.property_StyleTextBox = new System.Windows.Forms.TextBox();
            this.property_BedroomsTextBox = new System.Windows.Forms.TextBox();
            this.property_BathroomsTextBox = new System.Windows.Forms.TextBox();
            this.property_ApplianceTextBox = new System.Windows.Forms.TextBox();
            this.property_GarageTextBox = new System.Windows.Forms.TextBox();
            this.property_BasementTextBox = new System.Windows.Forms.TextBox();
            this.property_AgeTextBox = new System.Windows.Forms.TextBox();
            this.property_StatusTextBox = new System.Windows.Forms.TextBox();
            this.property_StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.property_CityTextBox = new System.Windows.Forms.TextBox();
            this.property_StateTextBox = new System.Windows.Forms.TextBox();
            this.property_CountryTextBox = new System.Windows.Forms.TextBox();
            this.property_PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.agent_IdTextBox = new System.Windows.Forms.TextBox();
            this.offerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Submit = new System.Windows.Forms.Button();
            this.txt_Offer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.button_Status = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PropertyId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_CustomerId2 = new System.Windows.Forms.TextBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            property_IdLabel = new System.Windows.Forms.Label();
            property_PriceLabel = new System.Windows.Forms.Label();
            property_SquareLabel = new System.Windows.Forms.Label();
            property_LotLabel = new System.Windows.Forms.Label();
            property_StyleLabel = new System.Windows.Forms.Label();
            property_BedroomsLabel = new System.Windows.Forms.Label();
            property_BathroomsLabel = new System.Windows.Forms.Label();
            property_ApplianceLabel = new System.Windows.Forms.Label();
            property_GarageLabel = new System.Windows.Forms.Label();
            property_BasementLabel = new System.Windows.Forms.Label();
            property_AgeLabel = new System.Windows.Forms.Label();
            property_StatusLabel = new System.Windows.Forms.Label();
            property_StreetAddressLabel = new System.Windows.Forms.Label();
            property_CityLabel = new System.Windows.Forms.Label();
            property_StateLabel = new System.Windows.Forms.Label();
            property_CountryLabel = new System.Windows.Forms.Label();
            property_PostalCodeLabel = new System.Windows.Forms.Label();
            agent_IdLabel = new System.Windows.Forms.Label();
            offerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTableBindingNavigator)).BeginInit();
            this.propertyTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // property_IdLabel
            // 
            property_IdLabel.AutoSize = true;
            property_IdLabel.Location = new System.Drawing.Point(26, 39);
            property_IdLabel.Name = "property_IdLabel";
            property_IdLabel.Size = new System.Drawing.Size(61, 13);
            property_IdLabel.TabIndex = 2;
            property_IdLabel.Text = "Property Id:";
            // 
            // property_PriceLabel
            // 
            property_PriceLabel.AutoSize = true;
            property_PriceLabel.Location = new System.Drawing.Point(26, 65);
            property_PriceLabel.Name = "property_PriceLabel";
            property_PriceLabel.Size = new System.Drawing.Size(76, 13);
            property_PriceLabel.TabIndex = 4;
            property_PriceLabel.Text = "Property Price:";
            // 
            // property_SquareLabel
            // 
            property_SquareLabel.AutoSize = true;
            property_SquareLabel.Location = new System.Drawing.Point(26, 91);
            property_SquareLabel.Name = "property_SquareLabel";
            property_SquareLabel.Size = new System.Drawing.Size(86, 13);
            property_SquareLabel.TabIndex = 6;
            property_SquareLabel.Text = "Property Square:";
            // 
            // property_LotLabel
            // 
            property_LotLabel.AutoSize = true;
            property_LotLabel.Location = new System.Drawing.Point(26, 117);
            property_LotLabel.Name = "property_LotLabel";
            property_LotLabel.Size = new System.Drawing.Size(67, 13);
            property_LotLabel.TabIndex = 8;
            property_LotLabel.Text = "Property Lot:";
            // 
            // property_StyleLabel
            // 
            property_StyleLabel.AutoSize = true;
            property_StyleLabel.Location = new System.Drawing.Point(26, 143);
            property_StyleLabel.Name = "property_StyleLabel";
            property_StyleLabel.Size = new System.Drawing.Size(75, 13);
            property_StyleLabel.TabIndex = 10;
            property_StyleLabel.Text = "Property Style:";
            // 
            // property_BedroomsLabel
            // 
            property_BedroomsLabel.AutoSize = true;
            property_BedroomsLabel.Location = new System.Drawing.Point(26, 169);
            property_BedroomsLabel.Name = "property_BedroomsLabel";
            property_BedroomsLabel.Size = new System.Drawing.Size(99, 13);
            property_BedroomsLabel.TabIndex = 12;
            property_BedroomsLabel.Text = "Property Bedrooms:";
            // 
            // property_BathroomsLabel
            // 
            property_BathroomsLabel.AutoSize = true;
            property_BathroomsLabel.Location = new System.Drawing.Point(26, 195);
            property_BathroomsLabel.Name = "property_BathroomsLabel";
            property_BathroomsLabel.Size = new System.Drawing.Size(102, 13);
            property_BathroomsLabel.TabIndex = 14;
            property_BathroomsLabel.Text = "Property Bathrooms:";
            // 
            // property_ApplianceLabel
            // 
            property_ApplianceLabel.AutoSize = true;
            property_ApplianceLabel.Location = new System.Drawing.Point(26, 221);
            property_ApplianceLabel.Name = "property_ApplianceLabel";
            property_ApplianceLabel.Size = new System.Drawing.Size(99, 13);
            property_ApplianceLabel.TabIndex = 16;
            property_ApplianceLabel.Text = "Property Appliance:";
            // 
            // property_GarageLabel
            // 
            property_GarageLabel.AutoSize = true;
            property_GarageLabel.Location = new System.Drawing.Point(26, 247);
            property_GarageLabel.Name = "property_GarageLabel";
            property_GarageLabel.Size = new System.Drawing.Size(87, 13);
            property_GarageLabel.TabIndex = 18;
            property_GarageLabel.Text = "Property Garage:";
            // 
            // property_BasementLabel
            // 
            property_BasementLabel.AutoSize = true;
            property_BasementLabel.Location = new System.Drawing.Point(26, 273);
            property_BasementLabel.Name = "property_BasementLabel";
            property_BasementLabel.Size = new System.Drawing.Size(99, 13);
            property_BasementLabel.TabIndex = 20;
            property_BasementLabel.Text = "Property Basement:";
            // 
            // property_AgeLabel
            // 
            property_AgeLabel.AutoSize = true;
            property_AgeLabel.Location = new System.Drawing.Point(26, 299);
            property_AgeLabel.Name = "property_AgeLabel";
            property_AgeLabel.Size = new System.Drawing.Size(71, 13);
            property_AgeLabel.TabIndex = 22;
            property_AgeLabel.Text = "Property Age:";
            // 
            // property_StatusLabel
            // 
            property_StatusLabel.AutoSize = true;
            property_StatusLabel.Location = new System.Drawing.Point(26, 325);
            property_StatusLabel.Name = "property_StatusLabel";
            property_StatusLabel.Size = new System.Drawing.Size(82, 13);
            property_StatusLabel.TabIndex = 24;
            property_StatusLabel.Text = "Property Status:";
            // 
            // property_StreetAddressLabel
            // 
            property_StreetAddressLabel.AutoSize = true;
            property_StreetAddressLabel.Location = new System.Drawing.Point(26, 351);
            property_StreetAddressLabel.Name = "property_StreetAddressLabel";
            property_StreetAddressLabel.Size = new System.Drawing.Size(121, 13);
            property_StreetAddressLabel.TabIndex = 26;
            property_StreetAddressLabel.Text = "Property Street Address:";
            // 
            // property_CityLabel
            // 
            property_CityLabel.AutoSize = true;
            property_CityLabel.Location = new System.Drawing.Point(26, 377);
            property_CityLabel.Name = "property_CityLabel";
            property_CityLabel.Size = new System.Drawing.Size(69, 13);
            property_CityLabel.TabIndex = 28;
            property_CityLabel.Text = "Property City:";
            // 
            // property_StateLabel
            // 
            property_StateLabel.AutoSize = true;
            property_StateLabel.Location = new System.Drawing.Point(26, 403);
            property_StateLabel.Name = "property_StateLabel";
            property_StateLabel.Size = new System.Drawing.Size(77, 13);
            property_StateLabel.TabIndex = 30;
            property_StateLabel.Text = "Property State:";
            // 
            // property_CountryLabel
            // 
            property_CountryLabel.AutoSize = true;
            property_CountryLabel.Location = new System.Drawing.Point(26, 429);
            property_CountryLabel.Name = "property_CountryLabel";
            property_CountryLabel.Size = new System.Drawing.Size(88, 13);
            property_CountryLabel.TabIndex = 32;
            property_CountryLabel.Text = "Property Country:";
            // 
            // property_PostalCodeLabel
            // 
            property_PostalCodeLabel.AutoSize = true;
            property_PostalCodeLabel.Location = new System.Drawing.Point(26, 455);
            property_PostalCodeLabel.Name = "property_PostalCodeLabel";
            property_PostalCodeLabel.Size = new System.Drawing.Size(109, 13);
            property_PostalCodeLabel.TabIndex = 34;
            property_PostalCodeLabel.Text = "Property Postal Code:";
            // 
            // agent_IdLabel
            // 
            agent_IdLabel.AutoSize = true;
            agent_IdLabel.Location = new System.Drawing.Point(26, 481);
            agent_IdLabel.Name = "agent_IdLabel";
            agent_IdLabel.Size = new System.Drawing.Size(50, 13);
            agent_IdLabel.TabIndex = 52;
            agent_IdLabel.Text = "Agent Id:";
            // 
            // offerLabel
            // 
            offerLabel.AutoSize = true;
            offerLabel.Location = new System.Drawing.Point(409, 9);
            offerLabel.Name = "offerLabel";
            offerLabel.Size = new System.Drawing.Size(33, 13);
            offerLabel.TabIndex = 53;
            offerLabel.Text = "Offer:";
            // 
            // propertyDBDataSet
            // 
            this.propertyDBDataSet.DataSetName = "PropertyDBDataSet";
            this.propertyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyTableBindingSource
            // 
            this.propertyTableBindingSource.DataMember = "PropertyTable";
            this.propertyTableBindingSource.DataSource = this.propertyDBDataSet;
            // 
            // propertyTableTableAdapter
            // 
            this.propertyTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableTableAdapter = null;
            this.tableAdapterManager.OfferTableTableAdapter = this.offerTableTableAdapter;
            this.tableAdapterManager.PropertyTableTableAdapter = this.propertyTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = project2v3_csc330.PropertyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // offerTableTableAdapter
            // 
            this.offerTableTableAdapter.ClearBeforeFill = true;
            // 
            // propertyTableBindingNavigator
            // 
            this.propertyTableBindingNavigator.AddNewItem = null;
            this.propertyTableBindingNavigator.BindingSource = this.propertyTableBindingSource;
            this.propertyTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertyTableBindingNavigator.DeleteItem = null;
            this.propertyTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.propertyTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.propertyTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertyTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertyTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertyTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertyTableBindingNavigator.Name = "propertyTableBindingNavigator";
            this.propertyTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertyTableBindingNavigator.Size = new System.Drawing.Size(1039, 25);
            this.propertyTableBindingNavigator.TabIndex = 0;
            this.propertyTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // propertyTableDataGridView
            // 
            this.propertyTableDataGridView.AutoGenerateColumns = false;
            this.propertyTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn26});
            this.propertyTableDataGridView.DataSource = this.propertyTableBindingSource;
            this.propertyTableDataGridView.Location = new System.Drawing.Point(300, 56);
            this.propertyTableDataGridView.Name = "propertyTableDataGridView";
            this.propertyTableDataGridView.Size = new System.Drawing.Size(716, 441);
            this.propertyTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Property_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Property_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Property_Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Property_Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Property_Square";
            this.dataGridViewTextBoxColumn3.HeaderText = "Property_Square";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Property_Lot";
            this.dataGridViewTextBoxColumn4.HeaderText = "Property_Lot";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Property_Style";
            this.dataGridViewTextBoxColumn5.HeaderText = "Property_Style";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Property_Bedrooms";
            this.dataGridViewTextBoxColumn6.HeaderText = "Property_Bedrooms";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Property_Bathrooms";
            this.dataGridViewTextBoxColumn7.HeaderText = "Property_Bathrooms";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Property_Appliance";
            this.dataGridViewTextBoxColumn8.HeaderText = "Property_Appliance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Property_Garage";
            this.dataGridViewTextBoxColumn9.HeaderText = "Property_Garage";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Property_Basement";
            this.dataGridViewTextBoxColumn10.HeaderText = "Property_Basement";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Property_Age";
            this.dataGridViewTextBoxColumn11.HeaderText = "Property_Age";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Property_Status";
            this.dataGridViewTextBoxColumn12.HeaderText = "Property_Status";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Property_StreetAddress";
            this.dataGridViewTextBoxColumn13.HeaderText = "Property_StreetAddress";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Property_City";
            this.dataGridViewTextBoxColumn14.HeaderText = "Property_City";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Property_State";
            this.dataGridViewTextBoxColumn15.HeaderText = "Property_State";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Property_Country";
            this.dataGridViewTextBoxColumn16.HeaderText = "Property_Country";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Property_PostalCode";
            this.dataGridViewTextBoxColumn17.HeaderText = "Property_PostalCode";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Agent_Id";
            this.dataGridViewTextBoxColumn26.HeaderText = "Agent_Id";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // property_IdTextBox
            // 
            this.property_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Id", true));
            this.property_IdTextBox.Location = new System.Drawing.Point(153, 36);
            this.property_IdTextBox.Name = "property_IdTextBox";
            this.property_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_IdTextBox.TabIndex = 3;
            // 
            // property_PriceTextBox
            // 
            this.property_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Price", true));
            this.property_PriceTextBox.Location = new System.Drawing.Point(153, 62);
            this.property_PriceTextBox.Name = "property_PriceTextBox";
            this.property_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_PriceTextBox.TabIndex = 5;
            // 
            // property_SquareTextBox
            // 
            this.property_SquareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Square", true));
            this.property_SquareTextBox.Location = new System.Drawing.Point(153, 88);
            this.property_SquareTextBox.Name = "property_SquareTextBox";
            this.property_SquareTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_SquareTextBox.TabIndex = 7;
            // 
            // property_LotTextBox
            // 
            this.property_LotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Lot", true));
            this.property_LotTextBox.Location = new System.Drawing.Point(153, 114);
            this.property_LotTextBox.Name = "property_LotTextBox";
            this.property_LotTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_LotTextBox.TabIndex = 9;
            // 
            // property_StyleTextBox
            // 
            this.property_StyleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Style", true));
            this.property_StyleTextBox.Location = new System.Drawing.Point(153, 140);
            this.property_StyleTextBox.Name = "property_StyleTextBox";
            this.property_StyleTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_StyleTextBox.TabIndex = 11;
            // 
            // property_BedroomsTextBox
            // 
            this.property_BedroomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Bedrooms", true));
            this.property_BedroomsTextBox.Location = new System.Drawing.Point(153, 166);
            this.property_BedroomsTextBox.Name = "property_BedroomsTextBox";
            this.property_BedroomsTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_BedroomsTextBox.TabIndex = 13;
            // 
            // property_BathroomsTextBox
            // 
            this.property_BathroomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Bathrooms", true));
            this.property_BathroomsTextBox.Location = new System.Drawing.Point(153, 192);
            this.property_BathroomsTextBox.Name = "property_BathroomsTextBox";
            this.property_BathroomsTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_BathroomsTextBox.TabIndex = 15;
            // 
            // property_ApplianceTextBox
            // 
            this.property_ApplianceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Appliance", true));
            this.property_ApplianceTextBox.Location = new System.Drawing.Point(153, 218);
            this.property_ApplianceTextBox.Name = "property_ApplianceTextBox";
            this.property_ApplianceTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_ApplianceTextBox.TabIndex = 17;
            // 
            // property_GarageTextBox
            // 
            this.property_GarageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Garage", true));
            this.property_GarageTextBox.Location = new System.Drawing.Point(153, 244);
            this.property_GarageTextBox.Name = "property_GarageTextBox";
            this.property_GarageTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_GarageTextBox.TabIndex = 19;
            // 
            // property_BasementTextBox
            // 
            this.property_BasementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Basement", true));
            this.property_BasementTextBox.Location = new System.Drawing.Point(153, 270);
            this.property_BasementTextBox.Name = "property_BasementTextBox";
            this.property_BasementTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_BasementTextBox.TabIndex = 21;
            // 
            // property_AgeTextBox
            // 
            this.property_AgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Age", true));
            this.property_AgeTextBox.Location = new System.Drawing.Point(153, 296);
            this.property_AgeTextBox.Name = "property_AgeTextBox";
            this.property_AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_AgeTextBox.TabIndex = 23;
            // 
            // property_StatusTextBox
            // 
            this.property_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Status", true));
            this.property_StatusTextBox.Location = new System.Drawing.Point(153, 322);
            this.property_StatusTextBox.Name = "property_StatusTextBox";
            this.property_StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_StatusTextBox.TabIndex = 25;
            // 
            // property_StreetAddressTextBox
            // 
            this.property_StreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_StreetAddress", true));
            this.property_StreetAddressTextBox.Location = new System.Drawing.Point(153, 348);
            this.property_StreetAddressTextBox.Name = "property_StreetAddressTextBox";
            this.property_StreetAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_StreetAddressTextBox.TabIndex = 27;
            // 
            // property_CityTextBox
            // 
            this.property_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_City", true));
            this.property_CityTextBox.Location = new System.Drawing.Point(153, 374);
            this.property_CityTextBox.Name = "property_CityTextBox";
            this.property_CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_CityTextBox.TabIndex = 29;
            // 
            // property_StateTextBox
            // 
            this.property_StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_State", true));
            this.property_StateTextBox.Location = new System.Drawing.Point(153, 400);
            this.property_StateTextBox.Name = "property_StateTextBox";
            this.property_StateTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_StateTextBox.TabIndex = 31;
            // 
            // property_CountryTextBox
            // 
            this.property_CountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_Country", true));
            this.property_CountryTextBox.Location = new System.Drawing.Point(153, 426);
            this.property_CountryTextBox.Name = "property_CountryTextBox";
            this.property_CountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_CountryTextBox.TabIndex = 33;
            // 
            // property_PostalCodeTextBox
            // 
            this.property_PostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Property_PostalCode", true));
            this.property_PostalCodeTextBox.Location = new System.Drawing.Point(153, 452);
            this.property_PostalCodeTextBox.Name = "property_PostalCodeTextBox";
            this.property_PostalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.property_PostalCodeTextBox.TabIndex = 35;
            // 
            // agent_IdTextBox
            // 
            this.agent_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyTableBindingSource, "Agent_Id", true));
            this.agent_IdTextBox.Location = new System.Drawing.Point(153, 478);
            this.agent_IdTextBox.Name = "agent_IdTextBox";
            this.agent_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.agent_IdTextBox.TabIndex = 53;
            // 
            // offerTableBindingSource
            // 
            this.offerTableBindingSource.DataMember = "OfferTable";
            this.offerTableBindingSource.DataSource = this.propertyDBDataSet;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(636, 26);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 55;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // txt_Offer
            // 
            this.txt_Offer.Location = new System.Drawing.Point(412, 28);
            this.txt_Offer.Name = "txt_Offer";
            this.txt_Offer.Size = new System.Drawing.Size(100, 20);
            this.txt_Offer.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "CustomerID";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(518, 28);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerID.TabIndex = 58;
            // 
            // button_Status
            // 
            this.button_Status.Location = new System.Drawing.Point(941, 26);
            this.button_Status.Name = "button_Status";
            this.button_Status.Size = new System.Drawing.Size(75, 23);
            this.button_Status.TabIndex = 59;
            this.button_Status.Text = "Status";
            this.button_Status.UseVisualStyleBackColor = true;
            this.button_Status.Click += new System.EventHandler(this.button_Status_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "PropertyID";
            // 
            // txt_PropertyId
            // 
            this.txt_PropertyId.Location = new System.Drawing.Point(835, 28);
            this.txt_PropertyId.Name = "txt_PropertyId";
            this.txt_PropertyId.Size = new System.Drawing.Size(100, 20);
            this.txt_PropertyId.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "CustomerID";
            // 
            // text_CustomerId2
            // 
            this.text_CustomerId2.Location = new System.Drawing.Point(729, 28);
            this.text_CustomerId2.Name = "text_CustomerId2";
            this.text_CustomerId2.Size = new System.Drawing.Size(100, 20);
            this.text_CustomerId2.TabIndex = 63;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(317, 26);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 64;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 515);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.text_CustomerId2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PropertyId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Status);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Offer);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(offerLabel);
            this.Controls.Add(property_IdLabel);
            this.Controls.Add(this.property_IdTextBox);
            this.Controls.Add(property_PriceLabel);
            this.Controls.Add(this.property_PriceTextBox);
            this.Controls.Add(property_SquareLabel);
            this.Controls.Add(this.property_SquareTextBox);
            this.Controls.Add(property_LotLabel);
            this.Controls.Add(this.property_LotTextBox);
            this.Controls.Add(property_StyleLabel);
            this.Controls.Add(this.property_StyleTextBox);
            this.Controls.Add(property_BedroomsLabel);
            this.Controls.Add(this.property_BedroomsTextBox);
            this.Controls.Add(property_BathroomsLabel);
            this.Controls.Add(this.property_BathroomsTextBox);
            this.Controls.Add(property_ApplianceLabel);
            this.Controls.Add(this.property_ApplianceTextBox);
            this.Controls.Add(property_GarageLabel);
            this.Controls.Add(this.property_GarageTextBox);
            this.Controls.Add(property_BasementLabel);
            this.Controls.Add(this.property_BasementTextBox);
            this.Controls.Add(property_AgeLabel);
            this.Controls.Add(this.property_AgeTextBox);
            this.Controls.Add(property_StatusLabel);
            this.Controls.Add(this.property_StatusTextBox);
            this.Controls.Add(property_StreetAddressLabel);
            this.Controls.Add(this.property_StreetAddressTextBox);
            this.Controls.Add(property_CityLabel);
            this.Controls.Add(this.property_CityTextBox);
            this.Controls.Add(property_StateLabel);
            this.Controls.Add(this.property_StateTextBox);
            this.Controls.Add(property_CountryLabel);
            this.Controls.Add(this.property_CountryTextBox);
            this.Controls.Add(property_PostalCodeLabel);
            this.Controls.Add(this.property_PostalCodeTextBox);
            this.Controls.Add(agent_IdLabel);
            this.Controls.Add(this.agent_IdTextBox);
            this.Controls.Add(this.propertyTableDataGridView);
            this.Controls.Add(this.propertyTableBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTableBindingNavigator)).EndInit();
            this.propertyTableBindingNavigator.ResumeLayout(false);
            this.propertyTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PropertyDBDataSet propertyDBDataSet;
        private System.Windows.Forms.BindingSource propertyTableBindingSource;
        private PropertyDBDataSetTableAdapters.PropertyTableTableAdapter propertyTableTableAdapter;
        private PropertyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator propertyTableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private PropertyDBDataSetTableAdapters.OfferTableTableAdapter offerTableTableAdapter;
        private System.Windows.Forms.DataGridView propertyTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.TextBox property_IdTextBox;
        private System.Windows.Forms.TextBox property_PriceTextBox;
        private System.Windows.Forms.TextBox property_SquareTextBox;
        private System.Windows.Forms.TextBox property_LotTextBox;
        private System.Windows.Forms.TextBox property_StyleTextBox;
        private System.Windows.Forms.TextBox property_BedroomsTextBox;
        private System.Windows.Forms.TextBox property_BathroomsTextBox;
        private System.Windows.Forms.TextBox property_ApplianceTextBox;
        private System.Windows.Forms.TextBox property_GarageTextBox;
        private System.Windows.Forms.TextBox property_BasementTextBox;
        private System.Windows.Forms.TextBox property_AgeTextBox;
        private System.Windows.Forms.TextBox property_StatusTextBox;
        private System.Windows.Forms.TextBox property_StreetAddressTextBox;
        private System.Windows.Forms.TextBox property_CityTextBox;
        private System.Windows.Forms.TextBox property_StateTextBox;
        private System.Windows.Forms.TextBox property_CountryTextBox;
        private System.Windows.Forms.TextBox property_PostalCodeTextBox;
        private System.Windows.Forms.TextBox agent_IdTextBox;
        private System.Windows.Forms.BindingSource offerTableBindingSource;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox txt_Offer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button button_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PropertyId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_CustomerId2;
        private System.Windows.Forms.Button button_Refresh;
    }
}