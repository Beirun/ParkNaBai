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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            parkInPanel.Show();
          
        }
        public void setParkInPanel(ParkInPanel parkInPanel) 
        {
            this.parkInPanel = parkInPanel;
            
        }
    }
}
