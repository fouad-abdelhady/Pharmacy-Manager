namespace Pharmay0._0._2.UI.Suppliers
{
    partial class SupplierProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierProfile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.errorMessage = new System.Windows.Forms.Label();
            this.saveCancelPanel = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.infoMessage = new System.Windows.Forms.Label();
            this.debtValueEditBox = new System.Windows.Forms.TextBox();
            this.mobileNumberEditBox = new System.Windows.Forms.TextBox();
            this.companyName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ordersData = new System.Windows.Forms.DataGridView();
            this.ordersButton = new System.Windows.Forms.Button();
            this.middlePanel.SuspendLayout();
            this.saveCancelPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersData)).BeginInit();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.middlePanel.Controls.Add(this.errorMessage);
            this.middlePanel.Controls.Add(this.saveCancelPanel);
            this.middlePanel.Controls.Add(this.label4);
            this.middlePanel.Controls.Add(this.infoMessage);
            this.middlePanel.Controls.Add(this.debtValueEditBox);
            this.middlePanel.Controls.Add(this.mobileNumberEditBox);
            this.middlePanel.Controls.Add(this.companyName);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlePanel.Location = new System.Drawing.Point(0, 0);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(597, 173);
            this.middlePanel.TabIndex = 2;
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(12, 102);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(34, 17);
            this.errorMessage.TabIndex = 14;
            this.errorMessage.Text = "Error";
            this.errorMessage.Visible = false;
            // 
            // saveCancelPanel
            // 
            this.saveCancelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.saveCancelPanel.Controls.Add(this.cancel);
            this.saveCancelPanel.Controls.Add(this.save);
            this.saveCancelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveCancelPanel.ForeColor = System.Drawing.Color.Silver;
            this.saveCancelPanel.Location = new System.Drawing.Point(0, 130);
            this.saveCancelPanel.Name = "saveCancelPanel";
            this.saveCancelPanel.Size = new System.Drawing.Size(597, 43);
            this.saveCancelPanel.TabIndex = 13;
            this.saveCancelPanel.Visible = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(7)))), ((int)(((byte)(2)))));
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(7)))), ((int)(((byte)(2)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(0, 0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(281, 43);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
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
            this.save.Location = new System.Drawing.Point(281, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(316, 43);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(276, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "EGP";
            // 
            // infoMessage
            // 
            this.infoMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoMessage.AutoSize = true;
            this.infoMessage.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.infoMessage.Location = new System.Drawing.Point(12, 9);
            this.infoMessage.Name = "infoMessage";
            this.infoMessage.Size = new System.Drawing.Size(167, 17);
            this.infoMessage.TabIndex = 8;
            this.infoMessage.Text = "Double mouse click to edit";
            this.infoMessage.Visible = false;
            // 
            // debtValueEditBox
            // 
            this.debtValueEditBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.debtValueEditBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.debtValueEditBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debtValueEditBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtValueEditBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.debtValueEditBox.Location = new System.Drawing.Point(228, 103);
            this.debtValueEditBox.MaxLength = 20;
            this.debtValueEditBox.Name = "debtValueEditBox";
            this.debtValueEditBox.ReadOnly = true;
            this.debtValueEditBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.debtValueEditBox.Size = new System.Drawing.Size(42, 16);
            this.debtValueEditBox.TabIndex = 4;
            this.debtValueEditBox.Text = "Debt ";
            this.debtValueEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debtValueEditBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.enableDebtValue);
            this.debtValueEditBox.MouseLeave += new System.EventHandler(this.DisableInfoMessage);
            this.debtValueEditBox.MouseHover += new System.EventHandler(this.EnableInfoMessage);
            // 
            // mobileNumberEditBox
            // 
            this.mobileNumberEditBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobileNumberEditBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mobileNumberEditBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobileNumberEditBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumberEditBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mobileNumberEditBox.Location = new System.Drawing.Point(228, 71);
            this.mobileNumberEditBox.MaxLength = 20;
            this.mobileNumberEditBox.Name = "mobileNumberEditBox";
            this.mobileNumberEditBox.ReadOnly = true;
            this.mobileNumberEditBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobileNumberEditBox.Size = new System.Drawing.Size(212, 16);
            this.mobileNumberEditBox.TabIndex = 3;
            this.mobileNumberEditBox.Text = "Mobile Number";
            this.mobileNumberEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mobileNumberEditBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.enableMobileNum);
            this.mobileNumberEditBox.MouseLeave += new System.EventHandler(this.DisableInfoMessage);
            this.mobileNumberEditBox.MouseHover += new System.EventHandler(this.EnableInfoMessage);
            // 
            // companyName
            // 
            this.companyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.companyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.companyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.companyName.Location = new System.Drawing.Point(228, 39);
            this.companyName.MaxLength = 20;
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyName.Size = new System.Drawing.Size(212, 16);
            this.companyName.TabIndex = 2;
            this.companyName.Text = "Company Name";
            this.companyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.companyName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.enableTextView);
            this.companyName.MouseLeave += new System.EventHandler(this.DisableInfoMessage);
            this.companyName.MouseHover += new System.EventHandler(this.EnableInfoMessage);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.ordersData);
            this.panel1.Controls.Add(this.ordersButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 255);
            this.panel1.TabIndex = 3;
            // 
            // ordersData
            // 
            this.ordersData.AllowUserToAddRows = false;
            this.ordersData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ordersData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ordersData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersData.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ordersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersData.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersData.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordersData.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ordersData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ordersData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ordersData.Location = new System.Drawing.Point(0, 32);
            this.ordersData.Name = "ordersData";
            this.ordersData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ordersData.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ordersData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ordersData.Size = new System.Drawing.Size(597, 223);
            this.ordersData.TabIndex = 3;
            this.ordersData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersData_CellDoubleClick);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.Transparent;
            this.ordersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ordersButton.FlatAppearance.BorderSize = 0;
            this.ordersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ordersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ordersButton.Location = new System.Drawing.Point(0, 0);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(597, 32);
            this.ordersButton.TabIndex = 2;
            this.ordersButton.Text = "Preavious Deals";
            this.ordersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ordersButton.UseVisualStyleBackColor = false;
            // 
            // SupplierProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.middlePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierProfile";
            this.Text = "SupplierProfile";
            this.Load += new System.EventHandler(this.SupplierProfile_Load);
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.saveCancelPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Label infoMessage;
        private System.Windows.Forms.Panel saveCancelPanel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.DataGridView ordersData;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox debtValueEditBox;
        public System.Windows.Forms.TextBox mobileNumberEditBox;
        public System.Windows.Forms.TextBox companyName;
    }
}