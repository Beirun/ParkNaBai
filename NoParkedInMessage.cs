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
    public partial class NoParkedInMessage : UserControl
    {
        public NoParkedInMessage()
        {
            InitializeComponent();
            noParkLabel();
        }

        public void noParkLabel() 
        {
            noPark.BackColor = Color.Transparent;
        }

        private void NoParkedInMessage_Load(object sender, EventArgs e)
        {
            noPark.Location = new Point(Width/2 - noPark.Width/2, Height/2 - noPark.Height/2);
        }
    }
}
