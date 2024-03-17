using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Style.MatchParentWidth(panel1);
            Style.MatchParentWidth(tableLayoutPanel1);
            flowLayoutPanel2.HorizontalScroll.Enabled = false;
            flowLayoutPanel2.HorizontalScroll.Visible = false;

            flowLayoutPanel1.VerticalScroll.Visible = false;

            PictureBox[] pictureBoxes = new PictureBox[4];

            /* Style.MatchParentWidth(panel2);
             Style.MatchParentWidth(panel3);
             Style.MatchParentWidth(panel4);
             Style.MatchParentWidth(panel5);
             Style.MatchParentWidth(panel6);*/
            string[] menus = { "McShareBox", "Burger", "Chicken", "Spaghetti", "Rice Bowls", "Desserts & Drinks", "McCafe", "Fries & Extras", "Happy Meal", };
            for (int i = 0; i < 9; i++)
            {
                // Create a FlowLayoutPanel for each iteration
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.WrapContents = false; // Optional
                flowLayoutPanel.AutoSize = true;

                // Create a PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu" + (i + 1) + ".jpg"));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 100;
                pictureBox.Height = 100;

                // Create a Label
                Label label = new Label();
                label.Text = menus[i]; // Unique label text for each iteration
                label.AutoSize = true; // Adjust size automatically

                // Add PictureBox and Label to FlowLayoutPanel
                flowLayoutPanel.Controls.Add(pictureBox);
                flowLayoutPanel.Controls.Add(label);

                // Add FlowLayoutPanel to the parent FlowLayoutPanel (flowLayoutPanel2)
                flowLayoutPanel2.Controls.Add(flowLayoutPanel);
            }

            //////////////////////////////////ads/////////////
            int currentIndex = 0;

            
            Timer timer = new Timer();
            timer.Interval = 4000; 
            timer.Tick += (sender, e) =>
            {
                panel1.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "ads", $"ad{currentIndex + 1}.jpg"));
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
                currentIndex = (currentIndex + 1) % 4;
            };
            timer.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
