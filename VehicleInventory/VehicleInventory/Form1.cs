using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleInventory.VehicleInventory;

namespace VehicleInventory
{
    public partial class VehicleInventoryForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public VehicleInventoryForm()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txbLicense.Text;
                sedan.VIN = txbVIN.Text;
                vehicles.Add(sedan);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added sedan";
            }
            else if (cbType.Text == "Truck")
            {
                Truck truck = new Truck(txbVIN.Text, txbLicense.Text);
                vehicles.Add(truck);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added truck";
            }

        }

        private void lbInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle vehicle = (Vehicle)lbInventory.SelectedItem;
            txbSummary.Text = vehicle.GetDescription();
        }
    }
}
