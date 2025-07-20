namespace ParkInParkOut
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.incorrectUserOrPasswordMessage = new System.Windows.Forms.Label();
            this.signUpLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backTextBoxPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBox2 = new ParkInParkOut.comBox();
            this.comBox1 = new ParkInParkOut.comBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.backTextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(918, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "×";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.exitButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.checkBox1.Location = new System.Drawing.Point(701, 541);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.ForestGreen;
            this.loginButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(526, 534);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(117, 40);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button2_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.loginButton.MouseHover += new System.EventHandler(this.loginButton_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(559, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordTextBox.Location = new System.Drawing.Point(535, 476);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(327, 19);
            this.passwordTextBox.TabIndex = 14;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.showIncorrectMessage);
            this.passwordTextBox.Enter += new System.EventHandler(this.showIncorrectMessage);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(9, 7);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(327, 21);
            this.userNameTextBox.TabIndex = 13;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.showIncorrectMessage);
            this.userNameTextBox.Enter += new System.EventHandler(this.showIncorrectMessage);
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(559, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username:";
            // 
            // incorrectUserOrPasswordMessage
            // 
            this.incorrectUserOrPasswordMessage.AutoSize = true;
            this.incorrectUserOrPasswordMessage.BackColor = System.Drawing.Color.Transparent;
            this.incorrectUserOrPasswordMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incorrectUserOrPasswordMessage.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectUserOrPasswordMessage.ForeColor = System.Drawing.Color.Red;
            this.incorrectUserOrPasswordMessage.Location = new System.Drawing.Point(559, 273);
            this.incorrectUserOrPasswordMessage.Name = "incorrectUserOrPasswordMessage";
            this.incorrectUserOrPasswordMessage.Size = new System.Drawing.Size(277, 20);
            this.incorrectUserOrPasswordMessage.TabIndex = 0;
            this.incorrectUserOrPasswordMessage.Text = "Incorrect Username or Password";
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.LinkColor = System.Drawing.Color.ForestGreen;
            this.signUpLabel.Location = new System.Drawing.Point(615, 648);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(148, 25);
            this.signUpLabel.TabIndex = 31;
            this.signUpLabel.TabStop = true;
            this.signUpLabel.Text = "Sign Up Here!";
            this.signUpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLabel_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.BackgroundImage = global::ParkInParkOut.Properties.Resources.sh;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(451, 813);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ParkInParkOut.Properties.Resources.parknabaireceipt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(519, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ParkInParkOut.Properties.Resources.passwordIcon;
            this.pictureBox2.Location = new System.Drawing.Point(522, 425);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ParkInParkOut.Properties.Resources.usernameicon;
            this.pictureBox3.Location = new System.Drawing.Point(526, 324);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // backTextBoxPanel
            // 
            this.backTextBoxPanel.BackColor = System.Drawing.Color.White;
            this.backTextBoxPanel.Controls.Add(this.userNameTextBox);
            this.backTextBoxPanel.Location = new System.Drawing.Point(526, 365);
            this.backTextBoxPanel.Name = "backTextBoxPanel";
            this.backTextBoxPanel.Size = new System.Drawing.Size(339, 38);
            this.backTextBoxPanel.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(526, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 38);
            this.panel1.TabIndex = 34;
            // 
            // comBox2
            // 
            this.comBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comBox2.BorderSize = 1;
            this.comBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comBox2.ForeColor = System.Drawing.Color.Navy;
            this.comBox2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comBox2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comBox2.ListForeColor = System.Drawing.Color.DimGray;
            this.comBox2.Location = new System.Drawing.Point(-19, -19);
            this.comBox2.MinimumSize = new System.Drawing.Size(200, 30);
            this.comBox2.Name = "comBox2";
            this.comBox2.Padding = new System.Windows.Forms.Padding(1);
            this.comBox2.Size = new System.Drawing.Size(200, 30);
            this.comBox2.TabIndex = 13;
            // 
            // comBox1
            // 
            this.comBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comBox1.BorderSize = 1;
            this.comBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comBox1.ForeColor = System.Drawing.Color.Navy;
            this.comBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comBox1.ListForeColor = System.Drawing.Color.DimGray;
            this.comBox1.Location = new System.Drawing.Point(-19, -19);
            this.comBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comBox1.Name = "comBox1";
            this.comBox1.Padding = new System.Windows.Forms.Padding(1);
            this.comBox1.Size = new System.Drawing.Size(200, 30);
            this.comBox1.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(950, 800);
            this.Controls.Add(this.backTextBoxPanel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.incorrectUserOrPasswordMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.backTextBoxPanel.ResumeLayout(false);
            this.backTextBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label incorrectUserOrPasswordMessage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private comBox comBox1;
        private comBox comBox2;
        private System.Windows.Forms.LinkLabel signUpLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel backTextBoxPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

