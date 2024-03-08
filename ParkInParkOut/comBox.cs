
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.ComponentModel;


namespace ParkInParkOut
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class comBox : UserControl
    {
        private Color backColor = Color.Blue;
        private Color iconColor = Color.Red;
        private Color listBackColor = Color.Gray;
        private Color listForeColor = Color.Gray;
        private Color borderColor = Color.Black;
        private int borderSize = 1;

        private ComboBox cmBoxList;
        private Label labelText;
        private Button buttonIcon;

        public event EventHandler OnSelectedIndexChanged;

        public comBox() 
        {
             cmBoxList = new ComboBox();
             labelText = new Label();
             buttonIcon = new Button();

            cmBoxList.BackColor = backColor;
            cmBoxList.ForeColor = iconColor;
            cmBoxList.Font = new Font("Arial", 10, FontStyle.Regular);
            cmBoxList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); // Default Event
            cmBoxList.TextChanged += new EventHandler(ComboBox_TextChanged); // Refresh Text 

            buttonIcon.Dock = DockStyle.Right;
            buttonIcon.FlatStyle = FlatStyle.Flat;
            buttonIcon.FlatAppearance.BorderSize = 0;
            buttonIcon.BackColor = backColor;
            buttonIcon.Size = new Size(30, 30);
            buttonIcon.Click += new EventHandler(Icon_Click); // Open DropDown List
            buttonIcon.Paint += new PaintEventHandler(Icon_Paint);

            labelText.Dock = DockStyle.Left;
            labelText.AutoSize = false;
            labelText.BackColor = backColor;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.Padding = new Padding(8, 0, 0, 0);
            labelText.Font = new Font("Arial", 10, FontStyle.Regular);
            labelText.Click += new EventHandler(Surface_Click);

            this.Controls.Add(labelText);
            this.Controls.Add(buttonIcon);
            this.Controls.Add(cmBoxList);
            this.MinimumSize = new Size(300, 30);
            this.Size = new Size(300, 30);
            this.ForeColor = Color.Navy;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cmBoxList.Width = labelText.Width;
            cmBoxList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmBoxList.Width,
                Y = labelText.Bottom - cmBoxList.Height
            };
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);

            labelText.Text = cmBoxList.Text;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconHeight = 6;
            int iconWidth = 14;
            var rectangleIcon = new Rectangle((buttonIcon.Width - iconWidth) / 2, (buttonIcon.Height - iconHeight) / 2, iconHeight, iconWidth);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            { 
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectangleIcon.X, rectangleIcon.Y, rectangleIcon.X + (iconWidth / 2), rectangleIcon.Bottom);
                path.AddLine(rectangleIcon.X + (iconWidth / 2), rectangleIcon.Bottom, rectangleIcon.Right, rectangleIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            //Open Dropdown List
            cmBoxList.Select();
            cmBoxList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            //Select Combo Box
            cmBoxList.Select();
            if (cmBoxList.DropDownStyle == ComboBoxStyle.DropDownList)
            cmBoxList.DroppedDown = true;
        }

      

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            labelText.Text = cmBoxList.Text;
        }


    }
}
