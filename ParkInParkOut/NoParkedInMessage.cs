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
            noPark.Parent = gradientPanel1;
            noPark.BackColor = Color.Transparent;
        }
    }
}
