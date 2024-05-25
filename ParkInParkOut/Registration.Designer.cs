namespace ParkInParkOut
{
    partial class Registration
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
            this.regFN = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.regPass = new System.Windows.Forms.TextBox();
            this.regLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regMI = new System.Windows.Forms.TextBox();
            this.regUN = new System.Windows.Forms.TextBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.logInLabel = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.exitButton.Location = new System.Drawing.Point(902, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "×";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // regFN
            // 
            this.regFN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regFN.Location = new System.Drawing.Point(637, 299);
            this.regFN.Name = "regFN";
            this.regFN.Size = new System.Drawing.Size(256, 21);
            this.regFN.TabIndex = 39;
            this.regFN.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.checkBox1.Location = new System.Drawing.Point(774, 604);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(607, 642);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(164, 40);
            this.registerButton.TabIndex = 42;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(499, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "First Name:";
            // 
            // regPass
            // 
            this.regPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPass.Location = new System.Drawing.Point(637, 563);
            this.regPass.Name = "regPass";
            this.regPass.PasswordChar = '*';
            this.regPass.Size = new System.Drawing.Size(256, 21);
            this.regPass.TabIndex = 36;
            this.regPass.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // regLN
            // 
            this.regLN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLN.Location = new System.Drawing.Point(5, 7);
            this.regLN.Name = "regLN";
            this.regLN.Size = new System.Drawing.Size(256, 21);
            this.regLN.TabIndex = 33;
            this.regLN.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(621, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Register Now";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(499, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(499, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Middle Initial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(499, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(499, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Password:";
            // 
            // regMI
            // 
            this.regMI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regMI.Location = new System.Drawing.Point(637, 435);
            this.regMI.Name = "regMI";
            this.regMI.Size = new System.Drawing.Size(256, 21);
            this.regMI.TabIndex = 48;
            this.regMI.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // regUN
            // 
            this.regUN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUN.Location = new System.Drawing.Point(637, 499);
            this.regUN.Name = "regUN";
            this.regUN.Size = new System.Drawing.Size(256, 21);
            this.regUN.TabIndex = 49;
            this.regUN.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(604, 241);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(192, 20);
            this.errorMessageLabel.TabIndex = 50;
            this.errorMessageLabel.Text = "Please fill in all fields";
            this.errorMessageLabel.Visible = false;
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.logInLabel.LinkColor = System.Drawing.Color.ForestGreen;
            this.logInLabel.Location = new System.Drawing.Point(635, 702);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(113, 25);
            this.logInLabel.TabIndex = 51;
            this.logInLabel.TabStop = true;
            this.logInLabel.Text = "Login Here!";
            this.logInLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLabel_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(632, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 36);
            this.panel2.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.regLN);
            this.panel3.Location = new System.Drawing.Point(632, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 36);
            this.panel3.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(632, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 36);
            this.panel4.TabIndex = 53;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(632, 491);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 36);
            this.panel5.TabIndex = 53;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(632, 556);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 36);
            this.panel6.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ParkInParkOut.Properties.Resources.parknabaireceipt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(513, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ParkInParkOut.Properties.Resources.sh;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 813);
            this.panel1.TabIndex = 31;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.logInLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.regUN);
            this.Controls.Add(this.regMI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regFN);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox regFN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regPass;
        private System.Windows.Forms.TextBox regLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regMI;
        private System.Windows.Forms.TextBox regUN;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.LinkLabel logInLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}