using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddEditVehicles : Form
    {
        /// <summary>
        /// A window whose purpose changes depending on whether or not Edit Mode is active. 
        /// Edit Mode is triggered once the 'Edit car' CTA 'Click' event listener is triggered. With edit mode the data fields will be populated with the existing data of the row selected prior.
        /// Otherwise with edit mode being inative the fields are empty for manual population and a new entry to the database can be submitted. 
        /// </summary>

        // Variable declaration for the existing database (encapsulation)
        private readonly RentalEntities _db = new RentalEntities();

        // If set to 'true' the 'Edit record' window will open populated with the selected row's data
        private bool editMode;

        public AddEditVehicles()
        {
            InitializeComponent();

            // Alters element text values depending on which version of the window is opened (Edit or Add)
            LbTitle.Text = "Add vehicle";

            // Declares '_db' as a new instance of the 'RentalEntities' object
            _db = new RentalEntities();

            editMode = false;
        }

        public AddEditVehicles(CarType carToEdit)
        {
            InitializeComponent();

            // Alters element text values depending on which version of the window is opened (Edit or Add)
            LbTitle.Text = "Edit vehicle";

            // Runs PopulateFields() method passing rental record data
            PopulateFields(carToEdit);

            editMode = true;
        }

        // Populates fields respective data from the row selected prior
        private void PopulateFields(CarType car)
        {
            // The purpose of ID is for lookups
            LbID.Text = car.ID.ToString();
            TbBrand.Text = car.Brand;
            TbModel.Text = car.Model;
            TbVIN.Text = car.VIN;
            TbYear.Text = car.Year.ToString();
            TbLpn.Text = car.License_Plate;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                // Assignes database attribute values to the values within entry fields
                var id = int.Parse(LbID.Text);
                var car = _db.CarTypes.FirstOrDefault(z => z.ID == id);
                car.Brand = TbBrand.Text;
                car.Model = TbModel.Text;
                car.VIN = TbVIN.Text;
                car.Year = int.Parse(TbYear.Text);
                car.License_Plate = TbLpn.Text;

                _db.SaveChanges();
            } 
            else
            {
                // Creates new instance/car with following attributes
                var newCar = new CarType
                {
                    Brand = TbBrand.Text,
                    Model = TbModel.Text,
                    VIN = TbVIN.Text,
                    Year = int.Parse(TbYear.Text),
                    License_Plate = TbLpn.Text
                };

                // Adds data to a new instance of the 'CarTypes' entity, then closes the window
                _db.CarTypes.Add(newCar);
                _db.SaveChanges();
                this.Close();
            }
        }

        // Closes window when the 'Cancel' CTA's 'Click' event listener is triggered.
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
