namespace Pharmay0._0._2.UI.Suppliers
{
    partial class DeleteOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteOrder));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deteteButton = new System.Windows.Forms.Button();
            this.deleteDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelUpdateButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.deleteDatePicker);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(440, 151);
            this.mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelUpdateButton);
            this.panel1.Controls.Add(this.deteteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 54);
            this.panel1.TabIndex = 1;
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
            this.deteteButton.Location = new System.Drawing.Point(222, 0);
            this.deteteButton.MaximumSize = new System.Drawing.Size(230, 55);
            this.deteteButton.Name = "deteteButton";
            this.deteteButton.Size = new System.Drawing.Size(218, 54);
            this.deteteButton.TabIndex = 36;
            this.deteteButton.Text = "Delete";
            this.deteteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deteteButton.UseVisualStyleBackColor = false;
            this.deteteButton.Click += new System.EventHandler(this.deteteButton_Click);
            // 
            // deleteDatePicker
            // 
            this.deleteDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.deleteDatePicker.CustomFormat = "";
            this.deleteDatePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDatePicker.Location = new System.Drawing.Point(59, 65);
            this.deleteDatePicker.MinDate = new System.DateTime(2020, 1, 7, 0, 0, 0, 0);
            this.deleteDatePicker.Name = "deleteDatePicker";
            this.deleteDatePicker.Size = new System.Drawing.Size(302, 27);
            this.deleteDatePicker.TabIndex = 37;
            this.deleteDatePicker.Value = new System.DateTime(2020, 10, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(55, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Delete orders starting from";
            // 
            // cancelUpdateButton
            // 
            this.cancelUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cancelUpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelUpdateButton.FlatAppearance.BorderSize = 0;
            this.cancelUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelUpdateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelUpdateButton.ForeColor = System.Drawing.Color.Silver;
            this.cancelUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelUpdateButton.Image")));
            this.cancelUpdateButton.Location = new System.Drawing.Point(0, 0);
            this.cancelUpdateButton.Name = "cancelUpdateButton";
            this.cancelUpdateButton.Size = new System.Drawing.Size(222, 54);
            this.cancelUpdateButton.TabIndex = 38;
            this.cancelUpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelUpdateButton.UseVisualStyleBackColor = false;
            this.cancelUpdateButton.Click += new System.EventHandler(this.cancelUpdateButton_Click);
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(440, 205);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteOrder";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deteteButton;
        private System.Windows.Forms.DateTimePicker deleteDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelUpdateButton;
    }
}