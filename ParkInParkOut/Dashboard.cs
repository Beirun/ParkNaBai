
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ParkInParkOut
{
    public partial class ParkInDash : Form
    {
        DateTime parkIn;
        DateTime parkOut;
        String vehicleType;
        String vehicleBrand;
        String plateNumber;
        public ParkInDash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Button2();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Button2()
        {
            
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.BackColor = SystemColors.WindowFrame;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = exitButton.BackColor;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = SystemColors.WindowFrame;
            exitButton.ForeColor = SystemColors.ButtonFace;

        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            exitButton.ForeColor = Color.FromArgb(150, 0, 0);
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            exitButton.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            exitButton.ForeColor = Color.Red;
        }



        private void parkOutButton_Click(object sender, EventArgs e)
        {
            parkInPanel1.Hide();
            parkOutResult1.Hide();
            parkOutPanel1.Show();
            parkOutPanel1.Invalidate();
            this.Invalidate();
        }

        

        private void parkInButton_Click(object sender, EventArgs e)
        {

            parkInPanel1.Show();
            parkOutResult1.Hide();
            parkOutPanel1.Hide();
        }

       

        
    }
}
