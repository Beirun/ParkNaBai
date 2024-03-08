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
    public partial class ErrorDateTimeMessage : UserControl
    {
        ParkInDash dash;
        public ErrorDateTimeMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dash.parkOutButton_Click(sender, e);
        }
        public void setDash(ParkInDash dash)
        {
            this.dash = dash;
        }
    }
}
