using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    public partial class LogsPanel : UserControl
    {
        SqlConnectionClass conn = new SqlConnectionClass();
        public LogsPanel()
        {
            InitializeComponent();
            setLogSheet();
        }

        public void setLogSheet()
        {
            Label title= new Label();
            title.Text = "USER LOGS";
            title.Font = new Font("Tahoma", 36, FontStyle.Bold);
            title.ForeColor = Color.ForestGreen;
            title.Size = new Size(TextRenderer.MeasureText(title.Text, title.Font).Width, TextRenderer.MeasureText(title.Text, title.Font).Height);
            title.Location = new Point(this.Width / 2 - title.Width / 2, 25);
            Controls.Add(title);

            List<String>[] list = conn.getLogs();
            FlowLayoutPanel[] innerPanel = new FlowLayoutPanel[list[0].Count];
            Label[,] labels = new Label[list[0].Count, 5];
            Label[] headerLabels = new Label[list.Length];
            Font font = new Font("Tahoma", 10, FontStyle.Bold);
            string[] strings = { "Log Date", "UserName", "First Name", "Last Name", "Midle Initial" };
            FlowLayoutPanel headerPanel = new FlowLayoutPanel();
            FlowLayoutPanel outerOuterPanel = new FlowLayoutPanel();
            FlowLayoutPanel outerPanel = new FlowLayoutPanel();


            outerOuterPanel.FlowDirection = FlowDirection.TopDown;
            outerOuterPanel.Size = new Size(Width - 50, Height - 125);
            outerOuterPanel.WrapContents = false;
            outerOuterPanel.Location = new Point(Width / 2 - outerOuterPanel.Width / 2,50 + Height / 2 - outerOuterPanel.Height / 2);

            
            

            headerPanel.FlowDirection = FlowDirection.LeftToRight;
            for(int i  = 0; i < list.Length; i++)
            {
                headerLabels[i] = new Label();
                headerLabels[i].Text = strings[i];
                headerLabels[i].Font = font;
                headerLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                headerLabels[i].ForeColor = Color.ForestGreen;
                headerPanel.Controls.Add(headerLabels[i]);
            }
            headerLabels[0].Size = new Size(250, TextRenderer.MeasureText(strings[0], font).Height+5);
            headerLabels[1].Size = new Size(150, TextRenderer.MeasureText(strings[0], font).Height + 5);
            headerLabels[2].Size = new Size(150, TextRenderer.MeasureText(strings[0], font).Height + 5);
            headerLabels[3].Size = new Size(150, TextRenderer.MeasureText(strings[0], font).Height + 5);
            headerLabels[4].Size = new Size(150, TextRenderer.MeasureText(strings[0], font).Height + 5);
            headerPanel.Width = outerOuterPanel.Width + 240;
            headerPanel.Height = 25;
            headerPanel.WrapContents = false;
            outerOuterPanel.Controls.Add(headerPanel);

            outerPanel.FlowDirection = FlowDirection.TopDown;
            outerPanel.AutoScroll = true;
            outerPanel.AutoScrollMinSize = new Size(0, 1000);
            outerPanel.WrapContents = false;
            outerPanel.Size = new Size(headerPanel.Width, outerOuterPanel.Height+90);
            font = new Font("Calida Code", 10, FontStyle.Regular);

            for (int i = 0; i < list[0].Count; i++)
            {
                innerPanel[i] = new FlowLayoutPanel();
                innerPanel[i].FlowDirection = FlowDirection.LeftToRight;
                innerPanel[i].WrapContents = false;
                if(i%2==0)innerPanel[i].BackColor = Color.FromArgb(173, 235, 173);
                for (int j = 0; j < 5; j++)
                {
                    Label label = labels[i, j] = new Label();

                    label.Text = list[j][i];
                    label.Font = font;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Size = new Size(headerLabels[j].Width, TextRenderer.MeasureText(label.Text, font).Height+5);
                    //if (j == 0) label.TextAlign = ContentAlignment.MiddleLeft;

                    innerPanel[i].Size = new Size(headerPanel.Width-50,label.Height+5);
                    innerPanel[i].Controls.Add(label);
                }
                outerPanel.Controls.Add(innerPanel[i]);
            }
            outerOuterPanel.Controls.Add(outerPanel);

            Controls.Add(outerOuterPanel);


        }
    }
}
