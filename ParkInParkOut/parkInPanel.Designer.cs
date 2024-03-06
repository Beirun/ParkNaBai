namespace ParkInParkOut
{
    partial class parkInPanel
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboVehicleBrand = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.comboVehicleBrand);
            this.panel4.Location = new System.Drawing.Point(294, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 40);
            this.panel4.TabIndex = 13;
            // 
            // comboVehicleBrand
            // 
            this.comboVehicleBrand.Enabled = false;
            this.comboVehicleBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicleBrand.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboVehicleBrand.ForeColor = System.Drawing.Color.DimGray;
            this.comboVehicleBrand.FormattingEnabled = true;
            this.comboVehicleBrand.ItemHeight = 27;
            this.comboVehicleBrand.Items.AddRange(new object[] {
            "YAMAHA",
            "HONDA",
            "NMAX",
            "RUSI"});
            this.comboVehicleBrand.Location = new System.Drawing.Point(0, 1);
            this.comboVehicleBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVehicleBrand.Name = "comboVehicleBrand";
            this.comboVehicleBrand.Size = new System.Drawing.Size(418, 35);
            this.comboVehicleBrand.TabIndex = 9;
            this.comboVehicleBrand.Text = "Vehicle Brand";
            this.comboVehicleBrand.SelectedIndexChanged += new System.EventHandler(this.comboVehicleBrand_SelectedIndexChanged);
            this.comboVehicleBrand.EnabledChanged += new System.EventHandler(this.comboVehicleBrand_EnabledChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.plateNumberTextBox);
            this.panel2.Location = new System.Drawing.Point(294, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 40);
            this.panel2.TabIndex = 11;
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateNumberTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.plateNumberTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.plateNumberTextBox.Location = new System.Drawing.Point(4, 7);
            this.plateNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plateNumberTextBox.Multiline = true;
            this.plateNumberTextBox.Name = "plateNumberTextBox";
            this.plateNumberTextBox.Size = new System.Drawing.Size(414, 33);
            this.plateNumberTextBox.TabIndex = 7;
            this.plateNumberTextBox.Text = "Plate Number";
            this.plateNumberTextBox.TextChanged += new System.EventHandler(this.plateNumberTextBox_TextChanged);
            this.plateNumberTextBox.Enter += new System.EventHandler(this.plateNum_Enter);
            this.plateNumberTextBox.Leave += new System.EventHandler(this.plateNum_Leave);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Tahoma", 14.2F, System.Drawing.FontStyle.Bold);
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitButton.Location = new System.Drawing.Point(424, 468);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 34);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.comboVehicleType);
            this.panel3.Location = new System.Drawing.Point(294, 330);
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
            "MotorBike",
            "Sedan",
            "SUV",
            "Van"});
            this.comboVehicleType.Location = new System.Drawing.Point(3, 4);
            this.comboVehicleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(415, 35);
            this.comboVehicleType.TabIndex = 8;
            this.comboVehicleType.Text = "Vehicle Type";
            this.comboVehicleType.SelectedIndexChanged += new System.EventHandler(this.comboVehicleType_SelectedIndexChanged);
            // 
            // parkInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "parkInPanel";
            this.Size = new System.Drawing.Size(1032, 799);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboVehicleBrand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox plateNumberTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboVehicleType;
    }
}
