using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;


namespace ParkInParkOut
{
    class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush color = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(color, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
