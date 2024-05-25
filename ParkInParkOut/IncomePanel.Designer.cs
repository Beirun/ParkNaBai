namespace ParkInParkOut
{
    partial class IncomePanel
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
            this.percentagePanel = new System.Windows.Forms.Panel();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.spreadsheetPanel = new System.Windows.Forms.Panel();
            this.dailyButton = new System.Windows.Forms.Button();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.monthlyButton = new System.Windows.Forms.Button();
            this.anuallyButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.customPanel = new System.Windows.Forms.Panel();
            this.selectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorLabel = new System.Windows.Forms.Label();
            this.customPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // percentagePanel
            // 
            this.percentagePanel.Location = new System.Drawing.Point(36, 117);
            this.percentagePanel.Name = "percentagePanel";
            this.percentagePanel.Size = new System.Drawing.Size(699, 302);
            this.percentagePanel.TabIndex = 0;
            this.percentagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.percentagePanel_Paint_1);
            // 
            // detailPanel
            // 
            this.detailPanel.Location = new System.Drawing.Point(754, 117);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(242, 302);
            this.detailPanel.TabIndex = 1;
            this.detailPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.detailPanel_Paint);
            // 
            // spreadsheetPanel
            // 
            this.spreadsheetPanel.Location = new System.Drawing.Point(36, 452);
            this.spreadsheetPanel.Name = "spreadsheetPanel";
            this.spreadsheetPanel.Size = new System.Drawing.Size(978, 322);
            this.spreadsheetPanel.TabIndex = 2;
            this.spreadsheetPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spreadsheetPanel_Paint);
            // 
            // dailyButton
            // 
            this.dailyButton.BackColor = System.Drawing.Color.ForestGreen;
            this.dailyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyButton.Font = new System.Drawing.Font("Tahoma", 8.2F, System.Drawing.FontStyle.Bold);
            this.dailyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dailyButton.Location = new System.Drawing.Point(61, 50);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(150, 50);
            this.dailyButton.TabIndex = 3;
            this.dailyButton.Text = "DAILY";
            this.dailyButton.UseVisualStyleBackColor = false;
            this.dailyButton.Click += new System.EventHandler(this.dailyButton_Click);
            this.dailyButton.MouseEnter += new System.EventHandler(this.Button_MouseLeave);
            this.dailyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // weeklyButton
            // 
            this.weeklyButton.BackColor = System.Drawing.Color.ForestGreen;
            this.weeklyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weeklyButton.Font = new System.Drawing.Font("Tahoma", 8.2F, System.Drawing.FontStyle.Bold);
            this.weeklyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.weeklyButton.Location = new System.Drawing.Point(251, 50);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(150, 50);
            this.weeklyButton.TabIndex = 4;
            this.weeklyButton.Text = "WEEKLY";
            this.weeklyButton.UseVisualStyleBackColor = false;
            this.weeklyButton.Click += new System.EventHandler(this.weeklyButton_Click);
            this.weeklyButton.MouseEnter += new System.EventHandler(this.Button_MouseLeave);
            this.weeklyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // monthlyButton
            // 
            this.monthlyButton.BackColor = System.Drawing.Color.ForestGreen;
            this.monthlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthlyButton.Font = new System.Drawing.Font("Tahoma", 8.2F, System.Drawing.FontStyle.Bold);
            this.monthlyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.monthlyButton.Location = new System.Drawing.Point(441, 50);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(150, 50);
            this.monthlyButton.TabIndex = 5;
            this.monthlyButton.Text = "MONTHLY";
            this.monthlyButton.UseVisualStyleBackColor = false;
            this.monthlyButton.Click += new System.EventHandler(this.monthlyButton_Click);
            this.monthlyButton.MouseEnter += new System.EventHandler(this.Button_MouseLeave);
            this.monthlyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // anuallyButton
            // 
            this.anuallyButton.BackColor = System.Drawing.Color.ForestGreen;
            this.anuallyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anuallyButton.Font = new System.Drawing.Font("Tahoma", 8.2F, System.Drawing.FontStyle.Bold);
            this.anuallyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.anuallyButton.Location = new System.Drawing.Point(631, 50);
            this.anuallyButton.Name = "anuallyButton";
            this.anuallyButton.Size = new System.Drawing.Size(150, 50);
            this.anuallyButton.TabIndex = 6;
            this.anuallyButton.Text = "ANUALLY";
            this.anuallyButton.UseVisualStyleBackColor = false;
            this.anuallyButton.Click += new System.EventHandler(this.anuallyButton_Click);
            this.anuallyButton.MouseEnter += new System.EventHandler(this.Button_MouseLeave);
            this.anuallyButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.ForestGreen;
            this.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton.Font = new System.Drawing.Font("Tahoma", 8.2F, System.Drawing.FontStyle.Bold);
            this.customButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.customButton.Location = new System.Drawing.Point(821, 50);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(150, 50);
            this.customButton.TabIndex = 7;
            this.customButton.Text = "CUSTOM";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            this.customButton.MouseEnter += new System.EventHandler(this.Button_MouseLeave);
            this.customButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // customPanel
            // 
            this.customPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(200)))), ((int)(((byte)(87)))));
            this.customPanel.Controls.Add(this.errorLabel);
            this.customPanel.Controls.Add(this.selectButton);
            this.customPanel.Controls.Add(this.label2);
            this.customPanel.Controls.Add(this.label1);
            this.customPanel.Controls.Add(this.endDateTimePicker);
            this.customPanel.Controls.Add(this.startDateTimePicker);
            this.customPanel.Location = new System.Drawing.Point(650, 103);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(321, 218);
            this.customPanel.TabIndex = 8;
            this.customPanel.Visible = false;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.ForestGreen;
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.selectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.selectButton.Location = new System.Drawing.Point(107, 177);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(107, 28);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "SELECT";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            this.selectButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.selectButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "END OF DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "START OF DATE";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.endDateTimePicker.Location = new System.Drawing.Point(34, 138);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(253, 22);
            this.endDateTimePicker.TabIndex = 1;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.startDateTimePicker.Location = new System.Drawing.Point(34, 72);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(253, 22);
            this.startDateTimePicker.TabIndex = 0;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLabel.Location = new System.Drawing.Point(36, 14);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(232, 20);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "ERROR! Incorrect Format!";
            this.errorLabel.Visible = false;
            // 
            // IncomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.anuallyButton);
            this.Controls.Add(this.monthlyButton);
            this.Controls.Add(this.weeklyButton);
            this.Controls.Add(this.dailyButton);
            this.Controls.Add(this.spreadsheetPanel);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.percentagePanel);
            this.Name = "IncomePanel";
            this.Size = new System.Drawing.Size(1032, 800);
            this.Load += new System.EventHandler(this.IncomePanel_Load);
            this.customPanel.ResumeLayout(false);
            this.customPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel percentagePanel;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Panel spreadsheetPanel;
        private System.Windows.Forms.Button dailyButton;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button monthlyButton;
        private System.Windows.Forms.Button anuallyButton;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Panel customPanel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label errorLabel;
    }
}
