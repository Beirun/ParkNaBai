using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace ParkInParkOut
{
    public partial class FloorSlots : UserControl
    {
        public ParkingSlots ParkingSlotPanel{
            get;
            set;
        }
        public FloorSlots()
        {
            InitializeComponent();
        }
        public void floorButtons()
        {
            Controls.Clear();
            Controls.Add(label1);
            Panel[] panels = new Panel[5];
            Panel bigPanel = new Panel();
            bigPanel.Size = new System.Drawing.Size(630, 490);
            bigPanel.Location = new Point(ClientSize.Width/2 - bigPanel.Width/2, ClientSize.Height/2 - bigPanel.Height/2 + 35);    
            bigPanel.BackColor = Color.ForestGreen;
            

            for(int i = 4, j =0; i >=0; i--)
            {
                panels[i] = new Panel();
                panels[i].Size = new System.Drawing.Size(600, 80);
                panels[i].Location = new Point(15, (j * 80) + ((j+1)*15));
                panels[i].BackColor = Color.White;
                panels[i].Tag = i + 1;
                panels[i].Paint += FloorSlots_Paint;
                panels[i].MouseClick += panel_MouseClick;
                bigPanel.Controls.Add(panels[i]);
                j++;
            }
            Controls.Add(bigPanel);
        }

        private void FloorSlots_Paint(object sender, PaintEventArgs e)
        {
            SqlConnectionClass conn = new SqlConnectionClass();
            Panel panel = sender as Panel;
            int count = conn.getParkedInFloor((int)panel.Tag);

            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#353535"));
            brush = new SolidBrush(Color.ForestGreen);

            Font font = new Font("Calida Code", 16, FontStyle.Bold);
            string text = "Floor " + panel.Tag;
            SizeF size = g.MeasureString(text, font);

            g.DrawString(text, font, brush, panel.Width / 2 - size.Width / 2, panel.Height / 2 - size.Height / 2);
            text = "Available Space: " + (12 -count);
            if (12 - count == 0) text = "Fully Oxccupied";
            font = new Font("Calida Code", 10, FontStyle.Bold);

            g.DrawString(text, font, brush, 10, 10);

            Rectangle rect = new Rectangle(panel.Width - panel.Height - 25, panel.Height / 2 - (panel.Height - 25)/2, panel.Height - 25, panel.Height - 25);
            int lineWidth = 10;
            int progress = (count * 100) / 12;
            if (progress < 0) progress = 0;
            if (progress > 100) progress = 100;

            // Calculate angles
            float startAngle = -90; // Start angle (top of the circle)
            float sweepAngle = (360f * progress) / 100f; // Sweep angle based on progress

            // Anti-aliasing for smoother drawing
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw background circle
            using (Pen backgroundPen = new Pen(Color.LightGray, lineWidth))
            {
                g.DrawArc(backgroundPen, rect.X + lineWidth / 2, rect.Y + lineWidth / 2, rect.Width - lineWidth, rect.Height - lineWidth, startAngle, 360);
            }

            size = g.MeasureString(progress + "%", font);
            g.DrawString(progress + "%", font,brush, (rect.X + lineWidth / 2 + (rect.Width - lineWidth)/2) - size.Width/2 + 1, (rect.Y + lineWidth / 2 + (rect.Height - lineWidth)/2) - size.Height / 2 + 1);
            
            
            // Draw progress circle
            using (Pen progressPen = new Pen(Color.ForestGreen, lineWidth))
            {
                g.DrawArc(progressPen, rect.X + lineWidth / 2, rect.Y + lineWidth / 2, rect.Width - lineWidth, rect.Height - lineWidth, startAngle, sweepAngle);
            }
        }
        public void panel_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            int index = (int)panel.Tag;
            ParkingSlotPanel.buttonSlots(index);
            ParkingSlotPanel.Show();
            this.Hide();
            
        }

        private void FloorSlots_Load(object sender, EventArgs e)
        {

        }
    }
}
