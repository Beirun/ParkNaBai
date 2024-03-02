using System.Drawing;
using System.Windows.Forms;

namespace ParkInParkOut
{
    partial class ParkInDash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDash = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.parkOutButton = new System.Windows.Forms.Button();
            this.parkInButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelPlateNumber = new System.Windows.Forms.Label();
            this.parkInTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboVehicleBrand = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plateNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDash.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDash
            // 
            this.panelDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelDash.Controls.Add(this.logoutButton);
            this.panelDash.Controls.Add(this.parkOutButton);
            this.panelDash.Controls.Add(this.parkInButton);
            this.panelDash.Controls.Add(this.panel1);
            this.panelDash.Location = new System.Drawing.Point(-3, 0);
            this.panelDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(296, 800);
            this.panelDash.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.logoutButton.Location = new System.Drawing.Point(61, 737);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(169, 29);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // parkOutButton
            // 
            this.parkOutButton.FlatAppearance.BorderSize = 0;
            this.parkOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkOutButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkOutButton.ForeColor = System.Drawing.Color.White;
            this.parkOutButton.Location = new System.Drawing.Point(2, 307);
            this.parkOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkOutButton.Name = "parkOutButton";
            this.parkOutButton.Size = new System.Drawing.Size(293, 45);
            this.parkOutButton.TabIndex = 4;
            this.parkOutButton.Text = "PARK OUT";
            this.parkOutButton.UseVisualStyleBackColor = true;
            this.parkOutButton.Click += new System.EventHandler(this.parkOutButton_Click);
            // 
            // parkInButton
            // 
            this.parkInButton.FlatAppearance.BorderSize = 0;
            this.parkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkInButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkInButton.ForeColor = System.Drawing.Color.White;
            this.parkInButton.Location = new System.Drawing.Point(2, 221);
            this.parkInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkInButton.Name = "parkInButton";
            this.parkInButton.Size = new System.Drawing.Size(293, 45);
            this.parkInButton.TabIndex = 3;
            this.parkInButton.Text = "PARK IN";
            this.parkInButton.UseVisualStyleBackColor = true;
            this.parkInButton.Click += new System.EventHandler(this.parkInButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.BackgroundImage = global::ParkInParkOut.Properties.Resources.PARK_NA_BAI;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(30, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 192);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(906, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "×";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.parkInTime);
            this.panel6.Controls.Add(this.labelPlateNumber);
            this.panel6.Location = new System.Drawing.Point(406, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 330);
            this.panel6.TabIndex = 15;
            // 
            // labelPlateNumber
            // 
            this.labelPlateNumber.AutoSize = true;
            this.labelPlateNumber.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelPlateNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPlateNumber.Location = new System.Drawing.Point(34, 100);
            this.labelPlateNumber.Name = "labelPlateNumber";
            this.labelPlateNumber.Size = new System.Drawing.Size(174, 29);
            this.labelPlateNumber.TabIndex = 0;
            this.labelPlateNumber.Text = "Plate Number:";
            // 
            // parkInTime
            // 
            this.parkInTime.AutoSize = true;
            this.parkInTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.parkInTime.ForeColor = System.Drawing.SystemColors.Window;
            this.parkInTime.Location = new System.Drawing.Point(45, 56);
            this.parkInTime.Name = "parkInTime";
            this.parkInTime.Size = new System.Drawing.Size(163, 29);
            this.parkInTime.TabIndex = 1;
            this.parkInTime.Text = "Park In Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(44, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehicle Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(29, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle Brand:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.submitButton);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(406, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 363);
            this.panel5.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.comboVehicleType);
            this.panel3.Location = new System.Drawing.Point(12, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 40);
            this.panel3.TabIndex = 12;
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicleType.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboVehicleType.ForeColor = System.Drawing.Color.DimGray;
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Items.AddRange(new object[] {
            "Motorcycle",
            "Sedan",
            "SUV",
            "Van"});
            this.comboVehicleType.Location = new System.Drawing.Point(3, 4);
            this.comboVehicleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(415, 35);
            this.comboVehicleType.TabIndex = 8;
            this.comboVehicleType.Text = "Vehicle Type";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Tahoma", 14.2F, System.Drawing.FontStyle.Bold);
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitButton.Location = new System.Drawing.Point(142, 267);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 34);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.comboVehicleBrand);
            this.panel4.Location = new System.Drawing.Point(12, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 40);
            this.panel4.TabIndex = 13;
            // 
            // comboVehicleBrand
            // 
            this.comboVehicleBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicleBrand.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboVehicleBrand.ForeColor = System.Drawing.Color.DimGray;
            this.comboVehicleBrand.FormattingEnabled = true;
            this.comboVehicleBrand.Items.AddRange(new object[] {
            "YAMAHA",
            "HONDA",
            "NMAX",
            "RUSI"});
            this.comboVehicleBrand.Location = new System.Drawing.Point(3, 4);
            this.comboVehicleBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVehicleBrand.Name = "comboVehicleBrand";
            this.comboVehicleBrand.Size = new System.Drawing.Size(415, 35);
            this.comboVehicleBrand.TabIndex = 9;
            this.comboVehicleBrand.Text = "Vehicle Brand";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.plateNum);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 40);
            this.panel2.TabIndex = 11;
            // 
            // plateNum
            // 
            this.plateNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateNum.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.plateNum.ForeColor = System.Drawing.Color.DimGray;
            this.plateNum.Location = new System.Drawing.Point(4, 7);
            this.plateNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plateNum.Multiline = true;
            this.plateNum.Name = "plateNum";
            this.plateNum.Size = new System.Drawing.Size(414, 33);
            this.plateNum.TabIndex = 7;
            this.plateNum.Text = "Plate Number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Location = new System.Drawing.Point(142, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ParkInDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(950, 800);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelDash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ParkInDash";
            this.Text = "Form1";
            this.panelDash.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelDash;
        private Button parkInButton;
        private Panel panel1;
        private Button parkOutButton;
        private Button logoutButton;
        private Button button2;
        private Panel panel6;
        private Label parkInTime;
        private Label labelPlateNumber;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Panel panel3;
        private ComboBox comboVehicleType;
        private Button submitButton;
        private Panel panel4;
        private ComboBox comboVehicleBrand;
        private Panel panel2;
        private TextBox plateNum;
        private Button button1;
    }
}
