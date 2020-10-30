namespace Pharmay0._0._2.UI.Suppliers
{
    partial class NewShipmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewShipmentForm));
            this.supplierPanel = new System.Windows.Forms.Panel();
            this.errorMessage = new System.Windows.Forms.Label();
            this.moveToAddCom = new System.Windows.Forms.LinkLabel();
            this.companiesListCombox = new System.Windows.Forms.ComboBox();
            this.companyNameLabel = new System.Windows.Forms.TextBox();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.orderMidsPanel = new System.Windows.Forms.Panel();
            this.shipmentMedsDetails = new System.Windows.Forms.DataGridView();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ShipmenDtls = new System.Windows.Forms.Label();
            this.updateOrderMedsPanel = new System.Windows.Forms.Panel();
            this.deteteButton = new System.Windows.Forms.Button();
            this.cancelUpdateButton = new System.Windows.Forms.Button();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.addExtraMedToOrder = new System.Windows.Forms.Button();
            this.expireDateLabel = new System.Windows.Forms.Label();
            this.ExpireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.sellingPriceTextBx = new System.Windows.Forms.TextBox();
            this.buyingPriceLabel = new System.Windows.Forms.Label();
            this.tepesPerPackageLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.medicenName = new System.Windows.Forms.Label();
            this.pareCodeLabel = new System.Windows.Forms.Label();
            this.buyingPriceEditBx = new System.Windows.Forms.TextBox();
            this.numberOfTapesEditBox = new System.Windows.Forms.TextBox();
            this.amoutTextBox = new System.Windows.Forms.TextBox();
            this.medicenTextBox = new System.Windows.Forms.TextBox();
            this.parcodeTextBx = new System.Windows.Forms.TextBox();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.supplierPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.orderMidsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentMedsDetails)).BeginInit();
            this.updateOrderMedsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierPanel
            // 
            this.supplierPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.supplierPanel.Controls.Add(this.errorMessage);
            this.supplierPanel.Controls.Add(this.moveToAddCom);
            this.supplierPanel.Controls.Add(this.companiesListCombox);
            this.supplierPanel.Controls.Add(this.companyNameLabel);
            this.supplierPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplierPanel.Location = new System.Drawing.Point(0, 0);
            this.supplierPanel.Name = "supplierPanel";
            this.supplierPanel.Size = new System.Drawing.Size(597, 93);
            this.supplierPanel.TabIndex = 0;
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(129)))), ((int)(((byte)(9)))));
            this.errorMessage.Location = new System.Drawing.Point(12, 73);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(34, 17);
            this.errorMessage.TabIndex = 13;
            this.errorMessage.Text = "Error";
            this.errorMessage.Visible = false;
            // 
            // moveToAddCom
            // 
            this.moveToAddCom.ActiveLinkColor = System.Drawing.Color.Silver;
            this.moveToAddCom.AutoSize = true;
            this.moveToAddCom.LinkColor = System.Drawing.Color.Transparent;
            this.moveToAddCom.Location = new System.Drawing.Point(194, 54);
            this.moveToAddCom.Name = "moveToAddCom";
            this.moveToAddCom.Size = new System.Drawing.Size(220, 19);
            this.moveToAddCom.TabIndex = 12;
            this.moveToAddCom.TabStop = true;
            this.moveToAddCom.Text = "Click here to add new supplier";
            this.moveToAddCom.VisitedLinkColor = System.Drawing.Color.Gray;
            this.moveToAddCom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moveToAddCom_LinkClicked);
            // 
            // companiesListCombox
            // 
            this.companiesListCombox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.companiesListCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companiesListCombox.ForeColor = System.Drawing.Color.Silver;
            this.companiesListCombox.FormattingEnabled = true;
            this.companiesListCombox.Location = new System.Drawing.Point(153, 26);
            this.companiesListCombox.Name = "companiesListCombox";
            this.companiesListCombox.Size = new System.Drawing.Size(302, 25);
            this.companiesListCombox.Sorted = true;
            this.companiesListCombox.TabIndex = 11;
            this.companiesListCombox.TabStop = false;
            this.companiesListCombox.SelectedIndexChanged += new System.EventHandler(this.companiesListCombox_SelectedIndexChanged);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.companyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.companyNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, 0);
            this.companyNameLabel.MaxLength = 20;
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.ReadOnly = true;
            this.companyNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyNameLabel.Size = new System.Drawing.Size(597, 20);
            this.companyNameLabel.TabIndex = 10;
            this.companyNameLabel.Text = "Select Company";
            this.companyNameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.middlePanel.Controls.Add(this.orderMidsPanel);
            this.middlePanel.Controls.Add(this.updateOrderMedsPanel);
            this.middlePanel.Controls.Add(this.addExtraMedToOrder);
            this.middlePanel.Controls.Add(this.expireDateLabel);
            this.middlePanel.Controls.Add(this.ExpireDatePicker);
            this.middlePanel.Controls.Add(this.label1);
            this.middlePanel.Controls.Add(this.sellingPriceTextBx);
            this.middlePanel.Controls.Add(this.buyingPriceLabel);
            this.middlePanel.Controls.Add(this.tepesPerPackageLabel);
            this.middlePanel.Controls.Add(this.amountLabel);
            this.middlePanel.Controls.Add(this.medicenName);
            this.middlePanel.Controls.Add(this.pareCodeLabel);
            this.middlePanel.Controls.Add(this.buyingPriceEditBx);
            this.middlePanel.Controls.Add(this.numberOfTapesEditBox);
            this.middlePanel.Controls.Add(this.amoutTextBox);
            this.middlePanel.Controls.Add(this.medicenTextBox);
            this.middlePanel.Controls.Add(this.parcodeTextBx);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(0, 93);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(597, 335);
            this.middlePanel.TabIndex = 1;
            // 
            // orderMidsPanel
            // 
            this.orderMidsPanel.AutoScroll = true;
            this.orderMidsPanel.Controls.Add(this.shipmentMedsDetails);
            this.orderMidsPanel.Controls.Add(this.TotalLabel);
            this.orderMidsPanel.Controls.Add(this.ShipmenDtls);
            this.orderMidsPanel.Location = new System.Drawing.Point(345, 0);
            this.orderMidsPanel.Name = "orderMidsPanel";
            this.orderMidsPanel.Size = new System.Drawing.Size(252, 266);
            this.orderMidsPanel.TabIndex = 31;
            // 
            // shipmentMedsDetails
            // 
            this.shipmentMedsDetails.AllowUserToAddRows = false;
            this.shipmentMedsDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shipmentMedsDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.shipmentMedsDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shipmentMedsDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.shipmentMedsDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipmentMedsDetails.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shipmentMedsDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.shipmentMedsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentMedsDetails.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shipmentMedsDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.shipmentMedsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipmentMedsDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.shipmentMedsDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.shipmentMedsDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.shipmentMedsDetails.Location = new System.Drawing.Point(0, 20);
            this.shipmentMedsDetails.Name = "shipmentMedsDetails";
            this.shipmentMedsDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shipmentMedsDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.shipmentMedsDetails.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shipmentMedsDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.shipmentMedsDetails.Size = new System.Drawing.Size(252, 226);
            this.shipmentMedsDetails.TabIndex = 24;
            this.shipmentMedsDetails.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipmentMedsDetails_CellContentDoubleClick);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.TotalLabel.Location = new System.Drawing.Point(0, 246);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(42, 20);
            this.TotalLabel.TabIndex = 23;
            this.TotalLabel.Text = "Total";
            // 
            // ShipmenDtls
            // 
            this.ShipmenDtls.AutoSize = true;
            this.ShipmenDtls.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShipmenDtls.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ShipmenDtls.Location = new System.Drawing.Point(0, 0);
            this.ShipmenDtls.Name = "ShipmenDtls";
            this.ShipmenDtls.Size = new System.Drawing.Size(127, 20);
            this.ShipmenDtls.TabIndex = 22;
            this.ShipmenDtls.Text = "Shipment Details";
            // 
            // updateOrderMedsPanel
            // 
            this.updateOrderMedsPanel.Controls.Add(this.deteteButton);
            this.updateOrderMedsPanel.Controls.Add(this.cancelUpdateButton);
            this.updateOrderMedsPanel.Controls.Add(this.saveUpdateButton);
            this.updateOrderMedsPanel.Location = new System.Drawing.Point(15, 254);
            this.updateOrderMedsPanel.Name = "updateOrderMedsPanel";
            this.updateOrderMedsPanel.Size = new System.Drawing.Size(207, 37);
            this.updateOrderMedsPanel.TabIndex = 30;
            // 
            // deteteButton
            // 
            this.deteteButton.BackColor = System.Drawing.Color.Maroon;
            this.deteteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deteteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deteteButton.FlatAppearance.BorderSize = 0;
            this.deteteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.deteteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deteteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deteteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deteteButton.ForeColor = System.Drawing.Color.Silver;
            this.deteteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deteteButton.Location = new System.Drawing.Point(0, 0);
            this.deteteButton.Name = "deteteButton";
            this.deteteButton.Size = new System.Drawing.Size(69, 37);
            this.deteteButton.TabIndex = 32;
            this.deteteButton.Text = "Delete";
            this.deteteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deteteButton.UseVisualStyleBackColor = false;
            this.deteteButton.Click += new System.EventHandler(this.deteteButton_Click);
            // 
            // cancelUpdateButton
            // 
            this.cancelUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cancelUpdateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelUpdateButton.FlatAppearance.BorderSize = 0;
            this.cancelUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cancelUpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cancelUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelUpdateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelUpdateButton.ForeColor = System.Drawing.Color.Silver;
            this.cancelUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelUpdateButton.Image")));
            this.cancelUpdateButton.Location = new System.Drawing.Point(69, 0);
            this.cancelUpdateButton.Name = "cancelUpdateButton";
            this.cancelUpdateButton.Size = new System.Drawing.Size(69, 37);
            this.cancelUpdateButton.TabIndex = 31;
            this.cancelUpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelUpdateButton.UseVisualStyleBackColor = false;
            this.cancelUpdateButton.Click += new System.EventHandler(this.cancelUpdateButton_Click);
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.saveUpdateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveUpdateButton.FlatAppearance.BorderSize = 0;
            this.saveUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.saveUpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.saveUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUpdateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUpdateButton.ForeColor = System.Drawing.Color.Silver;
            this.saveUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("saveUpdateButton.Image")));
            this.saveUpdateButton.Location = new System.Drawing.Point(138, 0);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(69, 37);
            this.saveUpdateButton.TabIndex = 30;
            this.saveUpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveUpdateButton.UseVisualStyleBackColor = false;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // addExtraMedToOrder
            // 
            this.addExtraMedToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.addExtraMedToOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addExtraMedToOrder.FlatAppearance.BorderSize = 0;
            this.addExtraMedToOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addExtraMedToOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addExtraMedToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExtraMedToOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExtraMedToOrder.ForeColor = System.Drawing.Color.Silver;
            this.addExtraMedToOrder.Image = ((System.Drawing.Image)(resources.GetObject("addExtraMedToOrder.Image")));
            this.addExtraMedToOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addExtraMedToOrder.Location = new System.Drawing.Point(15, 211);
            this.addExtraMedToOrder.Name = "addExtraMedToOrder";
            this.addExtraMedToOrder.Size = new System.Drawing.Size(207, 37);
            this.addExtraMedToOrder.TabIndex = 29;
            this.addExtraMedToOrder.Text = "Add Extra Medicen";
            this.addExtraMedToOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addExtraMedToOrder.UseVisualStyleBackColor = false;
            this.addExtraMedToOrder.Visible = false;
            this.addExtraMedToOrder.Click += new System.EventHandler(this.addExtraMedToOrder_Click);
            // 
            // expireDateLabel
            // 
            this.expireDateLabel.AutoSize = true;
            this.expireDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.expireDateLabel.Location = new System.Drawing.Point(11, 64);
            this.expireDateLabel.Name = "expireDateLabel";
            this.expireDateLabel.Size = new System.Drawing.Size(96, 20);
            this.expireDateLabel.TabIndex = 28;
            this.expireDateLabel.Text = "Expire Date ";
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.ExpireDatePicker.CustomFormat = "";
            this.ExpireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpireDatePicker.Location = new System.Drawing.Point(155, 64);
            this.ExpireDatePicker.MinDate = new System.DateTime(2020, 1, 7, 0, 0, 0, 0);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(169, 24);
            this.ExpireDatePicker.TabIndex = 27;
            this.ExpireDatePicker.Value = new System.DateTime(2020, 10, 12, 0, 0, 0, 0);
            this.ExpireDatePicker.ValueChanged += new System.EventHandler(this.ExpireDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(11, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Selling price / Unit";
            // 
            // sellingPriceTextBx
            // 
            this.sellingPriceTextBx.BackColor = System.Drawing.SystemColors.Control;
            this.sellingPriceTextBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellingPriceTextBx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingPriceTextBx.ForeColor = System.Drawing.Color.Black;
            this.sellingPriceTextBx.Location = new System.Drawing.Point(155, 182);
            this.sellingPriceTextBx.MaxLength = 20;
            this.sellingPriceTextBx.Name = "sellingPriceTextBx";
            this.sellingPriceTextBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sellingPriceTextBx.Size = new System.Drawing.Size(67, 23);
            this.sellingPriceTextBx.TabIndex = 25;
            this.sellingPriceTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buyingPriceLabel
            // 
            this.buyingPriceLabel.AutoSize = true;
            this.buyingPriceLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buyingPriceLabel.Location = new System.Drawing.Point(11, 153);
            this.buyingPriceLabel.Name = "buyingPriceLabel";
            this.buyingPriceLabel.Size = new System.Drawing.Size(142, 20);
            this.buyingPriceLabel.TabIndex = 24;
            this.buyingPriceLabel.Text = "Buying price / Unit";
            // 
            // tepesPerPackageLabel
            // 
            this.tepesPerPackageLabel.AutoSize = true;
            this.tepesPerPackageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.tepesPerPackageLabel.Location = new System.Drawing.Point(11, 124);
            this.tepesPerPackageLabel.Name = "tepesPerPackageLabel";
            this.tepesPerPackageLabel.Size = new System.Drawing.Size(93, 20);
            this.tepesPerPackageLabel.TabIndex = 23;
            this.tepesPerPackageLabel.Text = "Tapes / Unit";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.amountLabel.Location = new System.Drawing.Point(11, 95);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(108, 20);
            this.amountLabel.TabIndex = 22;
            this.amountLabel.Text = "Amount (Unit)";
            // 
            // medicenName
            // 
            this.medicenName.AutoSize = true;
            this.medicenName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.medicenName.Location = new System.Drawing.Point(11, 35);
            this.medicenName.Name = "medicenName";
            this.medicenName.Size = new System.Drawing.Size(124, 20);
            this.medicenName.TabIndex = 21;
            this.medicenName.Text = "Medicen Name";
            // 
            // pareCodeLabel
            // 
            this.pareCodeLabel.AutoSize = true;
            this.pareCodeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.pareCodeLabel.Location = new System.Drawing.Point(11, 6);
            this.pareCodeLabel.Name = "pareCodeLabel";
            this.pareCodeLabel.Size = new System.Drawing.Size(83, 20);
            this.pareCodeLabel.TabIndex = 20;
            this.pareCodeLabel.Text = "Parecode";
            // 
            // buyingPriceEditBx
            // 
            this.buyingPriceEditBx.BackColor = System.Drawing.SystemColors.Control;
            this.buyingPriceEditBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyingPriceEditBx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyingPriceEditBx.ForeColor = System.Drawing.Color.Black;
            this.buyingPriceEditBx.Location = new System.Drawing.Point(155, 153);
            this.buyingPriceEditBx.MaxLength = 20;
            this.buyingPriceEditBx.Name = "buyingPriceEditBx";
            this.buyingPriceEditBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buyingPriceEditBx.Size = new System.Drawing.Size(67, 23);
            this.buyingPriceEditBx.TabIndex = 19;
            this.buyingPriceEditBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfTapesEditBox
            // 
            this.numberOfTapesEditBox.BackColor = System.Drawing.SystemColors.Control;
            this.numberOfTapesEditBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfTapesEditBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTapesEditBox.ForeColor = System.Drawing.Color.Black;
            this.numberOfTapesEditBox.Location = new System.Drawing.Point(155, 124);
            this.numberOfTapesEditBox.MaxLength = 20;
            this.numberOfTapesEditBox.Name = "numberOfTapesEditBox";
            this.numberOfTapesEditBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numberOfTapesEditBox.Size = new System.Drawing.Size(67, 23);
            this.numberOfTapesEditBox.TabIndex = 17;
            this.numberOfTapesEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amoutTextBox
            // 
            this.amoutTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.amoutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amoutTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amoutTextBox.ForeColor = System.Drawing.Color.Black;
            this.amoutTextBox.Location = new System.Drawing.Point(155, 95);
            this.amoutTextBox.MaxLength = 20;
            this.amoutTextBox.Name = "amoutTextBox";
            this.amoutTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amoutTextBox.Size = new System.Drawing.Size(67, 23);
            this.amoutTextBox.TabIndex = 15;
            this.amoutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medicenTextBox
            // 
            this.medicenTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.medicenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicenTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicenTextBox.ForeColor = System.Drawing.Color.Black;
            this.medicenTextBox.Location = new System.Drawing.Point(155, 35);
            this.medicenTextBox.MaxLength = 20;
            this.medicenTextBox.Name = "medicenTextBox";
            this.medicenTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.medicenTextBox.Size = new System.Drawing.Size(169, 23);
            this.medicenTextBox.TabIndex = 13;
            this.medicenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parcodeTextBx
            // 
            this.parcodeTextBx.BackColor = System.Drawing.SystemColors.Control;
            this.parcodeTextBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parcodeTextBx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcodeTextBx.ForeColor = System.Drawing.Color.Black;
            this.parcodeTextBx.Location = new System.Drawing.Point(155, 6);
            this.parcodeTextBx.MaxLength = 20;
            this.parcodeTextBx.Name = "parcodeTextBx";
            this.parcodeTextBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parcodeTextBx.Size = new System.Drawing.Size(169, 23);
            this.parcodeTextBx.TabIndex = 2;
            this.parcodeTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parcodeTextBx.TextChanged += new System.EventHandler(this.parcodeTextBx_TextChanged);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.placeOrderButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.placeOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.placeOrderButton.FlatAppearance.BorderSize = 0;
            this.placeOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.placeOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.ForeColor = System.Drawing.Color.Silver;
            this.placeOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.placeOrderButton.Location = new System.Drawing.Point(0, 383);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(597, 45);
            this.placeOrderButton.TabIndex = 33;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // NewShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.supplierPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewShipmentForm";
            this.Text = "NewShipmentForm";
            this.Load += new System.EventHandler(this.NewShipmentForm_Load);
            this.supplierPanel.ResumeLayout(false);
            this.supplierPanel.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.orderMidsPanel.ResumeLayout(false);
            this.orderMidsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentMedsDetails)).EndInit();
            this.updateOrderMedsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel supplierPanel;
        private System.Windows.Forms.LinkLabel moveToAddCom;
        private System.Windows.Forms.ComboBox companiesListCombox;
        public System.Windows.Forms.TextBox companyNameLabel;
        private System.Windows.Forms.Panel middlePanel;
        public System.Windows.Forms.TextBox parcodeTextBx;
        private System.Windows.Forms.Label pareCodeLabel;
        private System.Windows.Forms.Panel orderMidsPanel;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label ShipmenDtls;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridView shipmentMedsDetails;
        private System.Windows.Forms.Panel updateOrderMedsPanel;
        private System.Windows.Forms.Button deteteButton;
        private System.Windows.Forms.Button cancelUpdateButton;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Button addExtraMedToOrder;
        private System.Windows.Forms.Label expireDateLabel;
        private System.Windows.Forms.DateTimePicker ExpireDatePicker;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox sellingPriceTextBx;
        private System.Windows.Forms.Label buyingPriceLabel;
        private System.Windows.Forms.Label tepesPerPackageLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label medicenName;
        public System.Windows.Forms.TextBox buyingPriceEditBx;
        public System.Windows.Forms.TextBox numberOfTapesEditBox;
        public System.Windows.Forms.TextBox amoutTextBox;
        public System.Windows.Forms.TextBox medicenTextBox;
        private System.Windows.Forms.Label errorMessage;
    }
}