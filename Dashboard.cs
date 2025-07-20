
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace ParkInParkOut
{
    public partial class ParkInDash : Form
    {
        
        ParkInPanel parkInPanel2;
        String userName;
        int clickCounter = 0;
        public ParkInDash(string userName)
        {
            DoubleBuffered = true;
            InitializeComponent();
            floorSlots1.ParkingSlotPanel = parkingSlots1;
            this.Controls.Remove(parkInPanel1);
            instantiatePanels(userName);
            this.StartPosition = FormStartPosition.CenterScreen;
            Button2();
            logoutButtons();
            parkingSlots1.Visible = false;
            floorSlots1.Visible = false;
            parkOutResult1.Visible = false;
            parkOutPanel1.Visible = false;
            noParkedInMessage1.Visible = false;
            successFulParkInMessage1.Visible = false;
            successfulParkedOutMessage1.Visible = false;
            logsPanel1.Visible = false;
            parkOutResult1.setDashboard(this);
            errorDateTimeMessage1.setDash(this);
            dashFee1.setDashboard(this);
            dashFee1.Visible = true;
            incomePanel1.Visible = false;
            floorSlots1.Visible = false;
            parkingSlots1.Visible = false;
            parkInPanel2.Visible = false;
            parkOutPanel1.Visible = false;
            successfulParkedOutMessage1.setDashboard(this);
            errorDateTimeMessage1.Visible = false;
            parkOutResult1.setSuccessfulParkedOutMessage(successfulParkedOutMessage1);
            parkOutPanel1.setErrorDatTimeMessage(errorDateTimeMessage1);
            parkOutResult1.setParkInPanel(parkInPanel2);
            exitButton.Location = new System.Drawing.Point(this.Width - exitButton.Width, 0);
            exitButton.BringToFront();
            this.userName = userName;
            parkOutResult1.UserName = userName;
            this.BackColor = Color.FromArgb(230, 230, 230);
            floorSlots1.BackColor = BackColor;
            dashFee1.BackColor = BackColor;
            errorDateTimeMessage1.BackColor = BackColor;
            noParkedInMessage1.BackColor = BackColor;
            parkingSlots1.BackColor = BackColor;
            parkInPanel2.BackColor = BackColor;
            parkOutPanel1.BackColor = BackColor;
            parkOutResult1.BackColor = BackColor;
            successFulParkInMessage1.BackColor = BackColor;
            successfulParkedOutMessage1.BackColor = BackColor;
            successFulParkInMessage1.d = this;
            dashboardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 171, 42);
            dashboardButton.BackColor = Color.FromArgb(42, 171, 42);
        }

        private void logoutButtons() { 
            logoutButton.BackColor = Color.FromArgb(230,230,230);
            logoutButton.ForeColor = Color.ForestGreen;
            logoutButton.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void instantiatePanels(string userName) {
            
            parkOutPanel1.setParkOutResult(parkOutResult1);

            parkInPanel2 = new ParkInPanel(parkOutPanel1, parkOutResult1);
            this.parkInPanel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parkInPanel2.Location = new System.Drawing.Point(panelDash.Width, 0);
            this.parkInPanel2.Name = "parkInPanel1";
            this.parkInPanel2.Size = new System.Drawing.Size(1032, 800);
            this.parkInPanel2.TabIndex = 12;
            this.Controls.Add(parkInPanel2);
            parkOutPanel1.setParkInPanel(parkInPanel2);

            parkInPanel2.SetSuccessfulMessage(successFulParkInMessage1);
            successFulParkInMessage1.setParkInPanel(parkInPanel2);
            parkingSlots1.parkInPanel = parkInPanel2;
            parkInPanel2.userName = userName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Visible = false;
            Thread.Sleep(250);
            loginForm.Visible = true;
        }
        private void Button2()
        {
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.ForestGreen;
            exitButton.BackColor = Color.FromArgb(230, 230, 230);
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = exitButton.BackColor;
        }
      
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            exitButton.ForeColor = Color.FromArgb(150, 0, 0);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = this.BackColor;
            exitButton.ForeColor = Color.ForestGreen;
        }
        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.White;
            logoutButton.ForeColor = Color.ForestGreen;

        }
        private void logoutButton_MouseDown(object sender, MouseEventArgs e)
        {
            logoutButton.ForeColor = Color.FromArgb(150, 0, 0);
        }
        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            logoutButton.ForeColor = Color.White;
        }

        private void parkInButton_MouseLeave(object sender, EventArgs e)
        {
            if (parkInPanel2.Visible || floorSlots1.Visible || parkingSlots1.Visible) return;
            parkInButton.BackColor = Color.ForestGreen;
            parkInButton.ForeColor = Color.FromArgb(230,230,230);

        }
        
        private void parkInButton_MouseEnter(object sender, EventArgs e)
        {
            if (parkInPanel2.Visible || floorSlots1.Visible || parkingSlots1.Visible) return;
            parkInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            parkInButton.ForeColor = Color.White;
            
        }
        private void parkOutButton_MouseLeave(object sender, EventArgs e)
        {
            if (parkOutPanel1.Visible || errorDateTimeMessage1.Visible || noParkedInMessage1.Visible || parkOutPanel1.Visible || successfulParkedOutMessage1.Visible) return;
            parkOutButton.BackColor = Color.ForestGreen;
            parkOutButton.ForeColor = Color.FromArgb(230, 230, 230);

        }

        private void parkOutButton_MouseEnter(object sender, EventArgs e)
        {
            if (parkOutPanel1.Visible || errorDateTimeMessage1.Visible || noParkedInMessage1.Visible || parkOutPanel1.Visible || successfulParkedOutMessage1.Visible) return;
            parkOutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            parkOutButton.ForeColor = Color.White;

        }
        private void dashboardButton_MouseLeave(object sender, EventArgs e)
        {   
            if (dashFee1.Visible) return;
            dashboardButton.BackColor = Color.ForestGreen;
            dashboardButton.ForeColor = Color.FromArgb(230, 230, 230);

        }

        private void dashboardButton_MouseEnter(object sender, EventArgs e)
        {
            if(clickCounter == 0) dashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            if (dashFee1.Visible) return;
            dashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            dashboardButton.ForeColor = Color.White;

        }


        public void parkOutButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            dashFee1.Visible = false;
            floorSlots1.Visible = false;
            parkingSlots1.Visible = false;
            parkInPanel2.Visible = false;
            logsPanel1.Visible = false;
            incomePanel1.Visible = false;

            parkOutResult1.Visible = false;
            successFulParkInMessage1.Visible = false;
            errorDateTimeMessage1.Visible = false;
            successfulParkedOutMessage1.Visible = false;
            dashFee1.Visible = false;
            parkInPanel2.Visible = false;
            floorSlots1.Visible = false;
            parkingSlots1.Visible = false; 
            parkInButton_MouseLeave(sender, e);
            dashboardButton_MouseLeave(sender, e);
            logsButton_MouseLeave(sender, e);
            incomeButton_MouseLeave(sender, e);
            if (parkOutPanel1.Visible || errorDateTimeMessage1.Visible || noParkedInMessage1.Visible || parkOutPanel1.Visible || successfulParkedOutMessage1.Visible) return;

            ((Button)sender).FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 171, 42);
            ((Button)sender).BackColor = Color.FromArgb(42, 171, 42);
            
            
            if (parkInPanel2.getCounter()==0)
            {
                noParkedInMessage1.Visible = true;
                parkOutPanel1.Visible = false;
            }
            else
            {
                parkOutPanel1.Visible = true;
                parkOutPanel1.Invalidate();
                noParkedInMessage1.Visible = false;
                parkOutPanel1.parkedInVehicles();
            }
        }

        

        public void parkInButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            dashFee1.Visible = false;
            parkingSlots1.Visible = false;
            parkOutPanel1.Visible = false;
            logsPanel1.Visible = false;
            incomePanel1.Visible = false;
            successfulParkedOutMessage1.Visible = false;
            parkOutResult1.Visible = false;
            errorDateTimeMessage1.Visible = false;
            noParkedInMessage1.Visible = false;

            parkingSlots1.Visible = false;
            dashFee1.Visible = false;
            parkInPanel2.Visible = false;
            parkOutPanel1.Visible = false;
            successFulParkInMessage1.Visible = false;
            dashboardButton_MouseLeave(sender, e);
            parkOutButton_MouseLeave(sender, e);
            logsButton_MouseLeave(sender, e);
            incomeButton_MouseLeave(sender, e);
            if (parkInPanel2.Visible || floorSlots1.Visible || parkingSlots1.Visible) return;

            ((Button)sender).FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 171, 42);
            ((Button)sender).BackColor = Color.FromArgb(42, 171, 42);
            floorSlots1.Visible = true;
            floorSlots1.floorButtons();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {

            floorSlots1.Visible = false;
            parkingSlots1.Visible = false;
            parkInPanel2.Visible = false;
            parkOutPanel1.Visible = false;
            incomePanel1.Visible = false;
            logsPanel1.Visible = false;

            parkOutResult1.Visible = false;
            noParkedInMessage1.Visible = false;
            errorDateTimeMessage1.Visible = false;
            successfulParkedOutMessage1.Visible = false;

            floorSlots1.Visible = false;
            parkingSlots1.Visible = false;
            successFulParkInMessage1.Visible = false;
            parkInButton_MouseLeave(sender, e);
            parkOutButton_MouseLeave(sender, e);
            logsButton_MouseLeave(sender, e);
            incomeButton_MouseLeave(sender, e);

            if (dashFee1.Visible) return;
            ((Button)sender).FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 171, 42);
            ((Button)sender).BackColor = Color.FromArgb(42, 171, 42); 
            dashFee1.Visible = true;
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
            floorSlots1.Visible = false;
            parkingSlots1.Visible = false;
            parkInPanel2.Visible = false;
            parkOutPanel1.Visible = false;
            dashFee1.Visible = false;
            incomePanel1.Visible = false;
            successFulParkInMessage1.Visible = false;
            parkOutResult1.Visible = false;
            noParkedInMessage1.Visible = false;
            errorDateTimeMessage1.Visible = false;
            successfulParkedOutMessage1.Visible = false;
            parkInButton_MouseLeave(sender, e);
            parkOutButton_MouseLeave(sender, e);
            dashboardButton_MouseLeave(sender, e);
            incomeButton_MouseLeave(sender, e);
            if (logsPanel1.Visible) return;
            ((Button)sender).FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 171, 42);
            ((Button)sender).BackColor = Color.FromArgb(42, 171, 42);
            logsPanel1.Visible = true;
        }

        private void logsButton_MouseEnter(object sender, EventArgs e)
        {
            if (logsPanel1.Visible) return;
            logsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            logsButton.ForeColor = Color.White;

        }

        private void logsButton_MouseLeave(object sender, EventArgs e)
        {
            if (logsPanel1.Visible) return;
            logsButton.BackColor = Color.ForestGreen;
            logsButton.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            floorSlots1.Visible = false;
            parkingSlots1.Visible = false;
            parkInPanel2.Visible = false;
            parkOutPanel1.Visible = false;
            dashFee1.Visible = false;
            logsPanel1.Visible = false;

            floorSlots1.Visible = false;
            parkingSlots1.Visible = false;
            parkInPanel2.Visible = false;
            parkOutResult1.Visible = false;
            parkOutPanel1.Visible = false;
            noParkedInMessage1.Visible = false;
            successfulParkedOutMessage1.Visible = false;
            successFulParkInMessage1.Visible = false;
            errorDateTimeMessage1.Visible = false;
            parkInButton_MouseLeave(sender, e);
            parkOutButton_MouseLeave(sender, e);
            dashboardButton_MouseLeave(sender, e);
            logsButton_MouseLeave(sender, e);
            if (incomePanel1.Visible) return;
            ((Button)sender).FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 171, 42);
            ((Button)sender).BackColor = Color.FromArgb(42, 171, 42);

            incomePanel1.setPaymentSheet("", "", "");
            incomePanel1.setPercentPanel();
            incomePanel1.setDetailPanel();
            incomePanel1.Visible = true;
        }

        private void incomeButton_MouseEnter(object sender, EventArgs e)
        {
            if (incomePanel1.Visible) return;
            incomeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            incomeButton.ForeColor = Color.White;
        }

        
        private void incomeButton_MouseLeave(object sender, EventArgs e)
        {
            if (incomePanel1.Visible) return;
            incomeButton.BackColor = Color.ForestGreen;
            incomeButton.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void incomePanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
