using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    internal class SlotPanel : Panel
    {
        public string vehicleType;
        public int row, column, floorSlot;
        public bool isParkOut {  get; set; }
        public SlotPanel( string vehicleType, int row, int column, int floorSlot)
        {
            this.row = row;
            this.column = column;
            this.floorSlot = floorSlot;
            this.vehicleType = vehicleType;
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
            Graphics g = e.Graphics;
            try
            {
                if (Image.FromFile("C:\\Users\\Beirun\\source\\repos\\ParkInParkOut\\ParkInParkOut\\Resources\\" + vehicleType.ToLower() + ".png") != null)
                {
                    Image image = Image.FromFile("C:\\Users\\Beirun\\source\\repos\\ParkInParkOut\\ParkInParkOut\\Resources\\" + vehicleType.ToLower() + ".png");

                    g.DrawImage(image, 0, 0, 175, 100);

                }
            }
            catch
            {
                if (!isParkOut)
                {
                    string Slot = "F" + floorSlot + "C" + column + "R" + row;
                    SizeF size = g.MeasureString(Slot, new Font("Tahoma", 18, FontStyle.Bold));
                    g.DrawRectangle(new Pen(Color.ForestGreen, 10), this.ClientRectangle);
                    g.DrawString(Slot, new Font("Tahoma", 18, FontStyle.Bold), new SolidBrush(Color.FromArgb(200, 80,170,80)), new Point(Width / 2 - (int)size.Width / 2, Height / 2 - (int)size.Height / 2));
                }
            }
        }
        
    }
}
