namespace ParkInParkOut
{
    partial class ParkInPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.errorFillMessage = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.parkInLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboVehicleType = new ParkInParkOut.comBox();
            this.comboVehicleBrand = new ParkInParkOut.comBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.BackColor = System.Drawing.Color.White;
            this.plateNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateNumberTextBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberTextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.plateNumberTextBox.Location = new System.Drawing.Point(9, 9);
            this.plateNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plateNumberTextBox.MaxLength = 7;
            this.plateNumberTextBox.Multiline = true;
            this.plateNumberTextBox.Name = "plateNumberTextBox";
            this.plateNumberTextBox.Size = new System.Drawing.Size(525, 30);
            this.plateNumberTextBox.TabIndex = 1;
            this.plateNumberTextBox.Text = "Plate Number";
            this.plateNumberTextBox.TextChanged += new System.EventHandler(this.showIncorrectMessage);
            this.plateNumberTextBox.Enter += new System.EventHandler(this.plateNum_Enter);
            this.plateNumberTextBox.Leave += new System.EventHandler(this.plateNum_Leave);
            // 
            // errorFillMessage
            // 
            this.errorFillMessage.AutoSize = true;
            this.errorFillMessage.BackColor = System.Drawing.Color.Transparent;
            this.errorFillMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorFillMessage.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.errorFillMessage.ForeColor = System.Drawing.Color.Red;
            this.errorFillMessage.Location = new System.Drawing.Point(364, 176);
            this.errorFillMessage.Name = "errorFillMessage";
            this.errorFillMessage.Size = new System.Drawing.Size(303, 20);
            this.errorFillMessage.TabIndex = 15;
            this.errorFillMessage.Text = "Please fill in all the necessary fields.";
            this.errorFillMessage.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitButton.Location = new System.Drawing.Point(391, 550);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(250, 50);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            this.submitButton.MouseEnter += new System.EventHandler(this.submitButton_MouseEnter);
            this.submitButton.MouseLeave += new System.EventHandler(this.submitButton_MouseLeave);
            // 
            // parkInLabel
            // 
            this.parkInLabel.AutoSize = true;
            this.parkInLabel.BackColor = System.Drawing.Color.Transparent;
            this.parkInLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkInLabel.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.parkInLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.parkInLabel.Location = new System.Drawing.Point(303, 69);
            this.parkInLabel.Name = "parkInLabel";
            this.parkInLabel.Size = new System.Drawing.Size(427, 60);
            this.parkInLabel.TabIndex = 20;
            this.parkInLabel.Text = "ENTER DETAILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(241, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 50);
            this.panel1.TabIndex = 21;
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.BackColor = System.Drawing.Color.White;
            this.comboVehicleType.BorderColor = System.Drawing.Color.ForestGreen;
            this.comboVehicleType.BorderSize = 2;
            this.comboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboVehicleType.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.comboVehicleType.ForeColor = System.Drawing.Color.ForestGreen;
            this.comboVehicleType.IconColor = System.Drawing.Color.ForestGreen;
            this.comboVehicleType.Items.AddRange(new object[] {
            "MotorBike",
            "Sedan",
            "SUV",
            "Van"});
            this.comboVehicleType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.comboVehicleType.ListForeColor = System.Drawing.Color.White;
            this.comboVehicleType.Location = new System.Drawing.Point(241, 335);
            this.comboVehicleType.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Padding = new System.Windows.Forms.Padding(2);
            this.comboVehicleType.Size = new System.Drawing.Size(550, 50);
            this.comboVehicleType.TabIndex = 2;
            this.comboVehicleType.SelectedIndexChanged += new System.EventHandler(this.comboVehicleType_OnSelectedIndexChanged);
            this.comboVehicleType.Enter += new System.EventHandler(this.showIncorrectMessage);
            this.comboVehicleType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboVehicleType_KeyDown);
            this.comboVehicleType.Leave += new System.EventHandler(this.comboVehicleType_Leave);
            // 
            // comboVehicleBrand
            // 
            this.comboVehicleBrand.BackColor = System.Drawing.Color.White;
            this.comboVehicleBrand.BorderColor = System.Drawing.Color.ForestGreen;
            this.comboVehicleBrand.BorderSize = 2;
            this.comboVehicleBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboVehicleBrand.Enabled = false;
            this.comboVehicleBrand.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.comboVehicleBrand.ForeColor = System.Drawing.Color.ForestGreen;
            this.comboVehicleBrand.IconColor = System.Drawing.Color.ForestGreen;
            this.comboVehicleBrand.Items.AddRange(new object[] {
            "MotorBike",
            "Sedan",
            "SUV",
            "Van"});
            this.comboVehicleBrand.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.comboVehicleBrand.ListForeColor = System.Drawing.Color.White;
            this.comboVehicleBrand.Location = new System.Drawing.Point(241, 420);
            this.comboVehicleBrand.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboVehicleBrand.Name = "comboVehicleBrand";
            this.comboVehicleBrand.Padding = new System.Windows.Forms.Padding(2);
            this.comboVehicleBrand.Size = new System.Drawing.Size(550, 50);
            this.comboVehicleBrand.TabIndex = 3;
            this.comboVehicleBrand.SelectedIndexChanged += new System.EventHandler(this.comboVehicleBrand_SelectedIndexChanged);
            this.comboVehicleBrand.EnabledChanged += new System.EventHandler(this.comboVehicleBrand_EnabledChanged);
            this.comboVehicleBrand.Enter += new System.EventHandler(this.showIncorrectMessage);
            this.comboVehicleBrand.Leave += new System.EventHandler(this.comboVehicleBrand_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.plateNumberTextBox);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 46);
            this.panel2.TabIndex = 22;
            // 
            // ParkInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorFillMessage);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.comboVehicleType);
            this.Controls.Add(this.comboVehicleBrand);
            this.Controls.Add(this.parkInLabel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "ParkInPanel";
            this.Size = new System.Drawing.Size(1032, 800);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox plateNumberTextBox;
        private System.Windows.Forms.Label errorFillMessage;
        private System.Windows.Forms.Button submitButton;
        private comBox comboVehicleType;
        private comBox comboVehicleBrand;
        private System.Windows.Forms.Label parkInLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
