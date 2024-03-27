using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{


    public partial class Form5 : Form
    {
        public string FoodName { get; set; }
        public string ImagePath { get; set; }
        public string ReturnValue { get; private set; }
        public double Prices { get; set; }
        public string[] Sizes { get; set; }
        public int foodSelection { get; set; }
        public int foodIndex { get; set; }
        //Dictionary<string, Dictionary<string, Tuple<string[], Tuple<double, string>[]>>>[] foodDictionary;
        Control[] dropdowns;
        Label[] customLabels;

        /* class FoodData
         {
            // public decimal[] Prices { get; set; }
             public string[] Sizes { get; set; }
         }*/
        string[] arrayFirst;
        string[] arraySecond;
        string[] arrayThird;
        string sel1;
        string sel2;
        string sel3;
        string[] sels;

        private int quantity = 0;
        
        string[] selColors;

        public Form5()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaximizeBox = false;
            Methods.ShowAds(panel1);
            Methods.MatchParentWidth(panel2);


            dropdowns = new Control[] { dropdown1, dropdown2, dropdown3 };
            customLabels = new Label[] { customText1, customText2, customText3 };
            sels = new string[] { sel1, sel2, sel3 };
            selColors = new string[] { "", "", "" };

            dropdown2.AutoScroll = false;
            dropdown2.VerticalScroll.Enabled = false;
            dropdown2.VerticalScroll.Visible = false;
            dropdown2.VerticalScroll.Maximum = 0;
            dropdown2.HorizontalScroll.Visible = false;
            dropdown2.AutoScroll = true;
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string folderName = Form3.Foldername.ToString();
            label2.Text = FoodName;
            label3.Text = Prices.ToString("PHP ###,###.00");
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, folderName, ImagePath + (/*i + */1) + ".jpg"));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            switch (foodSelection)
            {
                case 0:
                    switch (FoodName)
                    {
                        case "McShareBundle for 3":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };

                            break;
                        case "McShareBundle for 4":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke Small", "Coke Medium", "Coke Large", "Sprite Small", "Sprite Medium", "Sprite Large", "Coke Small", "Coke Medium", "Coke Large", "Sprite Small", "Sprite Medium", "Sprite Large" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "6pc Chicken McShareBox":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "8pc Chicken McShareBox":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "BFF ShakeShake & McFloat":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                    }
                    break;
                case 1:
                    switch (FoodName)
                    {
                        case "Double Crispy Fish Fillet Sandwich":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };

                            break;
                        case "Crispy Fish Fillet Sandwich":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Big Mac":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Double Quarter Pounder with Cheese":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Quarter Pounder with Cheese":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Triple Cheeseburger":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Double Cheeseburger":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "McChicken":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Cheeseburger":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Crispy Chicken Sandwich":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                        case "Burger Mcdo":
                            customText1.Text = "Chicken";
                            customText2.Text = "Drinks";
                            customText3.Text = "Additionals";
                            arrayFirst = new string[] { "Original", "Spicy" };
                            arraySecond = new string[] { "Coke", "Coke Float", "Sprite" };
                            arrayThird = new string[] { "Fries", "Gravy", "Rice" };
                            break;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }


            //LoadCustoms();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            ReturnValue = "asdasdasdasd";
            foreach (string a in sels)
            {
                MessageBox.Show("sel:" + a);
            }
            this.Close(); // Close the pop-up form
        }
        List<FlowLayoutPanel>[] flows = new List<FlowLayoutPanel>[]
        {
            new List<FlowLayoutPanel>(),
            new List<FlowLayoutPanel>(),
            new List<FlowLayoutPanel>()
        };
        private void LoadMenu(string[] menu, string imageName, int dropdown, ref string choice)
        {
            int counter = 0;
            for (int i = 0; i < menu.Length; i++)
            {

                if (counter < menu.Length)
                {
                    int index = i;
                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                    flowLayoutPanel.Dock = DockStyle.None; // Dock to fill the available space
                    flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                    flowLayoutPanel.WrapContents = false; // Optional
                    flowLayoutPanel.AutoSize = true;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", imageName + (/*i + */1) + ".jpg"));

                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = 50;
                    pictureBox.Height = 50;
                    // pictureBox.BackColor = Color.Red;
                    pictureBox.Margin = new Padding(20);
                    //pictureBox.BackColor = Color.Red;

                    Label label = new Label();
                    //string menuItemName = menu.ElementAt(counter).Key;
                    label.Text = menu[counter]; // Unique label text for each iter

                    counter++;
                    Methods.MatchParentWidth(label);
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.AutoEllipsis = true;
                    //label.BackColor = Color.Blue;

                    //flowLayoutPanel.Click += (sender, e) => FoodClicked(index);
                    // Methods.InheritEvent(flowLayoutPanel, (sender, e) => FoodClicked(index));


                    flowLayoutPanel.Controls.Add(pictureBox);
                    flowLayoutPanel.Controls.Add(label);
                    //flowLayoutPanel.AutoSize = true;

                    Methods.FlowMargin(pictureBox);
                    Methods.FlowMargin(label);

                    flowLayoutPanel.Margin = new Padding(0, 0, 0, 10);
                    // flowLayoutPanel.VerticalScroll.Enabled = false;
                    //string imagePath = Path.Combine(Application.StartupPath, "pictures", "menu" + (/*i + */1) + ".jpg").ToString();
                    //flowLayoutPanel.Click += (sender, e) => FoodClicked(index, imageName);
                    //Methods.InheritEvent(flowLayoutPanel, (sender, e) => FoodClicked(index, imageName));
                    flows[dropdown].Add(flowLayoutPanel);
                    flowLayoutPanel.Click += (sender, e) => ChoiceMade(label.Text, dropdown, index);
                    Methods.InheritEvent(flowLayoutPanel, (sender, e) => ChoiceMade(label.Text, dropdown, index));
                    dropdowns[dropdown].Controls.Add(flowLayoutPanel);
                    dropdowns[dropdown].Padding = new Padding(10);
                    //dropdowns[dropdown].VerticalScroll.Enabled = false;
                }

            }
        }

        // flows yung mga item
        // selIndex yung 0,1,2 ng dropdown
        // flowindex yung index ng item sa flow


        private void ChoiceMade(string txt, int selIndex, int flowIndex)
        {
            selColors[selIndex] = flowIndex.ToString();
            foreach (FlowLayoutPanel a in flows[selIndex])
            {
                a.BackColor = Color.Transparent;
            }
            sels[selIndex] = txt;

            if (selColors[selIndex] != "")
            {
                flows[selIndex][flowIndex].BackColor = Color.Blue;
            }

            MessageBox.Show(flowIndex.ToString());

        }

        private void customization1_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            dropdown1.Padding = new Padding(0, 0, 0, 0);
            dropdown2.Padding = new Padding(0, 0, 0, 0);
            dropdown3.Padding = new Padding(0, 0, 0, 0);




            flows[0].Clear();
            flows[1].Clear();
            flows[2].Clear();

            LoadMenu(arrayFirst, "menu", 0, ref sel1);

            if (selColors[0] != "")
            {
                flows[0][Convert.ToInt32(selColors[0])].BackColor = Color.Blue;
            }
        }
        private void customization2_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            dropdown1.Padding = new Padding(0, 0, 0, 0);
            dropdown2.Padding = new Padding(0, 0, 0, 0);
            dropdown3.Padding = new Padding(0, 0, 0, 0);

            flows[0].Clear();
            flows[1].Clear();
            flows[2].Clear();


            LoadMenu(arraySecond, "menu", 1, ref sel2);

            if (selColors[1] != "")
            {
                flows[1][Convert.ToInt32(selColors[1])].BackColor = Color.Blue;
            }
        }
        private void customization3_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            dropdown1.Padding = new Padding(0, 0, 0, 0);
            dropdown2.Padding = new Padding(0, 0, 0, 0);
            dropdown3.Padding = new Padding(0, 0, 0, 0);

            flows[0].Clear();
            flows[1].Clear();
            flows[2].Clear();


            LoadMenu(arrayThird, "menu", 2, ref sel3);

            if (selColors[2] != "")
            {
                flows[2][Convert.ToInt32(selColors[2])].BackColor = Color.Blue;
            }
        }

        private void customization1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customText1_Click(object sender, EventArgs e)
        {

        }
        private void add_Click(object sender, EventArgs e)
        {
            quantity++;
            showNum();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
                showNum();
            }
        }
        private void showNum()
        {
            Iterator.Text = quantity.ToString();
        }
    }
}