using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkInParkOut
{
    public partial class Receipt : Form
    {
        Image image;
        String plateNumber;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        

        public Receipt()
        {
            InitializeComponent();
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;

            exitButton.ForeColor = Color.ForestGreen;
            exitButton.BackColor = Color.White;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = exitButton.BackColor;
            this.Show();
            receiptBox.MouseDown += Form_MouseDown;
            receiptBox.MouseMove += Form_MouseMove;
            receiptBox.MouseUp += Form_MouseUp;
            this.Load += Form1_Load;
            this.Size = new System.Drawing.Size(receiptBox.Width, receiptBox.Height + saveButtonPanel.Height);
            exitButton.Location = new Point(receiptBox.Width - exitButton.Width, 0);
            saveButton.Location = new Point((receiptBox.Width/2) - (saveButton.Width / 2), saveButton.Location.Y);
            this.Location = new Point(50, 20);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.BackColor = Color.ForestGreen;
            saveButton.Text = "Download";
        }
        [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool Repaint);

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            this.MaximumSize = new Size(5000, 800);
            bool Result = MoveWindow(this.Handle, this.Left, this.Top, 5000, 500, true);
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }


        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            exitButton.ForeColor = Color.FromArgb(150, 0, 0);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = this.BackColor;
            exitButton.ForeColor = Color.ForestGreen;
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void setPlateNumber(String plateNumber)
        {
            this.plateNumber = plateNumber;
        }
        public void setImage(Image image)
        {
            this.image = image;

        }
        public void setPictureBox(Bitmap bmp)
        {
            receiptBox.SizeMode = PictureBoxSizeMode.Zoom;
            receiptBox.Image = image;
            receiptBox.Location = new Point(0, 0);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)receiptBox.Image;
            String file = "C:\\Users\\Beirun\\source\\repos\\ParkInParkOut\\ParkInParkOut\\Receipts\\" + plateNumber + ".png";
            bmp.Save(file, ImageFormat.Png);
            Process.Start("explorer.exe", $"/select,\"{file}\"");
        }
        
    }
}

