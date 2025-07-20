using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    public partial class ParkingSlots : UserControl
    {
        public ParkInPanel parkInPanel
        {
            get;
            set;
        }
        int FloorSlot;
        string vehicleType = "sedan";

        public ParkingSlots()
        {
            InitializeComponent();
        }
       
        public void buttonSlots(int floorSlot)
        {
            this.Controls.Clear();
            Controls.Add(label1);
            FloorSlot = floorSlot;
            Panel BigPanel = new Panel();
            BigPanel.Size = new Size(685, 505);
            BigPanel.Location = new Point(ClientSize.Width/2 - BigPanel.Width/2, ClientSize.Height/2 - BigPanel.Height/2 + 35);
            BigPanel.BackColor = Color.Gray;
            SlotPanel[,] panels = new SlotPanel[4, 3];
            String[,] vehicleTypes = new string[4, 3];
            for(int rows = 0; rows < 4; rows++)
            {
                for(int columns = 0; columns < 3; columns++)
                {
                    SqlConnectionClass conn = new SqlConnectionClass();
                    string slotVehicleType = conn.getSlotVehicleType(FloorSlot, columns+1, rows+1);
                    panels[rows, columns] = new SlotPanel(slotVehicleType,rows+1,columns+1,FloorSlot);

                    panels[rows,columns].Size = new Size(175, 100);
                    panels[rows, columns].Location = new Point((175 * columns) + (50*(columns+1)) - 20, 15 + (100 * rows) + (15*(rows+1)));
                    panels[rows, columns].BackColor = Color.FromArgb(200,200,200);
                    BigPanel.Controls.Add(panels[rows, columns]);
                    panels[rows, columns].MouseClick += button_MouseClick;
                }
            }
            this.Controls.Add(BigPanel);
        }
        
        public void button_MouseClick(object sender, MouseEventArgs e) {
            SlotPanel panel = (SlotPanel)sender;
            if (panel.vehicleType == "")
            {
                parkInPanel.FloorSlot = panel.floorSlot;
                parkInPanel.RowSlot = panel.row;
                parkInPanel.ColumnSlot = panel.column;
                parkInPanel.Show();

                this.Hide();
            }
        }
    }

}
