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
            this.gradientPanel1 = new ParkInParkOut.GradientPanel();
            this.comboVehicleType = new ParkInParkOut.comBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorFillMessage = new System.Windows.Forms.Label();
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.comboVehicleBrand = new System.Windows.Forms.ComboBox();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.Navy;
            this.gradientPanel1.Controls.Add(this.comboVehicleType);
            this.gradientPanel1.Controls.Add(this.submitButton);
            this.gradientPanel1.Controls.Add(this.errorFillMessage);
            this.gradientPanel1.Controls.Add(this.plateNumberTextBox);
            this.gradientPanel1.Controls.Add(this.comboVehicleBrand);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1032, 800);
            this.gradientPanel1.TabIndex = 16;
            this.gradientPanel1.TopColor = System.Drawing.Color.Purple;
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.BackColor = System.Drawing.Color.Navy;
            this.comboVehicleType.BorderColor = System.Drawing.Color.Cyan;
            this.comboVehicleType.BorderSize = 1;
            this.comboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboVehicleType.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.6F);
            this.comboVehicleType.ForeColor = System.Drawing.Color.White;
            this.comboVehicleType.IconColor = System.Drawing.Color.Fuchsia;
            this.comboVehicleType.Items.AddRange(new object[] {
            "MotorBike",
            "Sedan",
            "SUV",
            "Van"});
            this.comboVehicleType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.comboVehicleType.ListForeColor = System.Drawing.Color.Navy;
            this.comboVehicleType.Location = new System.Drawing.Point(297, 345);
            this.comboVehicleType.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Padding = new System.Windows.Forms.Padding(1);
            this.comboVehicleType.Size = new System.Drawing.Size(414, 37);
            this.comboVehicleType.TabIndex = 16;
            this.comboVehicleType.Text = "Vehicle Type";
            this.comboVehicleType.SelectedIndexChanged += new System.EventHandler(this.comboVehicleType_OnSelectedIndexChanged);
            this.comboVehicleType.Enter += new System.EventHandler(this.showIncorrectMessage);
            this.comboVehicleType.Leave += new System.EventHandler(this.comboVehicleType_Leave);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitButton.Location = new System.Drawing.Point(426, 490);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 34);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorFillMessage
            // 
            this.errorFillMessage.AutoSize = true;
            this.errorFillMessage.BackColor = System.Drawing.Color.Transparent;
            this.errorFillMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorFillMessage.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.errorFillMessage.ForeColor = System.Drawing.Color.Red;
            this.errorFillMessage.Location = new System.Drawing.Point(358, 219);
            this.errorFillMessage.Name = "errorFillMessage";
            this.errorFillMessage.Size = new System.Drawing.Size(303, 20);
            this.errorFillMessage.TabIndex = 15;
            this.errorFillMessage.Text = "Please fill in all the necessary fields.";
            this.errorFillMessage.Visible = false;
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateNumberTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.plateNumberTextBox.Location = new System.Drawing.Point(297, 290);
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
            this.comboVehicleBrand.Location = new System.Drawing.Point(297, 406);
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
            // ParkInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ParkInPanel";
            this.Size = new System.Drawing.Size(1032, 799);
            this.Load += new System.EventHandler(this.ParkInPanel_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboVehicleBrand;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox plateNumberTextBox;
        private System.Windows.Forms.Label errorFillMessage;
        private GradientPanel gradientPanel1;
        private comBox comboVehicleType;
    }
}
