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
            this.gradientPanel1 = new ParkInParkOut.GradientPanel();
            this.noPark = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.Navy;
            this.gradientPanel1.Controls.Add(this.noPark);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1032, 799);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.TopColor = System.Drawing.Color.Purple;
            // 
            // noPark
            // 
            this.noPark.AutoSize = true;
            this.noPark.BackColor = System.Drawing.Color.Transparent;
            this.noPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noPark.Location = new System.Drawing.Point(129, 340);
            this.noPark.Name = "noPark";
            this.noPark.Size = new System.Drawing.Size(767, 69);
            this.noPark.TabIndex = 0;
            this.noPark.Text = "No Vehicles Parked In Yet!";
            // 
            // NoParkedInMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.gradientPanel1);
            this.Name = "NoParkedInMessage";
            this.Size = new System.Drawing.Size(1032, 799);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label noPark;
        private GradientPanel gradientPanel1;
    }
}
