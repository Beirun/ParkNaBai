using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    public partial class Registration : Form
    {
        public Registration()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnectionClass conn = new SqlConnectionClass();

            if (string.IsNullOrEmpty(regFN.Text) || string.IsNullOrEmpty(regLN.Text) || string.IsNullOrEmpty(regMI.Text) || string.IsNullOrEmpty(regUN.Text) || string.IsNullOrEmpty(regPass.Text))
            {
                errorMessageLabel.Text = "Please Fill In All The Fields!";
                errorMessageLabel.Visible = true;
            }
            else if (conn.isUserNameTaken(regUN.Text))
            {
                errorMessageLabel.Text = "UserName is Already Taken!";
                errorMessageLabel.Visible = true;
            }
            else if (regFN.Text.Length > 50 || regLN.Text.Length > 50 || regMI.Text.Length > 2 || regUN.Text.Length > 100 || regPass.Text.Length > 100)
            {
                errorMessageLabel.Text = "Input Exceeds the Required Character Limit!";
                errorMessageLabel.Visible = true;
            }
            else
            {
                conn.addUser(regFN.Text, regLN.Text, regMI.Text, regUN.Text, regPass.Text);

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }

            errorMessageLabel.Location = new Point(panel1.Width+((ClientSize.Width - panel1.Width)/2 - errorMessageLabel.Width/2), errorMessageLabel.Location.Y);
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (regPass.PasswordChar != regUN.PasswordChar)
            {
                regPass.PasswordChar = regUN.PasswordChar;
                regPass.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            }
            else
            {
                regPass.PasswordChar = '*';
                regPass.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }
        }
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Red;
        }


        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = this.BackColor;
            exitButton.ForeColor = Color.ForestGreen;

        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;
        }

        private void logInLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm logForm = new LoginForm();
            logForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
