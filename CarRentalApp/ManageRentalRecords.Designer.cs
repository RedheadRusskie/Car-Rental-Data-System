
namespace CarRentalApp
{
    partial class RentalRecordsManagement
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
            System.Windows.Forms.PictureBox SkodaImg;
            this.LbManageRentalRecords = new System.Windows.Forms.Label();
            this.BtnDeleteRecord = new System.Windows.Forms.Button();
            this.BtnEditRecord = new System.Windows.Forms.Button();
            this.BtnAddRecord = new System.Windows.Forms.Button();
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            SkodaImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(SkodaImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SkodaImg
            // 
            SkodaImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            SkodaImg.Image = global::CarRentalApp.Properties.Resources.skoda;
            SkodaImg.Location = new System.Drawing.Point(-21, 332);
            SkodaImg.Name = "SkodaImg";
            SkodaImg.Size = new System.Drawing.Size(413, 207);
            SkodaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            SkodaImg.TabIndex = 9;
            SkodaImg.TabStop = false;
            // 
            // LbManageRentalRecords
            // 
            this.LbManageRentalRecords.AutoSize = true;
            this.LbManageRentalRecords.BackColor = System.Drawing.Color.Transparent;
            this.LbManageRentalRecords.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LbManageRentalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(122)))), ((int)(((byte)(228)))));
            this.LbManageRentalRecords.Location = new System.Drawing.Point(15, 22);
            this.LbManageRentalRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LbManageRentalRecords.Name = "LbManageRentalRecords";
            this.LbManageRentalRecords.Size = new System.Drawing.Size(408, 132);
            this.LbManageRentalRecords.TabIndex = 27;
            this.LbManageRentalRecords.Text = "Manage rental \r\nrecords";
            // 
            // BtnDeleteRecord
            // 
            this.BtnDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(122)))), ((int)(((byte)(228)))));
            this.BtnDeleteRecord.FlatAppearance.BorderSize = 0;
            this.BtnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteRecord.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteRecord.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteRecord.Location = new System.Drawing.Point(657, 224);
            this.BtnDeleteRecord.Name = "BtnDeleteRecord";
            this.BtnDeleteRecord.Size = new System.Drawing.Size(251, 34);
            this.BtnDeleteRecord.TabIndex = 25;
            this.BtnDeleteRecord.Text = "Delete record";
            this.BtnDeleteRecord.UseVisualStyleBackColor = false;
            this.BtnDeleteRecord.Click += new System.EventHandler(this.BtnDeleteRecord_Click);
            // 
            // BtnEditRecord
            // 
            this.BtnEditRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(122)))), ((int)(((byte)(228)))));
            this.BtnEditRecord.FlatAppearance.BorderSize = 0;
            this.BtnEditRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditRecord.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditRecord.ForeColor = System.Drawing.Color.White;
            this.BtnEditRecord.Location = new System.Drawing.Point(657, 171);
            this.BtnEditRecord.Name = "BtnEditRecord";
            this.BtnEditRecord.Size = new System.Drawing.Size(251, 34);
            this.BtnEditRecord.TabIndex = 24;
            this.BtnEditRecord.Text = "Edit record";
            this.BtnEditRecord.UseVisualStyleBackColor = false;
            this.BtnEditRecord.Click += new System.EventHandler(this.BtnEditRecord_Click);
            // 
            // BtnAddRecord
            // 
            this.BtnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(122)))), ((int)(((byte)(228)))));
            this.BtnAddRecord.FlatAppearance.BorderSize = 0;
            this.BtnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddRecord.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnAddRecord.ForeColor = System.Drawing.Color.White;
            this.BtnAddRecord.Location = new System.Drawing.Point(657, 118);
            this.BtnAddRecord.Name = "BtnAddRecord";
            this.BtnAddRecord.Size = new System.Drawing.Size(251, 34);
            this.BtnAddRecord.TabIndex = 23;
            this.BtnAddRecord.Text = "Add record";
            this.BtnAddRecord.UseVisualStyleBackColor = false;
            this.BtnAddRecord.Click += new System.EventHandler(this.BtnAddRecord_Click);
            // 
            // gvRecordList
            // 
            this.gvRecordList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.gvRecordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(1, 157);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.Size = new System.Drawing.Size(577, 390);
            this.gvRecordList.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(SkodaImg);
            this.panel1.Location = new System.Drawing.Point(584, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 548);
            this.panel1.TabIndex = 26;
            // 
            // RentalRecordsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(965, 547);
            this.Controls.Add(this.LbManageRentalRecords);
            this.Controls.Add(this.BtnDeleteRecord);
            this.Controls.Add(this.BtnEditRecord);
            this.Controls.Add(this.BtnAddRecord);
            this.Controls.Add(this.gvRecordList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.Name = "RentalRecordsManagement";
            this.Text = "ManageRentalRecords";
            this.Load += new System.EventHandler(this.RentalRecordsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(SkodaImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbManageRentalRecords;
        private System.Windows.Forms.Button BtnDeleteRecord;
        private System.Windows.Forms.Button BtnEditRecord;
        private System.Windows.Forms.Button BtnAddRecord;
        private System.Windows.Forms.DataGridView gvRecordList;
        private System.Windows.Forms.Panel panel1;
    }
}