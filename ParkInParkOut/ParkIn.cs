
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace ParkInParkOut
{
    public partial class ParkInDash : Form
    {
        public ParkInDash()
        {
            InitializeComponent();
            Button2();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Button2()
        {
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = SystemColors.WindowFrame;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = button2.BackColor;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.WindowFrame;
            button2.ForeColor = SystemColors.ButtonFace;

        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.FromArgb(150, 0, 0);
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            button2.ForeColor = Color.Red;
        }


        private void plateNum_Enter(object sender, EventArgs e)
        {
            if (plateNum.Text == "Plate Number")
            {
                plateNum.Text = "";

                plateNum.ForeColor = Color.Black;
            }
        }
        private void plateNum_Leave(object sender, EventArgs e)
        {
            if (plateNum.Text == "")
            {
                plateNum.Text = "Plate Number";

                plateNum.ForeColor = Color.DimGray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parkOutButton_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel6.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void parkInButton_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel5.Show();
        }
    }
}
