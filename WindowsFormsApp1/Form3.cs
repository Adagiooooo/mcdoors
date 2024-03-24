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
        int foodSelection = 0;

        Dictionary<string, double> mcsharebox = new Dictionary<string, double>
        {
            { "McShareBundle for 3", 500 },
            { "McShareBundle for 4", 900.00},
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
            { "6 Pc Chicken McNuggets", 0.0 }
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
            { "McCafe Icecd Coffee", 0.0 },
            { "McCafe Strawberry Oreo Frappe", 0.0 },
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





        /*public string[] mcsharebox =
{
                     "McShareBundle for 3",
                     "McShareBundle for 4",
                     "6pc Chicken McShareBox",
                     "8pc Chicken McShareBox",
                     "BFF ShakeShake & McFloat",
                };
        public string[] burgers =
{
                     "Double Crispy Fish Fillet Sandwich",
                     "Crispy Fish Fillet Sandwich",
                     "Big Mac",
                     "Double Quarter Pounder with Cheese",
                     "Quarter Pounder with Cheese, Lettuce, and Tomatoes",
                     "Quarter Pounder with Cheese",
                    "Triple Cheeseburger",
                     "Double Cheeseburger",
                     "McChicken",
                     "Cheeseburger with Lettuce & Tomatoes",
                     "Cheeseburger",
                     "Crispy Chicken Sandwich with Lettuce & Tomatoes",
                    "Crispy Chicken Sandwich",
                     "Burger McDo with Lettuce & Tomatoes",
                     "Burger Mcdo",
                };
        public string[] chickens =
        {
                     "1pc Chicken McDo Meal",
                     "2pc Chicken McDo Meal",
                     "1pc Spicy Chicken McDo Meal",
                     "2pc Spicy Chicken McDo Meal",
                     "McCrispy Chicken Fillet",
                     "McCrispy Chicken Fillet Ala King",
                     "6 Pc Chicken McNuggets",
                };
        public string[] spaghettis =
        {
                     "Chicken Spaghetti",
                     "McSpaghetti Solo",
        };
        public string[] ricebowls =
        {
                     "1pc Mushroom PepperSteak w/ Egg",
                     "2pc Mushroom PepperSteak w/ Egg",
                };
        public string[] dessertsNdrinks =
{
                     "McFlurry w/ Oreo",
                     "Hot Fudge Sundae",
                     "Hot Caramel Sundae",
                     "Apple Pie",
                     "Coke McFloat",
                     "Coke",
                     "Coke Zero",
                    "Sprite",
                     "Orange Juice",
                     "Iced Tea",
                     "Apple Juice",
                };
        public string[] mccafes =
{
                     "McCafe Premium Roast Coffee",
                     "McCafe Coffee Float",
                     "McCafe Icecd Coffee",
                     "McCafe Strawberry Oreo Frappe",
                     "Cappuccino",
                     "Espresso",
                     "Macchiato",
                    "Americano",
                     "Mochaccino",
                     "Cafe Latte",
                };
        public string[] friesNextras =
{
                     "BFF Fries",
                     "Fries",
                     "Shake Shake Fries",
                };
        public string[] happymeals =
{
                     "1pc Chicken Mcdo Happy Meal",
                     "4pc Chicken McNuggets Happy Meal",
                     "McSpaghetti Happy Meal",
                     "BurgerMcDo Happy Meal",
                };*/
        //public string[][] foodArrays;
        Dictionary<string, double>[] foodDictionary;

        public Form3()
        {
            InitializeComponent();
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

            //foodArrays = new string[][]
            //{
            //    /*mcsharebox,*/burgers,chickens,spaghettis,ricebowls,dessertsNdrinks,mccafes,friesNextras,happymeals
            //};

            PictureBox[] pictureBoxes = new PictureBox[4];

            /* Style.MatchParentWidth(panel2);
             Style.MatchParentWidth(panel3);
             Style.MatchParentWidth(panel4);
             Style.MatchParentWidth(panel5);
             Style.MatchParentWidth(panel6);*/
            string[] menus = { "McShareBox", "Burger", "Chicken","Spaghetti", "Rice Bowls", "Desserts & Drinks", "McCafe", "Fries & Extras", "Happy Meal", };
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
            //////////////////////////////////ads/////////////
           /* int currentIndex = 0;

            panel1.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "ads", $"ad{currentIndex + 1}.jpg"));
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            currentIndex++;


            Timer timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += (sender, e) =>
            {
                panel1.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "ads", $"ad{currentIndex + 1}.jpg"));
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
                currentIndex = (currentIndex + 1) % 4;
            };
            timer.Start();*/
            //////////////////////////////////////////////////////////////////

            ///
            //flowLayoutPanel3.Margin = new Padding(10);
            flowLayoutPanel3.HorizontalScroll.Enabled = false;
            flowLayoutPanel3.HorizontalScroll.Visible = false;





        }
        /*private void LoadMenu(string[] menu, string imageName)*/
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
                        pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", imageName + (/*i + */1) + ".jpg"));

                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 125;
                        pictureBox.Height = 125;
                        // pictureBox.BackColor = Color.Red;
                        pictureBox.Margin = new Padding(20);
                        //pictureBox.BackColor = Color.Red;

                        Label label = new Label();
                        string menuItemName = menu.ElementAt(counter).Key;
                        label.Text = menuItemName; // Unique label text for each iteration
                        Methods.MatchParentWidth(label);                       
                        label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        label.AutoSize = false;
                        label.AutoEllipsis = true;
                        // label.BackColor = Color.Blue;

                        //flowLayoutPanel.Click += (sender, e) => FoodClicked(index);
                       // Methods.InheritEvent(flowLayoutPanel, (sender, e) => FoodClicked(index));

                        flowLayoutPanel.Controls.Add(pictureBox);
                        flowLayoutPanel.Controls.Add(label);


                        //string imagePath = Path.Combine(Application.StartupPath, "pictures", "menu" + (/*i + */1) + ".jpg").ToString();
                        flowLayoutPanel.Click += (sender, e) => FoodClicked(local, imageName);
                        Methods.InheritEvent(flowLayoutPanel, (sender, e) => FoodClicked(local, imageName));

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
            
            
            string returnValue;
            // Create and show the pop-up form
            using (var popupForm = new Form5())
            {
                //MessageBox.Show(foodSelection.ToString());
                //string menuItemName = foodDictionary[foodSelection].ElementAt(index).Key;
                //double menuItemPrice = foodDictionary[foodSelection].ElementAt(index).Value;
                MessageBox.Show("index at:" + index.ToString());
                popupForm.FoodName = foodDictionary[foodSelection].ElementAt(index).Key;
                popupForm.ImagePath = img;
                popupForm.Prices = foodDictionary[foodSelection].ElementAt(index).Value;

                popupForm.foodSelection = foodSelection;
                popupForm.foodIndex = index;

                //MessageBox.Show(foodArrays[foodSelection][index]);
                // MessageBox.Show(img);
                popupForm.ShowDialog();

                //popupForm.FoodName = foodArrays[foodSelection][index];
                //popupForm.ImagePath = img;
                returnValue = popupForm.ReturnValue;
            }

            // Re-enable the main form after the pop-up form is closed
            this.Enabled = true;
        }
        private void SelectionClicked(int selection)
        {
            flowLayoutPanel3.Controls.Clear();
            foodSelection = selection;
            switch (selection)
            {
                case 0:
                    LoadMenu(mcsharebox, "menu");
                    break;
                case 1:
                    LoadMenu(burgers, "menu");
                    break;
                case 2:
                    LoadMenu(chickens, "menu");
                    break;
                case 3:
                    LoadMenu(spaghettis, "menu");
                    break;
                case 4:
                    LoadMenu(ricebowls, "menu");
                    break;
                case 5:
                    LoadMenu(dessertsNdrinks, "menu");
                    break;
                case 6:
                    LoadMenu(mccafes, "menu");
                    break;
                case 7:
                    LoadMenu(friesNextras, "menu");
                    break;
                case 8:
                    LoadMenu(happymeals, "menu");
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

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
