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

        public SuccessFulParkInMessage()
        {
            InitializeComponent();
            parkAgain();
        }

        private void parkAgain()
        {
            parkInAgain.BackColor = Color.Blue;
            parkInAgain.FlatAppearance.BorderSize = 0;
            parkInAgain.ForeColor = Color.White;
            label1.ForeColor = Color.White;
        }
        private void parkInAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            parkInPanel.Show();
          
        }
        public void setParkInPanel(ParkInPanel parkInPanel) 
        {
            this.parkInPanel = parkInPanel;
            
        }
        private void parkInAgain_MouseLeave(object sender, EventArgs e)
        {
            parkInAgain.BackColor = Color.Blue;
            parkInAgain.ForeColor = Color.White;

        }
        private void parkInAgain_MouseEnter(object sender, EventArgs e)
        {
            parkInAgain.FlatAppearance.MouseOverBackColor = Color.White;
            parkInAgain.ForeColor = Color.Blue;
        }

        private void SuccessFull_Load(object sender, EventArgs e)
        {
            label1.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;
        }

    }
}
