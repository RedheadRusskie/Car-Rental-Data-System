
namespace CarRentalApp
{
    partial class MainForm
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
            this.LbTitle = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.CalRented = new System.Windows.Forms.DateTimePicker();
            this.CalReturned = new System.Windows.Forms.DateTimePicker();
            this.LabRented = new System.Windows.Forms.Label();
            this.LabReturned = new System.Windows.Forms.Label();
            this.DropCars = new System.Windows.Forms.ComboBox();
            this.LabCars = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbRecordID = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.LabPrice = new System.Windows.Forms.Label();
            SkodaImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(SkodaImg)).BeginInit();
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
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.LbTitle.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(122)))), ((int)(((byte)(228)))));
            this.LbTitle.Location = new System.Drawing.Point(389, 472);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(323, 66);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Add Record";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Location = new System.Drawing.Point(449, 38);
            this.LabName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(56, 21);
            this.LabName.TabIndex = 1;
            this.LabName.Text = "Name";
            // 
            // TbName
            // 
            this.TbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.TbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbName.ForeColor = System.Drawing.Color.White;
            this.TbName.Location = new System.Drawing.Point(453, 59);
            this.TbName.MaxLength = 50;
            this.TbName.Multiline = true;
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(251, 29);
            this.TbName.TabIndex = 2;
            this.TbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalRented
            // 
            this.CalRented.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.CalRented.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.CalRented.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.CalRented.Location = new System.Drawing.Point(62, 60);
            this.CalRented.Name = "CalRented";
            this.CalRented.ShowCheckBox = true;
            this.CalRented.Size = new System.Drawing.Size(251, 26);
            this.CalRented.TabIndex = 3;
            // 
            // CalReturned
            // 
            this.CalReturned.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.CalReturned.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.CalReturned.Location = new System.Drawing.Point(62, 118);
            this.CalReturned.Name = "CalReturned";
            this.CalReturned.ShowCheckBox = true;
            this.CalReturned.Size = new System.Drawing.Size(251, 26);
            this.CalReturned.TabIndex = 4;
            // 
            // LabRented
            // 
            this.LabRented.AutoSize = true;
            this.LabRented.ForeColor = System.Drawing.Color.Black;
            this.LabRented.Location = new System.Drawing.Point(58, 36);
            this.LabRented.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabRented.Name = "LabRented";
            this.LabRented.Size = new System.Drawing.Size(100, 21);
            this.LabRented.TabIndex = 5;
            this.LabRented.Text = "Date rented";
            // 
            // LabReturned
            // 
            this.LabReturned.AutoSize = true;
            this.LabReturned.ForeColor = System.Drawing.Color.Black;
            this.LabReturned.Location = new System.Drawing.Point(58, 94);
            this.LabReturned.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabReturned.Name = "LabReturned";
            this.LabReturned.Size = new System.Drawing.Size(116, 21);
            this.LabReturned.TabIndex = 6;
            this.LabReturned.Text = "Date returned";
            // 
            // DropCars
            // 
            this.DropCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropCars.FormattingEnabled = true;
            this.DropCars.Location = new System.Drawing.Point(62, 174);
            this.DropCars.Name = "DropCars";
            this.DropCars.Size = new System.Drawing.Size(251, 29);
            this.DropCars.TabIndex = 7;
            // 
            // LabCars
            // 
            this.LabCars.AutoSize = true;
            this.LabCars.ForeColor = System.Drawing.Color.Black;
            this.LabCars.Location = new System.Drawing.Point(58, 150);
            this.LabCars.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabCars.Name = "LabCars";
            this.LabCars.Size = new System.Drawing.Size(36, 21);
            this.LabCars.TabIndex = 8;
            this.LabCars.Text = "Car";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LbRecordID);
            this.panel1.Controls.Add(SkodaImg);
            this.panel1.Controls.Add(this.CalRented);
            this.panel1.Controls.Add(this.CalReturned);
            this.panel1.Controls.Add(this.LabRented);
            this.panel1.Controls.Add(this.LabReturned);
            this.panel1.Controls.Add(this.DropCars);
            this.panel1.Controls.Add(this.LabCars);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 548);
            this.panel1.TabIndex = 9;
            // 
            // LbRecordID
            // 
            this.LbRecordID.AutoSize = true;
            this.LbRecordID.Location = new System.Drawing.Point(62, 264);
            this.LbRecordID.Name = "LbRecordID";
            this.LbRecordID.Size = new System.Drawing.Size(0, 21);
            this.LbRecordID.TabIndex = 14;
            this.LbRecordID.Visible = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(122)))), ((int)(((byte)(228)))));
            this.BtnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSubmit.FlatAppearance.BorderSize = 0;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSubmit.Location = new System.Drawing.Point(453, 173);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(251, 34);
            this.BtnSubmit.TabIndex = 10;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // TbPrice
            // 
            this.TbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.TbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPrice.ForeColor = System.Drawing.Color.White;
            this.TbPrice.Location = new System.Drawing.Point(453, 117);
            this.TbPrice.MaxLength = 50;
            this.TbPrice.Multiline = true;
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(251, 29);
            this.TbPrice.TabIndex = 11;
            this.TbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabPrice
            // 
            this.LabPrice.AutoSize = true;
            this.LabPrice.Location = new System.Drawing.Point(449, 93);
            this.LabPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabPrice.Name = "LabPrice";
            this.LabPrice.Size = new System.Drawing.Size(43, 21);
            this.LabPrice.TabIndex = 12;
            this.LabPrice.Text = "Cost";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(965, 547);
            this.Controls.Add(this.LabPrice);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Add record";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(SkodaImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label LabName;
        protected internal System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.DateTimePicker CalRented;
        private System.Windows.Forms.DateTimePicker CalReturned;
        private System.Windows.Forms.Label LabRented;
        private System.Windows.Forms.Label LabReturned;
        private System.Windows.Forms.ComboBox DropCars;
        private System.Windows.Forms.Label LabCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSubmit;
        protected internal System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label LabPrice;
        private System.Windows.Forms.Label LbRecordID;
    }
}

