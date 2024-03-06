using System.Drawing;
using System.Windows.Forms;

namespace ParkInParkOut
{
    partial class ParkInDash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDash = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.parkOutButton = new System.Windows.Forms.Button();
            this.parkInButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.parkOutPanel1 = new ParkInParkOut.parkOutPanel();
            this.parkInPanel1 = new ParkInParkOut.parkInPanel(parkOutPanel1, parkOutResult1);
            this.parkOutResult1 = new ParkInParkOut.parkOutResult();
            this.panelDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDash
            // 
            this.panelDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelDash.Controls.Add(this.logoutButton);
            this.panelDash.Controls.Add(this.parkOutButton);
            this.panelDash.Controls.Add(this.parkInButton);
            this.panelDash.Controls.Add(this.panel1);
            this.panelDash.Location = new System.Drawing.Point(-3, 0);
            this.panelDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(296, 800);
            this.panelDash.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.logoutButton.Location = new System.Drawing.Point(61, 737);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(169, 29);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // parkOutButton
            // 
            this.parkOutButton.FlatAppearance.BorderSize = 0;
            this.parkOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkOutButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkOutButton.ForeColor = System.Drawing.Color.White;
            this.parkOutButton.Location = new System.Drawing.Point(2, 307);
            this.parkOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkOutButton.Name = "parkOutButton";
            this.parkOutButton.Size = new System.Drawing.Size(293, 45);
            this.parkOutButton.TabIndex = 4;
            this.parkOutButton.Text = "PARK OUT";
            this.parkOutButton.UseVisualStyleBackColor = true;
            this.parkOutButton.Click += new System.EventHandler(this.parkOutButton_Click);
            // 
            // parkInButton
            // 
            this.parkInButton.FlatAppearance.BorderSize = 0;
            this.parkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkInButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkInButton.ForeColor = System.Drawing.Color.White;
            this.parkInButton.Location = new System.Drawing.Point(2, 221);
            this.parkInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkInButton.Name = "parkInButton";
            this.parkInButton.Size = new System.Drawing.Size(293, 45);
            this.parkInButton.TabIndex = 3;
            this.parkInButton.Text = "PARK IN";
            this.parkInButton.UseVisualStyleBackColor = true;
            this.parkInButton.Click += new System.EventHandler(this.parkInButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.BackgroundImage = global::ParkInParkOut.Properties.Resources.PARK_NA_BAI;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(30, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 192);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(1292, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(31, 33);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "×";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.exitButton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // parkOutPanel1
            // 
            this.parkOutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parkOutPanel1.Location = new System.Drawing.Point(291, 3);
            this.parkOutPanel1.Name = "parkOutPanel1";
            this.parkOutPanel1.Size = new System.Drawing.Size(1032, 799);
            this.parkOutPanel1.TabIndex = 11;
            // 
            // parkInPanel1
            // 
            this.parkInPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parkInPanel1.Location = new System.Drawing.Point(291, 0);
            this.parkInPanel1.Name = "parkInPanel1";
            this.parkInPanel1.Size = new System.Drawing.Size(1032, 799);
            this.parkInPanel1.TabIndex = 12;
            // 
            // parkOutResult1
            // 
            this.parkOutResult1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parkOutResult1.Location = new System.Drawing.Point(291, 0);
            this.parkOutResult1.Name = "parkOutResult1";
            this.parkOutResult1.Size = new System.Drawing.Size(1032, 799);
            this.parkOutResult1.TabIndex = 13;
            // 
            // ParkInDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1324, 800);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelDash);
            this.Controls.Add(this.parkInPanel1);
            this.Controls.Add(this.parkOutResult1);
            this.Controls.Add(this.parkOutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ParkInDash";
            this.Text = "Form1";
            this.panelDash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelDash;
        private Button parkInButton;
        private Panel panel1;
        private Button parkOutButton;
        private Button logoutButton;
        private Button exitButton;
        private parkOutPanel parkOutPanel1;
        private parkInPanel parkInPanel1;
        private parkOutResult parkOutResult1;
    }
}
