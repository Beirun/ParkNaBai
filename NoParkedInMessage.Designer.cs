namespace ParkInParkOut
{
    partial class NoParkedInMessage
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
            this.noPark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noPark
            // 
            this.noPark.AutoSize = true;
            this.noPark.BackColor = System.Drawing.Color.Transparent;
            this.noPark.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.noPark.ForeColor = System.Drawing.Color.ForestGreen;
            this.noPark.Location = new System.Drawing.Point(34, 328);
            this.noPark.Name = "noPark";
            this.noPark.Size = new System.Drawing.Size(931, 81);
            this.noPark.TabIndex = 0;
            this.noPark.Text = "No Vehicles Parked In Yet!";
            // 
            // NoParkedInMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.noPark);
            this.Name = "NoParkedInMessage";
            this.Size = new System.Drawing.Size(1032, 799);
            this.Load += new System.EventHandler(this.NoParkedInMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noPark;
    }
}
