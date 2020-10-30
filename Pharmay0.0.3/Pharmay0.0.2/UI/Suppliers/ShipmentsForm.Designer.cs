namespace Pharmay0._0._2.UI.Suppliers
{
    partial class ShipmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recentShipmentsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remainingLabel = new System.Windows.Forms.TextBox();
            this.paidAmountLabel = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.TextBox();
            this.addNewShipment = new System.Windows.Forms.Button();
            this.shipmentsData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.All = new System.Windows.Forms.CheckBox();
            this.PaidNotPaid = new System.Windows.Forms.CheckBox();
            this.deteteButton = new System.Windows.Forms.Button();
            this.DateFilterPanel = new System.Windows.Forms.Panel();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsData)).BeginInit();
            this.panel2.SuspendLayout();
            this.DateFilterPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // recentShipmentsButton
            // 
            this.recentShipmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.recentShipmentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentShipmentsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.recentShipmentsButton.FlatAppearance.BorderSize = 0;
            this.recentShipmentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.recentShipmentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.recentShipmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentShipmentsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentShipmentsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.recentShipmentsButton.Location = new System.Drawing.Point(0, 0);
            this.recentShipmentsButton.Name = "recentShipmentsButton";
            this.recentShipmentsButton.Size = new System.Drawing.Size(597, 32);
            this.recentShipmentsButton.TabIndex = 3;
            this.recentShipmentsButton.Text = "Recent Shipments";
            this.recentShipmentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recentShipmentsButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.remainingLabel);
            this.panel1.Controls.Add(this.paidAmountLabel);
            this.panel1.Controls.Add(this.totalPriceLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.companyNameLabel);
            this.panel1.Controls.Add(this.recentShipmentsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 69);
            this.panel1.TabIndex = 5;
            // 
            // remainingLabel
            // 
            this.remainingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.remainingLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remainingLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.remainingLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.remainingLabel.Location = new System.Drawing.Point(476, 32);
            this.remainingLabel.MaxLength = 20;
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.ReadOnly = true;
            this.remainingLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.remainingLabel.Size = new System.Drawing.Size(119, 16);
            this.remainingLabel.TabIndex = 13;
            this.remainingLabel.Text = "Remain";
            this.remainingLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paidAmountLabel
            // 
            this.paidAmountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.paidAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paidAmountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.paidAmountLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paidAmountLabel.Location = new System.Drawing.Point(357, 32);
            this.paidAmountLabel.MaxLength = 20;
            this.paidAmountLabel.Name = "paidAmountLabel";
            this.paidAmountLabel.ReadOnly = true;
            this.paidAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paidAmountLabel.Size = new System.Drawing.Size(119, 16);
            this.paidAmountLabel.TabIndex = 12;
            this.paidAmountLabel.Text = "Paid ";
            this.paidAmountLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPriceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalPriceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(238, 32);
            this.totalPriceLabel.MaxLength = 20;
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.ReadOnly = true;
            this.totalPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPriceLabel.Size = new System.Drawing.Size(119, 16);
            this.totalPriceLabel.TabIndex = 11;
            this.totalPriceLabel.Text = "Cost";
            this.totalPriceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateLabel.Location = new System.Drawing.Point(119, 32);
            this.dateLabel.MaxLength = 20;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.ReadOnly = true;
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateLabel.Size = new System.Drawing.Size(119, 16);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.companyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.companyNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, 32);
            this.companyNameLabel.MaxLength = 20;
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.ReadOnly = true;
            this.companyNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyNameLabel.Size = new System.Drawing.Size(119, 16);
            this.companyNameLabel.TabIndex = 9;
            this.companyNameLabel.Text = "Company";
            this.companyNameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addNewShipment
            // 
            this.addNewShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.addNewShipment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addNewShipment.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addNewShipment.FlatAppearance.BorderSize = 0;
            this.addNewShipment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addNewShipment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addNewShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewShipment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewShipment.ForeColor = System.Drawing.Color.Silver;
            this.addNewShipment.Image = ((System.Drawing.Image)(resources.GetObject("addNewShipment.Image")));
            this.addNewShipment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewShipment.Location = new System.Drawing.Point(0, 374);
            this.addNewShipment.Name = "addNewShipment";
            this.addNewShipment.Size = new System.Drawing.Size(597, 54);
            this.addNewShipment.TabIndex = 6;
            this.addNewShipment.Text = "New ";
            this.addNewShipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewShipment.UseVisualStyleBackColor = false;
            this.addNewShipment.Click += new System.EventHandler(this.addNewShipment_Click);
            // 
            // shipmentsData
            // 
            this.shipmentsData.AllowUserToAddRows = false;
            this.shipmentsData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shipmentsData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.shipmentsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shipmentsData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.shipmentsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipmentsData.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shipmentsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.shipmentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentsData.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shipmentsData.DefaultCellStyle = dataGridViewCellStyle3;
            this.shipmentsData.Dock = System.Windows.Forms.DockStyle.Top;
            this.shipmentsData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.shipmentsData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.shipmentsData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.shipmentsData.Location = new System.Drawing.Point(0, 69);
            this.shipmentsData.Name = "shipmentsData";
            this.shipmentsData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shipmentsData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.shipmentsData.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shipmentsData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.shipmentsData.Size = new System.Drawing.Size(597, 305);
            this.shipmentsData.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.All);
            this.panel2.Controls.Add(this.PaidNotPaid);
            this.panel2.Controls.Add(this.deteteButton);
            this.panel2.Controls.Add(this.DateFilterPanel);
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 51);
            this.panel2.TabIndex = 8;
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(308, 27);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(42, 21);
            this.All.TabIndex = 40;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            this.All.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // PaidNotPaid
            // 
            this.PaidNotPaid.AutoSize = true;
            this.PaidNotPaid.Location = new System.Drawing.Point(308, 0);
            this.PaidNotPaid.Name = "PaidNotPaid";
            this.PaidNotPaid.Size = new System.Drawing.Size(80, 21);
            this.PaidNotPaid.TabIndex = 39;
            this.PaidNotPaid.Text = "NotPaid";
            this.PaidNotPaid.UseVisualStyleBackColor = true;
            this.PaidNotPaid.CheckedChanged += new System.EventHandler(this.PaidNotPaid_CheckedChanged);
            // 
            // deteteButton
            // 
            this.deteteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.deteteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deteteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deteteButton.FlatAppearance.BorderSize = 0;
            this.deteteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.deteteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deteteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deteteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deteteButton.ForeColor = System.Drawing.Color.Silver;
            this.deteteButton.Image = ((System.Drawing.Image)(resources.GetObject("deteteButton.Image")));
            this.deteteButton.Location = new System.Drawing.Point(431, 0);
            this.deteteButton.MaximumSize = new System.Drawing.Size(230, 55);
            this.deteteButton.Name = "deteteButton";
            this.deteteButton.Size = new System.Drawing.Size(44, 49);
            this.deteteButton.TabIndex = 38;
            this.deteteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deteteButton.UseVisualStyleBackColor = false;
            this.deteteButton.Click += new System.EventHandler(this.deteteButton_Click);
            // 
            // DateFilterPanel
            // 
            this.DateFilterPanel.Controls.Add(this.ToDatePicker);
            this.DateFilterPanel.Controls.Add(this.FromDatePicker);
            this.DateFilterPanel.Controls.Add(this.panel6);
            this.DateFilterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DateFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.DateFilterPanel.Name = "DateFilterPanel";
            this.DateFilterPanel.Size = new System.Drawing.Size(282, 49);
            this.DateFilterPanel.TabIndex = 7;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.ToDatePicker.CustomFormat = "";
            this.ToDatePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToDatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDatePicker.Location = new System.Drawing.Point(46, 26);
            this.ToDatePicker.MinDate = new System.DateTime(2020, 1, 7, 0, 0, 0, 0);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(236, 23);
            this.ToDatePicker.TabIndex = 37;
            this.ToDatePicker.Value = new System.DateTime(2020, 10, 12, 0, 0, 0, 0);
            this.ToDatePicker.ValueChanged += new System.EventHandler(this.ToDatePicker_ValueChanged);
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.FromDatePicker.CustomFormat = "";
            this.FromDatePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.FromDatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatePicker.Location = new System.Drawing.Point(46, 0);
            this.FromDatePicker.MinDate = new System.DateTime(2020, 1, 7, 0, 0, 0, 0);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(236, 23);
            this.FromDatePicker.TabIndex = 36;
            this.FromDatePicker.Value = new System.DateTime(2020, 10, 12, 8, 15, 16, 0);
            this.FromDatePicker.ValueChanged += new System.EventHandler(this.FromDatePicker_ValueChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(46, 49);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(0, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "To    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "From:";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.filterButton.FlatAppearance.BorderSize = 0;
            this.filterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.filterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterButton.Location = new System.Drawing.Point(475, 0);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 49);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Filter";
            this.filterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // ShipmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.shipmentsData);
            this.Controls.Add(this.addNewShipment);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShipmentsForm";
            this.Text = "ShipmentsForm";
            this.Load += new System.EventHandler(this.ShipmentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DateFilterPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recentShipmentsButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox remainingLabel;
        public System.Windows.Forms.TextBox paidAmountLabel;
        public System.Windows.Forms.TextBox totalPriceLabel;
        public System.Windows.Forms.TextBox dateLabel;
        public System.Windows.Forms.TextBox companyNameLabel;
        private System.Windows.Forms.Button addNewShipment;
        private System.Windows.Forms.DataGridView shipmentsData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Panel DateFilterPanel;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deteteButton;
        private System.Windows.Forms.CheckBox All;
        private System.Windows.Forms.CheckBox PaidNotPaid;
    }
}