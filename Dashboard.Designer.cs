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
            this.logsButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.parkOutButton = new System.Windows.Forms.Button();
            this.parkInButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.logsPanel1 = new ParkInParkOut.LogsPanel();
            this.floorSlots1 = new ParkInParkOut.FloorSlots();
            this.parkingSlots1 = new ParkInParkOut.ParkingSlots();
            this.parkOutResult1 = new ParkInParkOut.ParkOutResult();
            this.parkOutPanel1 = new ParkInParkOut.ParkOutPanel();
            this.parkInPanel1 = new ParkInParkOut.ParkInPanel();
            this.noParkedInMessage1 = new ParkInParkOut.NoParkedInMessage();
            this.successFulParkInMessage1 = new ParkInParkOut.SuccessFulParkInMessage();
            this.errorDateTimeMessage1 = new ParkInParkOut.ErrorDateTimeMessage();
            this.dashFee1 = new ParkInParkOut.DashFee();
            this.successfulParkedOutMessage1 = new ParkInParkOut.SuccessfulParkedOutMessage();
            this.incomePanel1 = new ParkInParkOut.IncomePanel();
            this.panelDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDash
            // 
            this.panelDash.BackColor = System.Drawing.Color.ForestGreen;
            this.panelDash.Controls.Add(this.logsButton);
            this.panelDash.Controls.Add(this.incomeButton);
            this.panelDash.Controls.Add(this.dashboardButton);
            this.panelDash.Controls.Add(this.logoutButton);
            this.panelDash.Controls.Add(this.parkOutButton);
            this.panelDash.Controls.Add(this.parkInButton);
            this.panelDash.Controls.Add(this.panel1);
            this.panelDash.Location = new System.Drawing.Point(0, 0);
            this.panelDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(291, 800);
            this.panelDash.TabIndex = 1;
            // 
            // logsButton
            // 
            this.logsButton.BackColor = System.Drawing.Color.ForestGreen;
            this.logsButton.FlatAppearance.BorderSize = 0;
            this.logsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.logsButton.Location = new System.Drawing.Point(0, 549);
            this.logsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(291, 100);
            this.logsButton.TabIndex = 8;
            this.logsButton.Text = "USER LOGS";
            this.logsButton.UseVisualStyleBackColor = false;
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            this.logsButton.MouseEnter += new System.EventHandler(this.logsButton_MouseEnter);
            this.logsButton.MouseLeave += new System.EventHandler(this.logsButton_MouseLeave);
            // 
            // incomeButton
            // 
            this.incomeButton.BackColor = System.Drawing.Color.ForestGreen;
            this.incomeButton.FlatAppearance.BorderSize = 0;
            this.incomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.incomeButton.Location = new System.Drawing.Point(0, 449);
            this.incomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(291, 100);
            this.incomeButton.TabIndex = 7;
            this.incomeButton.Text = "INCOME";
            this.incomeButton.UseVisualStyleBackColor = false;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            this.incomeButton.MouseEnter += new System.EventHandler(this.incomeButton_MouseEnter);
            this.incomeButton.MouseLeave += new System.EventHandler(this.incomeButton_MouseLeave);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.ForestGreen;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dashboardButton.Location = new System.Drawing.Point(0, 150);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(291, 100);
            this.dashboardButton.TabIndex = 6;
            this.dashboardButton.Text = "DASHBOARD";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            this.dashboardButton.MouseEnter += new System.EventHandler(this.dashboardButton_MouseEnter);
            this.dashboardButton.MouseLeave += new System.EventHandler(this.dashboardButton_MouseLeave);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.logoutButton.Location = new System.Drawing.Point(61, 728);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(169, 38);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.button2_Click);
            this.logoutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoutButton_MouseDown);
            this.logoutButton.MouseEnter += new System.EventHandler(this.logoutButton_MouseEnter);
            this.logoutButton.MouseLeave += new System.EventHandler(this.logoutButton_MouseLeave);
            // 
            // parkOutButton
            // 
            this.parkOutButton.BackColor = System.Drawing.Color.ForestGreen;
            this.parkOutButton.FlatAppearance.BorderSize = 0;
            this.parkOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkOutButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.parkOutButton.Location = new System.Drawing.Point(0, 350);
            this.parkOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkOutButton.Name = "parkOutButton";
            this.parkOutButton.Size = new System.Drawing.Size(291, 100);
            this.parkOutButton.TabIndex = 4;
            this.parkOutButton.Text = "PARK OUT";
            this.parkOutButton.UseVisualStyleBackColor = false;
            this.parkOutButton.Click += new System.EventHandler(this.parkOutButton_Click);
            this.parkOutButton.MouseEnter += new System.EventHandler(this.parkOutButton_MouseEnter);
            this.parkOutButton.MouseLeave += new System.EventHandler(this.parkOutButton_MouseLeave);
            // 
            // parkInButton
            // 
            this.parkInButton.BackColor = System.Drawing.Color.ForestGreen;
            this.parkInButton.FlatAppearance.BorderSize = 0;
            this.parkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkInButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.parkInButton.Location = new System.Drawing.Point(0, 250);
            this.parkInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkInButton.Name = "parkInButton";
            this.parkInButton.Size = new System.Drawing.Size(291, 100);
            this.parkInButton.TabIndex = 3;
            this.parkInButton.Text = "PARK IN";
            this.parkInButton.UseVisualStyleBackColor = false;
            this.parkInButton.Click += new System.EventHandler(this.parkInButton_Click);
            this.parkInButton.MouseEnter += new System.EventHandler(this.parkInButton_MouseEnter);
            this.parkInButton.MouseLeave += new System.EventHandler(this.parkInButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ParkInParkOut.Properties.Resources.PARK_NA_BAI;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(30, -33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 192);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
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
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.exitButton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // logsPanel1
            // 
            this.logsPanel1.Location = new System.Drawing.Point(291, 0);
            this.logsPanel1.Name = "logsPanel1";
            this.logsPanel1.Size = new System.Drawing.Size(1032, 800);
            this.logsPanel1.TabIndex = 21;
            // 
            // floorSlots1
            // 
            this.floorSlots1.Location = new System.Drawing.Point(291, 0);
            this.floorSlots1.Name = "floorSlots1";
            this.floorSlots1.ParkingSlotPanel = null;
            this.floorSlots1.Size = new System.Drawing.Size(1032, 800);
            this.floorSlots1.TabIndex = 20;
            // 
            // parkingSlots1
            // 
            this.parkingSlots1.Location = new System.Drawing.Point(291, 0);
            this.parkingSlots1.Name = "parkingSlots1";
            this.parkingSlots1.parkInPanel = null;
            this.parkingSlots1.Size = new System.Drawing.Size(1032, 800);
            this.parkingSlots1.TabIndex = 19;
            // 
            // parkOutResult1
            // 
            this.parkOutResult1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parkOutResult1.Location = new System.Drawing.Point(291, 0);
            this.parkOutResult1.Name = "parkOutResult1";
            this.parkOutResult1.parkingSlot = null;
            this.parkOutResult1.parkOutPanel = null;
            this.parkOutResult1.Size = new System.Drawing.Size(1032, 800);
            this.parkOutResult1.TabIndex = 13;
            this.parkOutResult1.UserName = null;
            // 
            // parkOutPanel1
            // 
            this.parkOutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parkOutPanel1.FloorClicked = 0;
            this.parkOutPanel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.parkOutPanel1.Location = new System.Drawing.Point(291, 0);
            this.parkOutPanel1.Name = "parkOutPanel1";
            this.parkOutPanel1.Size = new System.Drawing.Size(1064, 850);
            this.parkOutPanel1.TabIndex = 11;
            // 
            // parkInPanel1
            // 
            this.parkInPanel1.BackColor = System.Drawing.Color.White;
            this.parkInPanel1.ColumnSlot = 0;
            this.parkInPanel1.FloorSlot = 0;
            this.parkInPanel1.ForeColor = System.Drawing.Color.White;
            this.parkInPanel1.Location = new System.Drawing.Point(291, 0);
            this.parkInPanel1.Name = "parkInPanel1";
            this.parkInPanel1.RowSlot = 0;
            this.parkInPanel1.Size = new System.Drawing.Size(1032, 800);
            this.parkInPanel1.TabIndex = 12;
            this.parkInPanel1.userName = null;
            // 
            // noParkedInMessage1
            // 
            this.noParkedInMessage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.noParkedInMessage1.Location = new System.Drawing.Point(291, 0);
            this.noParkedInMessage1.Name = "noParkedInMessage1";
            this.noParkedInMessage1.Size = new System.Drawing.Size(1032, 800);
            this.noParkedInMessage1.TabIndex = 14;
            // 
            // successFulParkInMessage1
            // 
            this.successFulParkInMessage1.BackColor = System.Drawing.Color.DimGray;
            this.successFulParkInMessage1.d = null;
            this.successFulParkInMessage1.Location = new System.Drawing.Point(291, 0);
            this.successFulParkInMessage1.Name = "successFulParkInMessage1";
            this.successFulParkInMessage1.Size = new System.Drawing.Size(1032, 800);
            this.successFulParkInMessage1.TabIndex = 15;
            // 
            // errorDateTimeMessage1
            // 
            this.errorDateTimeMessage1.BackColor = System.Drawing.Color.DimGray;
            this.errorDateTimeMessage1.Location = new System.Drawing.Point(291, 0);
            this.errorDateTimeMessage1.Name = "errorDateTimeMessage1";
            this.errorDateTimeMessage1.Size = new System.Drawing.Size(1032, 800);
            this.errorDateTimeMessage1.TabIndex = 16;
            // 
            // dashFee1
            // 
            this.dashFee1.Location = new System.Drawing.Point(291, 0);
            this.dashFee1.Name = "dashFee1";
            this.dashFee1.Size = new System.Drawing.Size(1032, 800);
            this.dashFee1.TabIndex = 17;
            // 
            // successfulParkedOutMessage1
            // 
            this.successfulParkedOutMessage1.Location = new System.Drawing.Point(291, 0);
            this.successfulParkedOutMessage1.Name = "successfulParkedOutMessage1";
            this.successfulParkedOutMessage1.Size = new System.Drawing.Size(1032, 800);
            this.successfulParkedOutMessage1.TabIndex = 18;
            // 
            // incomePanel1
            // 
            this.incomePanel1.Location = new System.Drawing.Point(291, 0);
            this.incomePanel1.Name = "incomePanel1";
            this.incomePanel1.Size = new System.Drawing.Size(1032, 800);
            this.incomePanel1.TabIndex = 22;
            this.incomePanel1.Load += new System.EventHandler(this.incomePanel1_Load);
            // 
            // ParkInDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 800);
            this.Controls.Add(this.incomePanel1);
            this.Controls.Add(this.logsPanel1);
            this.Controls.Add(this.floorSlots1);
            this.Controls.Add(this.parkingSlots1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelDash);
            this.Controls.Add(this.parkOutResult1);
            this.Controls.Add(this.parkOutPanel1);
            this.Controls.Add(this.parkInPanel1);
            this.Controls.Add(this.noParkedInMessage1);
            this.Controls.Add(this.successFulParkInMessage1);
            this.Controls.Add(this.errorDateTimeMessage1);
            this.Controls.Add(this.dashFee1);
            this.Controls.Add(this.successfulParkedOutMessage1);
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
        private ParkInPanel parkInPanel1;
        private NoParkedInMessage noParkedInMessage1;
        private ParkOutPanel parkOutPanel1;
        private ParkOutResult parkOutResult1;
        private SuccessFulParkInMessage successFulParkInMessage1;
        private ErrorDateTimeMessage errorDateTimeMessage1;
        private Button dashboardButton;
        private DashFee dashFee1;
        private SuccessfulParkedOutMessage successfulParkedOutMessage1;
        private ParkingSlots parkingSlots1;
        private FloorSlots floorSlots1;
        private Button incomeButton;
        private Button logsButton;
        private LogsPanel logsPanel1;
        private IncomePanel incomePanel1;
    }
}
