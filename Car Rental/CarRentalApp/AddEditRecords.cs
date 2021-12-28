using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// A window whose purpose changes depending on whether or not Edit Mode is active. 
        /// Edit Mode is triggered once the 'Edit record' CTA 'Click' event listener is triggered. With edit mode the data fields will be populated with the existing data of the row selected prior.
        /// Otherwise with edit mode being inative the fields are empty for manual population and a new entry to the database can be submitted. 
        /// </summary>

        // Variable declaration for the existing database (encapsulation)
        private readonly RentalEntities _db;

        // If set to 'true' the 'Edit record' window will open populated with the selected row's data
        private bool editMode;

        public MainForm()
        {
            InitializeComponent();

            // Alters element text values depending on which version of the window is opened (Edit or Add)
            LbTitle.Text = "Add record";
            this.Text = "Add record";

            editMode = false;

            // Declares '_db' as a new instance of the 'RentalEntities' object
            _db = new RentalEntities();
        }

        public MainForm(CarRental recordToEdit)
        {
            InitializeComponent();

            // Alters element text values depending on which version of the window is opened (Edit or Add)
            LbTitle.Text = "Edit rental record";
            this.Text = "Edit record";

            if (recordToEdit == null)
            {
                MessageBox.Show("Check if a valid record was selected to edit.");
            }
            else
            {
                // Triggers Edit Mode, 
                editMode = true;

                // Declares '_db' as a new instance of the 'RentalEntities' object
                _db = new RentalEntities();

                // Runs PopulateFields() method passing rental record data
                PopulateFields(recordToEdit);
            }
        }

        // Populates fields respective data from the row selected prior
        private void PopulateFields(CarRental recordToEdit)
        {
            // The purpose of ID is for lookups within 'BtnSave_Click()' method
            TbName.Text = recordToEdit.Customer_Name;
            CalRented.Value = (DateTime)recordToEdit.Date_Rented;
            CalReturned.Value = (DateTime)recordToEdit.Date_Returned;
            TbPrice.Text = recordToEdit.Price.ToString();
            LbRecordID.Text = recordToEdit.ID.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Sets variables for attributes within the 'CarRentals' entity using a lambda expression
            var cars = _db.CarTypes
                .Select(z => new {
                    ID = z.ID,
                    Name = z.Brand + " " + z.Model
                }).ToList();

            // Links dropdown text to the entity "Name" attribute
            DropCars.DisplayMember = "Name";

            // Links dropdown text to the entity "ID" attribute
            DropCars.ValueMember = "ID";

            // // Sets data source for dropdown population
            DropCars.DataSource = cars;
        }

        // Actions to be performed for when 'Submit' CTA's 'Click' event listener is triggered
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Exception handling for data entry related issues
            try
            {
                // Assigns variables to data entries
                string name = TbName.Text;
                var dateRented = CalRented.Value;
                var dateReturned = CalReturned.Value;
                var carType = DropCars.Text; // var is very flexible
                double price = Convert.ToDouble(TbPrice.Text);

                // False isValid value will display errMsg contents within a MessageBox
                var isValid = true;
                var errMsg = "";

                // Verifies if the 'Name' and 'Car' fields are empty
                if (string.IsNullOrWhiteSpace(name)
                    || string.IsNullOrWhiteSpace(carType))
                {
                    // errMsg is appended and isValid is set to false, thus triggering the respective MessageBox
                    isValid = false;
                    errMsg += "Please enter data into all fields.\n\r";
                }

                // Prevents end user from selecting a date returned value that is before the date rented
                if (dateReturned < dateRented)
                {
                    isValid = false;
                    errMsg += "Dates returned cannot be before dates rented.\n\r";     
                }

                if (isValid) 
                {
                    var rentalRecord = new CarRental();
                    if(editMode)
                    {
                        // The purpose of ID is for lookups
                        var id = int.Parse(LbRecordID.Text);
                        rentalRecord = _db.CarRentals.FirstOrDefault(z => z.ID == id);
                    }

                    // Assigns variables within the database to the values of the window fields
                    rentalRecord.Customer_Name = name;
                    rentalRecord.Date_Rented = dateRented;
                    rentalRecord.Date_Returned = dateReturned;
                    rentalRecord.Price = Convert.ToDecimal(price);
                    rentalRecord.CarType = (int)DropCars.SelectedValue;

                    // Adds new record to the database
                    if(!editMode)
                        _db.CarRentals.Add(rentalRecord);

                    _db.SaveChanges();

                    SubmitMsg(
                            name,
                            dateRented.ToString(),
                            dateReturned.ToString(),
                            carType, price.ToString()
                        );

                    Close();
                }
                
                if (!isValid)
                {
                    MessageBox.Show(errMsg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Upon successful data entry or changes being made, a message box is displayed containing the data submitted or edits. 
        public static void SubmitMsg(string name, string dateRented, string dateReturned, string carType, string price)
        {
            MessageBox.Show($"{name}'s data was submitted.\n\n" +
                $"Vehicle: {carType}\n" +
                $"Date Rented: {dateRented}\n" +
                $"Date Returned: {dateReturned}\n" +
                $"Price: ${price}");
        }
    }
}


