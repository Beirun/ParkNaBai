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
    public partial class ParkInPanel : UserControl
    {
        ParkOutPanel parkOutPanel;
        ParkOutResult parkOutResult;
        int counter = 0;

        SuccessFulParkInMessage successFulParkInMessage;
        public ParkInPanel(ParkOutPanel parkOutPanel, ParkOutResult parkOutResult)
        {
            InitializeComponent();
            this.parkOutResult = parkOutResult;
            this.parkOutPanel = parkOutPanel;
            vtext();
            submitButtons();
        }
        public ParkInPanel()
        {
            InitializeComponent();
            vtext();
            submitButtons();
        }

        private void vtext()
        {
            comboVehicleType.Text = "Vehicle Type";
            comboVehicleBrand.Text = "Vehicle Brand";
            
        }

        private void plateNum_Enter(object sender, EventArgs e)
        {
            if (plateNumberTextBox.Text == "Plate Number")
            {
                plateNumberTextBox.Text = "";

                plateNumberTextBox.ForeColor = Color.White;
            }
            errorFillMessage.Hide();
        }
        private void plateNum_Leave(object sender, EventArgs e)
        {
            if (plateNumberTextBox.Text == "")
            {
                plateNumberTextBox.Text = "Plate Number";

                plateNumberTextBox.ForeColor = Color.White;
            }
        }

        private void submitButtons()
        {
            submitButton.BackColor = Color.Purple;
            submitButton.ForeColor = Color.White;
            submitButton.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            submitButton.BackColor = Color.Purple;
            submitButton.ForeColor = Color.White;

        }
        private void submitButton_MouseEnter(object sender, EventArgs e)
        {
            submitButton.FlatAppearance.MouseOverBackColor = Color.White;
            submitButton.ForeColor = Color.Purple;
        }

        private void comboVehicleType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
         
            string[,] vehicleBrands = {
                { "Yamaha", "Honda", "Kawasaki", "Suzuki", "Harley-Davidson" },
                { "Toyota", "Honda", "Ford", "Chevrolet", "Volkswagen" },
                { "Toyota", "Ford", "Honda", "Jeep", "BMW" },
                { "Mercedes-Benz", "Ford", "Chrysler", "Volkswagen", "Honda" }
            };

            if (comboVehicleType.Text != "Vehicle Type") comboVehicleType.ForeColor = Color.White; 
            else comboVehicleType.ForeColor = Color.White; 

            comboVehicleBrand.Enabled = true;
            comboVehicleBrand.Items.Clear();
            for (int i = 0; i < 5; i++) comboVehicleBrand.Items.Add(vehicleBrands[comboVehicleType.SelectedIndex, i]);
        }

        private void comboVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVehicleBrand.Text != "Vehicle Brand") comboVehicleBrand.ForeColor = Color.White;
            else comboVehicleBrand.ForeColor = Color.White;

        }
        
        private void comboVehicleBrand_EnabledChanged(object sender, EventArgs e)
        {
            
            comboVehicleBrand.BackColor = comboVehicleBrand.Enabled ? BackColor : Color.Blue;
            comboVehicleBrand.ForeColor = comboVehicleBrand.Enabled ? Color.White : Color.Red;
            comboVehicleBrand.BackColor = Color.Blue;
        }
         
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (plateNumberTextBox.Text.Equals("Plate Number") || plateNumberTextBox.Text.Equals("") ||
                comboVehicleType.Text.Equals("Vehicle Type") || comboVehicleType.Text.Equals("") ||
                comboVehicleBrand.Text.Equals("Vehicle Brand") || comboVehicleType.Text.Equals(""))
            {
                errorFillMessage.Show();
            }
            else
            {
                if (parkOutPanel.isDuplicatePlateNumber(plateNumberTextBox.Text))
                {
                    errorFillMessage.Text = "Error! Duplicate Plate Number!";
                    errorFillMessage.Show();
                }
                else
                {
                    counter++;
                    parkOutPanel.addParkInTime(DateTime.Now.ToString());
                    parkOutPanel.addPlateNumber(plateNumberTextBox.Text);
                    parkOutPanel.addVehicleBrand(comboVehicleBrand.Text);
                    parkOutPanel.addVehicleType(comboVehicleType.Text);
                    parkOutPanel.parkedInVehicles();
                    setDefault();
                    successFulParkInMessage.Show();
                    this.Hide();
                }
            }
        }
        public void setDefault() 
        {
            plateNumberTextBox.Text = "Plate Number";
            comboVehicleType.Text = "Vehicle Type";
            comboVehicleBrand.Text = "Vehicle Brand";
            comboVehicleBrand.Enabled = false;
        }
        public int getCounter() { 
            return counter;
        }
        public void setCounter()
        {
            counter--;
        }
        private void showIncorrectMessage(object sender, EventArgs e)
        {
            errorFillMessage.Hide();
            errorFillMessage.Text = "Please fill in all the necessary fields.";
        }

        private void comboVehicleType_Leave(object sender, EventArgs e)
        {
            if (comboVehicleType.Text == "")
            {
                comboVehicleType.Text = "Vehicle Type";
                comboVehicleType.ForeColor = Color.White;
            }
        }

        private void comboVehicleBrand_Leave(object sender, EventArgs e)
        {
            if (comboVehicleBrand.Text == "")
            {
                comboVehicleBrand.Text = "Vehicle Brand";
                comboVehicleBrand.ForeColor = Color.White;
            }
        }


        private void ParkInPanel_Load(object sender, EventArgs e)
        {
           // comboVehicleBrand.ForeColor= Color.White;
        }

        public void SetSuccessfulMessage(SuccessFulParkInMessage successFulParkInMessage)
        { 
            this.successFulParkInMessage = successFulParkInMessage;
        }

    }
}