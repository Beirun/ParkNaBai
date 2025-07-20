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
    public partial class SuccessfulParkedOutMessage : UserControl
    {
        Bitmap bmp;
        ParkInDash dashboard;
        String plateNumber;
        Image image;
        public SuccessfulParkedOutMessage()
        {
            InitializeComponent();
        }

        public void setBitmap(Bitmap bmp)
        {
            this.bmp = bmp;
        }
        public void setPlateNumber(String plateNumber)
        {
            this.plateNumber = plateNumber;
        }
        public void setDashboard(ParkInDash dashboard) {
            this.dashboard = dashboard;
        }
        public void setImage(Image image)
        {
            this.image = image;
        }
        private void viewReceiptButton_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.setPlateNumber(plateNumber);
            receipt.setImage(image);
            receipt.setPictureBox(bmp);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dashboard.parkOutButton_Click(sender, e);
        }
        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            button.BackColor = Color.ForestGreen;
            button.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            button.ForeColor = Color.White;
        }

        private void SuccessfulParkedOutMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
