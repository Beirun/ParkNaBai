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
            this.comboVehicleBrand = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.errorFillMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboVehicleBrand
            // 
            this.comboVehicleBrand.Enabled = false;
            this.comboVehicleBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicleBrand.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
            this.comboVehicleBrand.ForeColor = System.Drawing.Color.DimGray;
            this.comboVehicleBrand.FormattingEnabled = true;
            this.comboVehicleBrand.ItemHeight = 29;
            this.comboVehicleBrand.Items.AddRange(new object[] {
            "YAMAHA",
            "HONDA",
            "NMAX",
            "RUSI"});
            this.comboVehicleBrand.Location = new System.Drawing.Point(297, 390);
            this.comboVehicleBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVehicleBrand.Name = "comboVehicleBrand";
            this.comboVehicleBrand.Size = new System.Drawing.Size(415, 37);
            this.comboVehicleBrand.TabIndex = 9;
            this.comboVehicleBrand.Text = "Vehicle Brand";
            this.comboVehicleBrand.SelectedIndexChanged += new System.EventHandler(this.comboVehicleBrand_SelectedIndexChanged);
            this.comboVehicleBrand.EnabledChanged += new System.EventHandler(this.comboVehicleBrand_EnabledChanged);
            this.comboVehicleBrand.Enter += new System.EventHandler(this.showIncorrectMessage);
            this.comboVehicleBrand.Leave += new System.EventHandler(this.comboVehicleBrand_Leave);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitButton.Location = new System.Drawing.Point(403, 468);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 34);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicleType.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
            this.comboVehicleType.ForeColor = System.Drawing.Color.DimGray;
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Items.AddRange(new object[] {
            "MotorBike",
            "Sedan",
            "SUV",
            "Van"});
            this.comboVehicleType.Location = new System.Drawing.Point(297, 332);
            this.comboVehicleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(415, 37);
            this.comboVehicleType.TabIndex = 8;
            this.comboVehicleType.Text = "Vehicle Type";
            this.comboVehicleType.SelectedIndexChanged += new System.EventHandler(this.comboVehicleType_SelectedIndexChanged);
            this.comboVehicleType.Enter += new System.EventHandler(this.showIncorrectMessage);
            this.comboVehicleType.Leave += new System.EventHandler(this.comboVehicleType_Leave);
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateNumberTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.plateNumberTextBox.Location = new System.Drawing.Point(297, 274);
            this.plateNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plateNumberTextBox.Multiline = true;
            this.plateNumberTextBox.Name = "plateNumberTextBox";
            this.plateNumberTextBox.Size = new System.Drawing.Size(414, 33);
            this.plateNumberTextBox.TabIndex = 7;
            this.plateNumberTextBox.Text = "Plate Number";
            this.plateNumberTextBox.TextChanged += new System.EventHandler(this.showIncorrectMessage);
            this.plateNumberTextBox.Enter += new System.EventHandler(this.plateNum_Enter);
            this.plateNumberTextBox.Leave += new System.EventHandler(this.plateNum_Leave);
            // 
            // errorFillMessage
            // 
            this.errorFillMessage.AutoSize = true;
            this.errorFillMessage.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.errorFillMessage.ForeColor = System.Drawing.Color.Red;
            this.errorFillMessage.Location = new System.Drawing.Point(350, 200);
            this.errorFillMessage.Name = "errorFillMessage";
            this.errorFillMessage.Size = new System.Drawing.Size(303, 20);
            this.errorFillMessage.TabIndex = 15;
            this.errorFillMessage.Text = "Please fill in all the necessary fields.";
            this.errorFillMessage.Visible = false;
            // 
            // ParkInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.errorFillMessage);
            this.Controls.Add(this.comboVehicleBrand);
            this.Controls.Add(this.comboVehicleType);
            this.Controls.Add(this.plateNumberTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "ParkInPanel";
            this.Size = new System.Drawing.Size(1032, 799);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboVehicleBrand;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox comboVehicleType;
        private System.Windows.Forms.TextBox plateNumberTextBox;
        private System.Windows.Forms.Label errorFillMessage;
    }
}
