using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    public partial class ParkOutResult : UserControl
    {
        DateTime parkInTime;
        DateTime parkOutTime;
        String plateNumber;
        String vehicleType;
        String vehicleBrand;
        ParkOutPanel parkOutPanel;
        ParkInDash dash;
   
        public ParkOutResult()
        {
            InitializeComponent();
        }
        public void setValues() {
            Calculator calculator = new Calculator();
            parkInTimeResult.Text = "Park In Time: " + parkInTime;
            parkOutTimeResult.Text = "Park Out Time: " + parkOutTime.ToString();
            labelPlateNumberResult.Text = "Plate Number: " + plateNumber;
            vehicleTypeResult.Text = "Vehicle Type: " + vehicleType;
            vehicleBrandResult.Text = "Vehicle Brand: " + vehicleBrand;

            TimeSpan timeSpan = calculator.getTimeSpan(parkInTime, parkOutTime);
            int hours = calculator.calculateHours(parkInTime, parkOutTime);

            double hourPoint = hours + calculator.calculateMinutePoint(timeSpan.Minutes);
            if (timeSpan.Minutes >= 30) hours++;
            parkingFeeResult.Text = "Parking Fee: " + calculator.parkingFee(hours, vehicleType);
            parkingTimeResult.Text = "Parking Time: " + hours.ToString("F2") + " Hours";

        }
        public void setParkOutTime(DateTime parkOutTime) { 
            this.parkOutTime = parkOutTime;
        }
        public void setPlateNumber(String plateNumber) { 
            this.plateNumber = plateNumber;
        }
        public void setVehicleType(String vehicleType) { 
            this.vehicleType = vehicleType;
        }
        public void setVehicleBrand(String vehicleBrand) { 
            this.vehicleBrand = vehicleBrand;
        }
        public void setParkInTime(String parkInTime) { 
            this.parkInTime = Convert.ToDateTime(parkInTime);
        }

        public void setDashboard(ParkInDash dash)
        {
            this.dash = dash;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            dash.parkOutButton_Click(sender, e);
        }

        private void BackButton()
        {
            backButton.BackColor = Color.Blue;
            backButton.ForeColor = Color.White;
            backButton.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Blue;
            backButton.ForeColor = Color.White;
    }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.FlatAppearance.MouseOverBackColor = Color.White;
            backButton.ForeColor = Color.Blue;
        }
    }
}
