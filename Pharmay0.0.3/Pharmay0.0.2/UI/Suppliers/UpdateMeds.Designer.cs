namespace Pharmay0._0._2.UI.Suppliers
{
    partial class UpdateMeds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMeds));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveCancelPanel = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.TapesPerUnitTXB = new System.Windows.Forms.TextBox();
            this.pareCodeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTXB = new System.Windows.Forms.TextBox();
            this.TotalAmountTXB = new System.Windows.Forms.TextBox();
            this.MedicenNameTXB = new System.Windows.Forms.TextBox();
            this.ExpireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oldMedsGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.saveCancelPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldMedsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveCancelPanel);
            this.panel1.Controls.Add(this.TapesPerUnitTXB);
            this.panel1.Controls.Add(this.pareCodeLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PriceTXB);
            this.panel1.Controls.Add(this.TotalAmountTXB);
            this.panel1.Controls.Add(this.MedicenNameTXB);
            this.panel1.Controls.Add(this.ExpireDatePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 227);
            this.panel1.TabIndex = 0;
            // 
            // saveCancelPanel
            // 
            this.saveCancelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.saveCancelPanel.Controls.Add(this.cancel);
            this.saveCancelPanel.Controls.Add(this.save);
            this.saveCancelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveCancelPanel.ForeColor = System.Drawing.Color.Silver;
            this.saveCancelPanel.Location = new System.Drawing.Point(0, 184);
            this.saveCancelPanel.Name = "saveCancelPanel";
            this.saveCancelPanel.Size = new System.Drawing.Size(597, 43);
            this.saveCancelPanel.TabIndex = 38;
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
            // TapesPerUnitTXB
            // 
            this.TapesPerUnitTXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TapesPerUnitTXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.TapesPerUnitTXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TapesPerUnitTXB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapesPerUnitTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TapesPerUnitTXB.Location = new System.Drawing.Point(233, 86);
            this.TapesPerUnitTXB.MaxLength = 20;
            this.TapesPerUnitTXB.Name = "TapesPerUnitTXB";
            this.TapesPerUnitTXB.ReadOnly = true;
            this.TapesPerUnitTXB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TapesPerUnitTXB.Size = new System.Drawing.Size(212, 19);
            this.TapesPerUnitTXB.TabIndex = 37;
            this.TapesPerUnitTXB.Text = "Total Amount";
            this.TapesPerUnitTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TapesPerUnitTXB.TextChanged += new System.EventHandler(this.TapesPerUnitTXB_TextChanged);
            this.TapesPerUnitTXB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TapesPerUnitTXB_MouseDoubleClick);
            // 
            // pareCodeLabel
            // 
            this.pareCodeLabel.AutoSize = true;
            this.pareCodeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pareCodeLabel.ForeColor = System.Drawing.Color.Silver;
            this.pareCodeLabel.Location = new System.Drawing.Point(3, 6);
            this.pareCodeLabel.Name = "pareCodeLabel";
            this.pareCodeLabel.Size = new System.Drawing.Size(101, 22);
            this.pareCodeLabel.TabIndex = 36;
            this.pareCodeLabel.Text = "Parecode";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(330, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "EGP";
            // 
            // PriceTXB
            // 
            this.PriceTXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PriceTXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.PriceTXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTXB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PriceTXB.Location = new System.Drawing.Point(233, 111);
            this.PriceTXB.MaxLength = 20;
            this.PriceTXB.Name = "PriceTXB";
            this.PriceTXB.ReadOnly = true;
            this.PriceTXB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceTXB.Size = new System.Drawing.Size(91, 19);
            this.PriceTXB.TabIndex = 34;
            this.PriceTXB.Text = "price";
            this.PriceTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PriceTXB.TextChanged += new System.EventHandler(this.PriceTXB_TextChanged);
            this.PriceTXB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PriceTXB_MouseDoubleClick);
            // 
            // TotalAmountTXB
            // 
            this.TotalAmountTXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalAmountTXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.TotalAmountTXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalAmountTXB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotalAmountTXB.Location = new System.Drawing.Point(233, 61);
            this.TotalAmountTXB.MaxLength = 20;
            this.TotalAmountTXB.Name = "TotalAmountTXB";
            this.TotalAmountTXB.ReadOnly = true;
            this.TotalAmountTXB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalAmountTXB.Size = new System.Drawing.Size(212, 19);
            this.TotalAmountTXB.TabIndex = 33;
            this.TotalAmountTXB.Text = "Total Amount";
            this.TotalAmountTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalAmountTXB.TextChanged += new System.EventHandler(this.TotalAmountTXB_TextChanged);
            this.TotalAmountTXB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TotalAmountTXB_MouseDoubleClick);
            // 
            // MedicenNameTXB
            // 
            this.MedicenNameTXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MedicenNameTXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.MedicenNameTXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicenNameTXB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicenNameTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MedicenNameTXB.Location = new System.Drawing.Point(233, 36);
            this.MedicenNameTXB.MaxLength = 20;
            this.MedicenNameTXB.Name = "MedicenNameTXB";
            this.MedicenNameTXB.ReadOnly = true;
            this.MedicenNameTXB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MedicenNameTXB.Size = new System.Drawing.Size(212, 19);
            this.MedicenNameTXB.TabIndex = 32;
            this.MedicenNameTXB.Text = "Medicen Name";
            this.MedicenNameTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MedicenNameTXB.TextChanged += new System.EventHandler(this.MedicenNameTXB_TextChanged);
            this.MedicenNameTXB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MedicenNameTXB_MouseDoubleClick);
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.ExpireDatePicker.CustomFormat = "";
            this.ExpireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpireDatePicker.Location = new System.Drawing.Point(233, 136);
            this.ExpireDatePicker.MinDate = new System.DateTime(2020, 1, 7, 0, 0, 0, 0);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(169, 24);
            this.ExpireDatePicker.TabIndex = 31;
            this.ExpireDatePicker.Value = new System.DateTime(2020, 10, 12, 0, 0, 0, 0);
            this.ExpireDatePicker.ValueChanged += new System.EventHandler(this.ExpireDatePicker_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.oldMedsGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 201);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 428);
            this.panel3.TabIndex = 2;
            // 
            // oldMedsGridView
            // 
            this.oldMedsGridView.AllowUserToAddRows = false;
            this.oldMedsGridView.AllowUserToDeleteRows = false;
            this.oldMedsGridView.AllowUserToResizeColumns = false;
            this.oldMedsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldMedsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.oldMedsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oldMedsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.oldMedsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldMedsGridView.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.oldMedsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.oldMedsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oldMedsGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.oldMedsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.oldMedsGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.oldMedsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.oldMedsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.oldMedsGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oldMedsGridView.Location = new System.Drawing.Point(0, 0);
            this.oldMedsGridView.MultiSelect = false;
            this.oldMedsGridView.Name = "oldMedsGridView";
            this.oldMedsGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.oldMedsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.oldMedsGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldMedsGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.oldMedsGridView.Size = new System.Drawing.Size(597, 201);
            this.oldMedsGridView.TabIndex = 6;
            this.oldMedsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oldMedsGridView_CellDoubleClick);
            // 
            // UpdateMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateMeds";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateMeds_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.saveCancelPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oldMedsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker ExpireDatePicker;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox PriceTXB;
        public System.Windows.Forms.TextBox TotalAmountTXB;
        public System.Windows.Forms.TextBox MedicenNameTXB;
        private System.Windows.Forms.Label pareCodeLabel;
        public System.Windows.Forms.TextBox TapesPerUnitTXB;
        private System.Windows.Forms.Panel saveCancelPanel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView oldMedsGridView;
    }
}