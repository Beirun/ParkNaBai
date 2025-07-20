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
using System.Data.SqlClient;

namespace ParkInParkOut
{
    public partial class ParkInPanel : UserControl
    {
        ParkOutPanel parkOutPanel;
        ParkOutResult parkOutResult;
        int counter;
        public string userName { get; set; }
        public int FloorSlot { get; set; }
        public int RowSlot { get; set; }
        public int ColumnSlot { get; set; }
        SuccessFulParkInMessage successFulParkInMessage;
        SqlConnectionClass sqlConnectionClass = new SqlConnectionClass();
        public ParkInPanel(ParkOutPanel parkOutPanel, ParkOutResult parkOutResult)
        {
            InitializeComponent();
            this.parkOutResult = parkOutResult;
            this.parkOutPanel = parkOutPanel;
            vtext();
            submitButtons();
            counter = sqlConnectionClass.getList();
        }
        public ParkInPanel()
        {
            InitializeComponent();
            vtext();
            submitButtons();
            counter = sqlConnectionClass.getList();
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

                plateNumberTextBox.ForeColor = Color.ForestGreen;
            }
            errorFillMessage.Hide();
        }
        private void plateNum_Leave(object sender, EventArgs e)
        {
            if (plateNumberTextBox.Text == "")
            {
                plateNumberTextBox.Text = "Plate Number";

                plateNumberTextBox.ForeColor = Color.ForestGreen;
            }
        }

        private void submitButtons()
        {
            submitButton.BackColor = Color.ForestGreen;
            submitButton.ForeColor = Color.FromArgb(230,230,230);
            submitButton.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
       

        private void submitButton_MouseEnter(object sender, EventArgs e)
        {
            submitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            submitButton.ForeColor = Color.White;

        }

        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            submitButton.BackColor = Color.ForestGreen;
            submitButton.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void comboVehicleType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
         
            string[,] vehicleBrands = {
                { "Yamaha", "Honda", "Kawasaki", "Suzuki", "Harley-Davidson" },
                { "Toyota", "Honda", "Ford", "Chevrolet", "Volkswagen" },
                { "Toyota", "Ford", "Honda", "Jeep", "BMW" },
                { "Mercedes-Benz", "Ford", "Chrysler", "Volkswagen", "Honda" }
            };

            if (comboVehicleType.Text != "Vehicle Type") comboVehicleType.ForeColor = Color.ForestGreen; 
            else comboVehicleType.ForeColor = Color.ForestGreen; 

            comboVehicleBrand.Enabled = true;
            comboVehicleBrand.Items.Clear();
            for (int i = 0; i < 5; i++) comboVehicleBrand.Items.Add(vehicleBrands[comboVehicleType.SelectedIndex, i]);
        }

        private void comboVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVehicleBrand.Text != "Vehicle Brand") comboVehicleBrand.ForeColor = Color.ForestGreen;
            else comboVehicleBrand.ForeColor = Color.ForestGreen;

        }
        
        private void comboVehicleBrand_EnabledChanged(object sender, EventArgs e)
        {
            
            comboVehicleBrand.BackColor = comboVehicleBrand.Enabled ? BackColor : Color.Blue;
            comboVehicleBrand.ForeColor = comboVehicleBrand.Enabled ? Color.ForestGreen : Color.Red;
            comboVehicleBrand.BackColor = Color.White;
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



                if (sqlConnectionClass.isVehicleInDB(plateNumberTextBox.Text, comboVehicleType.Text, comboVehicleBrand.Text))
                {
                    if (!sqlConnectionClass.isVehicleActive(plateNumberTextBox.Text))
                    {
                        sqlConnectionClass.addParkingRecord(userName, plateNumberTextBox.Text, FloorSlot, ColumnSlot, RowSlot);

                        setDefault();
                        successFulParkInMessage.Show();
                        this.Hide();
                    }
                    else
                    {
                        errorFillMessage.Text = "Error! Vehicle is Already Parked in!";
                        errorFillMessage.Show();
                    }
                }
                else if (sqlConnectionClass.isDuplicatePlateNumbber(plateNumberTextBox.Text))
                {
                    errorFillMessage.Text = "Error! Duplicate Plate Number!";
                    errorFillMessage.Show();
                }
                else
                {


                    /*string[,] vehicleBrands = {
                                                { "Yamaha", "Honda", "Kawasaki", "Suzuki", "Harley-Davidson" },
                                                { "Toyota", "Honda", "Ford", "Chevrolet", "Volkswagen" },
                                                { "Toyota", "Ford", "Honda", "Jeep", "BMW" },
                                                { "Mercedes-Benz", "Ford", "Chrysler", "Volkswagen", "Honda" }
                                            };
                    string[] vehicleTypes = { "MotorBike", "Sedan", "SUV", "Van" };
                    string alphabet = "ABCDEFGHIJKLMOPQRSTUVWXYZ";
                    string number = "1234567890";
                    Random ran = new Random();

                    for (int i = 0; i < 10; i++)
                    {
                        string plate = "";
                        for (int j = 0; j < 7; j++)
                        {
                            if (j < 4) plate += alphabet[ran.Next(alphabet.Length)];
                            else plate += number[ran.Next(number.Length)];
                        }
                        int rand = ran.Next(0, 4);
                        sqlConnectionClass.addVehicle(plate, vehicleTypes[rand], vehicleBrands[rand, ran.Next(0, 5)]);

                    }*/
                    sqlConnectionClass.addVehicle(plateNumberTextBox.Text, comboVehicleType.Text, comboVehicleBrand.Text);
                    sqlConnectionClass.addParkingRecord(userName, plateNumberTextBox.Text, FloorSlot, ColumnSlot, RowSlot);

                    counter++;
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
            counter = sqlConnectionClass.getList();
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
                comboVehicleType.ForeColor = Color.ForestGreen;
            }
        }

        private void comboVehicleBrand_Leave(object sender, EventArgs e)
        {
            if (comboVehicleBrand.Text == "")
            {
                comboVehicleBrand.Text = "Vehicle Brand";
                comboVehicleBrand.ForeColor = Color.ForestGreen;
            }
        }


/*        private void ParkInPanel_Load(object sender, EventArgs e)
        {
           // comboVehicleBrand.ForeColor= Color.White;
        }*/

        public void SetSuccessfulMessage(SuccessFulParkInMessage successFulParkInMessage)
        { 
            this.successFulParkInMessage = successFulParkInMessage;
        }

        private void comboVehicleType_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down))
            {
                comboVehicleType.Icon_Click(sender, e);
            }
        }

        
    }
}