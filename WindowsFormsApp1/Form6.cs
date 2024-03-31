using System;
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

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        
        //Form3 form3instance = Form3.GetInstance();
        private static Form6 instance;
        public int TotalItems;
        public double toPay;
        public string picTake{ get; private set; }
        class Items {
            public string ItemName { get; set; }
            public double TotalPrice { get; set; }
            public string FirstAdd{ get; set; }
            public string SecondAdd { get; set; }
            public string ThirdAdd { get; set; }
            public string ImagePath { get; set; }
            public int ItemQuantity { get; set; }

            public int foodSelection { get; set; }
            public int index { get; set; }
        }

        List<Items> items = new List<Items>();
        public Form6(string pic)
        {
            picTake = pic;
            InitializeComponent();
            this.ControlBox = false;
            this.FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true; 
                }
            };
            Methods.CenterSub(panel1);
            Methods.MatchParentWidth(pictureBox1);
           // Methods.MatchParentWidth(flowLayoutPanel2);
            Methods.MatchParentWidth(panel3);
            Methods.CenterSub(panel3);
            panel3.Width += 5; 
            //Methods.MatchParentWidth()

        }

        public static Form6 GetInstance()
        {
            if (instance == null)
            {
                instance = new Form6("");
            }
            return instance;
        }
        public void AddFood(string itemName, double totalItemPrice, string firstAdditional,
            string secondAdditional, string thirdAdditional, string imageLink, int quantity, int selection, int index)
        {
            Items item = new Items();
            item.ItemName = itemName;
            item.TotalPrice = totalItemPrice;
            item.FirstAdd = firstAdditional;
            item.SecondAdd = secondAdditional;
            item.ThirdAdd = thirdAdditional;
            item.ImagePath = imageLink;
            item.ItemQuantity = quantity;
            item.foodSelection = selection;
            item.index= index;
            items.Add(item);

            MakePanel(item);
        }
        private void MakePanel(Items item)
        {
            PictureBox panelPictureBox = new PictureBox();
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            Label priceLabel = new Label();

            Label firstLabel = new Label();
            Label secondLabel = new Label();
            Label thirdLabel = new Label();

            Label totalLabel = new Label();

            panelPictureBox.Image = Image.FromFile(item.ImagePath);
            //panelPictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "pictures", "menu1" + ".jpg"));

            panelPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            panelPictureBox.Height = 75;
            panelPictureBox.Width = 75;


            nameLabel.Text = "(" + item.ItemQuantity + "x) " + item.ItemName;
            priceLabel.Text = "Base price: " + item.TotalPrice.ToString("PHP #,###.00");
            firstLabel.Text = item.FirstAdd;
            secondLabel.Text = item.SecondAdd;
            thirdLabel.Text = item.ThirdAdd;
            totalLabel.Text = (item.ItemQuantity * item.TotalPrice).ToString("PHP ###,##0.00");

            FlowLayoutPanel labelFlow = new FlowLayoutPanel();
           // labelFlow.AutoSize = true;
            //labelFlow.Margin = new Padding(0);


            labelFlow.Controls.Add(nameLabel);
           /* labelFlow.Controls.Add(priceLabel);
            labelFlow.Controls.Add(firstLabel);
            labelFlow.Controls.Add(secondLabel);
            labelFlow.Controls.Add(thirdLabel);
            labelFlow.FlowDirection = FlowDirection.TopDown;
           */

          /*  foreach (Control con in labelFlow.Controls)
            {
                con.Margin = new Padding(0,0,0,3);
                con.AutoSize = true;

            }
          */
            FlowLayoutPanel labelFlow2 = new FlowLayoutPanel();
            labelFlow2.AutoSize = true;
            Label labelMinus = new Label();
            Label labelPlus = new Label();
            Label qtyLabel = new Label();

            Panel minusPanel = new Panel();
            Panel plusPanel = new Panel();
            Panel qtyPanel = new Panel();

            Button minusButton = new Button();
            Button plusButton = new Button();

            minusButton.Text = "-";
            plusButton.Text = "+";

            

            minusPanel.Controls.Add(labelMinus);
            plusPanel.Controls.Add(labelPlus);
            
            qtyPanel.Controls.Add(qtyLabel);

            labelMinus.Text = "-";
            labelMinus.TextAlign = ContentAlignment.MiddleCenter;
            minusPanel.Size = new Size(50, 50);
            labelMinus.Dock = DockStyle.Fill;
            minusPanel.BackColor = Color.Red;
            labelMinus.Font = new Font(labelMinus.Font.FontFamily, 12); // Change the font size to 12

            labelPlus.Text = "+";
            labelPlus.TextAlign = ContentAlignment.MiddleCenter;
            plusPanel.Size = new Size(50, 50);
            labelPlus.Dock = DockStyle.Fill;
            plusPanel.BackColor = Color.Red;
            labelPlus.Font = new Font(labelMinus.Font.FontFamily, 12); // Change the font size to 12
           
            qtyLabel.Text = item.ItemQuantity.ToString();
            qtyLabel.TextAlign = ContentAlignment.MiddleCenter;
            qtyPanel.Size = new Size(50, 50);
            qtyLabel.Dock = DockStyle.Fill;
            qtyLabel.Font = new Font(labelMinus.Font.FontFamily, 12); // Change the font size to 12

            plusPanel.Margin = new Padding(0);
            minusPanel.Margin = new Padding(0);
            qtyPanel.Margin = new Padding(0);
            int q;
           /*  plusPanel.Click += (sender, e) =>
             {
                 q = add(item);
                 qtyLabel.Text = q.ToString();
             };
             minusPanel.Click += (sender, e) =>
             {
                 q = sub(item);
                 qtyLabel.Text = q.ToString();
             };
           */
            labelPlus.Click += (sender, e) =>
            {
                q = add(item);
                nameLabel.Text = "(" + q + "x) " + item.ItemName;
                totalLabel.Text = "Total: " + (q * item.TotalPrice).ToString();
                qtyLabel.Text = q.ToString();

            };
            labelMinus.Click += (sender, e) =>
            {
                q = sub(item);
                nameLabel.Text = "(" + q + "x) " + item.ItemName;
                totalLabel.Text = "Total: " + (q * item.TotalPrice).ToString();
                 qtyLabel.Text = q.ToString();
            };
            
           // labelFlow2.Controls.Add(minusButton);
           labelFlow2.Controls.Add(minusPanel);
            labelFlow2.Controls.Add(qtyPanel);
            labelFlow2.Controls.Add(plusPanel);

            minusPanel.Margin = new Padding(20, 20, 0, 0);
            qtyPanel.Margin = new Padding(0, 20, 0, 0);
            plusPanel.Margin = new Padding(0, 20, 0, 0);
            //labelFlow2.Controls.Add(plusButton);

            

            minusPanel.BorderStyle = BorderStyle.FixedSingle;
            qtyPanel.BorderStyle = BorderStyle.FixedSingle;
            plusPanel.BorderStyle = BorderStyle.FixedSingle;

            //labelFlow2.BorderStyle = BorderStyle.FixedSingle;
            //Methods.RoundBorders(labelFlow2, 5);
            // labelFlow.Location = new System.Drawing.Point(300, 0);

            FlowLayoutPanel panelq = new FlowLayoutPanel();
            panelq.FlowDirection= FlowDirection.LeftToRight;
            panelq.Width = 600;
            panelq.Height = 100;
            panelq.BackColor = Color.White;
            panelq.Margin = new Padding(10, 0, 0, 10);

            panelq.Controls.Add(panelPictureBox);
            panelq.Controls.Add(labelFlow);
            //panelq.Controls.Add(labelFlow2);

         //   panelq.Controls.Add(totalLabel);

           // panelq.Controls.Add(labelFlow2);


            FlowLayoutPanel labelFlow3 = new FlowLayoutPanel();
            labelFlow3.FlowDirection = FlowDirection.TopDown;
            Button btn = new Button();
            btn.Text = "Edit";
            btn.Click += (sender, e) =>
            {
                edit(item);
                panelq.Controls.Clear();
                panelq.Dispose();
                items.Remove(item);
                MakePanel(item);
            };
            Button removebtn = new Button();
            removebtn.Text = "Remove";
            removebtn.Click += (sender, e) =>
            {
                panelq.Dispose();
                items.Remove(item);
            };
            //labelFlow3.Controls.Add(btn);
           //labelFlow3.Controls.Add(removebtn);
            // panelq.Controls.Add(labelFlow3);

            labelFlow.FlowDirection = FlowDirection.TopDown;

            labelFlow.Controls.Add(removebtn);
            panelq.Controls.Add(labelFlow2);
            labelFlow.WrapContents = false;

            labelFlow3.Controls.Add(totalLabel);
            labelFlow3.Controls.Add(btn);
            panelq.Controls.Add(labelFlow3);

            panelq.WrapContents = false;


            labelFlow.Width = 180;
            labelFlow2.Margin = new Padding(0, 0, 50, 0);

            nameLabel.Margin = new Padding(0, 0, 0, 8);

            btn.ForeColor = Color.White;
            removebtn.ForeColor = Color.White;




            btn.Size = new Size(75, 50);
            removebtn.Size = new Size(75, 50);
            btn.BackColor = Color.Red;
            removebtn.BackColor = Color.Red;


            // EACH PANEL FOR EACH ITEM IS ADDED TO THE FLOW IN SCREEN
            panelq.Padding = new Padding(10);
            flowLayoutPanel2.Controls.Add(panelq);
            Methods.RoundBorders(panelq, 10);
            CalcTotalItems();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*Panel panelq = new Panel();
            panelq.Width = 600;
            panelq.Height = 100;
            panelq.BackColor = Color.White;
           panelq.Margin = new Padding(10, 0, 0, 10);
            flowLayoutPanel2.Controls.Add(panelq);
            Methods.RoundBorders(panelq, 10);*/
            /*foreach(Items item in items)
            {
                MessageBox.Show(item.ItemName);
                MessageBox.Show(item.FirstAdd);
            }*/

        }
        private int add(Items item)
        {
            item.ItemQuantity++;
            int a = item.ItemQuantity;
           // qtyLabel.Text = a.ToString();
            CalcTotalItems();
            return a;
        }
        private int sub(Items item)
        {
            item.ItemQuantity--;
            int a = item.ItemQuantity;
           // qtyLabel.Text = a.ToString();
            CalcTotalItems();
            return a;
        }
        public void CalcTotalItems()
        {
            int a = 0;
            double b = 0;
            foreach (Items item in items)
            {
                a += item.ItemQuantity;
                b += item.TotalPrice * item.ItemQuantity;
            }
            TotalItems = a;
            toPay = b;
            toPayLabel.Text = "Total: " + toPay.ToString("PHP ###,##0.00");
            toPayLabel.ForeColor = Color.White;
            //form3instance.UpdateText();
        }
        private void edit(Items item)
        {
            // Disable the main form
            this.Enabled = false;


           // string returnValue;

            // ORDER CREATION
           // string itemName;
           // double totalItemPrice;
           // string firstAdditional;
           // string secondAdditional;
           // string thirdAdditional;
           // string imageLink;
            //

            // Create and show the pop-up form
            using (var popupForm = new Form5(instance))
            {

                // MessageBox.Show("index at:" + index.ToString());
                popupForm.FoodName = item.ItemName;
                popupForm.ImagePath = item.ImagePath;
                popupForm.Prices = item.TotalPrice;

                popupForm.quantity = item.ItemQuantity;


                popupForm.foodSelection = item.foodSelection;
                popupForm.foodIndex = item.index;



                popupForm.editOrder = true;

                //MessageBox.Show(foodArrays[foodSelection][index]);
                // MessageBox.Show(img);
                popupForm.ShowDialog();

                //popupForm.FoodName = foodArrays[foodSelection][index];
                //popupForm.ImagePath = img;
                // returnValue = popupForm.ReturnValue;

                //itemName = popupForm.itemName;
                item.TotalPrice = popupForm.totalItemPrice;
                item.FirstAdd = popupForm.firstAdditional;
                item.SecondAdd = popupForm.secondAdditional;
                item.ThirdAdd = popupForm.thirdAdditional;
                item.ItemQuantity = popupForm.qty;
                


            }

            // Re-enable the main form after the pop-up form is closed
            this.Enabled = true;
            items.Add(item);
            CalcTotalItems();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void datapass(string qrcredit)
        {
            picTake = qrcredit;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8(picTake);
            form8.FormClosed += (s, args) => this.Close();
            form8.Show();
        }
    }
}
