namespace Pharmay0._0._2.UI
{
    partial class Activation
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
            this.DevID = new System.Windows.Forms.TextBox();
            this.DevPassword = new System.Windows.Forms.TextBox();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.dirCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DevID
            // 
            this.DevID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DevID.Location = new System.Drawing.Point(160, 37);
            this.DevID.Name = "DevID";
            this.DevID.Size = new System.Drawing.Size(158, 24);
            this.DevID.TabIndex = 0;
            this.DevID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DevID.UseSystemPasswordChar = true;
            // 
            // DevPassword
            // 
            this.DevPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DevPassword.Location = new System.Drawing.Point(12, 67);
            this.DevPassword.Name = "DevPassword";
            this.DevPassword.Size = new System.Drawing.Size(459, 24);
            this.DevPassword.TabIndex = 1;
            this.DevPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DevPassword.UseSystemPasswordChar = true;
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ApplyFilter.FlatAppearance.BorderSize = 0;
            this.ApplyFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplyFilter.Location = new System.Drawing.Point(12, 116);
            this.ApplyFilter.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(459, 43);
            this.ApplyFilter.TabIndex = 3;
            this.ApplyFilter.Text = "Activate Pharmacy Manager";
            this.ApplyFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ApplyFilter.UseVisualStyleBackColor = false;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // dirCode
            // 
            this.dirCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.dirCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dirCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dirCode.Location = new System.Drawing.Point(12, 12);
            this.dirCode.Name = "dirCode";
            this.dirCode.Size = new System.Drawing.Size(459, 17);
            this.dirCode.TabIndex = 4;
            this.dirCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dirCode.UseSystemPasswordChar = true;
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(483, 180);
            this.Controls.Add(this.dirCode);
            this.Controls.Add(this.ApplyFilter);
            this.Controls.Add(this.DevPassword);
            this.Controls.Add(this.DevID);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Activation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Activation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DevID;
        private System.Windows.Forms.TextBox DevPassword;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.TextBox dirCode;
    }
}