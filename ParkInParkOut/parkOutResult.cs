using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public ParkOutResult(ParkInDash dash, ParkOutPanel parkOutPanel)
        {
            this.dash = dash;
            this.parkOutPanel = parkOutPanel;
            InitializeComponent();
            setValues();
        }

        public void setValues() {
            parkInTimeResult.Text = "Park In Time: " + parkInTime;
            parkOutTimeResult.Text = "Park Out Time: " + DateTime.Now.ToString();
            labelPlateNumberResult.Text = "Plate Number: " + plateNumber;
            vehicleTypeResult.Text = "Vehicle Type: " + vehicleType;
            vehicleBrandResult.Text = "Vehicle Brand: " + vehicleBrand;
            
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
    }
}
