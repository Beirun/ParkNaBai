using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace ParkInParkOut
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Button1();
            textBoxes();
            Button2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(42,42,42);
            button1.ForeColor = Color.Red;
        }


        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(50, 50, 50);
            button1.ForeColor = SystemColors.ButtonFace;

        }
        private void Button1()
        {
            checkBox1.TabStop = false;
            button2.TabStop = false;
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.FromArgb(50, 50, 50);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = button1.BackColor;
        }
        private void Button2() {
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.FromArgb(225, 225, 225);
            button2.BackColor = Color.FromArgb(75, 75, 75);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.FromArgb(150, 0, 0);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar != textBox1.PasswordChar)
            {
                textBox3.PasswordChar = textBox1.PasswordChar;
                textBox3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);

            }
            else
            {
                textBox3.PasswordChar = '*';
                textBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            }
        }

        private void textBoxes() {
            //textBox1.TextAlign = VerticalAlignment.Center;
            //textBox2.TextAlign = VerticalAlignment.Cen;
            textBox2.BackColor = Color.FromArgb(255, 255, 255);
            textBox1.BackColor = Color.FromArgb(255, 255, 255);
            textBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(255,255,255);
            button2.BackColor = Color.FromArgb(100,100,100);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            button2.ForeColor = Color.FromArgb(225, 225, 225);
            button2.BackColor = Color.FromArgb(75, 75, 75);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.ToLower().Equals("admin") && textBox3.Text.ToLower().Equals("admin")) {
                ParkInDash d = new ParkInDash();
                this.Visible = false;
                Thread.Sleep(500);
                d.Show();
                
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) button2_Click(sender, e);
        }
    }
}
