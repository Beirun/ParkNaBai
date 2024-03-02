using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace ParkIn
{
    partial class parkOut
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDash = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.parkOutButton = new System.Windows.Forms.Button();
            this.parkInButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDash
            // 
            this.panelDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelDash.Controls.Add(this.button1);
            this.panelDash.Controls.Add(this.parkOutButton);
            this.panelDash.Controls.Add(this.parkInButton);
            this.panelDash.Controls.Add(this.panel1);
            this.panelDash.Location = new System.Drawing.Point(-3, -2);
            this.panelDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(264, 446);
            this.panelDash.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(49, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // parkOutButton
            // 
            this.parkOutButton.FlatAppearance.BorderSize = 0;
            this.parkOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkOutButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkOutButton.ForeColor = System.Drawing.Color.White;
            this.parkOutButton.Location = new System.Drawing.Point(15, 198);
            this.parkOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkOutButton.Name = "parkOutButton";
            this.parkOutButton.Size = new System.Drawing.Size(230, 45);
            this.parkOutButton.TabIndex = 4;
            this.parkOutButton.Text = "PARK OUT";
            this.parkOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkOutButton.UseVisualStyleBackColor = true;
            // 
            // parkInButton
            // 
            this.parkInButton.FlatAppearance.BorderSize = 0;
            this.parkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkInButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkInButton.ForeColor = System.Drawing.Color.White;
            this.parkInButton.Location = new System.Drawing.Point(15, 140);
            this.parkInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkInButton.Name = "parkInButton";
            this.parkInButton.Size = new System.Drawing.Size(230, 45);
            this.parkInButton.TabIndex = 3;
            this.parkInButton.Text = "PARK IN";
            this.parkInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkInButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.BackgroundImage = global::ParkInParkOut.Properties.Resources.PARK_NA_BAI;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(15, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 142);
            this.panel1.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Tahoma", 14.2F, System.Drawing.FontStyle.Bold);
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitButton.Location = new System.Drawing.Point(528, 285);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 34);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicleType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVehicleType.ForeColor = System.Drawing.Color.DimGray;
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Items.AddRange(new object[] {
            "Motorcycle",
            "Sedan",
            "SUV",
            "Van"});
            this.comboVehicleType.Location = new System.Drawing.Point(411, 184);
            this.comboVehicleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(418, 27);
            this.comboVehicleType.TabIndex = 14;
            this.comboVehicleType.Text = "Vehicle Type";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(920, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "×";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // parkOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(950, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelDash);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.comboVehicleType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "parkOut";
            this.Text = "Form2";
            this.panelDash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDash;
        private Button button1;
        private Button parkOutButton;
        private Button parkInButton;
        private Panel panel1;
        private Button submitButton;
        private ComboBox comboVehicleType;
        private Button button2;
    }
}