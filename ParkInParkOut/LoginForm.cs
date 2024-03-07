using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace ParkInParkOut
{
    public partial class LoginForm : Form
    {
        ParkInDash d;
        ParkInPanel parkInPanel;
        ParkOutPanel parkOutPanel;
        ParkOutResult parkOutResult;
        NoParkedInMessage noParkedInMessage;
        Boolean isEntered = false;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Button1();
            textBoxes();
            Button2();
        }
        public LoginForm(ParkInDash d, ParkInPanel parkInPanel, ParkOutPanel parkOutPanel, ParkOutResult parkOutResult, NoParkedInMessage noParkedInMessage)
        {
            this.d = d;
            this.parkInPanel = parkInPanel;
            this.parkOutPanel = parkOutPanel;
            this.parkOutResult = parkOutResult;
            this.noParkedInMessage = noParkedInMessage;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Button1();
            textBoxes();
            Button2();
 
        }


        private void LoginForm_Load(object sender, EventArgs e) {
            label1.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;

            label2.Parent = gradientPanel1;
            label2.BackColor = Color.Transparent;

            checkBox1.Parent = gradientPanel1;
            checkBox1.BackColor = Color.Transparent;
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Navy;
            button1.ForeColor = Color.Red;
        }


        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Navy;
            button1.ForeColor = SystemColors.ButtonFace;

        }
        private void Button1()
        {
            checkBox1.TabStop = false;
            button2.TabStop = false;
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = button1.BackColor;
            incorrectUserOrPasswordMessage.Hide();
        }
        private void Button2() {
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.FromArgb(225, 225, 225);
            button2.BackColor = Color.Navy;
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
                textBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            }
            else
            {
                textBox3.PasswordChar = '*';
                textBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            }
        }

        private void textBoxes() {
            textBox2.BackColor = Color.FromArgb(255, 255, 255);
            textBox1.BackColor = Color.FromArgb(255, 255, 255);
            textBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Navy;
            button2.BackColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            button2.ForeColor = Color.FromArgb(225, 225, 225);
            button2.BackColor = Color.Navy;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.ToLower().Equals("admin") && textBox3.Text.ToLower().Equals("admin")) {
                if (d == null) d = new ParkInDash();
                else
                {
                    parkOutPanel.Hide();
                    parkOutResult.Hide();
                    noParkedInMessage.Hide();
                    parkInPanel.Show();
                }
                this.Visible = false;
                Thread.Sleep(250);
                d.Show();


            }
            else if(!isEntered)
            {
                incorrectUserOrPasswordMessage.Show();
            }
            else { incorrectUserOrPasswordMessage.Show(); }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                isEntered = true;
                button2_Click(sender, e);
            }
        }

        private void incorrectUserOrPasswordMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void showIncorrectMessage(object sender, EventArgs e) {
            incorrectUserOrPasswordMessage.Hide();
        }

    }
}
