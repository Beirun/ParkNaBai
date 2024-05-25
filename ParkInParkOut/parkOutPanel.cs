using IronBarCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ParkInParkOut
{
    public partial class ParkOutPanel : UserControl
    {
        SqlConnectionClass conn = new SqlConnectionClass();
        FlowLayoutPanel[] parkoutSmallPanel;
        Panel bigPanel, BigPanel2, searchBoxPanel;
        Panel detailPanel;
        Panel panel;
        TextBox searchBox;
        Button searchButton;
        int timeHoverElapsed = 0;
        SlotPanel panelEntered;
        SlotPanel previousEntered;
        Panel[] panels;
        SlotPanel[,] slotPanels;
        Panel[,] panelsEntered = new Panel[4,3];
        Timer timer;
        public int FloorClicked {  get; set; }
        List<String> parkInTime = new List<String>();
        List<String> plateNumber = new List<String>();
        List<String> vehicleType = new List<String>();
        List<String> vehicleBrand = new List<String>();
        Timer mouseTimer;
        int index = 0;
        ParkInDash dash;
        ParkOutResult parkOutResult;
        ParkInPanel parkInPanel;
        ErrorDateTimeMessage errorDateTimeMessage;
        int floorSearched = 0;
        int columnSearched = 0;
        int rowSearched = 0;
        bool isFloorPainted = false;
        bool isSlotPainted = false;
        bool isFloorClicked = true;
        bool isSlotClicked = true;
        bool isSearchDone = false;
        public ParkOutPanel()
        {
            InitializeComponent();
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel.Size = new Size(1, 1);
            panel.Location = new Point(0, 0);
            this.MouseClick += (sender, e) => { panel.Focus(); };

        }


        private void FloorSlots_Paint(object sender, PaintEventArgs e)
        {
            SqlConnectionClass conn = new SqlConnectionClass();
            Panel panel = sender as Panel;
            int count = conn.getParkedInFloor((int)panel.Tag);

            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#353535"));

            brush = new SolidBrush(Color.ForestGreen);
            if(count==0) brush = new SolidBrush(Color.FromArgb(40,130,40));
            Font font = new Font("Calida Code", 16, FontStyle.Bold);
            string text = "Floor " + panel.Tag;
            SizeF size = g.MeasureString(text, font);

            g.DrawString(text, font, brush, panel.Width / 2 - size.Width / 2, panel.Height / 2 - size.Height / 2);
            text = "Currently Parked: " + count;
            if (count == 0) text = "Empty Floor";
            font = new Font("Calida Code", 10, FontStyle.Bold);

            g.DrawString(text, font, brush, 10, 10);

            Rectangle rect = new Rectangle(panel.Width - panel.Height - 25, panel.Height / 2 - (panel.Height - 25) / 2, panel.Height - 25, panel.Height - 25);
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
            g.DrawString(progress + "%", font, brush, (rect.X + lineWidth / 2 + (rect.Width - lineWidth) / 2) - size.Width / 2 + 1, (rect.Y + lineWidth / 2 + (rect.Height - lineWidth) / 2) - size.Height / 2 + 1);


            // Draw progress circle
            using (Pen progressPen = new Pen(Color.ForestGreen, lineWidth))
            {
                g.DrawArc(progressPen, rect.X + lineWidth / 2, rect.Y + lineWidth / 2, rect.Width - lineWidth, rect.Height - lineWidth, startAngle, sweepAngle);
            }
        }
        public void searchBar()
        {
            Controls.Add(panel);
            searchBoxPanel = new Panel();
            searchBox = new TextBox();
            searchBox.Text = "Enter Plate Number";
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Anchor = AnchorStyles.None;
            searchBox.BackColor = Color.White;
            searchBox.ForeColor = Color.Gray;
            searchBox.Font = new Font("Calida Code", 10, FontStyle.Regular);
            searchBox.Size = new Size(TextRenderer.MeasureText(searchBox.Text, searchBox.Font).Width+150, TextRenderer.MeasureText(searchBox.Text, searchBox.Font).Height);
            searchBox.Multiline = false;
            searchBox.TextChanged += SearchBox_TextChanged;
            searchBox.KeyPress += SearchBox_KeyPress;
            searchBox.Enter += SearchBox_Enter;
            searchBox.Leave += SearchBox_Leave;
            searchBoxPanel.Size = new Size(searchBox.Width + 40, searchBox.Height + 20);
            searchBoxPanel.BackColor = Color.White;
            searchBoxPanel.Cursor = Cursors.IBeam;
            searchBoxPanel.MouseClick += (sender, e) => searchBox.Focus();
            searchBox.Location = new Point(searchBoxPanel.Width/2 - searchBox.Width/2, searchBoxPanel.Height / 2 - searchBox.Height / 2);
            searchBoxPanel.Controls.Add(searchBox);
            searchBoxPanel.Location = new Point(Width/2 - searchBoxPanel.Width/2, 50);
            
            Controls.Add(searchBoxPanel);
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = sender as TextBox;
                floorSearched = conn.getSearchedVehicle("parkingrecords.floorslot", textBox.Text);
                columnSearched = conn.getSearchedVehicle("parkingrecords.columnslot", textBox.Text);
                rowSearched = conn.getSearchedVehicle("parkingrecords.rowslot", textBox.Text);
                if (floorSearched != 0 && columnSearched != 0 && rowSearched != 0)
                {
                    isFloorPainted = true;
                    isFloorClicked = false;
                    isSearchDone = false;
                    bigPanel.Invalidate();
                    if (BigPanel2 != null && BigPanel2.Visible && !isSearchDone)
                    {
                        isSlotClicked = false;
                        isSlotPainted = true;
                        BigPanel2.Invalidate();
                    }
                }
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (panel != null) panel.Hide();
            if (textBox.Text.Trim() == "") return;
            panel = new Panel();
            panel.BackColor = Color.Transparent;
            List<String> plateNumbers = conn.searchPlateNumber(textBox.Text);
            if (plateNumbers.Count == 0 || (plateNumbers.Count == 1 && plateNumbers[0].ToLower() == textBox.Text.ToLower())) return;
            Label[] plateNumberLabels = new Label[plateNumbers.Count];
            for(int i = 0;  i < plateNumberLabels.Length; i++)
            {
                plateNumberLabels[i] = new Label();
                plateNumberLabels[i].Text = "   "+plateNumbers[i];
                plateNumberLabels[i].ForeColor = Color.FromArgb(50, 50, 50);
                plateNumberLabels[i].BackColor = panel.BackColor;
                plateNumberLabels[i].TextAlign = ContentAlignment.MiddleLeft;
                plateNumberLabels[i].Font = new Font("Calida Code", 10, FontStyle.Regular);
                plateNumberLabels[i].Size = new Size(searchBoxPanel.Width, searchBoxPanel.Height);
                plateNumberLabels[i].Location = new Point(0, searchBoxPanel.Height * i);
                plateNumberLabels[i].MouseClick += searchPlateNumber_MouseClick;
                plateNumberLabels[i].MouseEnter += searchPlateNumber_MouseEnter;
                plateNumberLabels[i].MouseLeave += searchPlateNumber_MouseLeave;
               
                panel.Controls.Add(plateNumberLabels[i]);
            }
            panel.Size = new Size(searchBoxPanel.Width, searchBoxPanel.Height * plateNumbers.Count);
            panel.Location = new Point(searchBoxPanel.Left, searchBoxPanel.Top + searchBoxPanel.Height);
            Controls.Add(panel);
            panel.BringToFront();
        }

        private void searchPlateNumber_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = panel.BackColor;
            label.ForeColor = Color.FromArgb(50,50,50);
        }

        private void searchPlateNumber_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.LightGray;
            label.ForeColor = Color.FromArgb(25, 25, 25);
        }

        private void searchPlateNumber_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            searchBox.Text = label.Text.Trim();
            searchBox.SelectionStart = label.Text.Trim().Length;
        }

        

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "Enter Plate Number";
                textBox.ForeColor = Color.Gray;
            }
            if(panel != null){
                Controls.Remove(panel);
                panel.Hide();
            }

        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Enter Plate Number")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.FromArgb(25,25,25);
            }
            
        }

        public void parkedInVehicles()
        {
            this.Controls.Clear();
            Controls.Add(panel);
            searchBar();
            panels = new Panel[5];

            bigPanel = new Panel();
            this.MouseClick += (sender, e) => { bigPanel.Focus(); };
            bigPanel.Size = new System.Drawing.Size(630, 490);
            bigPanel.Location = new Point(ClientSize.Width / 2 - bigPanel.Width / 2 -12, ClientSize.Height / 2 - bigPanel.Height / 2 + 15);
            bigPanel.BackColor = Color.ForestGreen;


            for (int i = 4, j =0; i >= 0; i--)
            {
                panels[i] = new Panel();
                panels[i].Size = new System.Drawing.Size(600, 80);
                panels[i].Location = new Point(15, (j * 80) + ((j + 1) * 15));

                SqlConnectionClass conn = new SqlConnectionClass();
                int count = conn.getParkedInFloor(i+1);
                panels[i].BackColor = Color.White;
                panels[i].Tag = i + 1;
                panels[i].Paint += FloorSlots_Paint;
                j++;
                if (count == 0)
                {
                    panels[i].BackColor = Color.DarkGray;

                }
                else
                {
                    panels[i].MouseClick += FloorSlot_MouseClick;
                }
                bigPanel.Controls.Add(panels[i]);
            }
            bigPanel.Paint += BigPanel_Paint;
            Controls.Add(bigPanel);
        }

        private void BigPanel_Paint(object sender, PaintEventArgs e)
        {
            if (isFloorPainted && !isFloorClicked)
            {
                int floor = 4 - (floorSearched - 1);
                Panel panel = panels[floor];
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(15-5, ((5-floorSearched) * 80) + ((6-floorSearched) * 15)-5, panel.Width+10, panel.Height+10);
                using (SolidBrush brush = new SolidBrush(Color.DarkRed))
                {
                    g.FillRectangle(brush,rect);
                }
            }
            
        }

        public void FloorSlot_MouseClick(object sender, EventArgs e)
        {
            
            Controls.Add(panel);
            Controls.Remove(bigPanel);
            BigPanel2 = new Panel();
            BigPanel2.Size = new Size(685, 505);
            BigPanel2.Location = new Point(ClientSize.Width / 2 - BigPanel2.Width / 2 - 15, ClientSize.Height / 2 - BigPanel2.Height / 2 + 35);
            BigPanel2.BackColor = Color.Gray;
            slotPanels = new SlotPanel[4, 3];
            int FloorSlot = 0;
            try { FloorSlot = (int)((Panel)sender).Tag; } catch  { FloorSlot = FloorClicked;}
            FloorClicked = FloorSlot;
            String[,] vehicleTypes = new string[4, 3];
            for (int rows = 0; rows < 4; rows++)
            {
                for (int columns = 0; columns < 3; columns++)
                {

                    SqlConnectionClass conn = new SqlConnectionClass();
                    string slotVehicleType = conn.getSlotVehicleType(FloorSlot, columns + 1, rows + 1);
                    slotPanels[rows, columns] = new SlotPanel(slotVehicleType, rows + 1, columns + 1, FloorSlot);
                    slotPanels[rows, columns].isParkOut = true;
                    slotPanels[rows, columns].BackColor = Color.FromArgb(240,240,240);
                    if (slotVehicleType == "")
                    {
                        slotPanels[rows, columns].Paint += Empty_Paint;
                        slotPanels[rows, columns].BackColor = Color.FromArgb(190,190,190);

                    }
                    slotPanels[rows, columns].Size = new Size(175, 100);
                    slotPanels[rows, columns].Location = new Point((175 * columns) + (50 * (columns + 1)) - 20, 15 + (100 * rows) + (15 * (rows + 1)));
                    slotPanels[rows, columns].MouseClick += ParkOut_MouseClick;
                    slotPanels[rows, columns].MouseEnter += Slot_MouseEnter;
                    slotPanels[rows, columns].MouseLeave += Slot_MouseLeave; 
                    BigPanel2.Controls.Add(slotPanels[rows, columns]);
                }
            }
            this.Controls.Add(BigPanel2);
            this.MouseClick += (send, ex) => { BigPanel2.Focus(); };
            BigPanel2.MouseClick += (send, ex) => { BigPanel2.Focus(); };
            
            BigPanel2.Paint += BigPanel2_Paint;
            if ((int)((Panel)sender).Tag == floorSearched)
            {
                isFloorPainted = false;
                isFloorClicked = true;
                isSlotPainted = true;
                isSlotClicked = false;
                BigPanel2.Invalidate();
            }
            if (searchBox.Focused) this.ActiveControl = BigPanel2;

        }

        private void BigPanel2_Paint(object sender, PaintEventArgs e)
        {
            SlotPanel panel;
            if (floorSearched != 0 && columnSearched != 0 && rowSearched != 0) panel = slotPanels[rowSearched - 1, columnSearched - 1];
            else return;
            if (isSlotPainted && !isSlotClicked && panel.floorSlot == floorSearched && !isSearchDone)
            {
                
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(panel.Left-5,panel.Top-5, panel.Width + 10, panel.Height + 10);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(90,170,90)))
                {
                    g.FillRectangle(brush, rect);
                }
            }
        }

        private void Slot_MouseLeave(object sender, EventArgs e)
        {
            timeHoverElapsed = 0;
            if(timer != null) timer.Enabled = false;
            Timer newTimer = new Timer();
            newTimer.Interval = 500;
            newTimer.Tick += NewTimer_Tick;
            newTimer.Start();
        }

        private void NewTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (panelsEntered[previousEntered.row - 1, previousEntered.column - 1] != null) panelsEntered[previousEntered.row - 1, previousEntered.column - 1].Hide();
            }
            catch
            {
                return;
            }
            Timer timer = sender as Timer;
            timer.Enabled = false;
            previousEntered = panelEntered; 
        }

        private void Slot_MouseEnter(object sender, EventArgs e)
        {
            SlotPanel panel = sender as SlotPanel;
            if (panel.vehicleType == "") return;
            if (previousEntered == null) previousEntered = panel;
            panelEntered = panel;
            
            timer = new Timer();
            timer.Interval = 250;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeHoverElapsed >= 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if(panelsEntered[i, j] != null) panelsEntered[i, j].Hide();
                    }
                }
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1] = new Panel();
                
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].Size = new Size(125, 75);
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].BackColor = Color.White;
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].Location = new Point(panelEntered.Location.X + panelEntered.Width + 5, panelEntered.Location.Y);
                if(panelEntered.column == 3) panelsEntered[panelEntered.row - 1, panelEntered.column - 1].Location = new Point(panelEntered.Location.X - panelsEntered[panelEntered.row - 1, panelEntered.column - 1].Width - 5, panelEntered.Location.Y);


                Font labelFont = new Font("Tahoma", 10, FontStyle.Bold);
                Label plateNumberLabel = new Label();
                Color fore = Color.FromArgb(90, 170, 90);
                plateNumberLabel.Text = conn.getSelectedVehicle("vehicles.platenumber", panelEntered.floorSlot, panelEntered.column, panelEntered.row);
                plateNumberLabel.Font = labelFont;
                plateNumberLabel.ForeColor = fore;
                plateNumberLabel.Size = new Size(TextRenderer.MeasureText(plateNumberLabel.Text, labelFont).Width, TextRenderer.MeasureText(plateNumberLabel.Text, labelFont).Height);
                plateNumberLabel.Location = new Point(0, 0);

                Label vehicleTypeLabel = new Label();
                vehicleTypeLabel.Text = conn.getSelectedVehicle("vehicles.vehicletype", panelEntered.floorSlot, panelEntered.column, panelEntered.row);
                vehicleTypeLabel.Font = labelFont;
                vehicleTypeLabel.ForeColor = fore;
                vehicleTypeLabel.Size = new Size(TextRenderer.MeasureText(vehicleTypeLabel.Text, labelFont).Width, TextRenderer.MeasureText(vehicleTypeLabel.Text, labelFont).Height);
                vehicleTypeLabel.Location = new Point(0, plateNumberLabel.Height+7);

                Label vehicleBrandLabel = new Label();
                vehicleBrandLabel.Text = conn.getSelectedVehicle("vehicles.vehiclebrand", panelEntered.floorSlot, panelEntered.column, panelEntered.row);
                vehicleBrandLabel.Font = labelFont;
                vehicleBrandLabel.ForeColor = fore;
                vehicleBrandLabel.Size = new Size(TextRenderer.MeasureText(vehicleBrandLabel.Text, labelFont).Width, TextRenderer.MeasureText(vehicleBrandLabel.Text, labelFont).Height);
                vehicleBrandLabel.Location = new Point(0, plateNumberLabel.Height + vehicleTypeLabel.Height + 15);
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].Controls.Add(plateNumberLabel);
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].Controls.Add(vehicleTypeLabel);
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].Controls.Add(vehicleBrandLabel);
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].MouseLeave += DetailPanel_MouseLeave;
                BigPanel2.Controls.Add(panelsEntered[panelEntered.row - 1, panelEntered.column - 1]);
                panelsEntered[panelEntered.row - 1, panelEntered.column - 1].BringToFront();
            }
            timeHoverElapsed++;
        }
        
        private void DetailPanel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.Hide();
        }

        private void Empty_Paint(object sender, PaintEventArgs e)
        {
            SlotPanel panel = sender as SlotPanel;
            Graphics g = e.Graphics;
            SizeF size = g.MeasureString("EMPTY", new Font("Tahoma", 24, FontStyle.Bold));
            g.DrawString("EMPTY", new Font("Tahoma", 24, FontStyle.Bold), new SolidBrush(Color.FromArgb(128,20, 75, 20)), new Point(panel.Width/2 - (int)size.Width/2, panel.Height / 2 - (int)size.Height / 2));

        }

        private void ParkOut_MouseClick(object sender, MouseEventArgs e)
        {

            SlotPanel panel = sender as SlotPanel;
            if (panel.row == rowSearched && panel.column == columnSearched)
            {
                isFloorPainted = false;
                isSlotPainted = false;
                isFloorClicked = true;
                isSlotClicked = true;
                isSearchDone = true;
                BigPanel2.Invalidate();
            }
            string vehicleType = panel.vehicleType;
            if (vehicleType.Equals("")) return;
            DateTime datetime = Convert.ToDateTime(conn.getSelectedVehicle("parkingrecords.parkintime", panel.floorSlot, panel.column, panel.row));

            if ( datetime > DateTime.Now)
            {
                errorDateTimeMessage.Show();
                this.Hide();
            }
            else
            {
                parkOutResult.setParkOutTime(DateTime.Now);
                parkOutResult.parkingSlot = "F" + panel.floorSlot + "C" + panel.column + "R" + panel.row;
                parkOutResult.setParkInTime(conn.getSelectedVehicle("parkingrecords.parkintime", panel.floorSlot, panel.column, panel.row));
                parkOutResult.setPlateNumber(conn.getSelectedVehicle("vehicles.platenumber", panel.floorSlot, panel.column, panel.row));
                parkOutResult.setVehicleType(conn.getSelectedVehicle("vehicles.vehicletype", panel.floorSlot, panel.column, panel.row));
                parkOutResult.setVehicleBrand(conn.getSelectedVehicle("vehicles.vehiclebrand", panel.floorSlot, panel.column, panel.row));
                parkOutResult.Show();
                parkOutResult.setValues();
                this.Hide();

            }
            
        }

        public void setErrorDatTimeMessage(ErrorDateTimeMessage errorDateTimeMessage)
        {
            this.errorDateTimeMessage = errorDateTimeMessage;
        }

        private void ParkOutPanel_Load(object sender, EventArgs e)
        {

        }

        public void setParkInPanel(ParkInPanel parkInPanel) { 
            this.parkInPanel = parkInPanel;
        }
        public void setParkOutResult(ParkOutResult parkOutResult) { 
            this.parkOutResult = parkOutResult;
            parkOutResult.parkOutPanel = this;
        }


    }
}
