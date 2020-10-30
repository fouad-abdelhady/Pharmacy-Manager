namespace Pharmay0._0._2.UI.Suppliers
{
    partial class AddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.orderMidsPanel = new System.Windows.Forms.Panel();
            this.errorMessage = new System.Windows.Forms.Label();
            this.mobileNumber = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.mobileNum = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.ConfirmCancelMenu = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.orderMidsPanel.SuspendLayout();
            this.ConfirmCancelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 40);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Confirm Shipment";
            // 
            // orderMidsPanel
            // 
            this.orderMidsPanel.AutoScroll = true;
            this.orderMidsPanel.Controls.Add(this.errorMessage);
            this.orderMidsPanel.Controls.Add(this.mobileNumber);
            this.orderMidsPanel.Controls.Add(this.customerNameLabel);
            this.orderMidsPanel.Controls.Add(this.mobileNum);
            this.orderMidsPanel.Controls.Add(this.customerName);
            this.orderMidsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderMidsPanel.Location = new System.Drawing.Point(0, 40);
            this.orderMidsPanel.Name = "orderMidsPanel";
            this.orderMidsPanel.Size = new System.Drawing.Size(534, 163);
            this.orderMidsPanel.TabIndex = 37;
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(129)))), ((int)(((byte)(9)))));
            this.errorMessage.Location = new System.Drawing.Point(185, 113);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(34, 17);
            this.errorMessage.TabIndex = 13;
            this.errorMessage.Text = "Error";
            this.errorMessage.Visible = false;
            // 
            // mobileNumber
            // 
            this.mobileNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobileNumber.AutoSize = true;
            this.mobileNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mobileNumber.Location = new System.Drawing.Point(36, 78);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(107, 17);
            this.mobileNumber.TabIndex = 12;
            this.mobileNumber.Text = "Mobile Number";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerNameLabel.Location = new System.Drawing.Point(36, 40);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(125, 17);
            this.customerNameLabel.TabIndex = 10;
            this.customerNameLabel.Text = "Customer Name *";
            // 
            // mobileNum
            // 
            this.mobileNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobileNum.BackColor = System.Drawing.SystemColors.Control;
            this.mobileNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNum.ForeColor = System.Drawing.Color.Black;
            this.mobileNum.Location = new System.Drawing.Point(188, 78);
            this.mobileNum.MaxLength = 11;
            this.mobileNum.Name = "mobileNum";
            this.mobileNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mobileNum.Size = new System.Drawing.Size(295, 23);
            this.mobileNum.TabIndex = 9;
            this.mobileNum.Text = "01";
            this.mobileNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerName
            // 
            this.customerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerName.BackColor = System.Drawing.SystemColors.Control;
            this.customerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.Color.Black;
            this.customerName.Location = new System.Drawing.Point(188, 40);
            this.customerName.MaxLength = 20;
            this.customerName.Name = "customerName";
            this.customerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerName.Size = new System.Drawing.Size(295, 23);
            this.customerName.TabIndex = 7;
            this.customerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmCancelMenu
            // 
            this.ConfirmCancelMenu.Controls.Add(this.cancelButton);
            this.ConfirmCancelMenu.Controls.Add(this.addCustomerButton);
            this.ConfirmCancelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfirmCancelMenu.Location = new System.Drawing.Point(0, 206);
            this.ConfirmCancelMenu.Name = "ConfirmCancelMenu";
            this.ConfirmCancelMenu.Size = new System.Drawing.Size(534, 52);
            this.ConfirmCancelMenu.TabIndex = 38;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Silver;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(0, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(261, 52);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.addCustomerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addCustomerButton.FlatAppearance.BorderSize = 0;
            this.addCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.ForeColor = System.Drawing.Color.Silver;
            this.addCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("addCustomerButton.Image")));
            this.addCustomerButton.Location = new System.Drawing.Point(261, 0);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(273, 52);
            this.addCustomerButton.TabIndex = 30;
            this.addCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(534, 258);
            this.Controls.Add(this.ConfirmCancelMenu);
            this.Controls.Add(this.orderMidsPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.orderMidsPanel.ResumeLayout(false);
            this.orderMidsPanel.PerformLayout();
            this.ConfirmCancelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel orderMidsPanel;
        private System.Windows.Forms.Panel ConfirmCancelMenu;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Label mobileNumber;
        private System.Windows.Forms.Label customerNameLabel;
        public System.Windows.Forms.TextBox mobileNum;
        public System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label errorMessage;
    }
}