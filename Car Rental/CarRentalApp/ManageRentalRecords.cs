using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class RentalRecordsManagement : Form
    {
        /// <summary>
        /// A window displaying 'CarRental' entity entries and options to add, edit, or delete its records, all of which actions can be triggered with their own respcetive CTA elements. 
        /// </summary>

        #region Data

        // Variable declaration for the existing database (encapsulation)
        private readonly RentalEntities _db;

        // Declares '_db' as a new instance of the 'RentalEntities' object
        public RentalRecordsManagement()
        {
            InitializeComponent();
            _db = new RentalEntities();
        }
        
        // Loads data to grid view or otherwise displays error message
        private void RentalRecordsManagement_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateGrid()
        {
            // Sets variables for attributes within the 'CarRentals' entity using a lambda expression
            var records = _db.CarRentals
                .Select(z => new {
                    Customer = z.Customer_Name,
                    Date_Rented = z.Date_Rented,
                    Date_Returned = z.Date_Returned,
                    ID = z.ID,
                    Price = z.Price,
                    Vehicle = z.CarType1.Brand + " " + z.CarType1.Model // Inner join
                }).ToList();

            // Sets data source for grid view population
            gvRecordList.DataSource = records;

            // Changing header text for aesthetic purposes
            gvRecordList.Columns["Date_Rented"].HeaderText = "Date Rented";
            gvRecordList.Columns["Date_Returned"].HeaderText = "Date Returned";
            gvRecordList.Columns["ID"].Visible = false;
        }

        #endregion
        #region Buttons

        // Declares 'addRecord' as a new instance of the 'MainForm' object, declares its MDI parent and opens the new instance when the 'Click' event listener is triggered.
        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            var addRecord = new MainForm();
            addRecord.MdiParent = this.MdiParent;
            addRecord.Show();
        }

        private void BtnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Gets ID of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["ID"].Value;

                // Queries DB for record
                var record = _db.CarRentals.FirstOrDefault(x => x.ID == id);

                // Launches AddEditVehicles window with respective data
                var addEditRentalRecord = new MainForm(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();
            }
            catch
            {
                RowError();
            }
        }

        private void BtnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Gets ID of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["ID"].Value;

                // Queries DB for record
                var record = _db.CarRentals.FirstOrDefault(x => x.ID == id);

                // Delete vehicle from table
                _db.CarRentals.Remove(record);

                // Saves changes to DB
                _db.SaveChanges();

                // Refreshed gv (Grid View)
                gvRecordList.Refresh();
            }
            catch
            {
                RowError();
            }
        }

        #endregion

        // Message box for when instance selection is not performed properly.
        private void RowError()
        {
            MessageBox.Show("Select entire row to edit or delete.");
        }
    }
}
