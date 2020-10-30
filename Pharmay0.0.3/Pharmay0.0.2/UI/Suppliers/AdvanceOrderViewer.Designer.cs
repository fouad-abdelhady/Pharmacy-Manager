namespace Pharmay0._0._2.UI.Suppliers
{
    partial class AdvanceOrderViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvanceOrderViewer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.GeneralFilterPanel = new System.Windows.Forms.Panel();
            this.NumOfOrders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioAll = new System.Windows.Forms.RadioButton();
            this.RadioUnpaid = new System.Windows.Forms.RadioButton();
            this.DateFilterPanel = new System.Windows.Forms.Panel();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deteteButton = new System.Windows.Forms.Button();
            this.RadioPaid = new System.Windows.Forms.RadioButton();
            this.RadioDate = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.GeneralFilterPanel.SuspendLayout();
            this.DateFilterPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ApplyFilter);
            this.panel2.Controls.Add(this.GeneralFilterPanel);
            this.panel2.Controls.Add(this.DateFilterPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 114);
            this.panel2.TabIndex = 2;
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.BackColor = System.Drawing.Color.Transparent;
            this.ApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ApplyFilter.FlatAppearance.BorderSize = 0;
            this.ApplyFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplyFilter.Location = new System.Drawing.Point(192, 34);
            this.ApplyFilter.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(117, 77);
            this.ApplyFilter.TabIndex = 2;
            this.ApplyFilter.Text = "Apply";
            this.ApplyFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ApplyFilter.UseVisualStyleBackColor = false;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // GeneralFilterPanel
            // 
            this.GeneralFilterPanel.Controls.Add(this.NumOfOrders);
            this.GeneralFilterPanel.Controls.Add(this.label2);
            this.GeneralFilterPanel.Controls.Add(this.RadioAll);
            this.GeneralFilterPanel.Controls.Add(this.RadioUnpaid);
            this.GeneralFilterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GeneralFilterPanel.Location = new System.Drawing.Point(0, 28);
            this.GeneralFilterPanel.Name = "GeneralFilterPanel";
            this.GeneralFilterPanel.Size = new System.Drawing.Size(179, 86);
            this.GeneralFilterPanel.TabIndex = 7;
            this.GeneralFilterPanel.Visible = false;
            // 
            // NumOfOrders
            // 
            this.NumOfOrders.BackColor = System.Drawing.SystemColors.Control;
            this.NumOfOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumOfOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.NumOfOrders.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfOrders.ForeColor = System.Drawing.Color.Black;
            this.NumOfOrders.Location = new System.Drawing.Point(103, 23);
            this.NumOfOrders.MaxLength = 20;
            this.NumOfOrders.Name = "NumOfOrders";
            this.NumOfOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumOfOrders.Size = new System.Drawing.Size(61, 23);
            this.NumOfOrders.TabIndex = 31;
            this.NumOfOrders.Text = "0";
            this.NumOfOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfOrders.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(0, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Num Of Orders";
            // 
            // RadioAll
            // 
            this.RadioAll.AutoSize = true;
            this.RadioAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RadioAll.Location = new System.Drawing.Point(0, 63);
            this.RadioAll.Name = "RadioAll";
            this.RadioAll.Size = new System.Drawing.Size(179, 23);
            this.RadioAll.TabIndex = 27;
            this.RadioAll.TabStop = true;
            this.RadioAll.Text = "All";
            this.RadioAll.UseVisualStyleBackColor = true;
            this.RadioAll.CheckedChanged += new System.EventHandler(this.RadioAll_CheckedChanged);
            // 
            // RadioUnpaid
            // 
            this.RadioUnpaid.AutoSize = true;
            this.RadioUnpaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioUnpaid.Dock = System.Windows.Forms.DockStyle.Top;
            this.RadioUnpaid.Location = new System.Drawing.Point(0, 0);
            this.RadioUnpaid.Name = "RadioUnpaid";
            this.RadioUnpaid.Size = new System.Drawing.Size(179, 23);
            this.RadioUnpaid.TabIndex = 1;
            this.RadioUnpaid.TabStop = true;
            this.RadioUnpaid.Text = "Unpaid ";
            this.RadioUnpaid.UseVisualStyleBackColor = true;
            this.RadioUnpaid.CheckedChanged += new System.EventHandler(this.RadioPaidOrders_CheckedChanged);
            // 
            // DateFilterPanel
            // 
            this.DateFilterPanel.Controls.Add(this.ToDatePicker);
            this.DateFilterPanel.Controls.Add(this.FromDatePicker);
            this.DateFilterPanel.Controls.Add(this.panel6);
            this.DateFilterPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DateFilterPanel.Location = new System.Drawing.Point(315, 28);
            this.DateFilterPanel.Name = "DateFilterPanel";
            this.DateFilterPanel.Size = new System.Drawing.Size(282, 86);
            this.DateFilterPanel.TabIndex = 6;
            this.DateFilterPanel.Visible = false;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.ToDatePicker.CustomFormat = "";
            this.ToDatePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToDatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDatePicker.Location = new System.Drawing.Point(46, 63);
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
            this.panel6.Size = new System.Drawing.Size(46, 86);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(0, 69);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.deteteButton);
            this.panel4.Controls.Add(this.RadioPaid);
            this.panel4.Controls.Add(this.RadioDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 28);
            this.panel4.TabIndex = 5;
            // 
            // deteteButton
            // 
            this.deteteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.deteteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deteteButton.FlatAppearance.BorderSize = 0;
            this.deteteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.deteteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deteteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deteteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deteteButton.ForeColor = System.Drawing.Color.Silver;
            this.deteteButton.Image = ((System.Drawing.Image)(resources.GetObject("deteteButton.Image")));
            this.deteteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deteteButton.Location = new System.Drawing.Point(262, 0);
            this.deteteButton.MaximumSize = new System.Drawing.Size(230, 55);
            this.deteteButton.Name = "deteteButton";
            this.deteteButton.Size = new System.Drawing.Size(29, 28);
            this.deteteButton.TabIndex = 37;
            this.deteteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deteteButton.UseVisualStyleBackColor = false;
            this.deteteButton.Click += new System.EventHandler(this.deteteButton_Click);
            // 
            // RadioPaid
            // 
            this.RadioPaid.AutoSize = true;
            this.RadioPaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioPaid.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioPaid.Location = new System.Drawing.Point(0, 0);
            this.RadioPaid.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.RadioPaid.Name = "RadioPaid";
            this.RadioPaid.Size = new System.Drawing.Size(83, 28);
            this.RadioPaid.TabIndex = 1;
            this.RadioPaid.Text = "General";
            this.RadioPaid.UseVisualStyleBackColor = true;
            this.RadioPaid.CheckedChanged += new System.EventHandler(this.RadioPaid_CheckedChanged);
            // 
            // RadioDate
            // 
            this.RadioDate.AutoSize = true;
            this.RadioDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.RadioDate.Location = new System.Drawing.Point(504, 0);
            this.RadioDate.Name = "RadioDate";
            this.RadioDate.Size = new System.Drawing.Size(93, 28);
            this.RadioDate.TabIndex = 0;
            this.RadioDate.Text = "Date Fiter";
            this.RadioDate.UseVisualStyleBackColor = true;
            this.RadioDate.CheckedChanged += new System.EventHandler(this.RadioDate_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.OrdersDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 314);
            this.panel1.TabIndex = 3;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrdersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.OrdersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersDataGridView.CausesValidation = false;
            this.OrdersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrdersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.OrdersDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrdersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrdersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrdersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.OrdersDataGridView.Size = new System.Drawing.Size(597, 314);
            this.OrdersDataGridView.TabIndex = 5;
            this.OrdersDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellContentDoubleClick);
            this.OrdersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellContentDoubleClick);
            this.OrdersDataGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.OrdersDataGridView_ColumnAdded);
            // 
            // AdvanceOrderViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdvanceOrderViewer";
            this.Text = "AdvanceOrderViewer";
            this.Load += new System.EventHandler(this.AdvanceOrderViewer_Load);
            this.panel2.ResumeLayout(false);
            this.GeneralFilterPanel.ResumeLayout(false);
            this.GeneralFilterPanel.PerformLayout();
            this.DateFilterPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel GeneralFilterPanel;
        private System.Windows.Forms.Panel DateFilterPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton RadioPaid;
        private System.Windows.Forms.RadioButton RadioDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.RadioButton RadioUnpaid;
        private System.Windows.Forms.RadioButton RadioAll;
        public System.Windows.Forms.TextBox NumOfOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deteteButton;
    }
}