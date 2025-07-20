using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ParkInParkOut
{
    public partial class IncomePanel : UserControl
    {
        SqlConnectionClass conn = new SqlConnectionClass();
        int totalIncome = 0;
        int counter = 0;
        string texts = "Total Income";

        List<string>[] list = new List<string>[6];
        public IncomePanel()
        {
            InitializeComponent();
        }
        public void setPaymentSheet(string text, string start, string end)
        {
            list = conn.getPaymentSheet(text, start, end);
            getTotalIncome(list[5]);
            percentagePanel.Invalidate();
            spreadsheetPanel.Controls.Clear();
            FlowLayoutPanel sheetPanel = new FlowLayoutPanel();
            FlowLayoutPanel[] sheetPanels = new FlowLayoutPanel[list[0].Count];
            Label[,] labels = new Label[list[0].Count,list.Length];
            Label[] headerLabels = new Label[list.Length];
            Font font = new Font("Tahoma", 9, FontStyle.Bold);
            string[] strings = { "Plate Number", "Vehicle Type", "Vehicle Brand", "Park In Time", "Park Out Time", "Payment" };
            FlowLayoutPanel headerPanel = new FlowLayoutPanel();
            headerPanel.FlowDirection = FlowDirection.LeftToRight;
            for (int i = 0; i < list.Length; i++)
            {
                headerLabels[i] = new Label();
                headerLabels[i].Text = strings[i];
                headerLabels[i].Font = font;
                headerLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                headerLabels[i].ForeColor = Color.ForestGreen;
                headerPanel.Controls.Add(headerLabels[i]);
            }
            headerLabels[0].Size = new Size(100, TextRenderer.MeasureText(strings[0], font).Height + 15);
            headerLabels[1].Size = new Size(100, TextRenderer.MeasureText(strings[0], font).Height + 15);
            headerLabels[2].Size = new Size(100, TextRenderer.MeasureText(strings[0], font).Height + 15);
            headerLabels[3].Size = new Size(150, TextRenderer.MeasureText(strings[0], font).Height + 15);
            headerLabels[4].Size = new Size(150, TextRenderer.MeasureText(strings[0], font).Height + 15);
            headerLabels[5].Size = new Size(65, TextRenderer.MeasureText(strings[0], font).Height + 15);
            headerPanel.Height = 35;
            headerPanel.Width = spreadsheetPanel.Width;
            headerPanel.WrapContents = false;

            spreadsheetPanel.Controls.Add(headerPanel);
            headerPanel.Location = new Point(0, 0);
            sheetPanel.Size = new Size(spreadsheetPanel.Width, spreadsheetPanel.Height-headerPanel.Height);
            sheetPanel.Location = new Point(0, headerPanel.Height);
            sheetPanel.FlowDirection = FlowDirection.TopDown;
            sheetPanel.AutoScroll = true;
            sheetPanel.WrapContents = false;
            font = new Font("Tahoma", 8, FontStyle.Regular);

            for (int i = 0; i < list[0].Count; i++)
            {
                sheetPanels[i] = new FlowLayoutPanel();
                if (i % 2 == 0) sheetPanels[i].BackColor = Color.FromArgb(190, 240, 190);
                sheetPanels[i].FlowDirection = FlowDirection.LeftToRight;
                sheetPanels[i].WrapContents = false;
                for (int j = 0; j < list.Length; j++)
                {
                    Label label = labels[i,j] = new Label();
                    label.Text = list[j][i];
                    label.Font = font;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Size = new Size(headerLabels[j].Width, TextRenderer.MeasureText(label.Text, font).Height + 25);
                    sheetPanels[i].Controls.Add(label);
                }
                sheetPanels[i].Size = new Size(spreadsheetPanel.Width-23, headerLabels[0].Height+15);
                if(i>5) sheetPanel.Size = new Size(sheetPanel.Width, sheetPanel.Height + sheetPanels[i].Height-45);
                sheetPanel.Controls.Add(sheetPanels[i]);
            }
            spreadsheetPanel.Controls.Add(sheetPanel);
            spreadsheetPanel.Invalidate();
            counter++;
        } 
        public void setPercentPanel()
        {
            percentagePanel.Paint += PercentagePanel_Paint;
            percentagePanel.Invalidate();
            percentagePanel.Controls.Clear();
            Label label = new Label();
            Label phpLabel = new Label();
            Label incomeLabel = new Label();
            Label percentLabel = new Label();
            label.Text = totalIncome.ToString();
            if (totalIncome != 0) label.ForeColor = Color.ForestGreen;
            else label.ForeColor = Color.FromArgb(180, 40, 40);
            int fsize = 65;
            int gap = -6;
            while((int)TextRenderer.MeasureText(label.Text, new Font("Tahoma", fsize, FontStyle.Bold)).Width>265) { fsize--; gap++; }
            label.Font = new Font("Tahoma", fsize, FontStyle.Bold);
            if (fsize == 65) gap = 0;
            label.Size = new Size(TextRenderer.MeasureText(label.Text, label.Font).Width, TextRenderer.MeasureText(label.Text, label.Font).Height);
            //MessageBox.Show(label.Size.ToString());
            label.Location = new Point(percentagePanel.Width/2- 55, percentagePanel.Height/2 - label.Height/2 -5);
            percentagePanel.Controls.Add(label);

            phpLabel.Text = "PHP";
            phpLabel.Font = new Font("Tahoma", 25, FontStyle.Bold);
            phpLabel.ForeColor = label.ForeColor;
            phpLabel.Size = new Size(TextRenderer.MeasureText(phpLabel.Text, phpLabel.Font).Width, TextRenderer.MeasureText(phpLabel.Text, phpLabel.Font).Height);
            phpLabel.Location = new Point(label.Location.X+ label.Width-28+gap, label.Height + label.Location.Y - phpLabel.Height - 12);
            percentagePanel.Controls.Add(phpLabel);

            incomeLabel.Text = texts;
            incomeLabel.Font = new Font("Tahoma", 14, FontStyle.Bold);
            incomeLabel.ForeColor = ColorTranslator.FromHtml("#454545");

            incomeLabel.Size = new Size(TextRenderer.MeasureText(texts, incomeLabel.Font).Width, TextRenderer.MeasureText(texts, incomeLabel.Font).Height);
            incomeLabel.Location = new Point(label.Location.X + 20 , 50);
            percentagePanel.Controls.Add(incomeLabel);

            int max = 1000;
            while (totalIncome > max) { max += 1000; }
            string text = "Out Of " + max + " PHP";
            percentLabel.Text = text;
            percentLabel.Font = new Font("Tahoma", 14, FontStyle.Bold);
            percentLabel.ForeColor = ColorTranslator.FromHtml("#454545");
            percentLabel.Size = new Size(TextRenderer.MeasureText(percentLabel.Text, percentLabel.Font).Width, TextRenderer.MeasureText(percentLabel.Text, percentLabel.Font).Height);
            percentLabel.Location = new Point(label.Location.X + 20, label.Height + label.Location.Y + 5);
            percentagePanel.Controls.Add(percentLabel);

            incomeLabel.BringToFront();
            phpLabel.BringToFront();
        }
        public void getTotalIncome(List<string> list)
        {
            int income = 0;
            for (int i = 0; i < list.Count; i++) income += Convert.ToInt32(list[i]);
            totalIncome = income;
        }
        private void PercentagePanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnectionClass conn = new SqlConnectionClass();
            Panel panel = sender as Panel;

            int max = 1000;
            while(totalIncome > max) { max += 1000; }
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#353535"));

            Font font = new Font("Tahoma", 65, FontStyle.Bold);
            string text = totalIncome.ToString();
            SizeF size = g.MeasureString(text, font);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            Rectangle rect = new Rectangle(10, panel.Height / 2 - (panel.Height - 50) / 2, panel.Height - 50, panel.Height - 50);
            int lineWidth = 35;
            int progress = (totalIncome * 100) / max;
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

            font = new Font("Tahoma", 24, FontStyle.Bold);
            size = g.MeasureString(progress + "%", font);
            g.DrawString(progress + "%", font, brush, (rect.X + lineWidth / 2 + (rect.Width - lineWidth) / 2) - size.Width / 2 + 1, (rect.Y + lineWidth / 2 + (rect.Height - lineWidth) / 2) - size.Height / 2 + 1);


            // Draw progress circle
            using (Pen progressPen = new Pen(Color.ForestGreen, lineWidth))
            {
                g.DrawArc(progressPen, rect.X + lineWidth / 2, rect.Y + lineWidth / 2, rect.Width - lineWidth, rect.Height - lineWidth, startAngle, sweepAngle);
            }
        }

        public void setDetailPanel()
        {
            detailPanel.Paint += DetailPanel_Paint;
        }

        private void DetailPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#353535"));

            Font font = new Font("Tahoma", 10, FontStyle.Bold);
            g.DrawString("Average Income", font, brush, 0, 65, StringFormat.GenericDefault);

            g.DrawString("Number of Payments", font, brush, 0, 135, StringFormat.GenericDefault);
            string s = " Transaction";
            if (list[5].Count > 1) s += "s";

            brush = new SolidBrush(Color.ForestGreen);
            float d = ((float)totalIncome) / list[5].Count;
            if (list[5].Count == 0) d = 0F;
            g.DrawString( d.ToString("F1") + " PHP", font, brush, getXPosition(g, (d.ToString("F1")) + " PHP", font), 85, StringFormat.GenericDefault);
            g.DrawString(list[5].Count.ToString() + s, font, brush, getXPosition(g, list[5].Count.ToString() + s, font), 155, StringFormat.GenericDefault);
        }

        public int getXPosition(Graphics g, String text, Font font)
        {
            int x = 0;
            SizeF size = g.MeasureString(text, font);
            x = (int)(185 - size.Width);
            return x;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 171, 42);
            btn.ForeColor = Color.White;

        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.ForestGreen;
            btn.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void dailyButton_Click(object sender, EventArgs e)
        {
            texts = "Today's Income";
            setPaymentSheet("Daily", "", "");
            customPanel.Visible = false;
            setPercentPanel();
            setDetailPanel();
            spreadsheetPanel.Invalidate();
            spreadsheetPanel.Update();
            percentagePanel.Invalidate();
            detailPanel.Invalidate();
        }

        private void weeklyButton_Click(object sender, EventArgs e)
        {
            texts = "This Week's Income";

            setPaymentSheet("Weekly", "", "");
            customPanel.Visible = false;
            setDetailPanel();
            setPercentPanel();
            spreadsheetPanel.Invalidate();
            spreadsheetPanel.Update();
            percentagePanel.Invalidate();
            detailPanel.Invalidate();
        }

        private void monthlyButton_Click(object sender, EventArgs e)
        {
            texts = "This Month's Income";

            setPaymentSheet("Monthly", "", "");
            customPanel.Visible = false;
            setDetailPanel();
            setPercentPanel();
            spreadsheetPanel.Invalidate();
            spreadsheetPanel.Update();
            percentagePanel.Invalidate();
            detailPanel.Invalidate();
        }

        private void anuallyButton_Click(object sender, EventArgs e)
        {
            texts = "This Year's Income";
            setPaymentSheet("Yearly", "", "");
            customPanel.Visible = false;
            setDetailPanel();
            setPercentPanel();
            spreadsheetPanel.Invalidate();
            spreadsheetPanel.Update();
            percentagePanel.Invalidate();
            detailPanel.Invalidate();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            customPanel.Visible = !customPanel.Visible;
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(startDateTimePicker.Value > endDateTimePicker.Value || startDateTimePicker.Value > DateTime.Now)
            {
                errorLabel.Visible = true;
                return;
            }
            customPanel.Visible = false;
            texts = "Total Income";
            if(startDateTimePicker.Value != endDateTimePicker.Value) setPaymentSheet("Custom",startDateTimePicker.Value.ToString(),endDateTimePicker.Value.ToString());
            else if(startDateTimePicker.Value == DateTime.Now && endDateTimePicker.Value == DateTime.Now) dailyButton_Click(sender, e);
            setDetailPanel();
            setPercentPanel();
            spreadsheetPanel.Invalidate();
            spreadsheetPanel.Update();
            percentagePanel.Invalidate();
            detailPanel.Invalidate();
        }

        private void percentagePanel_Paint_1(object sender, PaintEventArgs e)
        {
            customPanel.Visible = false;

        }

        private void IncomePanel_Load(object sender, EventArgs e)
        {
            customPanel.Visible = false;

        }

        private void detailPanel_Paint(object sender, PaintEventArgs e)
        {
            customPanel.Visible = false;

        }

        private void spreadsheetPanel_Paint(object sender, PaintEventArgs e)
        {
            customPanel.Visible = false;

        }
    }
}
