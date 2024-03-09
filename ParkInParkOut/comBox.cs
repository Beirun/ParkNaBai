
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.ComponentModel;
using System.Drawing.Design;


namespace ParkInParkOut
{
    [DefaultEvent("SelectedIndexChanged")]
    class comBox : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listForeColor = Color.White;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        private ComboBox cmBoxList;
        private Label labelText;
        private Button buttonIcon;

        

        public new Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                labelText.BackColor = backColor;
                buttonIcon.BackColor = backColor;
            }
        }
        public Color IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                buttonIcon.Invalidate(); // redraw icon
            }
        }
        public Color ListBackColor
        {
            get
            {
                return listBackColor;
            }
            set
            {
                listBackColor = value;
                cmBoxList.BackColor = listBackColor;
            }
        }
        public Color ListForeColor
        {
            get
            {
                return listForeColor;
            }
            set
            {
                listForeColor = value;
                cmBoxList.ForeColor = listForeColor;
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                labelText.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                labelText.Font = value;
                cmBoxList.Font = value;
            }
        }

        public override string Text
        {
            get { return labelText.Text; }
            set { labelText.Text = value; }
        }

        public ComboBoxStyle DropDownStyle
        {
            get { return cmBoxList.DropDownStyle; }
            set { cmBoxList.DropDownStyle = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmBoxList.Items; }

        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource
        {
            get { return cmBoxList.DataSource; }
            set { cmBoxList.DataSource = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Editor("System.Windows.Form.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture = neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmBoxList.AutoCompleteCustomSource; }
            set { cmBoxList.AutoCompleteCustomSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmBoxList.AutoCompleteSource; }
            set { cmBoxList.AutoCompleteSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmBoxList.AutoCompleteMode; }
            set { cmBoxList.AutoCompleteMode = value; }
        }


        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmBoxList.SelectedItem; }
            set { cmBoxList.SelectedItem = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmBoxList.SelectedIndex; }
            set { cmBoxList.SelectedIndex = value; }
        }



        public event EventHandler SelectedIndexChanged;

        public comBox() 
        {
             cmBoxList = new ComboBox();
             labelText = new Label();
             buttonIcon = new Button();

            cmBoxList.BackColor = listBackColor;
            cmBoxList.ForeColor = listForeColor;
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

            labelText.Dock = DockStyle.Fill;
            labelText.AutoSize = false;
            labelText.BackColor = backColor;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.FlatStyle = FlatStyle.Flat;
            labelText.Padding = new Padding(8, 2, 0, 0);
            labelText.Font = new Font(this.Font.Name, 10F);
            labelText.Click += new EventHandler(Surface_Click);
            labelText.Enter += new EventHandler(Surface_Enter);
            labelText.Leave += new EventHandler(Surface_Leave);


            this.Controls.Add(labelText);
            this.Controls.Add(buttonIcon);
            this.Controls.Add(cmBoxList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.Navy;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }
        private void AdjustComboBoxDimensions()
        {
            cmBoxList.Width = labelText.Width;
         /*   cmBoxList.Location = new Point()
            { X = labelText.Bottom - cmBoxList.Height,
                Y = cmBoxList.Width};
         */
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelText.Text = cmBoxList.Text;

            if (SelectedIndexChanged != null)
                SelectedIndexChanged.Invoke(sender, e);

        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconHeight = 6;
            int iconWidth = 14;
            var rectangleIcon = new Rectangle((buttonIcon.Width - iconWidth) / 2, (buttonIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
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
            this. OnClick(e);
            //Select Combo Box
            cmBoxList.Select();
            if (cmBoxList.DropDownStyle == ComboBoxStyle.DropDownList)
            cmBoxList.DroppedDown = true;
        }

      

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            labelText.Text = cmBoxList.Text;
        }
        private void Surface_Leave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_Enter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
