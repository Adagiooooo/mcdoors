using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.Food;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public string eatText;
        public string paymentMethod;
        public Form3 form3instance;
        Form6 form6Instance = Form6.GetInstance();
        public static string Foldername { get; set; }
        int foodSelection = 0;
        private Timer timer;
        private string picTake;

        Dictionary<string, double> mcsharebox = new Dictionary<string, double>
        {
            { "McShareBundle for 3", 500 },
            { "McShareBundle for 4", 900},
            { "6pc Chicken McShareBox", 500 },
            { "8pc Chicken McShareBox", 700 },
            { "BFF ShakeShake & McFloat", 300 },
            // Add more properties as needed
        };
        Dictionary<string, double> burgers = new Dictionary<string, double>
        {
            { "Double Crispy Fish Fillet Sandwich", 0.0 },
            { "Crispy Fish Fillet Sandwich", 0.0 },
            { "Big Mac", 0.0 },
            { "Double Quarter Pounder with Cheese", 0.0 },
          //  { "Quarter Pounder with Cheese, Lettuce, and Tomatoes", 0.0 },
            { "Quarter Pounder with Cheese", 0.0 },
            { "Triple Cheeseburger", 0.0 },
            { "Double Cheeseburger", 0.0 },
            { "McChicken", 0.0 },
          //  { "Cheeseburger with Lettuce & Tomatoes", 0.0 },
            { "Cheeseburger", 0.0 },
            //{ "Crispy Chicken Sandwich with Lettuce & Tomatoes", 0.0 },
            { "Crispy Chicken Sandwich", 0.0 },
          //  { "Burger McDo with Lettuce & Tomatoes", 0.0 },
            { "Burger Mcdo", 0.0 }
        };

        Dictionary<string, double> chickens = new Dictionary<string, double>
        {
            { "1pc Chicken McDo Meal", 0.0 },
            { "2pc Chicken McDo Meal", 0.0 },
            { "1pc Spicy Chicken McDo Meal", 0.0 },
            { "2pc Spicy Chicken McDo Meal", 0.0 },
            { "McCrispy Chicken Fillet", 0.0 },
            { "McCrispy Chicken Fillet Ala King", 0.0 },
            { "6pc Chicken McNuggets", 0.0 }
        };

        Dictionary<string, double> spaghettis = new Dictionary<string, double>
        {
            { "Chicken Spaghetti", 0.0 },
            { "McSpaghetti Solo", 0.0 }
        };

        Dictionary<string, double> ricebowls = new Dictionary<string, double>
        {
            { "1pc Mushroom PepperSteak w/ Egg", 0.0 },
            { "2pc Mushroom PepperSteak w/ Egg", 0.0 }
        };

        Dictionary<string, double> dessertsNdrinks = new Dictionary<string, double>
        {
            { "McFlurry w/ Oreo", 0.0 },
            { "Hot Fudge Sundae", 0.0 },
            { "Hot Caramel Sundae", 0.0 },
            { "Apple Pie", 0.0 },
            { "Coke McFloat", 0.0 },
            { "Coke", 0.0 },
            { "Coke Zero", 0.0 },
            { "Sprite", 0.0 },
            { "Orange Juice", 0.0 },
            { "Iced Tea", 0.0 },
            { "Apple Juice", 0.0 }
        };

        Dictionary<string, double> mccafes = new Dictionary<string, double>
        {
            { "McCafe Premium Roast Coffee", 0.0 },
            { "McCafe Coffee Float", 0.0 },
            { "McCafe Iced Coffee", 0.0 },
            { "McCafe  Iced Coffee Chocolate", 0.0 },
          //  { "Cappuccino", 0.0 },
           // { "Espresso", 0.0 },
           // { "Macchiato", 0.0 },
           // { "Americano", 0.0 },
          //  { "Mochaccino", 0.0 },
            { "Cafe Latte", 0.0 }
        };

        Dictionary<string, double> friesNextras = new Dictionary<string, double>
        {
            { "BFF Fries", 0.0 },
            { "Fries", 0.0 },
            { "Shake Shake Fries", 0.0 }
        };

        Dictionary<string, double> happymeals = new Dictionary<string, double>
        {
            { "1pc Chicken Mcdo Happy Meal", 0.0 },
            { "4pc Chicken McNuggets Happy Meal", 0.0 },
            { "McSpaghetti Happy Meal", 0.0 },
            { "BurgerMcDo Happy Meal", 0.0 }
        };






        Dictionary<string, double>[] foodDictionary;

        public Form3(string pic)
        {
            picTake = pic;
            InitializeComponent();
            Form form3instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            Methods.MatchParentWidth(panel1);
            Methods.MatchParentWidth(tableLayoutPanel1);
            flowLayoutPanel2.HorizontalScroll.Enabled = false;
            flowLayoutPanel2.HorizontalScroll.Visible = false;

            flowLayoutPanel1.VerticalScroll.Visible = false;

            foodDictionary = new Dictionary<string, double>[]
            {
                mcsharebox,burgers,chickens,spaghettis,ricebowls,dessertsNdrinks,mccafes,friesNextras,happymeals
            };



            PictureBox[] pictureBoxes = new PictureBox[4];


            string[] menus = { "McShareBox", "Burger", "Chicken", "Spaghetti", "Rice Bowls", "Desserts & Drinks", "McCafe", "Fries & Extras", "Happy Meal", };
            for (int i = 0; i < menus.Length; i++)
            {
                int index = i;
                // Create a FlowLayoutPanel for each iteration
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.WrapContents = false; // Optional
                flowLayoutPanel.AutoSize = true;
                Methods.MatchParentWidth(flowLayoutPanel);

                // Create a PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu" + (i + 1) + ".jpg"));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                Methods.FlowMargin(pictureBox);
                //  pictureBox.BackColor = Color.Red;

                // Create a Label
                Label label = new Label();
                label.Text = menus[i]; // Unique label text for each iteration
                Methods.FlowMargin(label);
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                //label.BackColor = Color.Blue;

                //pictureBox.Click += (sender, e) => selectionClicked(index);
                //label.Click += (sender, e) => selectionClicked(index);

                // Add PictureBox and Label to FlowLayoutPanel
                flowLayoutPanel.Controls.Add(pictureBox);
                flowLayoutPanel.Controls.Add(label);

                flowLayoutPanel.Click += (sender, e) => SelectionClicked(index);
                Methods.InheritEvent(flowLayoutPanel, (sender, e) => SelectionClicked(index));

                // Add FlowLayoutPanel to the parent FlowLayoutPanel (flowLayoutPanel2)
                flowLayoutPanel2.Controls.Add(flowLayoutPanel);
            }

            Methods.ShowAds(panel1);

            flowLayoutPanel3.HorizontalScroll.Enabled = false;
            flowLayoutPanel3.HorizontalScroll.Visible = false;

            timer = new Timer();

            // Set the interval to 1000 milliseconds (1 second)
            timer.Interval = 1000;

            // Subscribe to the Tick event
            timer.Tick += UpdateText;

            // Start the timer
            timer.Start();
            


            // label1.Text = "My Order - " + eatText;

        }

        private void LoadMenu(Dictionary<string, double> menu, string imageName)
        {
            int counter = 0;
            for (int i = 0; i < menu.Count; i++)
            {
                FlowLayoutPanel flowLayoutPanelB = new FlowLayoutPanel();
                flowLayoutPanelB.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanelB.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanelB.WrapContents = false; // Optional
                flowLayoutPanelB.AutoSize = true;
                Methods.MatchParentWidth(flowLayoutPanelB);
                //flowLayoutPanelB.BackColor = Color.Blue;
                for (int j = 0; j < 3; j++)
                {
                    if (counter < menu.Count)
                    {
                        int local = counter;
                        int index = i;
                        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                        flowLayoutPanel.Dock = DockStyle.None; // Dock to fill the available space
                        flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                        flowLayoutPanel.WrapContents = false; // Optional
                        flowLayoutPanel.AutoSize = true;

                        PictureBox pictureBox = new PictureBox();
                        string imagePath = Path.Combine(Application.StartupPath, imageName, imageName + (counter + 1) + ".png");

                        pictureBox.Image = Image.FromFile(imagePath);

                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 125;
                        pictureBox.Height = 125;
                        // pictureBox.BackColor = Color.Red;
                        pictureBox.Margin = new Padding(20);
                        //pictureBox.Margin = new Padding(25, 20, 20, 20);
                        //pictureBox.BackColor = Color.Red;
                        Label label = new Label();
                        string menuItemName = menu.ElementAt(counter).Key;
                        label.Text = menuItemName; // Unique label text for each iteration
                        Methods.MatchParentWidth(label);
                        label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        label.AutoSize = false;
                        label.Width = 150;
                        label.Height = 50;
                        Methods.MatchParentWidth(label);
                        label.AutoEllipsis = false;
                        // label.BackColor = Color.Blue;

                        //flowLayoutPanel.Click += (sender, e) => FoodClicked(index);
                        // Methods.InheritEvent(flowLayoutPanel, (sender, e) => FoodClicked(index));

                        flowLayoutPanel.Controls.Add(pictureBox);
                        flowLayoutPanel.Controls.Add(label);


                        //string imagePath = Path.Combine(Application.StartupPath, "pictures", "menu" + (/i +/1) + ".jpg").ToString();
                        flowLayoutPanel.Click += (sender, e) => FoodClicked(local, imagePath);
                        Methods.InheritEvent(flowLayoutPanel, (sender, e) => FoodClicked(local, imagePath));

                        flowLayoutPanelB.Controls.Add(flowLayoutPanel);
                        counter++;
                    }
                }
                flowLayoutPanel3.Controls.Add(flowLayoutPanelB);
            }
        }
        private void FoodClicked(int index, string img)
        {
            // Disable the main form
            this.Enabled = false;


            //  string returnValue;
            //
            // ORDER CREATION
            /* string itemName;
             double totalItemPrice;
             string firstAdditional;
             string secondAdditional;
             string thirdAdditional;
             string imageLink;*/
            //

            // Create and show the pop-up form
            using (var popupForm = new Form5(form6Instance))
            {

                // MessageBox.Show("index at:" + index.ToString());
                popupForm.FoodName = foodDictionary[foodSelection].ElementAt(index).Key;
                popupForm.ImagePath = img;
                popupForm.Prices = foodDictionary[foodSelection].ElementAt(index).Value;

                popupForm.quantity = 1;
                popupForm.foodSelection = foodSelection;
                popupForm.foodIndex = index;

                popupForm.editOrder = false;

                //MessageBox.Show(foodArrays[foodSelection][index]);
                // MessageBox.Show(img);
                popupForm.ShowDialog();

                //popupForm.FoodName = foodArrays[foodSelection][index];
                //popupForm.ImagePath = img;
                // returnValue = popupForm.ReturnValue;

                /*  itemName = popupForm.itemName;
                  totalItemPrice = popupForm.totalItemPrice;
                  firstAdditional = popupForm.firstAdditional;
                  secondAdditional = popupForm.secondAdditional;
                  thirdAdditional = popupForm.thirdAdditional;
                  form6Instance.AddFood(popupForm.itemName, popupForm.totalItemPrice, popupForm.firstAdditional,
                      popupForm.secondAdditional, popupForm.thirdAdditional, imageLink = popupForm.imageLink, popupForm.qty,
                      popupForm.foodSelection, popupForm.foodIndex);
                */

            }

            // Re-enable the main form after the pop-up form is closed
            this.Enabled = true;
            //label2.Text = form6Instance.toPay.ToString("PHP #,###.00");
            //label3.Text = "Items: " + form6Instance.TotalItems.ToString();
            //UpdateText();

        }
        public void UpdateText(object sender, EventArgs e)
        {
            form6Instance.CalcTotalItems();
            label2.Text = form6Instance.toPay.ToString("PHP #,##0.00");
            label3.Text = "Items: " + form6Instance.TotalItems.ToString();
        }

        private void SelectionClicked(int selection)
        {
            flowLayoutPanel3.Controls.Clear();
            foodSelection = selection;
            switch (selection)
            {
                case 0:
                    LoadMenu(mcsharebox, "mcsharebox");
                    Foldername = "mcsharebox";
                    break;
                case 1:
                    LoadMenu(burgers, "burger");
                    Foldername = "burger";
                    break;
                case 2:
                    LoadMenu(chickens, "chicken");
                    Foldername = "chicken";
                    break;
                case 3:
                    LoadMenu(spaghettis, "spaghetti");
                    Foldername = "spaghetti";
                    break;
                case 4:
                    LoadMenu(ricebowls, "ricebowl");
                    Foldername = "ricebowl";
                    break;
                case 5:
                    LoadMenu(dessertsNdrinks, "dessertNdrinks");
                    Foldername = "dessertNdrinks";
                    break;
                case 6:
                    LoadMenu(mccafes, "coffee");
                    Foldername = "coffee";
                    break;
                case 7:
                    LoadMenu(friesNextras, "friesNextras");
                    Foldername = "friesNextras";
                    break;
                case 8:
                    LoadMenu(happymeals, "happymeal");
                    Foldername = "happymeal";
                    break;
            }
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
            //UpdateText();
            label1.Text = "My Order - " + eatText;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form8 form8 = new Form8(picTake);
            form8.FormClosed += (s, args) => this.Close();
            form8.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (form6Instance != null)
            {
                form6Instance.datapass(picTake);
                form6Instance.Show();
            }
            else
            {
                Form6 form6Instance = Form6.GetInstance();
                form6Instance.datapass(picTake);
                form6Instance.Show();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}