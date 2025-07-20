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
    public partial class SuccessFulParkInMessage : UserControl
    {
        ParkInPanel parkInPanel;
        public ParkInDash d {  get; set; }

        public SuccessFulParkInMessage()
        {
            InitializeComponent();
            parkAgain();
        }

        private void parkAgain()
        {
            parkInAgain.BackColor = Color.ForestGreen;
            parkInAgain.FlatAppearance.BorderSize = 0;
            parkInAgain.ForeColor = Color.FromArgb(230,230,230);
            label1.ForeColor = Color.ForestGreen;
        }
        private void parkInAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            d.parkInButton_Click(sender, e);
          
        }
        public void setParkInPanel(ParkInPanel parkInPanel) 
        {
            this.parkInPanel = parkInPanel;
            
        }
        private void parkInAgain_MouseLeave(object sender, EventArgs e)
        {
            parkInAgain.BackColor = Color.ForestGreen;
            parkInAgain.ForeColor = Color.FromArgb(230, 230, 230);

        }
        private void parkInAgain_MouseEnter(object sender, EventArgs e)
        {
            parkInAgain.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            parkInAgain.ForeColor = Color.White;
        }
        
        private void SuccessFulParkInMessage_Load(object sender, EventArgs e)
        {

        }

        /*private void SuccessFull_Load(object sender, EventArgs e)
        {
            label1.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;
        }*/

    }
}
