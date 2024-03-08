namespace ParkInParkOut
{
    partial class SuccessFulParkInMessage
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
            this.parkInAgain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.Navy;
            this.gradientPanel1.Controls.Add(this.parkInAgain);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1032, 800);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.Purple;
            // 
            // parkInAgain
            // 
            this.parkInAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkInAgain.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkInAgain.Location = new System.Drawing.Point(321, 402);
            this.parkInAgain.Name = "parkInAgain";
            this.parkInAgain.Size = new System.Drawing.Size(356, 73);
            this.parkInAgain.TabIndex = 1;
            this.parkInAgain.Text = "Park In Again";
            this.parkInAgain.UseVisualStyleBackColor = true;
            this.parkInAgain.Click += new System.EventHandler(this.parkInAgain_Click);
            this.parkInAgain.MouseEnter += new System.EventHandler(this.parkInAgain_MouseEnter);
            this.parkInAgain.MouseLeave += new System.EventHandler(this.parkInAgain_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Successfully Parked In!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuccessFulParkInMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.gradientPanel1);
            this.Name = "SuccessFulParkInMessage";
            this.Size = new System.Drawing.Size(1032, 800);
            this.Load += new System.EventHandler(this.SuccessFull_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button parkInAgain;
        private GradientPanel gradientPanel1;
    }
}
