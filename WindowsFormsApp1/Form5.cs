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
        Dictionary<string, Dictionary<string, Tuple<string[], Tuple<double, string>[]>>>[] foodDictionary;
        Control[] dropdowns;
        Label[] customLabels;

        /* class FoodData
         {
            // public decimal[] Prices { get; set; }
             public string[] Sizes { get; set; }
         }*/

        public Form5()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaximizeBox = false;
            Methods.ShowAds(panel1);
            Methods.MatchParentWidth(panel2);
           // pictureBox1.BackColor = Color.Red;
            customization1.BackColor = Color.Blue;
            customization2.BackColor = Color.Blue;
            customization3.BackColor = Color.Blue;
            dropdown1.BackColor = Color.Green;
            dropdown2.BackColor = Color.Green;
            dropdown3.BackColor = Color.Green;
            // Methods.ApplyCircularBorder(label4);

            //MessageBox.Show(FoodName);
            //MessageBox.Show(ImagePath);

            //label2.Text = FoodName;
            //pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", ImagePath + "1.jpg"));

            /* PictureBox pictureBox = new PictureBox();
             pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu1" + ".jpg"));
             pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
             pictureBox.Width = 100;
             pictureBox.Height = 100;
             Methods.FlowMargin(pictureBox);

             dropdown2.Controls.Add(pictureBox);
            */

            ///////////////////////////////////////////////////////
            ///// VALUES

            /**Dictionary<string, Dictionary<string, string[]>> mcsharebox = new Dictionary<string, Dictionary<string, string[]>>()
{
    { "McShareBundle for 3", new Dictionary<string, string[]>() },
    { "McShareBundle for 4", new Dictionary<string, string[]>() },
    { "6pc Chicken McShareBox", new Dictionary<string, string[]>() },
    { "8pc Chicken McShareBox", new Dictionary<string, string[]>() },
    { "BFF ShakeShake & McFloat", new Dictionary<string, string[]>() }
};

            mcsharebox["McShareBundle for 3"].Add("Chicken", new string[] { "Original", "Spicy" });
            mcsharebox["McShareBundle for 3"].Add("Drinks", new string[] { "Coke", "Coke Float", "Sprite", "Orange Juice" });
            mcsharebox["McShareBundle for 3"].Add("Sides", new string[] { "Fries", "Burger", "Extra Rice" });

            mcsharebox["McShareBundle for 4"].Add("Chicken", new string[] { "Original", "Spicy" });
            mcsharebox["McShareBundle for 4"].Add("Drinks", new string[] { "Coke", "Coke Float", "Sprite", "Orange Juice" });
            mcsharebox["McShareBundle for 4"].Add("Sides", new string[] { "Fries", "Burger", "Extra Rice" });

            mcsharebox["6pc Chicken McShareBox"].Add("Chicken", new string[] { "Original", "Spicy" });
            mcsharebox["6pc Chicken McShareBox"].Add("Drinks", new string[] { "Coke", "Coke Float", "Sprite", "Orange Juice" });
            mcsharebox["6pc Chicken McShareBox"].Add("Sides", new string[] { "Fries", "Burger", "Extra Rice" });

            mcsharebox["8pc Chicken McShareBox"].Add("Chicken", new string[] { "Original", "Spicy" });
            mcsharebox["8pc Chicken McShareBox"].Add("Drinks", new string[] { "Coke", "Coke Float", "Sprite", "Orange Juice" });
            mcsharebox["8pc Chicken McShareBox"].Add("Sides", new string[] { "Fries", "Burger", "Extra Rice" });

            mcsharebox["BFF ShakeShake & McFloat"].Add("Flavor", new string[] { "Cheese", "BBQ" });

            **/
            //new Dictionary string, string , string
            Dictionary<string, Dictionary<string, Tuple<string[], Tuple<double, string>[]>>> mcsharebox = new Dictionary<string, Dictionary<string, Tuple<string[], Tuple<double, string>[]>>>()
{
             //McShareBundle3
    { "McShareBundle for 3", new Dictionary<string, Tuple<string[], Tuple<double, string>[]>>()
        {
            { "Chicken", Tuple.Create(new string[] { "Original", "Spicy" }, new Tuple<double, string>[]
                {
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image")
                })
            }, 
            { "Drinks", Tuple.Create(new string[] { "Coke", "Coke Zero", "Coke Float", "Orange Juice" }, new Tuple<double, string>[]
                {
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image")
                })
            },
            { "Sides", Tuple.Create(new string[] { "Fries", "Burger", "Extra Rice" }, new Tuple<double, string>[]
                {
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image")
                })
            }
        }
    },
           //McShareBundle4
    { "McShareBundle for 4", new Dictionary<string, Tuple<string[], Tuple<double, string>[]>>()
        {
            { "Chicken", Tuple.Create(new string[] { "Original", "Spicy" }, new Tuple<double, string>[]
                {
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image")
                })
            },
            { "Drinks", Tuple.Create(new string[] { "Coke", "Coke Zero", "Coke Float", "Orange Juice" }, new Tuple<double, string>[]
                {
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image")
                })
            },
            { "Sides", Tuple.Create(new string[] { "Fries", "Burger", "Extra Rice" }, new Tuple<double, string>[]
                {
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image"),
                    Tuple.Create(0.00, "image")
                })
            }
        }
    },
            //6pc Chicken McShareBox

    { "6pc Chicken McShareBox", new Dictionary<string, Tuple<string[], Tuple<double, string>[]>>()
    {
        { "Chicken", Tuple.Create(new string[] { "Original", "Spicy" }, new Tuple<double, string>[]
            {
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image")
            })
        },
        { "Drinks", Tuple.Create(new string[] { "Coke", "Coke Zero", "Coke Float", "Orange Juice" }, new Tuple<double, string>[]
            {
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image"),

                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image")
            })
        },
        { "Sides", Tuple.Create(new string[] { "Fries", "Burger", "Extra Rice" }, new Tuple<double, string>[]
            {
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image")
            })
        }
    }
},
        //8piece Chicken box
    { "8pc Chicken McShareBox", new Dictionary<string, Tuple<string[], Tuple<double, string>[]>>()
    {
        { "Chicken", Tuple.Create(new string[] { "Original", "Spicy" }, new Tuple<double, string>[]
            {
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image")
            })
        },
        { "Drinks", Tuple.Create(new string[] { "Coke", "Coke Zero", "Coke Float", "Orange Juice" }, new Tuple<double, string>[]
            {
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image"),

                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image")
            })
        },
        { "Sides", Tuple.Create(new string[] { "Fries", "Burger", "Extra Rice" }, new Tuple<double, string>[]
            {
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image")
            })
        }
    }
},
            //BFF Fries
    { "BFF ShakeShake & McFloat", new Dictionary<string, Tuple<string[], Tuple<double, string>[]>>()
    {
        { "Flavors", Tuple.Create(new string[] { "Cheese", "BBQ" }, new Tuple<double, string>[]
            {
                Tuple.Create(0.00, "image"),
                Tuple.Create(0.00, "image")
            })
        }
        
    }
}

};



            Dictionary<string, Dictionary<string, string[]>> burgers = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "Double Crispy Fish Fillet Sandwich", new Dictionary<string, string[]>() },
                { "Crispy Fish Fillet Sandwich", new Dictionary<string, string[]>() },
                { "Big Mac", new Dictionary<string, string[]>() },
                { "Double Quarter Pounder with Cheese", new Dictionary<string, string[]>() },
              //  { "Quarter Pounder with Cheese, Lettuce, and Tomatoes", new Dictionary<string, string[]>() },
                { "Quarter Pounder with Cheese", new Dictionary<string, string[]>() },
                { "Triple Cheeseburger", new Dictionary<string, string[]>() },
                { "Double Cheeseburger", new Dictionary<string, string[]>() },
                { "McChicken", new Dictionary<string, string[]>() },
             //   { "Cheeseburger with Lettuce & Tomatoes", new Dictionary<string, string[]>() },
                { "Cheeseburger", new Dictionary<string, string[]>() },
               // { "Crispy Chicken Sandwich with Lettuce & Tomatoes", new Dictionary<string, string[]>() },
                { "Crispy Chicken Sandwich", new Dictionary<string, string[]>() },
               // { "Burger McDo with Lettuce & Tomatoes", new Dictionary<string, string[]>() },
                { "Burger Mcdo", new Dictionary<string, string[]>() }
            };

            Dictionary<string, Dictionary<string, string[]>> chickens = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "1pc Chicken McDo Meal", new Dictionary<string, string[]>() },
                { "2pc Chicken McDo Meal", new Dictionary<string, string[]>() },
                { "1pc Spicy Chicken McDo Meal", new Dictionary<string, string[]>() },
                { "2pc Spicy Chicken McDo Meal", new Dictionary<string, string[]>() },
                { "McCrispy Chicken Fillet", new Dictionary<string, string[]>() },
                { "McCrispy Chicken Fillet Ala King", new Dictionary<string, string[]>() },
                { "6 Pc Chicken McNuggets", new Dictionary<string, string[]>() }
            };

            Dictionary<string, Dictionary<string, string[]>> spaghettis = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "Chicken Spaghetti", new Dictionary<string, string[]>() },
                { "McSpaghetti Solo", new Dictionary<string, string[]>() }
            };

            Dictionary<string, Dictionary<string, string[]>> ricebowls = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "1pc Mushroom PepperSteak w/ Egg", new Dictionary<string, string[]>() },
                { "2pc Mushroom PepperSteak w/ Egg", new Dictionary<string, string[]>() }
            };

            Dictionary<string, Dictionary<string, string[]>> dessertsNdrinks = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "McFlurry w/ Oreo", new Dictionary<string, string[]>() },
                { "Hot Fudge Sundae", new Dictionary<string, string[]>() },
                { "Hot Caramel Sundae", new Dictionary<string, string[]>() },
                { "Apple Pie", new Dictionary<string, string[]>() },
                { "Coke McFloat", new Dictionary<string, string[]>() },
                { "Coke", new Dictionary<string, string[]>() },
                { "Coke Zero", new Dictionary<string, string[]>() },
                { "Sprite", new Dictionary<string, string[]>() },
                { "Orange Juice", new Dictionary<string, string[]>() },
                { "Iced Tea", new Dictionary<string, string[]>() },
                { "Apple Juice", new Dictionary<string, string[]>() }
            };

            Dictionary<string, Dictionary<string, string[]>> mccafes = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "McCafe Premium Roast Coffee", new Dictionary<string, string[]>() },
                { "McCafe Coffee Float", new Dictionary<string, string[]>() },
                { "McCafe Icecd Coffee", new Dictionary<string, string[]>() },
                { "McCafe Strawberry Oreo Frappe", new Dictionary<string, string[]>() },
              //  { "Cappuccino", new Dictionary<string, string[]>() },
              //  { "Espresso", new Dictionary<string, string[]>() },
               // { "Macchiato", new Dictionary<string, string[]>() },
               // { "Americano", new Dictionary<string, string[]>() },
               // { "Mochaccino", new Dictionary<string, string[]>() },
                { "Cafe Latte", new Dictionary<string, string[]>() }
            };

            Dictionary<string, Dictionary<string, string[]>> friesNextras = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "BFF Fries", new Dictionary<string, string[]>() },
                { "Fries", new Dictionary<string, string[]>() },
                { "Shake Shake Fries", new Dictionary<string, string[]>() }
            };

            Dictionary<string, Dictionary<string, string[]>> happymeals = new Dictionary<string, Dictionary<string, string[]>>()
            {
                { "1pc Chicken Mcdo Happy Meal", new Dictionary<string, string[]>() },
                { "4pc Chicken McNuggets Happy Meal", new Dictionary<string, string[]>() },
                { "McSpaghetti Happy Meal", new Dictionary<string, string[]>() },
                { "BurgerMcDo Happy Meal", new Dictionary<string, string[]>() }
            };



            /*  Dictionary<string, double> burgers = new Dictionary<string, double>
          {
              { "Double Crispy Fish Fillet Sandwich", 0.0 },
              { "Crispy Fish Fillet Sandwich", 0.0 },
              { "Big Mac", 0.0 },
              { "Double Quarter Pounder with Cheese", 0.0 },
              { "Quarter Pounder with Cheese, Lettuce, and Tomatoes", 0.0 },
              { "Quarter Pounder with Cheese", 0.0 },
              { "Triple Cheeseburger", 0.0 },
              { "Double Cheeseburger", 0.0 },
              { "McChicken", 0.0 },
              { "Cheeseburger with Lettuce & Tomatoes", 0.0 },
              { "Cheeseburger", 0.0 },
              { "Crispy Chicken Sandwich with Lettuce & Tomatoes", 0.0 },
              { "Crispy Chicken Sandwich", 0.0 },
              { "Burger McDo with Lettuce & Tomatoes", 0.0 },
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
              { "Cappuccino", 0.0 },
              { "Espresso", 0.0 },
              { "Macchiato", 0.0 },
              { "Americano", 0.0 },
              { "Mochaccino", 0.0 },
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


            */
            //////////////////////////////////////////////////////////
            var doubleCrispyFishFillet = new Dictionary<string, string[]>
            {
                { "Size", new string[] { "Small", "Medium" , "Large"} },
                { "Drinks", new string[] { "Lettuce", "Tomato" } }
            };

            // Example: Attributes for Burger 2
            var crispyFishFillet = new Dictionary<string, string[]>
            {
                { "Size", new string[] { "Medium", "Large" } },
                { "Toppings", new string[] { "Onion", "Pickles" } }
            };

            Dictionary<string, Dictionary<string, Tuple<string[], Tuple<double, string>[]>>>[] foodDictionary = new Dictionary<string, Dictionary<string, Tuple<string[], Tuple<double, string>[]>>>[]
            {
                mcsharebox
                //burgers, chickens, spaghettis, ricebowls, dessertsNdrinks, mccafes, friesNextras, happymeals
            };





            dropdowns = new Control[] { dropdown1, dropdown2, dropdown3 };
            customLabels = new Label[] { customText1, customText2, customText3 };

            //LoadCustoms();
            //LoadCustoms(FoodName);
           /* if (foodDictionary[foodSelection].ContainsKey(FoodName))
            {
                var innerDictionary = foodDictionary[foodSelection][FoodName];
                foreach (var kvp in innerDictionary)
                {
                    string key = kvp.Key; // Inner dictionary key
                    string[] values = kvp.Value; // Inner dictionary value

                    // Now you can use 'key' and 'values' accordingly
                    MessageBox.Show($"Key: {key}, Values: {string.Join(", ", values)}");
                }
            }
            else
            {
                MessageBox.Show("not found");
            }*/

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = FoodName;
            label3.Text = Prices.ToString("PHP ###,###.00");
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", ImagePath + (/*i + */1) + ".jpg"));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            LoadCustoms();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            ReturnValue = "asdasdasdasd";
            this.Close(); // Close the pop-up form
        }

        private void LoadMenu(string[] menu, string imageName, int dropdown)
        {
            int counter = 0;
            for (int i = 0; i < menu.Length; i++)
            {
                FlowLayoutPanel flowLayoutPanelB = new FlowLayoutPanel();
                flowLayoutPanelB.Dock = DockStyle.None; // Dock to fill the available space
                flowLayoutPanelB.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanelB.WrapContents = false; // Optional
                flowLayoutPanelB.AutoSize = true;
                Methods.MatchParentWidth(flowLayoutPanelB);
                //flowLayoutPanelB.BackColor = Color.Blue;
                for (int j = 0; j < 5; j++)
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
                        pictureBox.Width = 75;
                        pictureBox.Height = 75;
                        // pictureBox.BackColor = Color.Red;
                        pictureBox.Margin = new Padding(20);
                        //pictureBox.BackColor = Color.Red;

                        Label label = new Label();
                        //string menuItemName = menu.ElementAt(counter).Key;
                        label.Text = menu[counter]; // Unique label text for each iteration
                        counter++;
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
                        //flowLayoutPanel.Click += (sender, e) => FoodClicked(index, imageName);
                        //Methods.InheritEvent(flowLayoutPanel, (sender, e) => FoodClicked(index, imageName));

                        flowLayoutPanelB.Controls.Add(flowLayoutPanel);
                    }
                }
                dropdowns[dropdown].Controls.Add(flowLayoutPanelB);
            }
        }
        // foodDictionary[foodSelection].ElementAt(index).Value;

        private void LoadCustoms()
        {
            var selected = foodDictionary[foodSelection][FoodName];
            // MessageBox.Show("Food name:"+FoodName);
            int iteration = 0;
            foreach (var kvp in selected)
            {
                string attribute = kvp.Key; // Key of the key-value pair

                string[] values = kvp.Value; // Value of the key-value pair

                customLabels[iteration].Text = attribute;
                // MessageBox.Show(attribute);
                /**string asdf = "";
                foreach (string val in /values)
                {
                    asdf += val + ",";
                }**/
                //MessageBox.Show(asdf);
                iteration++;
                // Now you can use 'attribute' and 'values' accordingly
                // For example, you can add them to dropdown controls
            }
        }

        private void customization1_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            var selected = foodDictionary[foodSelection][FoodName];
            //var selected = foodDictionary[foodSelection][FoodName]
            int iteration = 0;
            foreach (var kvp in selected)
            {
                if (iteration == 0)
                {
                    string attribute = kvp.Key;
                    string[] values = kvp.Value;

                    LoadMenu(values, "menu", 0);
                }

                iteration++;

            }

        }
        private void customization2_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            var selected = foodDictionary[foodSelection][FoodName];
            //var selected = foodDictionary[foodSelection][FoodName]
            int iteration = 0;
            foreach (var kvp in selected)
            {
                if (iteration == 1)
                {
                    string attribute = kvp.Key;
                    string[] values = kvp.Value;

                    LoadMenu(values, "menu", 1);
                }

                iteration++;

            }
        }
        private void customization3_click(object sender, EventArgs e)
        {
            dropdown1.Controls.Clear();
            dropdown2.Controls.Clear();
            dropdown3.Controls.Clear();

            var selected = foodDictionary[foodSelection][FoodName];
            //var selected = foodDictionary[foodSelection][FoodName]
            int iteration = 0;
            foreach (var kvp in selected)
            {
                if (iteration == 2)
                {
                    string attribute = kvp.Key;
                    string[] values = kvp.Value;

                    LoadMenu(values, "menu", 2);
                }

                iteration++;

            }
        }



        private void customization1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
