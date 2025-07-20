namespace ParkInParkOut
{
    partial class Receipt
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
            this.exitButton = new System.Windows.Forms.Button();
            this.receiptBox = new System.Windows.Forms.PictureBox();
            this.saveButtonPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBox)).BeginInit();
            this.saveButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(522, 1);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(31, 33);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "×";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.exitButton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // receiptBox
            // 
            this.receiptBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.receiptBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptBox.Location = new System.Drawing.Point(0, 0);
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.Size = new System.Drawing.Size(575, 1102);
            this.receiptBox.TabIndex = 12;
            this.receiptBox.TabStop = false;
            // 
            // saveButtonPanel
            // 
            this.saveButtonPanel.Controls.Add(this.saveButton);
            this.saveButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButtonPanel.Location = new System.Drawing.Point(0, 1053);
            this.saveButtonPanel.Name = "saveButtonPanel";
            this.saveButtonPanel.Size = new System.Drawing.Size(575, 49);
            this.saveButtonPanel.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(178, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 37);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save Button";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 1102);
            this.Controls.Add(this.saveButtonPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.receiptBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.receiptBox)).EndInit();
            this.saveButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox receiptBox;
        private System.Windows.Forms.Panel saveButtonPanel;
        private System.Windows.Forms.Button saveButton;
    }
}