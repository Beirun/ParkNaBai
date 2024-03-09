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
            Button1();
        }
        private void Button1()
        {
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.Blue;
            button1.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dash.parkOutButton_Click(sender, e);
        }
        public void setDash(ParkInDash dash)
        {
            this.dash = dash;
        }
        private void ErrorDateTime_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Blue;
        }
        private void ErrorDateTime_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseOverBackColor = Color.Blue;
            button1.ForeColor = Color.White;
        }
        private void ErrorDateTime_Load(object sender, EventArgs e)
        {
            label1.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Red;

            label2.Parent = gradientPanel1;
            label2.BackColor = Color.Transparent;
            label2 .ForeColor = Color.Red;
        }
    }
}
