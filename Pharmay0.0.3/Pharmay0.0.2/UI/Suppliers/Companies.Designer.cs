namespace Pharmay0._0._2.UI
{
    partial class Companies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Companies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bottomBar = new System.Windows.Forms.Panel();
            this.addCompany = new System.Windows.Forms.Button();
            this.suppliersListPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalDebtValue = new System.Windows.Forms.Label();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesData = new System.Windows.Forms.DataGridView();
            this.saveCancelPanel = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.companyName = new System.Windows.Forms.TextBox();
            this.deptValue = new System.Windows.Forms.TextBox();
            this.mobileNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.newSpplierPanel = new System.Windows.Forms.Panel();
            this.bottomBar.SuspendLayout();
            this.suppliersListPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesData)).BeginInit();
            this.saveCancelPanel.SuspendLayout();
            this.newSpplierPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomBar
            // 
            this.bottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.bottomBar.Controls.Add(this.addCompany);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Location = new System.Drawing.Point(0, 379);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(597, 49);
            this.bottomBar.TabIndex = 0;
            // 
            // addCompany
            // 
            this.addCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.addCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCompany.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addCompany.FlatAppearance.BorderSize = 0;
            this.addCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCompany.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompany.ForeColor = System.Drawing.Color.Silver;
            this.addCompany.Image = ((System.Drawing.Image)(resources.GetObject("addCompany.Image")));
            this.addCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCompany.Location = new System.Drawing.Point(0, 0);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(597, 49);
            this.addCompany.TabIndex = 0;
            this.addCompany.Text = "Add New Supplier";
            this.addCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCompany.UseVisualStyleBackColor = false;
            this.addCompany.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // suppliersListPanel
            // 
            this.suppliersListPanel.AutoScroll = true;
            this.suppliersListPanel.AutoSize = true;
            this.suppliersListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.suppliersListPanel.Controls.Add(this.companiesData);
            this.suppliersListPanel.Controls.Add(this.panel3);
            this.suppliersListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersListPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.suppliersListPanel.Location = new System.Drawing.Point(0, 0);
            this.suppliersListPanel.Name = "suppliersListPanel";
            this.suppliersListPanel.Size = new System.Drawing.Size(597, 428);
            this.suppliersListPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.totalDebtValue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 38);
            this.panel3.TabIndex = 0;
            // 
            // totalDebtValue
            // 
            this.totalDebtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDebtValue.AutoSize = true;
            this.totalDebtValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDebtValue.Location = new System.Drawing.Point(186, 9);
            this.totalDebtValue.Name = "totalDebtValue";
            this.totalDebtValue.Size = new System.Drawing.Size(97, 21);
            this.totalDebtValue.TabIndex = 0;
            this.totalDebtValue.Text = "Total Debt:";
            this.totalDebtValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            // 
            // companiesData
            // 
            this.companiesData.AllowUserToAddRows = false;
            this.companiesData.AllowUserToDeleteRows = false;
            this.companiesData.AllowUserToResizeColumns = false;
            this.companiesData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companiesData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.companiesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.companiesData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.companiesData.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companiesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.companiesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesData.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.companiesData.DefaultCellStyle = dataGridViewCellStyle3;
            this.companiesData.Dock = System.Windows.Forms.DockStyle.Top;
            this.companiesData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.companiesData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.companiesData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.companiesData.Location = new System.Drawing.Point(0, 38);
            this.companiesData.MultiSelect = false;
            this.companiesData.Name = "companiesData";
            this.companiesData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companiesData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.companiesData.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companiesData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.companiesData.Size = new System.Drawing.Size(597, 390);
            this.companiesData.TabIndex = 3;
            this.companiesData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showSelectedCompanyData);
            // 
            // saveCancelPanel
            // 
            this.saveCancelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.saveCancelPanel.Controls.Add(this.cancel);
            this.saveCancelPanel.Controls.Add(this.save);
            this.saveCancelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveCancelPanel.ForeColor = System.Drawing.Color.Silver;
            this.saveCancelPanel.Location = new System.Drawing.Point(0, 167);
            this.saveCancelPanel.Name = "saveCancelPanel";
            this.saveCancelPanel.Size = new System.Drawing.Size(597, 43);
            this.saveCancelPanel.TabIndex = 0;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Dock = System.Windows.Forms.DockStyle.Right;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(283, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(314, 43);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(7)))), ((int)(((byte)(2)))));
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(7)))), ((int)(((byte)(2)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(-15, 0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(298, 43);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Close";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // companyName
            // 
            this.companyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.companyName.BackColor = System.Drawing.SystemColors.Control;
            this.companyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.Color.Black;
            this.companyName.Location = new System.Drawing.Point(227, 28);
            this.companyName.MaxLength = 20;
            this.companyName.Name = "companyName";
            this.companyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyName.Size = new System.Drawing.Size(295, 23);
            this.companyName.TabIndex = 1;
            this.companyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deptValue
            // 
            this.deptValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deptValue.BackColor = System.Drawing.SystemColors.Control;
            this.deptValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deptValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptValue.ForeColor = System.Drawing.Color.Black;
            this.deptValue.Location = new System.Drawing.Point(227, 63);
            this.deptValue.MaxLength = 20;
            this.deptValue.Name = "deptValue";
            this.deptValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deptValue.Size = new System.Drawing.Size(192, 23);
            this.deptValue.TabIndex = 2;
            this.deptValue.Text = "0";
            this.deptValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mobileNum
            // 
            this.mobileNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobileNum.BackColor = System.Drawing.SystemColors.Control;
            this.mobileNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNum.ForeColor = System.Drawing.Color.Black;
            this.mobileNum.Location = new System.Drawing.Point(227, 98);
            this.mobileNum.MaxLength = 11;
            this.mobileNum.Name = "mobileNum";
            this.mobileNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mobileNum.Size = new System.Drawing.Size(295, 23);
            this.mobileNum.TabIndex = 3;
            this.mobileNum.Text = "01";
            this.mobileNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company Name *";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(75, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dept Value";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(75, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile Number";
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(129)))), ((int)(((byte)(9)))));
            this.errorMessage.Location = new System.Drawing.Point(224, 134);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(34, 17);
            this.errorMessage.TabIndex = 7;
            this.errorMessage.Text = "Error";
            this.errorMessage.Visible = false;
            // 
            // newSpplierPanel
            // 
            this.newSpplierPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.newSpplierPanel.Controls.Add(this.errorMessage);
            this.newSpplierPanel.Controls.Add(this.label3);
            this.newSpplierPanel.Controls.Add(this.label2);
            this.newSpplierPanel.Controls.Add(this.label1);
            this.newSpplierPanel.Controls.Add(this.mobileNum);
            this.newSpplierPanel.Controls.Add(this.deptValue);
            this.newSpplierPanel.Controls.Add(this.companyName);
            this.newSpplierPanel.Controls.Add(this.saveCancelPanel);
            this.newSpplierPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newSpplierPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpplierPanel.Location = new System.Drawing.Point(0, 169);
            this.newSpplierPanel.Name = "newSpplierPanel";
            this.newSpplierPanel.Size = new System.Drawing.Size(597, 210);
            this.newSpplierPanel.TabIndex = 1;
            this.newSpplierPanel.Visible = false;
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.newSpplierPanel);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.suppliersListPanel);
            this.Name = "Companies";
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.Companies_Load);
            this.bottomBar.ResumeLayout(false);
            this.suppliersListPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesData)).EndInit();
            this.saveCancelPanel.ResumeLayout(false);
            this.newSpplierPanel.ResumeLayout(false);
            this.newSpplierPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bottomBar;
        private System.Windows.Forms.Button addCompany;
        private System.Windows.Forms.Panel suppliersListPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalDebtValue;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private System.Windows.Forms.DataGridView companiesData;
        private System.Windows.Forms.Panel saveCancelPanel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        public System.Windows.Forms.TextBox companyName;
        public System.Windows.Forms.TextBox deptValue;
        public System.Windows.Forms.TextBox mobileNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Panel newSpplierPanel;
    }
}