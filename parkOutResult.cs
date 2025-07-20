using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
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
        Label[] labels = new Label[8];
        public string UserName {  get; set; }
        int Payment = 0;
        String plateNumber;
        String vehicleType;
        String vehicleBrand;
        public ParkOutPanel parkOutPanel {  get; set; }
        public string parkingSlot {  get; set; }
        ParkInPanel parkInPanel;
        ParkInDash dash;
        SuccessfulParkedOutMessage parkOutMessage;
        Bitmap bmp;

        public ParkOutResult()
        {
            InitializeComponent();
            BackButton();
            for (int i = 0; i < labels.Length; i++) labels[i] = new Label();

        }
        public void setSuccessfulParkedOutMessage(SuccessfulParkedOutMessage parkOutMessage) { 
            this.parkOutMessage = parkOutMessage;
        }
        public void setValues() {
            Calculator calculator = new Calculator();

            labels[0].Text = parkInTime.ToString();
            labels[1].Text = parkOutTime.ToString();
            labels[2].Text = plateNumber;
            labels[3].Text = vehicleType;
            labels[4].Text = vehicleBrand;
            labels[5].Text = parkingSlot;

            TimeSpan timeSpan = calculator.getTimeSpan(parkInTime, parkOutTime);
            int hours = calculator.calculateHours(parkInTime, parkOutTime);
            double hourPoint = hours + calculator.calculateMinutePoint(timeSpan.Minutes);
            if (timeSpan.Minutes >= 30) hours++;
            labels[6].Text = calculator.parkingFee(hours, vehicleType).ToString();
            labels[7].Text = hours.ToString("F2") + " Hours";
            int gap = 75;
            for (int i = 0;i < labels.Length; i++)
            {
                labels[i].Font = parkingTimeResult.Font;
                labels[i].ForeColor = Color.ForestGreen;
                labels[i].Size = new Size(TextRenderer.MeasureText(labels[i].Text, labels[i].Font).Width, TextRenderer.MeasureText(labels[i].Text, labels[i].Font).Height);
                labels[i].Location = new Point(Width- TextRenderer.MeasureText(labels[i].Text, labels[i].Font).Width-gap, (i*45)+150);
                Controls.Add(labels[i]);
            }
            parkInTimeResult.Location = new Point(gap, labels[0].Location.Y);
            parkOutTimeResult.Location = new Point(gap, labels[1].Location.Y);
            labelPlateNumberResult.Location = new Point(gap, labels[2].Location.Y);
            vehicleTypeResult.Location = new Point(gap, labels[3].Location.Y);
            vehicleBrandResult.Location = new Point(gap, labels[4].Location.Y);
            slotResult.Location = new Point(gap, labels[5].Location.Y);
            parkingTimeResult.Location = new Point(gap, labels[6].Location.Y);
            parkingFeeResult.Location = new Point(gap, labels[7].Location.Y);
        }

        public void setReceipt()
        {
            String text = "PARKING RECEIPT";
            int intWidth = 600;
            int intHeight = 1000;

            bmp = new Bitmap(intWidth, intHeight);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            Brush brush = new SolidBrush(Color.Black);
            Font font = new Font("Cascadia Code", 50, FontStyle.Bold, GraphicsUnit.Pixel);
            SizeF size = g.MeasureString(text, font);
            Pen pen = new Pen(Color.Black, 4);
            using (Image image = Image.FromFile("C:\\Users\\Beirun\\source\\repos\\ParkInParkOut\\ParkInParkOut\\Resources\\parknabaireceipt.png"))
            {
                g.DrawImage(image, new Point(image.Width / 2, 25));
            }
            g.DrawLine(pen, 25, 245 - size.Height, 575, 245 - size.Height);
            g.DrawLine(pen, 25, 225 + size.Height, 575, 225 + size.Height);
            g.DrawString(text, font, brush, (intWidth - size.Width) / 2, 210, StringFormat.GenericDefault);

            font = new Font("Cascadia Code", 20, FontStyle.Regular, GraphicsUnit.Pixel);
            g.DrawString("PARK IN TIME", font, brush, 25, 350, StringFormat.GenericDefault);
            g.DrawString(parkInTime.ToString().ToUpper(), font, brush, getXPosition(g, parkInTime.ToString().ToUpper(), font), 350, StringFormat.GenericDefault);

            g.DrawString("PARK OUT TIME", font, brush, 25, 410, StringFormat.GenericDefault);
            g.DrawString(parkOutTime.ToString().ToUpper(), font, brush, getXPosition(g, parkOutTime.ToString().ToUpper(), font), 410, StringFormat.GenericDefault);

            g.DrawString("PLATE NUMBER", font, brush, 25, 470, StringFormat.GenericDefault);
            g.DrawString(plateNumber.ToUpper(), font, brush, getXPosition(g, plateNumber.ToUpper(), font), 470, StringFormat.GenericDefault);

            g.DrawString("VEHICLE TYPE", font, brush, 25, 530, StringFormat.GenericDefault);
            g.DrawString(vehicleType.ToUpper(), font, brush, getXPosition(g, vehicleType.ToUpper(), font), 530, StringFormat.GenericDefault);

            g.DrawString("VEHICLE BRAND", font, brush, 25, 590, StringFormat.GenericDefault);
            g.DrawString(vehicleBrand.ToUpper(), font, brush, getXPosition(g, vehicleBrand.ToUpper(), font), 590, StringFormat.GenericDefault);

            g.DrawString("PARKING SLOT", font, brush, 25, 650, StringFormat.GenericDefault);
            g.DrawString(parkingSlot.ToUpper(), font, brush, getXPosition(g, parkingSlot.ToUpper(), font), 650, StringFormat.GenericDefault);


            Calculator calculator = new Calculator();

            TimeSpan timeSpan = calculator.getTimeSpan(parkInTime, parkOutTime);
            int hours = calculator.calculateHours(parkInTime, parkOutTime);

            double hourPoint = hours + calculator.calculateMinutePoint(timeSpan.Minutes);
            if (timeSpan.Minutes >= 30) hours++;

            g.DrawString("PARKING TIME", font, brush, 25, 710, StringFormat.GenericDefault);
            g.DrawString(hours.ToString("F2") + " HOURS", font, brush, getXPosition(g, hours.ToString("F2") + " HOURS", font), 710, StringFormat.GenericDefault);


            font = new Font("Cascadia Code", 50, FontStyle.Bold, GraphicsUnit.Pixel);
            size = g.MeasureString("PAID: " + calculator.parkingFee(hours, vehicleType) + " PHP", font);
            Payment = calculator.parkingFee(hours, vehicleType);
            g.DrawString("PAID: " + calculator.parkingFee(hours, vehicleType) + " PHP", font, brush, (intWidth - size.Width) / 2, 770, StringFormat.GenericDefault);
            g.DrawLine(pen, 25, 825, 575, 825);

            using (Image img = Image.FromFile("C:\\Users\\Beirun\\source\\repos\\ParkInParkOut\\ParkInParkOut\\Resources\\barcode.png"))
            {
                g.DrawImage(img, new Point(20, 860));
            }

            g.Flush();
            
            Image image1 = (Image) bmp.Clone();
            parkOutMessage.setImage(image1);
            
            bmp.Dispose();
            parkOutMessage.setPlateNumber(plateNumber);
            parkOutMessage.setBitmap(bmp);
            


        }

        public int getXPosition(Graphics g, String text, Font font)
        {
            int x = 0;
            SizeF size = g.MeasureString(text, font);
            x = (int)(575 - size.Width);
            return x;
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
        public void setParkInPanel(ParkInPanel parkInPanel) { 
            this.parkInPanel = parkInPanel;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            dash.parkOutButton_Click(sender, e);
        }

        private void BackButton()
        {
            backButton.BackColor = Color.ForestGreen;
            backButton.ForeColor = Color.FromArgb(230,230,230);
            backButton.Font = new Font("Tahoma", 10, FontStyle.Bold);

            submitButton.BackColor = Color.ForestGreen;
            submitButton.ForeColor = Color.FromArgb(230,230,230);
            submitButton.Font = new Font("Tahoma", 10, FontStyle.Bold);

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

        private void submitButton_Click(object sender, EventArgs e)
        {   
            parkOutMessage.Show();
            setReceipt();
            new SqlConnectionClass().parkOutVehicle(UserName, plateNumber, Payment);
            parkInPanel.setCounter();
            this.Hide();
        }

        private void ParkOutResult_Load(object sender, EventArgs e)
        {

        }
    }
}
