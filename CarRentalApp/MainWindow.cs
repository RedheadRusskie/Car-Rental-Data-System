using System;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// This is the landing window which first appears upon the program being launched. It is the MDI parent of all child elements and the primary means by which other windows can be navigated to. 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        #region StripButtons

        // Opens 'Add Record' window
        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRecord = new MainForm();
            addRecord.MdiParent = this;
            addRecord.Show();
        }

        // Opens 'Vehicle list' window
        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleList = new VehicleListingManagement();
            vehicleList.MdiParent = this;
            vehicleList.Show();
        }

        // Opens 'Manage rental records' window
        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rentalRecords = new RentalRecordsManagement();
            rentalRecords.MdiParent = this;
            rentalRecords.Show();
        }

        #endregion
    }
}
