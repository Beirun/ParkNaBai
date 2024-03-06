namespace ParkInParkOut
{
    partial class parkOutPanel
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
            this.vehicleBrandLabel = new System.Windows.Forms.Label();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.parkInTimLabel = new System.Windows.Forms.Label();
            this.labelPlateNumberLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // vehicleBrandLabel
            // 
            this.vehicleBrandLabel.AutoSize = true;
            this.vehicleBrandLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.vehicleBrandLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.vehicleBrandLabel.Location = new System.Drawing.Point(625, 86);
            this.vehicleBrandLabel.Name = "vehicleBrandLabel";
            this.vehicleBrandLabel.Size = new System.Drawing.Size(172, 29);
            this.vehicleBrandLabel.TabIndex = 3;
            this.vehicleBrandLabel.Text = "Vehicle Brand";
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.AutoSize = true;
            this.vehicleTypeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.vehicleTypeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.vehicleTypeLabel.Location = new System.Drawing.Point(445, 86);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(157, 29);
            this.vehicleTypeLabel.TabIndex = 2;
            this.vehicleTypeLabel.Text = "Vehicle Type";
            // 
            // parkInTimLabel
            // 
            this.parkInTimLabel.AutoSize = true;
            this.parkInTimLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.parkInTimLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.parkInTimLabel.Location = new System.Drawing.Point(71, 86);
            this.parkInTimLabel.Name = "parkInTimLabel";
            this.parkInTimLabel.Size = new System.Drawing.Size(156, 29);
            this.parkInTimLabel.TabIndex = 1;
            this.parkInTimLabel.Text = "Park In Time";
            // 
            // labelPlateNumberLabel
            // 
            this.labelPlateNumberLabel.AutoSize = true;
            this.labelPlateNumberLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelPlateNumberLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPlateNumberLabel.Location = new System.Drawing.Point(252, 86);
            this.labelPlateNumberLabel.Name = "labelPlateNumberLabel";
            this.labelPlateNumberLabel.Size = new System.Drawing.Size(167, 29);
            this.labelPlateNumberLabel.TabIndex = 0;
            this.labelPlateNumberLabel.Text = "Plate Number";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(42, 147);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(922, 629);
            this.flowLayoutPanel.TabIndex = 16;
            // 
            // parkOutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.vehicleBrandLabel);
            this.Controls.Add(this.labelPlateNumberLabel);
            this.Controls.Add(this.parkInTimLabel);
            this.Controls.Add(this.vehicleTypeLabel);
            this.Name = "parkOutPanel";
            this.Size = new System.Drawing.Size(1032, 799);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label vehicleBrandLabel;
        private System.Windows.Forms.Label vehicleTypeLabel;
        private System.Windows.Forms.Label parkInTimLabel;
        private System.Windows.Forms.Label labelPlateNumberLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
