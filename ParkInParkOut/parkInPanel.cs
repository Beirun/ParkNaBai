using System;
using ParkInParkOut;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    public partial class parkInPanel : UserControl
    {
        parkOutPanel parkOutPanel;
        parkOutResult parkOutResult;
        public parkInPanel(parkOutPanel parkOutPanel, parkOutResult parkOutResult)
        {
            InitializeComponent();
            this.parkOutResult = parkOutResult;
            this.parkOutPanel = parkOutPanel;
        }

        private void plateNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void plateNum_Enter(object sender, EventArgs e)
        {
            if (plateNumberTextBox.Text == "Plate Number")
            {
                plateNumberTextBox.Text = "";

                plateNumberTextBox.ForeColor = Color.FromArgb(50, 50, 50);
            }
        }
        private void plateNum_Leave(object sender, EventArgs e)
        {
            if (plateNumberTextBox.Text == "")
            {
                plateNumberTextBox.Text = "Plate Number";

                plateNumberTextBox.ForeColor = Color.DimGray;
            }
        }
        private void comboVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[,] vehicleBrands = {
                { "Yamaha", "Honda", "Kawasaki", "Suzuki", "Harley-Davidson" },
                { "Toyota", "Honda", "Ford", "Chevrolet", "Volkswagen" },
                { "Toyota", "Ford", "Honda", "Jeep", "BMW" },
                { "Mercedes-Benz", "Ford", "Chrysler", "Volkswagen", "Honda" }
            };

            if (comboVehicleType.Text != "Vehicle Type") comboVehicleType.ForeColor = Color.FromArgb(50, 50, 50);
            else comboVehicleType.ForeColor = Color.DimGray;

            comboVehicleBrand.Enabled = true;
            comboVehicleBrand.Items.Clear();
            for (int i = 0; i < 5; i++) comboVehicleBrand.Items.Add(vehicleBrands[comboVehicleType.SelectedIndex, i]);
        }

        private void comboVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVehicleBrand.Text != "Vehicle Brand") comboVehicleBrand.ForeColor = Color.FromArgb(50, 50, 50);
            else comboVehicleBrand.ForeColor = Color.DimGray;

        }

        private void comboVehicleBrand_EnabledChanged(object sender, EventArgs e)
        {
            comboVehicleBrand.BackColor = comboVehicleBrand.Enabled ? SystemColors.Window : Color.FromArgb(255, 255, 255);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            parkOutPanel.addParkInTime(DateTime.Now.ToString());
            parkOutPanel.addPlateNumber(plateNumberTextBox.Text);
            parkOutPanel.addVehicleBrand(comboVehicleBrand.Text);
            parkOutPanel.addVehicleType(comboVehicleType.Text);
            parkOutPanel.parkedInVehicles();

        }
    }
}
