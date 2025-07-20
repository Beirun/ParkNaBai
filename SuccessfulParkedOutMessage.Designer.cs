namespace ParkInParkOut
{
    partial class SuccessfulParkedOutMessage
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
            this.successfulParkedInLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.viewReceiptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // successfulParkedInLabel
            // 
            this.successfulParkedInLabel.AutoSize = true;
            this.successfulParkedInLabel.BackColor = System.Drawing.Color.Transparent;
            this.successfulParkedInLabel.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successfulParkedInLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.successfulParkedInLabel.Location = new System.Drawing.Point(38, 326);
            this.successfulParkedInLabel.Name = "successfulParkedInLabel";
            this.successfulParkedInLabel.Size = new System.Drawing.Size(924, 72);
            this.successfulParkedInLabel.TabIndex = 0;
            this.successfulParkedInLabel.Text = "SUCCESSFULLY PARKED OUT!";
            this.successfulParkedInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.ForestGreen;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.backButton.Location = new System.Drawing.Point(237, 544);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(188, 49);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // viewReceiptButton
            // 
            this.viewReceiptButton.BackColor = System.Drawing.Color.ForestGreen;
            this.viewReceiptButton.FlatAppearance.BorderSize = 0;
            this.viewReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReceiptButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReceiptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.viewReceiptButton.Location = new System.Drawing.Point(542, 544);
            this.viewReceiptButton.Name = "viewReceiptButton";
            this.viewReceiptButton.Size = new System.Drawing.Size(188, 49);
            this.viewReceiptButton.TabIndex = 2;
            this.viewReceiptButton.Text = "View Receipt";
            this.viewReceiptButton.UseVisualStyleBackColor = false;
            this.viewReceiptButton.Click += new System.EventHandler(this.viewReceiptButton_Click);
            this.viewReceiptButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.viewReceiptButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // SuccessfulParkedOutMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewReceiptButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.successfulParkedInLabel);
            this.Name = "SuccessfulParkedOutMessage";
            this.Size = new System.Drawing.Size(1032, 800);
            this.Load += new System.EventHandler(this.SuccessfulParkedOutMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successfulParkedInLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button viewReceiptButton;
    }
}
