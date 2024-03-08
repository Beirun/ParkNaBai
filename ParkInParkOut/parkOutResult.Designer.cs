namespace ParkInParkOut
{
    partial class ParkOutResult
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
            this.parkOutTimeResult = new System.Windows.Forms.Label();
            this.parkingTimeResult = new System.Windows.Forms.Label();
            this.parkingFeeResult = new System.Windows.Forms.Label();
            this.vehicleBrandResult = new System.Windows.Forms.Label();
            this.vehicleTypeResult = new System.Windows.Forms.Label();
            this.parkInTimeResult = new System.Windows.Forms.Label();
            this.labelPlateNumberResult = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ParkInParkOut.GradientPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkOutTimeResult
            // 
            this.parkOutTimeResult.AutoSize = true;
            this.parkOutTimeResult.BackColor = System.Drawing.Color.Transparent;
            this.parkOutTimeResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.parkOutTimeResult.ForeColor = System.Drawing.SystemColors.Window;
            this.parkOutTimeResult.Location = new System.Drawing.Point(292, 276);
            this.parkOutTimeResult.Name = "parkOutTimeResult";
            this.parkOutTimeResult.Size = new System.Drawing.Size(182, 29);
            this.parkOutTimeResult.TabIndex = 17;
            this.parkOutTimeResult.Text = "Park Out Time:";
            // 
            // parkingTimeResult
            // 
            this.parkingTimeResult.AutoSize = true;
            this.parkingTimeResult.BackColor = System.Drawing.Color.Transparent;
            this.parkingTimeResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.parkingTimeResult.ForeColor = System.Drawing.SystemColors.Window;
            this.parkingTimeResult.Location = new System.Drawing.Point(303, 451);
            this.parkingTimeResult.Name = "parkingTimeResult";
            this.parkingTimeResult.Size = new System.Drawing.Size(171, 29);
            this.parkingTimeResult.TabIndex = 16;
            this.parkingTimeResult.Text = "Parking Time:";
            // 
            // parkingFeeResult
            // 
            this.parkingFeeResult.AutoSize = true;
            this.parkingFeeResult.BackColor = System.Drawing.Color.Transparent;
            this.parkingFeeResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.parkingFeeResult.ForeColor = System.Drawing.SystemColors.Window;
            this.parkingFeeResult.Location = new System.Drawing.Point(318, 494);
            this.parkingFeeResult.Name = "parkingFeeResult";
            this.parkingFeeResult.Size = new System.Drawing.Size(156, 29);
            this.parkingFeeResult.TabIndex = 15;
            this.parkingFeeResult.Text = "Parking Fee:";
            // 
            // vehicleBrandResult
            // 
            this.vehicleBrandResult.AutoSize = true;
            this.vehicleBrandResult.BackColor = System.Drawing.Color.Transparent;
            this.vehicleBrandResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.vehicleBrandResult.ForeColor = System.Drawing.SystemColors.Window;
            this.vehicleBrandResult.Location = new System.Drawing.Point(295, 406);
            this.vehicleBrandResult.Name = "vehicleBrandResult";
            this.vehicleBrandResult.Size = new System.Drawing.Size(179, 29);
            this.vehicleBrandResult.TabIndex = 3;
            this.vehicleBrandResult.Text = "Vehicle Brand:";
            // 
            // vehicleTypeResult
            // 
            this.vehicleTypeResult.AutoSize = true;
            this.vehicleTypeResult.BackColor = System.Drawing.Color.Transparent;
            this.vehicleTypeResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.vehicleTypeResult.ForeColor = System.Drawing.SystemColors.Window;
            this.vehicleTypeResult.Location = new System.Drawing.Point(310, 363);
            this.vehicleTypeResult.Name = "vehicleTypeResult";
            this.vehicleTypeResult.Size = new System.Drawing.Size(164, 29);
            this.vehicleTypeResult.TabIndex = 2;
            this.vehicleTypeResult.Text = "Vehicle Type:";
            // 
            // parkInTimeResult
            // 
            this.parkInTimeResult.AutoSize = true;
            this.parkInTimeResult.BackColor = System.Drawing.Color.Transparent;
            this.parkInTimeResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.parkInTimeResult.ForeColor = System.Drawing.SystemColors.Window;
            this.parkInTimeResult.Location = new System.Drawing.Point(311, 232);
            this.parkInTimeResult.Name = "parkInTimeResult";
            this.parkInTimeResult.Size = new System.Drawing.Size(163, 29);
            this.parkInTimeResult.TabIndex = 1;
            this.parkInTimeResult.Text = "Park In Time:";
            // 
            // labelPlateNumberResult
            // 
            this.labelPlateNumberResult.AutoSize = true;
            this.labelPlateNumberResult.BackColor = System.Drawing.Color.Transparent;
            this.labelPlateNumberResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelPlateNumberResult.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPlateNumberResult.Location = new System.Drawing.Point(300, 319);
            this.labelPlateNumberResult.Name = "labelPlateNumberResult";
            this.labelPlateNumberResult.Size = new System.Drawing.Size(174, 29);
            this.labelPlateNumberResult.TabIndex = 0;
            this.labelPlateNumberResult.Text = "Plate Number:";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.Navy;
            this.gradientPanel1.Controls.Add(this.backButton);
            this.gradientPanel1.Controls.Add(this.parkInTimeResult);
            this.gradientPanel1.Controls.Add(this.parkOutTimeResult);
            this.gradientPanel1.Controls.Add(this.vehicleTypeResult);
            this.gradientPanel1.Controls.Add(this.parkingTimeResult);
            this.gradientPanel1.Controls.Add(this.vehicleBrandResult);
            this.gradientPanel1.Controls.Add(this.labelPlateNumberResult);
            this.gradientPanel1.Controls.Add(this.parkingFeeResult);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1032, 799);
            this.gradientPanel1.TabIndex = 18;
            this.gradientPanel1.TopColor = System.Drawing.Color.Purple;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(428, 619);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ParkOutResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ParkOutResult";
            this.Size = new System.Drawing.Size(1032, 799);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label parkOutTimeResult;
        private System.Windows.Forms.Label parkingTimeResult;
        private System.Windows.Forms.Label parkingFeeResult;
        private System.Windows.Forms.Label vehicleBrandResult;
        private System.Windows.Forms.Label vehicleTypeResult;
        private System.Windows.Forms.Label parkInTimeResult;
        private System.Windows.Forms.Label labelPlateNumberResult;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button backButton;
    }
}
