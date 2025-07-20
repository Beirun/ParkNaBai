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
    public partial class DashFee : UserControl
    {
        ParkInDash dash;
        
        public DashFee()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(230, 230, 230);
            GoParkIn();
        }
        
      
        public void setDashboard(ParkInDash dash)
        {
            this.dash = dash;
        }

        private void goToParkIn_Click(object sender, EventArgs e)
        {
            dash.parkInButton_Click(sender, e); 
        }

        private void DashFee_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 230, 230);
        }
        private void GoParkIn()
        {
            goToParkIn.BackColor = Color.ForestGreen;
            goToParkIn.ForeColor = Color.FromArgb(230, 230, 230);

        }
        private void goToParkIn_MouseLeave(object sender, EventArgs e)
        {
            goToParkIn.BackColor = Color.ForestGreen;
            goToParkIn.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void goToParkIn_MouseEnter(object sender, EventArgs e)
        {
            goToParkIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            goToParkIn.ForeColor = Color.White;
        }
    }
}
    

