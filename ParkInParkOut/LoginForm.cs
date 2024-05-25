using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using ParkInParkOut.Properties;



namespace ParkInParkOut
{
    public partial class LoginForm : Form
    {
        ParkInDash d;
        int count = 0;
        bool isMouseOver = true;
        bool isBackColorChanged = false;
        int rValue = Color.ForestGreen.R;
        int gValue = Color.ForestGreen.G;
        int bValue = Color.ForestGreen.B;
        
        Boolean isEntered = false;
        public LoginForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            Button1();
            textBoxes();
            Button2();
            this.ActiveControl = userNameTextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = this.BackColor;
            exitButton.ForeColor = Color.ForestGreen;
        }
        private void Button1()
        {
            checkBox1.TabStop = false;
            loginButton.TabStop = false;
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.ForestGreen;
            exitButton.BackColor = this.BackColor;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = exitButton.BackColor;
            incorrectUserOrPasswordMessage.Hide();
        }
        private void Button2() {
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.ForeColor = Color.FromArgb(225, 225, 225);
            loginButton.BackColor = Color.ForestGreen;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            exitButton.ForeColor = Color.FromArgb(150, 0, 0);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar != userNameTextBox.PasswordChar)
            {
                passwordTextBox.PasswordChar = userNameTextBox.PasswordChar;
                passwordTextBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                passwordTextBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }
        }

        private void textBoxes() {
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (!isBackColorChanged)
            {
                loginButton.FlatAppearance.MouseOverBackColor = loginButton.BackColor;
                isBackColorChanged = true;
            }
            isMouseOver = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (isBackColorChanged)
            {
                loginButton.BackColor = loginButton.FlatAppearance.MouseOverBackColor;
                isBackColorChanged = false;
            }
            isMouseOver = false;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnectionClass sqlConnectionClass = new SqlConnectionClass();

            if (sqlConnectionClass.isPasswordCorrect(userNameTextBox.Text,passwordTextBox.Text)) {
                sqlConnectionClass.addUserLog(userNameTextBox.Text);
                d = new ParkInDash(userNameTextBox.Text);
                this.Visible = false;
                System.Threading.Thread.Sleep(250);
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

        private void showIncorrectMessage(object sender, EventArgs e) {
            incorrectUserOrPasswordMessage.Hide();
        }

        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void loginButton_MouseHover(object sender, EventArgs e)
        {
            loginButton.Cursor = Cursors.Hand;
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            checkBox1.Cursor = Cursors.Hand;
        }
    }
}
