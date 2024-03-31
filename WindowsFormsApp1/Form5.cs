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

        public double Prices { get; set; }
        public string[] Sizes { get; set; }
        public int foodSelection { get; set; }
        public int foodIndex { get; set; }
        Form6 form6;

        Control[] dropdowns;
        Label[] customLabels;

        string[] arrayFirst;
        string[] arraySecond;
        string[] arrayThird;
        string[][] arrays;
        public string sel1;
        public string sel2;
        public string sel3;
        string[] sels;

        public int quantity;
        
        string[] selColors;
        public bool editOrder;

        Label qtyLabel = new Label();

        public string itemName { get; private set; }
        public double totalItemPrice { get; private set; }
        public string firstAdditional { get; private set; }
        public string secondAdditional { get; private set; }
        public string thirdAdditional { get; private set; }
        public string imageLink { get; private set; }
        public int qty { get; private set; }

        public Form5(Form6 form6instance)
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            form6 = form6instance;
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

            arrays = new string[3][];
            arrays[0] = arrayFirst;
            arrays[1] = arraySecond;
            arrays[2] = arrayThird;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string folderName = Form3.Foldername.ToString();
            label2.Text = FoodName;
            label3.Text = Prices.ToString("PHP ###,##0.00");
            pictureBox1.Image = Image.FromFile(ImagePath);
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
                            arraySecond = new string[] { "Coke", "Sprite", "Coke Float"};
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

            ///////
            // bottom panel
            FlowLayoutPanel labelFlow2 = new FlowLayoutPanel();
            labelFlow2.AutoSize = true;
            Label labelMinus = new Label();
            Label labelPlus = new Label();

            Panel minusPanel = new Panel();
            Panel plusPanel = new Panel();
            Panel qtyPanel = new Panel();

            minusPanel.Controls.Add(labelMinus);
            plusPanel.Controls.Add(labelPlus);
            qtyPanel.Controls.Add(qtyLabel);

            labelMinus.Text = "-";
            labelMinus.TextAlign = ContentAlignment.MiddleCenter;
            minusPanel.Size = new Size(50, 50);
            labelMinus.Dock = DockStyle.Fill;
            labelMinus.Font = new Font(labelMinus.Font.FontFamily, 30); 

            labelPlus.Text = "+";
            labelPlus.TextAlign = ContentAlignment.MiddleCenter;
            plusPanel.Size = new Size(50, 50);
            labelPlus.Dock = DockStyle.Fill;
            labelPlus.Font = new Font(labelMinus.Font.FontFamily, 30); 

            qtyLabel.Text = quantity.ToString();
            qtyLabel.TextAlign = ContentAlignment.MiddleCenter;
            qtyPanel.Size = new Size(50, 50);
            qtyLabel.Dock = DockStyle.Fill;
            qtyLabel.Font = new Font(labelMinus.Font.FontFamily, 30);

            plusPanel.Click += add_Click;
            minusPanel.Click += subtract_Click;
            labelMinus.Click += subtract_Click;
            labelPlus.Click += add_Click;




            labelFlow2.Controls.Add(minusPanel);
            labelFlow2.Controls.Add(qtyPanel);
            labelFlow2.Controls.Add(plusPanel);
            labelFlow2.Height = 50;
            //labelFlow2.Margin = new Padding(50, 0, 0, 0);

            Methods.MatchParentWidth(panel4);
            panel4.Controls.Add(labelFlow2);
           // panel4.AutoSize = true;
            Methods.CenterSub(panel4);
            panel4.Margin = new Padding(15, 0, 0, 0);
            
            // add panel to center-===-----
            
            //panel4.BackColor = Color.Red;
            Methods.MatchParentWidth(panel4);
            // panel4.Margin = new Padding(0);
            //labelFlow2.Margin = new Padding(0);

            // Methods.CenterSub(panel4);
            //panel4.Height = 50;
            //Methods.MatchParentWidth(btnClose);
            Methods.InheritEvent(customization1, customization1_click);
            Methods.InheritEvent(customization2, customization2_click);
            Methods.InheritEvent(customization3, customization3_click);

            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (sels[0] != null && sels[1] != null && sels[2] != null)
            {
                itemName = FoodName;
                totalItemPrice = Prices;
                firstAdditional = customText1.Text + ": " + sels[0];
                secondAdditional = customText2.Text + ": " + sels[1];
                thirdAdditional = customText3.Text + ": " + sels[2];
                imageLink = ImagePath;
                qty = quantity;

                form6.AddFood(itemName, totalItemPrice, firstAdditional,
                   secondAdditional, thirdAdditional, imageLink = imageLink, qty,
                   foodSelection, foodIndex);


                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill up all fields", "Notification");
            }
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
                    flowLayoutPanel.Dock = DockStyle.None; 
                    flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                    flowLayoutPanel.WrapContents = false; 
                    flowLayoutPanel.AutoSize = true;

                    PictureBox pictureBox = new PictureBox();
                    if (dropdown == 0)
                    {
                        pictureBox.Image = Image.FromFile(ImagePath);
                    }
                    else
                    {
                        pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "form5", menu[counter] + ".png"));
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = 50;
                    pictureBox.Height = 50;
              
                    pictureBox.Margin = new Padding(20);
                    pictureBox.Margin = new Padding(27, 20, 20, 20);
              

                    Label label = new Label();
   
                    label.Text = menu[counter]; 

                    counter++;
                    Methods.MatchParentWidth(label);
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.AutoEllipsis = true;
        




                    flowLayoutPanel.Controls.Add(pictureBox);
                    flowLayoutPanel.Controls.Add(label);


                    Methods.FlowMargin(pictureBox);
                    Methods.FlowMargin(label);

                    flowLayoutPanel.Margin = new Padding(0, 0, 0, 10);
                    flows[dropdown].Add(flowLayoutPanel);
                    flowLayoutPanel.Click += (sender, e) => ChoiceMade(label.Text, dropdown, index, pictureBox.Image);
                    Methods.InheritEvent(flowLayoutPanel, (sender, e) => ChoiceMade(label.Text, dropdown, index, pictureBox.Image));
                    dropdowns[dropdown].Controls.Add(flowLayoutPanel);
                    dropdowns[dropdown].Padding = new Padding(10);
                }

            }
        }

        // flows yung mga item
        // selIndex yung 0,1,2 ng dropdown
        // flowindex yung index ng item sa flow

        private void ChoiceMade(string txt, int selIndex, int flowIndex, Image image)
        {
            PictureBox[] picboxes = { pictureBox2, pictureBox3, pictureBox4 };
            Label[] chs = { ch1, ch2, ch3 };
            picboxes[selIndex].Image = image;
            chs[selIndex].Text = txt;
           
            selColors[selIndex] = flowIndex.ToString();
            foreach (FlowLayoutPanel a in flows[selIndex])
            {
                a.BackColor = Color.Transparent;
                //a.ForeColor = Color.Black;
            }
            sels[selIndex] = txt;

            if (selColors[selIndex] != "")
            {
                flows[selIndex][flowIndex].BackColor = Color.LightGray;
                flows[selIndex][flowIndex].ForeColor = Color.Black;
            }


        }

        private void customization1_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();





            flows[0].Clear();
            flows[1].Clear();
            flows[2].Clear();

            LoadMenu(arrayFirst, "menu", 0, ref sel1);

            if (selColors[0] != "")
            {
                flows[0][Convert.ToInt32(selColors[0])].BackColor = Color.LightGray;
            }
        }
        private void customization2_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            flows[0].Clear();
            flows[1].Clear();
            flows[2].Clear();


            LoadMenu(arraySecond, "menu", 1, ref sel2);

            if (selColors[1] != "")
            {
                flows[1][Convert.ToInt32(selColors[1])].BackColor = Color.LightGray;
            }
        }
        private void customization3_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            flows[0].Clear();
            flows[1].Clear();
            flows[2].Clear();


            LoadMenu(arrayThird, "menu", 2, ref sel3);

            if (selColors[2] != "")
            {
                flows[2][Convert.ToInt32(selColors[2])].BackColor = Color.LightGray;
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
            if (quantity > 1)
            {
                quantity--;
                showNum();
            }
        }
        private void showNum()
        {
            qtyLabel.Text = quantity.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}