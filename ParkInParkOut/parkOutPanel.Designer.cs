namespace ParkInParkOut
{
    partial class ParkOutPanel
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.parkInTimLabel = new System.Windows.Forms.Label();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.vehicleBrandLabel = new System.Windows.Forms.Label();
            this.labelPlateNumberLabel = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.Navy;
            this.gradientPanel1.Controls.Add(this.flowLayoutPanel);
            this.gradientPanel1.Controls.Add(this.parkInTimLabel);
            this.gradientPanel1.Controls.Add(this.vehicleTypeLabel);
            this.gradientPanel1.Controls.Add(this.vehicleBrandLabel);
            this.gradientPanel1.Controls.Add(this.labelPlateNumberLabel);
            this.gradientPanel1.Location = new System.Drawing.Point(0, -6);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1032, 820);
            this.gradientPanel1.TabIndex = 17;
            this.gradientPanel1.TopColor = System.Drawing.Color.Purple;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Location = new System.Drawing.Point(30, 111);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(925, 657);
            this.flowLayoutPanel.TabIndex = 16;
            // 
            // parkInTimLabel
            // 
            this.parkInTimLabel.AutoSize = true;
            this.parkInTimLabel.BackColor = System.Drawing.Color.Transparent;
            this.parkInTimLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.parkInTimLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.parkInTimLabel.Location = new System.Drawing.Point(56, 70);
            this.parkInTimLabel.Name = "parkInTimLabel";
            this.parkInTimLabel.Size = new System.Drawing.Size(156, 29);
            this.parkInTimLabel.TabIndex = 1;
            this.parkInTimLabel.Text = "Park In Time";
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.AutoSize = true;
            this.vehicleTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.vehicleTypeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.vehicleTypeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.vehicleTypeLabel.Location = new System.Drawing.Point(428, 70);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(157, 29);
            this.vehicleTypeLabel.TabIndex = 2;
            this.vehicleTypeLabel.Text = "Vehicle Type";
            // 
            // vehicleBrandLabel
            // 
            this.vehicleBrandLabel.AutoSize = true;
            this.vehicleBrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.vehicleBrandLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.vehicleBrandLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.vehicleBrandLabel.Location = new System.Drawing.Point(607, 70);
            this.vehicleBrandLabel.Name = "vehicleBrandLabel";
            this.vehicleBrandLabel.Size = new System.Drawing.Size(172, 29);
            this.vehicleBrandLabel.TabIndex = 3;
            this.vehicleBrandLabel.Text = "Vehicle Brand";
            // 
            // labelPlateNumberLabel
            // 
            this.labelPlateNumberLabel.AutoSize = true;
            this.labelPlateNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.labelPlateNumberLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelPlateNumberLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPlateNumberLabel.Location = new System.Drawing.Point(236, 70);
            this.labelPlateNumberLabel.Name = "labelPlateNumberLabel";
            this.labelPlateNumberLabel.Size = new System.Drawing.Size(167, 29);
            this.labelPlateNumberLabel.TabIndex = 0;
            this.labelPlateNumberLabel.Text = "Plate Number";
            // 
            // ParkOutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ParkOutPanel";
            this.Size = new System.Drawing.Size(1032, 799);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label vehicleBrandLabel;
        private System.Windows.Forms.Label vehicleTypeLabel;
        private System.Windows.Forms.Label parkInTimLabel;
        private System.Windows.Forms.Label labelPlateNumberLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private GradientPanel gradientPanel1;
    }
}
